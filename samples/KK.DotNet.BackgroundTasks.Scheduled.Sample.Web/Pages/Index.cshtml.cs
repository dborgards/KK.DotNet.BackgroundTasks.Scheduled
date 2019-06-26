using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KK.DotNet.BackgroundTasks.Scheduled.Sample.Web.Pages
{
    public class IndexModel : PageModel
    {
        public readonly Scheduler scheduler;

        // When using the default SchedulerHostedService than there is also a Scheduler
        // this can be used to get access to the scheduled task list for example
        public IndexModel(
            Scheduler scheduler
        )
        {
            this.scheduler = scheduler;
        }

        public void OnGet()
        {

        }
    }
}
