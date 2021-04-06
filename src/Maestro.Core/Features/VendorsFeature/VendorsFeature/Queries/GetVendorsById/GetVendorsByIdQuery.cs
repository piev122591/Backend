using AutoMapper;
using Maestro.Core.Exceptions;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.VendorsFeature.VendorsFeature.Queries.GetVendorsById
{
    public class GetVendorsByIdQuery : IRequest<Response<GetVendorsByIdVM>>
    {
        public int CarrierId { get; set; }
    }

    public class GetVendorsByIdQueryHandler : IRequestHandler<GetVendorsByIdQuery, Response<GetVendorsByIdVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorsQueryRepository _vendorsRepo;

        public GetVendorsByIdQueryHandler(IMapper mapper, IVendorsQueryRepository vendorsRepo)
        {
            this._mapper = mapper;
            this._vendorsRepo = vendorsRepo;
        }
        public async Task<Response<GetVendorsByIdVM>> Handle(GetVendorsByIdQuery request, CancellationToken cancellationToken)
        {

            var vendor = await _vendorsRepo.GetByIdAsync(request.CarrierId);

            if (vendor == null) throw new ApiException($"Department Not Found.");

            var result = _mapper.Map<GetVendorsByIdVM>(vendor);

            return new Response<GetVendorsByIdVM>(result);
        }
    }
}
