using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler:IRequestHandler<RemoveCategoryCommand>
    {
        private readonly IRepository<Category> _repository;
        public RemoveCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.CategoryId));
        }
    }
}
