using Scheduler.Data.Abstract;
using Scheduler.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.Data.Repositories
{
   public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(SchedulerContext context)
            :base(context)
        {

        }
                

    }
}
