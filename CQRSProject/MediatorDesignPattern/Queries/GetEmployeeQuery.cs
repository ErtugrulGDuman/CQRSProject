using CQRSProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Queries
{
    public class GetEmployeeQuery : IRequest<List<GetEmployeeQueryResults>>
    {
    }
}
