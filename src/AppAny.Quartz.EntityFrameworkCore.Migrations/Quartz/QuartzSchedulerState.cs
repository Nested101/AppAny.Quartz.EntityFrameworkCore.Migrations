namespace AppAny.Quartz.EntityFrameworkCore.Migrations.PostgreSQL
{
  public class QuartzSchedulerState
  {
    public string SchedulerName { get; set; } = null!;
    public string InstanceName { get; set; } = null!;
    public long LastCheckInTime { get; set; }
    public long CheckInInterval { get; set; }
  }
}
