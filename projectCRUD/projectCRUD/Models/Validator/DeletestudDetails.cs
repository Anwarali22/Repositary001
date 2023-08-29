using FluentValidation;
using projectCRUD.Models.Commands;

namespace projectCRUD.Models.Validator
{
    public class DeletestudDetails:AbstractValidator<DeleteStudentDetails>
    {
        public DeletestudDetails() 
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
