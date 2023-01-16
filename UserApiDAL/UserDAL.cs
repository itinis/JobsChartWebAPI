using Microsoft.EntityFrameworkCore;

namespace UserApiDAL
{
    public class UserDAL : IUserDAL
    {
        public async Task<List<ChartJobs>> getAlljobsChart()
        {
            try
            {
                using (var db = new ChartContext())
                {
                    return db.chartJobs.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> insertJobsChart(ChartJobs chartJobsElement)
        {
            try
            {
                using (var db = new ChartContext())
                {
                    db.chartJobs.Add(chartJobsElement);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }
        public async Task<bool> updateJobsChart(ChartJobs chartJobsElement)
        {
            try
            {
                using (var db = new ChartContext())
                {
                    var currentChartJobsElement = db.chartJobs.Where(x => x.chartJobId == chartJobsElement.chartJobId).FirstOrDefault();
                    if (currentChartJobsElement != null)
                    {
                        currentChartJobsElement.date = chartJobsElement.date;
                        currentChartJobsElement.jobsPerDay = chartJobsElement.jobsPerDay;
                        currentChartJobsElement.jobsViews = chartJobsElement.jobsViews;
                        currentChartJobsElement.predictedJobsViews = chartJobsElement.predictedJobsViews;

                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false; throw;
            }
            throw new NotImplementedException();
        }
        public async Task<bool> deleteJobsChart(ChartJobs chartJobsElement)
        {
            try
            {
                using (var db = new ChartContext())
                {
                    var currentChartJobsElement = db.chartJobs.Where(x => x.chartJobId == chartJobsElement.chartJobId).FirstOrDefault();
                    if (currentChartJobsElement != null)
                    {
                        db.Entry(currentChartJobsElement).State = EntityState.Deleted;

                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}