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

namespace Maestro.Core.Features.VendorsFeature.VendorsFeature.Command.AddVendors
{
    public class AddVendorsCommand : AddVendorsDTO, IRequest<Response<AddVendorsVM>>
    {

    }

    public class AddVendorsCommandHandler : IRequestHandler<AddVendorsCommand, Response<AddVendorsVM>>
    {
        private readonly IMapper _mapper;
        private readonly IVendorsCommandRepository _vendorsRepo;
        private readonly IDateAndTime _dateAndTime;

        public AddVendorsCommandHandler(IMapper mapper, IVendorsCommandRepository vendorsRepo, IDateAndTime dateAndTime)
        {
            this._mapper = mapper;
            this._vendorsRepo = vendorsRepo;
            this._dateAndTime = dateAndTime;
        }

        public async Task<Response<AddVendorsVM>> Handle(AddVendorsCommand request, CancellationToken cancellationToken)
        {
            request.CreatedDate = this._dateAndTime.UtcNow;

            var vendors = await _vendorsRepo.AddAsyncReturnByEntity(request);

            var result = _mapper.Map<AddVendorsVM>(vendors);

            return new Response<AddVendorsVM>(result);
        }
    }
}
