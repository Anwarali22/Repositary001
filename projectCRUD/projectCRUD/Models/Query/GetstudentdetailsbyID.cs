using MediatR;
using Microsoft.EntityFrameworkCore;
using projectCRUD.Controllers;

namespace projectCRUD.Models.Query
{
    public class GetstudentdetailsbyID : IRequest<StudBasicDetails>
    {
        public int ID { get; set; }
        public class GetstudentdetailsbyIDHandler : IRequestHandler<GetstudentdetailsbyID, StudBasicDetails>
        {
            private StudDetailsContext _context;

            public GetstudentdetailsbyIDHandler(StudDetailsContext context)
            {
                _context = context;
            }

            public async Task<StudBasicDetails> Handle(GetstudentdetailsbyID request, CancellationToken cancellationToken)
            {
                var StudDetails = await _context.StudBasicDetails.Where(a => a.Id == request.ID).FirstOrDefaultAsync();
                return StudDetails;
            }
        }
    }
}
