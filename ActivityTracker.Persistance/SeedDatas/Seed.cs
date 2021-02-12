using ActivityTracker.Domain.Entities;
using ActivityTracker.Persistance.DatabaseContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityTracker.Persistance.SeedDatas
{
    public class Seed
    {
        public static void SeedData(DatabaseContext context)
        {
            if (!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Today Activity 1",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Today Activity 1",
                        Category = "Drinks",
                        City ="İzmir",
                        Venue  ="Pub",
                    },
                    new Activity
                    {
                        Title = "Past Activity 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Past Activity 1",
                        Category = "Culture",
                        City ="Aydın",
                        Venue  ="Museum",
                    }
                };
                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}
