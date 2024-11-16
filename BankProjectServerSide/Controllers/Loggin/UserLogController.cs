using BussnesLayer_BankProjectServerSide.LogginLogic;
using DataAccesslayer_BankProjectServerSide.LogginData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankProjectServerSide.Controllers.Loggin
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLogController : ControllerBase
    {

        [HttpGet("GetAllUserLog")]
        public ActionResult<List<LoginIDDTO>> GetAllLogs()
        {
            List<LoginIDDTO> list = clsUserLogLogic.GetAllUsersLog();
            if (list != null)
                return Ok(list);
            else
                return NotFound();
        }

        [HttpGet("Searching/{Num}/{Text}/{Filter}/{StartDate}/{EndDate}")]
        public ActionResult<List<LoginIDDTO>> SearchingLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            List<LoginIDDTO> list = clsUserLogLogic.SerchingLoggin(Num, Text, Filter, StartTime, EndTime);
            if (list != null)
                return Ok(list);
            else
                return NotFound();
        }


        [HttpPost("AddNewUserLog")]
        public ActionResult<int> AddNewUserLog(LoginIDDTO dto)
        {
            int ID = clsUserLogLogic.AddNewLogUser(dto);
            return Ok(ID);
        }

    }
}
