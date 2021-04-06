using AutoMapper;
using Maestro.Core.Interfaces;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRemitInfoRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.VendorsFeature.VendorsRemitInfoFeature.Command.UpdateVendorRemitInfo
{
    public class UpdateVendorRemitInfoCommand : UpdateVendorRemitInfoDTO, IRequest<Response<UpdateVendorRemitInfoVM>>
    {


    }


    public class UpdateVendorRemitInfoCommandHandler : IRequestHandler<UpdateVendorRemitInfoCommand, Response<UpdateVendorRemitInfoVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorRemitInfoCommandRepository _remitInfoRepo;
        private readonly IDateAndTime _dateAndTime;

        public UpdateVendorRemitInfoCommandHandler(IMapper mapper, IDateAndTime dateAndTime, IVendorRemitInfoCommandRepository remitInfoRepo)
        {
            this._mapper = mapper;
            this._remitInfoRepo = remitInfoRepo;
            this._dateAndTime = dateAndTime;
        }


        public async Task<Response<UpdateVendorRemitInfoVM>> Handle(UpdateVendorRemitInfoCommand request, CancellationToken cancellationToken)
        {
            request.CreatedDate = this._dateAndTime.UtcNow;

            var department = await _remitInfoRepo.UpdateAsyncReturnByEntity(request);

            var result = _mapper.Map<UpdateVendorRemitInfoVM>(department);

            return new Response<UpdateVendorRemitInfoVM>(result);
        }
    }
}
