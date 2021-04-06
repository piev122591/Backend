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

namespace Maestro.Core.Features.DepartmentFeature.Queries.GetDepartmetById
{
    /// <summary>
    /// Get department by Id request parmarmeter
    /// </summary>
    public class GetDepartmentByIdQuery : IRequest<Response<GetDepartmentByIdVM>>
    {
        public int DepartmentId { get; set; }

    }

    /// <summary>
    /// Get Department by Id Query Handler, This class handles the incoming request.
    /// </summary>
    public class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, Response<GetDepartmentByIdVM>>
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentQueryRepository _deparmentRepo;

        /// <summary>
        /// Get Department by id constructor for Dependency Injection
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="departmentRepo"></param>
        public GetDepartmentByIdQueryHandler(IMapper mapper, IDepartmentQueryRepository departmentRepo)
        {
            this._mapper = mapper;
            this._deparmentRepo = departmentRepo;
        }

        /// <summary>
        /// Handles the request of Get Department By Id
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Response View Model (GetDepartmentByIdVM)</returns>
        public async Task<Response<GetDepartmentByIdVM>> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {

            var department = await _deparmentRepo.GetByIdAsync(request.DepartmentId);

            if (department == null) throw new ApiException($"Department Not Found.");

            var result = _mapper.Map<GetDepartmentByIdVM>(department);

            return new Response<GetDepartmentByIdVM>(result);

        }
    }
}
