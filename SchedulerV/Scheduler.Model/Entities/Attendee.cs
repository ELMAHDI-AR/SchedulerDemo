using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.Model.Entities
{
   public class Attendee : IEntityBase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
