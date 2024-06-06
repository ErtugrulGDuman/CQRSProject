using CQRSProject.DAL.Context;
using CQRSProject.MediatorDesignPattern.Queries;
using CQRSProject.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<GetEmployeeQueryResults>>
    {
        private readonly CQRSContext _context;

        public GetEmployeeQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetEmployeeQueryResults>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _context.Employees.Select(x=>new GetEmployeeQueryResults
            {
                EmployeeId = x.EmployeeId,
                Name = x.Name,
                Salary = x.Salary,
                Surname = x.Surname
            }).ToListAsync();
        }
    }
}
