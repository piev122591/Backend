using AutoMapper;
using Maestro.Core.Exceptions;
using Maestro.Core.Interfaces.IDepartmentRepo;
using Maestro.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maestro.Core.Features.DepartmentFeature.Queries.GetAllDepartment
{
    public class GetAllDepartmentQuery : IRequest<Response<List<GetAllDepartmentVM>>>
    {


    }

    public class GetAllDepartmentQueryHandler : IRequestHandler<GetAllDepartmentQuery,Response<List<GetAllDepartmentVM>>>
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentQueryRepository _deparmentRepo;

        public GetAllDepartmentQueryHandler(IMapper mapper, IDepartmentQueryRepository departmentRepo)
        {
            this._mapper = mapper;
            this._deparmentRepo = departmentRepo;
        }


        public async Task<Response<List<GetAllDepartmentVM>>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            var department = await _deparmentRepo.GetAllAsync();
 
            if (department == null) throw new ApiException($"Department Not Found.");

            var result = _mapper.Map<List<GetAllDepartmentVM>>(department);

            return new Response<List<GetAllDepartmentVM>>(result);

          
        }
    }


}
