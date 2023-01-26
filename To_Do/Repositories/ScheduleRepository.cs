using Microsoft.EntityFrameworkCore;
using To_Do.Data;
using To_Do.Models;
using To_Do.Services.Interfaces;

namespace To_Do.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ApplicationDbContext _context;
        public ScheduleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateSchedule(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
        }

        public void DeleteSchedule(int scheduleId)
        {
            var schedule = _context.Schedules.Where(x => x.Id == scheduleId).First();
            _context.Schedules.Remove(schedule);
            _context.SaveChanges();
        }

        public IEnumerable<Schedule> GetAllSchedules()
        {
            return _context.Schedules.Where(_ => true);
        }

        public Schedule GetScheduleById(int scheduleId)
        {
            return _context.Schedules.Where(x => x.Id == scheduleId).First();
        }

        public void UpdateSchedule(Schedule schedule)
        {
            _context.Schedules.Update(schedule);
            _context.SaveChanges();
        }
    }
}
