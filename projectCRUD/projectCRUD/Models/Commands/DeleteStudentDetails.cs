using MediatR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace projectCRUD.Models.Commands
{
    public class DeleteStudentDetails : IRequest<int>
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        public class DeleteStudentDetailscommand : IRequestHandler<DeleteStudentDetails, int>
        {


            public StudDetailsContext context;

            public DeleteStudentDetailscommand(StudDetailsContext context)
            {
                this.context = context;
            }

            public async Task<int> Handle(DeleteStudentDetails request, CancellationToken cancellationToken)
            {
                var deletestud = await context.StudBasicDetails.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
                context.StudBasicDetails.Remove(deletestud);
                await context.SaveChangesAsync();
                return deletestud.Id;
            }
        }
    }
}
