using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using UserApiBL;
using UserApiDAL;

namespace UserWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }
       
   
     
         [HttpGet("getAlljobsChart")]
         public async Task<ActionResult<List<ChartJobs>>> getAlljobsChart()
         {
             var res = await this.userBL.getAlljobsChart();
             return res;
         }
        //// POST api/<UserController>
        [HttpPost("insertJobsChart")]
         public async Task<ActionResult<bool>> insertJobsChart([FromBody] ChartJobs chartJobsElement)
         {
             var res = await this.userBL.insertJobsChart(chartJobsElement);
             return res;
         }
        [HttpPost("updateJobsChart")]

        public async Task<ActionResult<bool>> updateJobsChart([FromBody] ChartJobs chartJobsElement)
        {
            var res = await this.userBL.updateJobsChart(chartJobsElement);
            return res;
        }
        [HttpPost("deleteJobsChart")]

        public async Task<ActionResult<bool>> deleteJobsChart([FromBody] ChartJobs chartJobsElement)
        {
            var res = await this.userBL.deleteJobsChart(chartJobsElement);
            return res;
        }
    }
}
