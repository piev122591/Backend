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

namespace Maestro.Core.Features.VendorsFeature.VendorsStatusFeature.Command.AddVendorStatus
{
    public class AddVendorStatusCommand : AddVendorStatusDTO , IRequest<Response<AddVendorStatusVM>>
    {
    }

    public class AddVendorStatusCommandHandler : IRequestHandler<AddVendorStatusCommand, Response<AddVendorStatusVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorStatusCommandRepository _vendorstatusRepo;
        private readonly IDateAndTime _dateAndTime;


        public AddVendorStatusCommandHandler(IMapper mapper, IVendorStatusCommandRepository vendorstatusRepo,IDateAndTime dateAndTime)
        {
            this._mapper = mapper;
            this._vendorstatusRepo = vendorstatusRepo;
            this._dateAndTime = dateAndTime;

        }

        public async Task<Response<AddVendorStatusVM>> Handle(AddVendorStatusCommand request, CancellationToken cancellationToken)
        {
            request.CreatedDate = this._dateAndTime.UtcNow;

            var vendorstatus = await _vendorstatusRepo.AddAsyncReturnByEntity(request);

            var result = _mapper.Map<AddVendorStatusVM>(vendorstatus);

            return new Response<AddVendorStatusVM>(result);
        }
    }
}
