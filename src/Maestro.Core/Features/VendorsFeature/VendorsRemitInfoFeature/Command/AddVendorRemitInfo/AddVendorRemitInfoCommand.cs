using AutoMapper;
using Maestro.Core.Interfaces;
using Maestro.Core.Interfaces.IDepartmentRepo;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRemitInfoRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.VendorsFeature.VendorsRemitInfoFeature.Command.AddVendorRemitInfo
{
    public class AddVendorRemitInfoCommand : AddVendorRemitInfoDTO, IRequest<Response<AddVendorRemitInfoVM>>
    {



    }


    public class AddVendorRemitInfoCommandHandler : IRequestHandler<AddVendorRemitInfoCommand, Response<AddVendorRemitInfoVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorRemitInfoCommandRepository _vendorremitinfoRepo;
        private readonly IDateAndTime _dateAndTime;

        public AddVendorRemitInfoCommandHandler(IMapper mapper, IDateAndTime dateAndTime, IVendorRemitInfoCommandRepository vendorremitinfoRepo)
        {
            this._mapper = mapper;
            this._vendorremitinfoRepo = vendorremitinfoRepo;
            this._dateAndTime = dateAndTime;
        }
        public async Task<Response<AddVendorRemitInfoVM>> Handle(AddVendorRemitInfoCommand request, CancellationToken cancellationToken)
        {

            request.CreatedDate = this._dateAndTime.UtcNow;

            var vendorinfo = await _vendorremitinfoRepo.AddAsyncReturnByEntity(request);

            var result = _mapper.Map<AddVendorRemitInfoVM>(vendorinfo);

            return new Response<AddVendorRemitInfoVM>(result);

       



        }
    }
}
