using To_Do.Models;

namespace To_Do.Services.Interfaces
{
    public interface IScheduleRepository
    {
        public IEnumerable<Schedule> GetAllSchedules();
        public void CreateSchedule(Schedule schedule);
        public void DeleteSchedule(int scheduleId);
        public Schedule GetScheduleById(int scheduleId);
        public void UpdateSchedule(Schedule schedule);
    }
}