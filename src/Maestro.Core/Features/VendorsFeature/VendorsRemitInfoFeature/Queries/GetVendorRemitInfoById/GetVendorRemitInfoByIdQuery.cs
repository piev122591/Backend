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

namespace Maestro.Core.Features.VendorsFeature.VendorsRemitInfoFeature.Queries.GetVendorRemitInfoById
{
    public class GetVendorRemitInfoByIdQuery : IRequest<Response<GetVendorRemitInfoByIdVM>>
    {
        public int RemitId { get; set; }
    }

    public class GetVendorRemitInfoByIdQueryHandler : IRequestHandler<GetVendorRemitInfoByIdQuery, Response<GetVendorRemitInfoByIdVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorRemitInfoQueryRepository _remitInfoRepo;

        public GetVendorRemitInfoByIdQueryHandler(IMapper mapper, IVendorRemitInfoQueryRepository remitInfoRepo)
        {
            this._mapper = mapper;
            this._remitInfoRepo = remitInfoRepo;
        }

        public async Task<Response<GetVendorRemitInfoByIdVM>> Handle(GetVendorRemitInfoByIdQuery request, CancellationToken cancellationToken)
        {
            var remitinfo = await _remitInfoRepo.GetByIdAsync(request.RemitId);

            if (remitinfo == null) throw new ApiException($"Department Not Found.");

            var result = _mapper.Map<GetVendorRemitInfoByIdVM>(remitinfo);

            return new Response<GetVendorRemitInfoByIdVM>(result);
        }
    }
}
