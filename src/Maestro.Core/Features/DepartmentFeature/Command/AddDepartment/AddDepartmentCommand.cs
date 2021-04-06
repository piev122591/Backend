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

namespace Maestro.Core.Features.DepartmentFeature.Command.AddDepartment
{
    public class AddDepartmentCommand : AddDepartmentDTO, IRequest<Response<AddDepartmentVM>>
    {
       
    }

    public class AddDepartmentCommandHandler : IRequestHandler<AddDepartmentCommand, Response<AddDepartmentVM>>
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentCommandRepository _deparmentRepo;
        private readonly IDateAndTime _dateAndTime;
        public AddDepartmentCommandHandler(IMapper mapper, IDateAndTime dateAndTime, IDepartmentCommandRepository departmentRepo)
        {
            this._mapper = mapper;
            this._deparmentRepo = departmentRepo;
            this._dateAndTime = dateAndTime;
        }

        public async Task<Response<AddDepartmentVM>> Handle(AddDepartmentCommand request, CancellationToken cancellationToken)
        {

            request.CreatedDate = this._dateAndTime.UtcNow;

            var department = await _deparmentRepo.AddAsyncReturnByEntity(request);

            var result = _mapper.Map<AddDepartmentVM>(department);

            return new Response<AddDepartmentVM>(result);
        }
    }
}

