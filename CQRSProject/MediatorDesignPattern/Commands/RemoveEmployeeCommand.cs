using MediatR;

namespace CQRSProject.MediatorDesignPattern.Commands
{
    public class RemoveEmployeeCommand : IRequest
    {
        public RemoveEmployeeCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
