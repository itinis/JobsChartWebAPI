using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApiDAL
{
    public interface IUserDAL
    {
        Task<List<ChartJobs>> getAlljobsChart();
        Task<bool> insertJobsChart(ChartJobs chartJobsElement);
        Task<bool> updateJobsChart(ChartJobs chartJobsElement);
        Task<bool> deleteJobsChart(ChartJobs chartJobsElement);
    }
}
