using To_Do.Models;

namespace To_Do.Services.Interfaces
{
    public interface IJobRepository
    {
        public void CreateJob(Job request);
        public void DeleteJob(int jobId);
        public Job GetJobById(int jobId);
        public void UpdateJob(Job job);
    }
}