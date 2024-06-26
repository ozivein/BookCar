﻿using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateTagCloudCommand:IRequest
    {
        public int TagCloudId { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; }
    }
}
