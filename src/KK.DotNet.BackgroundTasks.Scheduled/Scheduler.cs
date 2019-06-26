using System.Collections.Generic;

namespace KK.DotNet.BackgroundTasks.Scheduled
{
    public class Scheduler
    {
        private readonly SchedulerTaskList schedulerTasks;

        public Scheduler(
             SchedulerTaskList schedulerTasks
        )
        {
            this.schedulerTasks = schedulerTasks;
        }

        public SchedulerTaskList SchedulerTasks
        {
            get {
                return this.schedulerTasks;
            }
        }
    }
}
