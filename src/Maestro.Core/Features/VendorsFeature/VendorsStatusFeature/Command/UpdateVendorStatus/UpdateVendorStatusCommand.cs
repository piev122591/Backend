using AutoMapper;
using Maestro.Core.Interfaces;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsStatusRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.VendorsFeature.VendorsStatusFeature.Command.UpdateVendorStatus
{
    public class UpdateVendorStatusCommand : UpdateVendorStatusDTO, IRequest<Response<UpdateVendorStatusVM>>
    {
    }

    public class UpdateVendorStatusCommandHandler : IRequestHandler<UpdateVendorStatusCommand, Response<UpdateVendorStatusVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorStatusCommandRepository _vendorStatusRepo;
        private readonly IDateAndTime _dateAndTime;
        public UpdateVendorStatusCommandHandler(IMapper mapper, IVendorStatusCommandRepository vendorStatusRepo, IDateAndTime dateAndTime)
        {
            this._mapper = mapper;
            this._vendorStatusRepo = vendorStatusRepo;
            this._dateAndTime = dateAndTime;
        }


        public async Task<Response<UpdateVendorStatusVM>> Handle(UpdateVendorStatusCommand request, CancellationToken cancellationToken)
        {
            request.CreatedDate = this._dateAndTime.UtcNow;

            var department = await _vendorStatusRepo.UpdateAsyncReturnByEntity(request);

            var result = _mapper.Map<UpdateVendorStatusVM>(department);

            return new Response<UpdateVendorStatusVM>(result);

        }
    }
}
