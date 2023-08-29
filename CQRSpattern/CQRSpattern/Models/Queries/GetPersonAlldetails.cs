using MediatR;

namespace CQRSpattern.Models.Queries
{
    public record GetPersonAlldetails : IRequest<List<EmployeeModel>>;



}
