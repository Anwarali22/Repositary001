using FluentValidation;
using projectCRUD.Models.Commands;
namespace projectCRUD.Models.Validator
{
    public class UpdatestudDetails:AbstractValidator<UpdateStudentDetails>
    {
        public UpdatestudDetails() 
        {
            RuleFor(x=>x.Id).NotEmpty();
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x=>x.Gender).NotEmpty();
            RuleFor(x=>x.Age).NotEmpty();


        }
    }
}
