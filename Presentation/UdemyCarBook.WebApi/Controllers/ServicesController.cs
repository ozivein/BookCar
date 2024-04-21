using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public ServicesController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }


        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            return Ok(await _mediatR.Send(new GetServiceQuery()));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            return Ok(await _mediatR.Send(new GetServiceByIdQuery(id)));

        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommand createServiceCommand)
        {
            await _mediatR.Send(createServiceCommand);
            return Ok("Lokasyon Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand updateServiceCommand)
        {
            await _mediatR.Send(updateServiceCommand);
            return Ok("Lokasyon Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _mediatR.Send(new RemoveServiceCommand(id));
            return Ok("Lokasyon silindi");
        }

    }
}
