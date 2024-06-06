using CQRSProject.DAL.Context;
using CQRSProject.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class RemoveEmployeeCommandHandler : IRequestHandler<RemoveEmployeeCommand>
    {
        private readonly CQRSContext _context;

        public RemoveEmployeeCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveEmployeeCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.Id);
            _context.Employees.Remove(values);
            await _context.SaveChangesAsync();

        }
    }
}
