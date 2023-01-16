using UserApiDAL;

namespace UserApiBL
{
    public class UserBL :IUserBL
    {
        IUserDAL userDAL;
        public UserBL(IUserDAL userDAL)
        {
            this.userDAL = userDAL; 
        }


        public async Task<List<ChartJobs>> getAlljobsChart()
        {
            return await userDAL.getAlljobsChart();
        }
        public async Task<bool> insertJobsChart(ChartJobs chartJobsElement)
        {
            return await userDAL.insertJobsChart(chartJobsElement);
        }

        public async Task<bool> updateJobsChart(ChartJobs chartJobsElement)
        {
            return await userDAL.updateJobsChart(chartJobsElement);
        }
        public async Task<bool> deleteJobsChart(ChartJobs chartJobsElement)
        {
            return await userDAL.deleteJobsChart(chartJobsElement);
        }
    }
}