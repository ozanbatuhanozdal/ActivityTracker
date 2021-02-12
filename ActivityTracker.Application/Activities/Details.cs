﻿using ActivityTracker.Domain.Entities;
using ActivityTracker.Persistance.DatabaseContexts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActivityTracker.Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly DatabaseContext _context;
            public Handler(DatabaseContext context)
            {
                _context = context;

            }

            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {

                var activity = await _context.Activities.FindAsync(request.Id);

                return activity;
                
            }
        }
    }
}