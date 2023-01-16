using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApiDAL;

namespace UserApiBL
{
    public interface IUserBL
    {
        Task<List<ChartJobs>> getAlljobsChart();
        Task<bool> insertJobsChart(ChartJobs chartJobsElement);
        Task<bool> updateJobsChart(ChartJobs chartJobsElement);
        Task<bool> deleteJobsChart(ChartJobs chartJobsElement);

    }
}
