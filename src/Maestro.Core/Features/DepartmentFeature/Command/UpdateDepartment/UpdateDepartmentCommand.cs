using AutoMapper;
using Maestro.Core.Interfaces;
using Maestro.Core.Interfaces.IDepartmentRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.DepartmentFeature.Command.UpdateDepartment
{
    public class UpdateDepartmentCommand : UpdateDepartmentDTO, IRequest<Response<UpdateDepartmentVM>>
    {

    }

    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, Response<UpdateDepartmentVM>>
    {

        private readonly IMapper _mapper;
        private readonly IDepartmentCommandRepository _deparmentRepo;
        private readonly IDateAndTime _dateAndTime;

        public UpdateDepartmentCommandHandler(IMapper mapper, IDateAndTime dateAndTime, IDepartmentCommandRepository departmentRepo)
        {
            this._mapper = mapper;
            this._deparmentRepo = departmentRepo;
            this._dateAndTime = dateAndTime;
        }

        public async Task<Response<UpdateDepartmentVM>> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            request.CreatedDate = this._dateAndTime.UtcNow;

            var department = await _deparmentRepo.UpdateAsyncReturnByEntity(request);

            var result = _mapper.Map<UpdateDepartmentVM>(department);

            return new Response<UpdateDepartmentVM>(result);
        }
    }


}
