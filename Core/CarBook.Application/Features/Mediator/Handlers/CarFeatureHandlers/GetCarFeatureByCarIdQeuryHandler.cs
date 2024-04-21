using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByCarIdQeuryHandler : IRequestHandler<GetCarFeatureByCarIdQeury, List<GetCarFeatureByCarIdQeuryResult>>
    {
        private readonly ICarFeatureRepository _carFeatureRepository;
        private readonly IMapper _mapper;

        public GetCarFeatureByCarIdQeuryHandler(ICarFeatureRepository carFeatureRepository, IMapper mapper)
        {
            _carFeatureRepository = carFeatureRepository;
            _mapper = mapper;
        }

        public async Task<List<GetCarFeatureByCarIdQeuryResult>> Handle(GetCarFeatureByCarIdQeury request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetCarFeatureByCarIdQeuryResult>>(await _carFeatureRepository.GetCarFeatureByCarId(request.CarId));
        }
    }
}
