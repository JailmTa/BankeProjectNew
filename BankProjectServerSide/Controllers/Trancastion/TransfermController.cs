using BussnesLayer_BankProjectServerSide.LogginLogic;
using DataAccesslayer_BankProjectServerSide.LogginData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankProjectServerSide.Controllers.Trancastion
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransfermController : ControllerBase
    {
        [HttpGet("GetAllTransferms")]
        public ActionResult<List<TransfermLogDTO>> GetAllLogs()
        {
            List<TransfermLogDTO> list = clsTransfermLogData.GetAllTransfermLog();
            if (list != null)
                return Ok(list);
            else
                return NotFound();
        }

        [HttpPost("AddNewTransferms")]
        public ActionResult<int> AddTransferm(TransfermLogDTO dto)
        {
          
            int Num= clsTransfermLogLogic.AddNewTransferm(dto);
            return Ok(Num);
        }

        [HttpGet("Searching/{Num}/{Text}/{Filter}/{StartDate}/{EndDate}")]
        public ActionResult<List<TransfermLogDTO>> SearchingLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            List<TransfermLogDTO> list = clsTransfermLogLogic.SerchingLoggin(Num, Text, Filter, StartTime, EndTime);
            if (list != null)
                return Ok(list);
            else
                return NotFound();
        }

    }
}
