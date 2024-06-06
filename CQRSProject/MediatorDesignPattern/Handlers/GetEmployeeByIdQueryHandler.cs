using CQRSProject.DAL.Context;
using CQRSProject.MediatorDesignPattern.Queries;
using CQRSProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, GetEmployeeByIdQueryResult>
    {
        private readonly CQRSContext _context;

        public GetEmployeeByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<GetEmployeeByIdQueryResult> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.Id);
            return new GetEmployeeByIdQueryResult
            {
                EmployeeId = values.EmployeeId,
                Name = values.Name,
                Surname = values.Surname,
                Salary = values.Salary
            };
        }
    }
}
