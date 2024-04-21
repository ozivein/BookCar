using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public ContactsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _mediatR.Send(new GetContactQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var values = await _mediatR.Send(new GetContactByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand createContactCommand)
        {
            await _mediatR.Send(createContactCommand);
            return Ok("İletişim bilgisi Eklendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveContact(int id)
        {
            await _mediatR.Send(new RemoveContactCommand(id));
            return Ok("İletişim bilgisi silindi");
        }

        [HttpPut]
        public async Task<IActionResult> ContactUpdate(UpdateContactCommand updateContactCommand)
        {
            await _mediatR.Send(updateContactCommand);
            return Ok("İletişim bilgisi güncellendi");
        }
    }
}
