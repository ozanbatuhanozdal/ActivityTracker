using ActivityTracker.Persistance.DatabaseContexts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ActivityTracker.Application.Activities
{
    public class Delete
    {
        public class Command: IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DatabaseContext _context;

            public Handler(DatabaseContext context)
            {
                _context = context;

            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {

                var activity = await _context.Activities.FindAsync(request.Id);

                if (activity == null)
                    throw new Exception("Activity doesnt exist1");


                _context.Remove(activity);

                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Failed to save changes");
            }
        }
    }
}
