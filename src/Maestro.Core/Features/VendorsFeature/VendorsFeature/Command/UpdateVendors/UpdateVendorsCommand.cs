using AutoMapper;
using Maestro.Core.Interfaces;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.VendorsFeature.VendorsFeature.Command.UpdateVendors
{
    public class UpdateVendorsCommand : UpdateVendorsDTO,IRequest<Response<UpdateVendorsVM>>
    {
    }

    public class UpdateVendorsCommandHandler : IRequestHandler<UpdateVendorsCommand, Response<UpdateVendorsVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorsCommandRepository _vendorsRepo;
        private readonly IDateAndTime _dateAndTime;
        public UpdateVendorsCommandHandler(IMapper mapper, IVendorsCommandRepository vendorsRepo, IDateAndTime dateAndTime)
        {
            this._mapper = mapper;
            this._vendorsRepo = vendorsRepo;
            this._dateAndTime = dateAndTime;
        }
        public async Task<Response<UpdateVendorsVM>> Handle(UpdateVendorsCommand request, CancellationToken cancellationToken)
        {
           request.CreatedDate = this._dateAndTime.UtcNow;

            var department = await _vendorsRepo.UpdateAsyncReturnByEntity(request);

            var result = _mapper.Map<UpdateVendorsVM>(department);

            return new Response<UpdateVendorsVM>(result);
        }
    }
}
