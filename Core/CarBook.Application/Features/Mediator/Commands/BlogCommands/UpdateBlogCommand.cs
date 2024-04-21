﻿using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateBlogCommand:IRequest
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
    }
}
