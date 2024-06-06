using CQRSProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Queries
{
    public class GetEmployeeByIdQuery : IRequest<GetEmployeeByIdQueryResult>
    {
        public GetEmployeeByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
