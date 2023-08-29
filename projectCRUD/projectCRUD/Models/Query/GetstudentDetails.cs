

using MediatR;
using Microsoft.EntityFrameworkCore;

namespace projectCRUD.Models.Query
{
    public class GetstudentDetails:IRequest<IEnumerable<StudBasicDetails>>

    {
        public class GetstudentDetailsQueryHandler : IRequestHandler<GetstudentDetails, IEnumerable<StudBasicDetails>>
        {
            private readonly StudDetailsContext context;

            public GetstudentDetailsQueryHandler(StudDetailsContext context)
            {
                this.context = context;
            }

            public async Task<IEnumerable<StudBasicDetails>> Handle(GetstudentDetails request, CancellationToken cancellationToken)
            {
                var StudDetails=await context.StudBasicDetails.ToListAsync();
                return StudDetails;
            }
        }
    }
}
