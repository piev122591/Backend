using AutoMapper;
using Maestro.Core.Exceptions;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRemitInfoRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.VendorsFeature.VendorsRemitInfoFeature.Queries.GetAllVendorRemitInfo
{
    public class GetAllVendorRemitInfoQuery : IRequest<Response<List<GetAllVendorRemitInfoVM>>>
    {

    }

    public class GetAllVendorRemitInfoQueryHandler : IRequestHandler<GetAllVendorRemitInfoQuery, Response<List<GetAllVendorRemitInfoVM>>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorRemitInfoQueryRepository _remitInfoRepo;
        public GetAllVendorRemitInfoQueryHandler(IMapper mapper, IVendorRemitInfoQueryRepository remitInfoRepo)
        {
            this._mapper = mapper;
            this._remitInfoRepo = remitInfoRepo;
        }

        public async Task<Response<List<GetAllVendorRemitInfoVM>>> Handle(GetAllVendorRemitInfoQuery request, CancellationToken cancellationToken)
        {
            var remitinfo = await _remitInfoRepo.GetAllAsync();

            if (remitinfo == null) throw new ApiException($"Department Not Found.");

            var result = _mapper.Map<List<GetAllVendorRemitInfoVM>>(remitinfo);

            return new Response<List<GetAllVendorRemitInfoVM>>(result);

        }
    }
}
