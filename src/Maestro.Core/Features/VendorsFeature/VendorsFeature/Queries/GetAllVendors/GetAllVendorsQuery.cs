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

namespace Maestro.Core.Features.VendorsFeature.VendorsFeature.Queries.GetAllVendors
{
    public class GetAllVendorsQuery : IRequest<Response<List<GetAllVendorsVM>>>
    {

    }

    public class GetAllVendorsQueryHandler : IRequestHandler<GetAllVendorsQuery, Response<List<GetAllVendorsVM>>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorsQueryRepository _vendorsRepo;
        public GetAllVendorsQueryHandler(IMapper mapper, IVendorsQueryRepository vendorsRepo)
        {
            this._mapper = mapper;
            this._vendorsRepo = vendorsRepo;
        }

        public async Task<Response<List<GetAllVendorsVM>>> Handle(GetAllVendorsQuery request, CancellationToken cancellationToken)
        {
            var vendors = await _vendorsRepo.GetAllAsync();

            if (vendors == null) throw new ApiException($"Department Not Found.");

            var result = _mapper.Map<List<GetAllVendorsVM>>(vendors);

            return new Response<List<GetAllVendorsVM>>(result);

        }


    }
}
