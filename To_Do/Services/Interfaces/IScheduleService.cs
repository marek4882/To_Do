using To_Do.Models;
using To_Do.ViewModels.Schedule;

namespace To_Do.Services.Interfaces
{
    public interface IScheduleService
    {
        public IEnumerable<ScheduleVM> GetSchedules(string userId);
        public void CreateSchedule(CreateScheduleVM schedule, string userId);
        public void DeleteSchedule(int scheduleId);
        public Schedule GetScheduleById(int scheduleId);
        public void UpdateSchedule(Schedule schedule);
        public IEnumerable<Job> GetScheduleJobs(int scheduleId);
    }
}