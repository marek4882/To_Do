using To_Do.Models;
using To_Do.ViewModels.Job;

namespace To_Do.Services.Interfaces
{
    public interface IJobService
    {
        public void CreateJob(CreateJobVM request);
        public IEnumerable<JobVM> GetJobs(int scheduleId);
        public void DeleteJob(int jobId);
        public Job GetJobById(int jobId);
        public void UpdateJob(Job job);
    }
}