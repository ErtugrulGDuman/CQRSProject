﻿using CQRSProject.DAL.Context;
using CQRSProject.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly CQRSContext _context;

        public UpdateEmployeeCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.EmployeeId);
            values.Surname = request.Surname;
            values.Name = request.Name;
            values.Salary = request.Salary;
            await _context.SaveChangesAsync();
        }
    }
}
