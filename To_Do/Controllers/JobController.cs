using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using To_Do.Services.Interfaces;
using To_Do.ViewModels.Job;

namespace To_Do.Controllers
{
    [Authorize]
    public class JobController : Controller
    {
        private readonly IJobService _jobService;
        private readonly ICategoryService _categoryService;
        public JobController(IJobService jobService, ICategoryService categoryService)
        {
            _jobService = jobService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int scheduleId)
        {
            var model = new JobIndexVM();
            model.Jobs = _jobService.GetJobs(scheduleId);
            var job = new CreateJobVM();
            var categories = _categoryService.GetCategories();
            job.Categories = categories.Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();
            job.ScheduleId = scheduleId;
            model.CreateJobVM = job;
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateJobVM request)
        {
         {
                _jobService.CreateJob(request);
                return RedirectToAction("Index", "Job", new { scheduleId = request.ScheduleId });
            }

        }

        public IActionResult Delete(int jobId, int scheduleId)
        {
            _jobService.DeleteJob(jobId);
            return RedirectToAction("Index", "Job", new { scheduleId = scheduleId });
        }

        public IActionResult Update(int jobId, int scheduleId)
        {
            var job = _jobService.GetJobById(jobId);
            var model = new UpdateJobVM()
            {
                ScheduleId = scheduleId,
                Id = job.Id,
                CategoryId = job.CategoryId.ToString(),
                Name = job.Name
            };
            var categories = _categoryService.GetCategories();
            model.Categories = categories.Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UpdateJobVM request)
        {
            var job = _jobService.GetJobById(request.Id);
            job.CategoryId = int.Parse(request.CategoryId);
            job.Name = request.Name;
            _jobService.UpdateJob(job);
            return RedirectToAction("Index", "Job", new { scheduleId = request.ScheduleId });
        }

        public IActionResult ChangeStatus(int jobId, bool isDone, int scheduleId)
        {
            var job = _jobService.GetJobById(jobId);
            job.IsDone = !isDone;
            _jobService.UpdateJob(job);
            return RedirectToAction("Index", "Job", new { scheduleId = scheduleId });
        }
    }
}
