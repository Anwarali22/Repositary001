using CQRSpattern.DataAccess;
using CQRSpattern.Models.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSpattern.Models.Handler
{
    public class GetPersonHandlerAllDetails : IRequestHandler<GetPersonAlldetails, List<EmployeeModel>>
    {
        /*   private readonly List<EmployeeModel> _employees;*/
        private readonly ApplicationDBContext context;
        public GetPersonHandlerAllDetails( ApplicationDBContext context)
        {
            this.context = context;
        }
        public async Task<List<EmployeeModel>> Handle(GetPersonAlldetails request, CancellationToken cancellationToken)
        {
            
            ApplicationDBContext ab = new ApplicationDBContext(EmployeeModel);
            List<EmployeeModel> employees = ab.Employees.ToList();

            return employees;
        }
    }
}
