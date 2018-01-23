using Scheduler.Data.Abstract;
using Scheduler.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.Data.Repositories
{
   public class ScheduleRepository : EntityBaseRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(SchedulerContext context)
            :base(context)
        {

        }
    }
}
