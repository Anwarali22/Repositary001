using FluentValidation;
using MediatR;

namespace projectCRUD.Models.PipeLineBehaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            this.validators = validators;
        }



        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if (validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(validators.Select(x => x.ValidateAsync(context, cancellationToken)));
                var failurs = validationResults.SelectMany(e => e.Errors).Where(n => n != null).ToList();
                if (failurs.Any())
                {
                    throw new ValidationException(failurs);
                }

            }
            return await next();
        }
    }
}
