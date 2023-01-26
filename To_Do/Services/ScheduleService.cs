using To_Do.Models;
using To_Do.Repositories;
using To_Do.Services.Interfaces;
using To_Do.ViewModels.Schedule;

namespace To_Do.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public void CreateSchedule(CreateScheduleVM request, string userId)
        {
            var schedule = new Schedule()
            {
                Name = request.Name,
                Date = request.DueDate,
                UserId = userId
            };

            _scheduleRepository.CreateSchedule(schedule);
        }

        public void DeleteSchedule(int scheduleId)
        {
            _scheduleRepository.DeleteSchedule(scheduleId);
        }

        public Schedule GetScheduleById(int scheduleId)
        {
            return _scheduleRepository.GetScheduleById(scheduleId);
        }

        public IEnumerable<Job> GetScheduleJobs(int scheduleId)
        {
            return GetScheduleById(scheduleId).Jobs;
        }

        public IEnumerable<ScheduleVM> GetSchedules(string userId)
        {
            var schedules = _scheduleRepository.GetAllSchedules().Where(x => x.UserId == userId).ToList();
            return schedules.Select(x => new ScheduleVM() { Id = x.Id, Date = x.Date, Name = x.Name, UserEmail = x.User.Email });
        }

        public void UpdateSchedule(Schedule schedule)
        {
            _scheduleRepository.UpdateSchedule(schedule);
        }
    }
}
