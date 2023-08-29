using MediatR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace projectCRUD.Models.Commands
{
    public class createstudentDetails : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        public class CreateStudentDetailsCommand : IRequestHandler<createstudentDetails, int>
        {

            public StudDetailsContext context;

            public CreateStudentDetailsCommand(StudDetailsContext context)
            {
                this.context = context;
            }

            public async Task<int> Handle(createstudentDetails request, CancellationToken cancellationToken)
            {
                var studentdetails = new StudBasicDetails();
                studentdetails.Id = request.Id;
                studentdetails.Name = request.Name;
                studentdetails.Gender = request.Gender;
                studentdetails.Age = request.Age;
                context.StudBasicDetails.Add(studentdetails);
                await context.SaveChangesAsync();
                return request.Id;

            }
        }
    }
}
