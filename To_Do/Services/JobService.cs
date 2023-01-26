using To_Do.Models;
using To_Do.Repositories;
using To_Do.Services.Interfaces;
using To_Do.ViewModels.Job;

namespace To_Do.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IScheduleService _scheduleService;
        public JobService(IJobRepository jobRepository, IScheduleService scheduleService)
        {
            _jobRepository = jobRepository;
            _scheduleService = scheduleService;
        }
        public void CreateJob(CreateJobVM request)
        {
            var job = new Job() { CategoryId = int.Parse(request.CategoryId), Name = request.Name, ScheduleId = request.ScheduleId };
            _jobRepository.CreateJob(job);
        }

        public void DeleteJob(int jobId)
        {
            _jobRepository.DeleteJob(jobId);
        }

        public Job GetJobById(int jobId)
        {
            return _jobRepository.GetJobById(jobId);
        }

        public IEnumerable<JobVM> GetJobs(int scheduleId)
        {
            var jobs = _scheduleService.GetScheduleJobs(scheduleId);
            if (jobs.Any())
            {
                return jobs.Select(x => new JobVM() { Id = x.Id, Name = x.Name, IsDone = x.IsDone, Category = x.Category });
            }

            return new List<JobVM>();
        }

        public void UpdateJob(Job job)
        {
            _jobRepository.UpdateJob(job);
        }
    }
}