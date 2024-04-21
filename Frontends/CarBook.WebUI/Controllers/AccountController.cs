using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountConsumeApiService _accountConsumeApiService;

        public AccountController(IAccountConsumeApiService accountConsumeApiService)
        {
            _accountConsumeApiService = accountConsumeApiService;
        }

        public IActionResult CreateAppUser()
        {
            return View(new RegisterDto());
        }
        [HttpPost]
        public async Task<IActionResult> CreateAppUser(RegisterDto registerDto)
        {
            var response = await _accountConsumeApiService.CreateAppUserAsync(registerDto);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Login");
            }
            return View(registerDto);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var responseToken = await _accountConsumeApiService.LoginAsync(loginDto);
            if (responseToken is not null)
            {
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(responseToken.Token);
                var claim = token.Claims.ToList();
                if (responseToken.Token is not null)
                {
                    claim.Add(new Claim("accessToken", responseToken.Token));
                    var claimsIdentity = new ClaimsIdentity(claim, JwtBearerDefaults.AuthenticationScheme);
                    var authProps = new AuthenticationProperties
                    {
                        ExpiresUtc = responseToken.ExpireDate,
                        IsPersistent = true
                    };
                    await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);

                    return RedirectToAction(nameof(Index), "Default");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
