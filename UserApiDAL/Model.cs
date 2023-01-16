
 using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;

namespace UserApiDAL
{
    public class ChartContext : DbContext
    {
        public DbSet<ChartJobs> chartJobs { get; set; }


        // The following configures EF to create a Sqlite database file as `C:\blogging.db`.
        // For Mac or Linux, change this to `/tmp/blogging.db` or any other absolute path.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\Owner\Desktop\PandologicTest\JobsChartWebAPI\UserApiDAL\chartJobsDB\chartJobs.db");
    }
    public class ChartJobs
    {
        [Key]
        public int chartJobId { get; set; }
        public DateTime date { get; set; }
        public int jobsPerDay { get; set; }
        public int jobsViews { get; set; }
        public int predictedJobsViews { get; set; }



    }

   
}
