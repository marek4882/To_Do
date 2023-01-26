using To_Do.Data;
using To_Do.Models;
using To_Do.Services.Interfaces;

namespace To_Do.Repositories
{
    public class JobRepository : IJobRepository
    {
        public readonly ApplicationDbContext _context;
        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateJob(Job request)
        {
            _context.Jobs.Add(request);
            _context.SaveChanges();
        }

        public void DeleteJob(int jobId)
        {
            var job = _context.Jobs.FirstOrDefault(x => x.Id == jobId);
            _context.Jobs.Remove(job);
            _context.SaveChanges();
        }

        public Job GetJobById(int jobId)
        {
            return _context.Jobs.FirstOrDefault(x => x.Id == jobId);
        }

        public void UpdateJob(Job job)
        {
            _context.Jobs.Update(job);
            _context.SaveChanges();
        }
    }
}