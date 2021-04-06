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

namespace Maestro.Core.Features.VendorsFeature.VendorsStatusFeature.Queries.GetAllVendorStatus
{
    public class GetAllVendorStatusQuery : IRequest<Response<List<GetAllVendorStatusVM>>>
    {
    }

    public class GetAllVendorStatusQueryHandler : IRequestHandler<GetAllVendorStatusQuery, Response<List<GetAllVendorStatusVM>>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorStatusQueryRepository _vendorStatusRepo;

        public GetAllVendorStatusQueryHandler(IMapper mapper, IVendorStatusQueryRepository vendorStatusRepo)
        {
            this._mapper = mapper;
            this._vendorStatusRepo = vendorStatusRepo;
        }

        public async Task<Response<List<GetAllVendorStatusVM>>> Handle(GetAllVendorStatusQuery request, CancellationToken cancellationToken)
        {
            var vendorstatus = await _vendorStatusRepo.GetAllAsync();

            if (vendorstatus == null) throw new ApiException($"Department Not Found.");

            var result = _mapper.Map<List<GetAllVendorStatusVM>>(vendorstatus);

            return new Response<List<GetAllVendorStatusVM>>(result);
        }
    }
}
