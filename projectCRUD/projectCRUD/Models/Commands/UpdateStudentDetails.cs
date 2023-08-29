using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace projectCRUD.Models.Commands
{
    public class UpdateStudentDetails : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        public class UpdateStudentDetailsComannd : IRequestHandler<UpdateStudentDetails, int>
        {
            public StudDetailsContext context;

            public UpdateStudentDetailsComannd(StudDetailsContext context)
            {
                this.context = context;
            }

            public async Task<int> Handle(UpdateStudentDetails request, CancellationToken cancellationToken)
            {
                var updatechange = context.StudBasicDetails.Where(a => a.Id == request.Id).FirstOrDefault();



                if (updatechange == null)
                {
                    return default;
                }
                else
                {
                    updatechange.Id = request.Id;
                    updatechange.Name = request.Name;
                    updatechange.Gender = request.Gender;
                    updatechange.Age = request.Age;

                    context.StudBasicDetails.Update(updatechange);
                    await context.SaveChangesAsync();
                    return updatechange.Id;
                }






            }


        }
    }
}



