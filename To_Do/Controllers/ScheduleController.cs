using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using To_Do.Models;
using To_Do.Services.Interfaces;
using To_Do.ViewModels.Schedule;

namespace To_Do.Controllers
{
    [Authorize]
    public class ScheduleController : Controller
    {
        private readonly IScheduleService _scheduleService;
        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        public IActionResult Index()
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var schedules = _scheduleService.GetSchedules(currentUserId);
            return View(schedules);
        }

        [HttpPost]
        public IActionResult Create(CreateScheduleVM request)
        {
            if (ModelState.IsValid)
            {
                var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _scheduleService.CreateSchedule(request, currentUserId);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int scheduleId)
        {
            _scheduleService.DeleteSchedule(scheduleId);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int scheduleId)
        {
            var schedule = _scheduleService.GetScheduleById(scheduleId);
            var model = new UpdateScheduleVM() { DueDate = schedule.Date, Id = schedule.Id, Name = schedule.Name };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UpdateScheduleVM request)
        {
            var schedule = _scheduleService.GetScheduleById(request.Id);
            schedule.Date = request.DueDate;
            schedule.Name = request.Name;
            _scheduleService.UpdateSchedule(schedule);
            return RedirectToAction("Index");
        }
    }
}
