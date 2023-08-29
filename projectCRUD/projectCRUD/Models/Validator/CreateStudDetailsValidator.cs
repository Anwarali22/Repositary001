using FluentValidation;
using projectCRUD.Models.Commands;
using System.Data;

namespace projectCRUD.Models.Validator
{
    public class CreateStudDetailsValidator : AbstractValidator<createstudentDetails>
    {
        public CreateStudDetailsValidator()
        {
            RuleFor(x=>x.Id).NotEmpty();
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x=>x.Gender).NotEmpty();
            RuleFor(x=>x.Age).NotEmpty();



        }

    }
}
