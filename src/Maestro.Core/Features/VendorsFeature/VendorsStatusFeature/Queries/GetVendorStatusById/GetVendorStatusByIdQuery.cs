using AutoMapper;
using Maestro.Core.Exceptions;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsStatusRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.VendorsFeature.VendorsStatusFeature.Queries.GetVendorStatusById
{
    public class GetVendorStatusByIdQuery : IRequest<Response<GetVendorStatusByIdVM>>
    {
        public int VendorStatusId { get; set; }

    }


    public class GetVendorStatusByIdQueryHandler : IRequestHandler<GetVendorStatusByIdQuery, Response<GetVendorStatusByIdVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorStatusQueryRepository _vendorStatusRepo;
        public GetVendorStatusByIdQueryHandler(IMapper mapper, IVendorStatusQueryRepository vendorStatusRepo)
        {
            this._mapper = mapper;
            this._vendorStatusRepo = vendorStatusRepo;
        }

        public async Task<Response<GetVendorStatusByIdVM>> Handle(GetVendorStatusByIdQuery request, CancellationToken cancellationToken)
        {
            var vendorstatus = await _vendorStatusRepo.GetByIdAsync(request.VendorStatusId);

            if (vendorstatus == null) throw new ApiException($"Department Not Found.");

            var result = _mapper.Map<GetVendorStatusByIdVM>(vendorstatus);

            return new Response<GetVendorStatusByIdVM>(result);
        }
    }
}
