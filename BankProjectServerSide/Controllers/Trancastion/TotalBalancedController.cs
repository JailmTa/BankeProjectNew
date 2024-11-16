using BussnesLayer_BankProjectServerSide.PersonTypesLogic;
using DataAccesslayer_BankProjectServerSide.PersonTypesData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankProjectServerSide.Controllers.Trancastion
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalBalancedController : ControllerBase
    {
        static float _Balanced = 0f;
        [HttpGet("GetTotalBalanced")]
        public ActionResult<List<TotalBalancedDTO>> GetTotalBalanced()
        {
            float Balanced = 0f;
            List<TotalBalancedDTO> dto = clsClientsLogic.GetTotalBalanced(ref Balanced);
            if (dto != null)
            {
                _Balanced = Balanced;
                return Ok(dto);
            }
            return BadRequest();
        }

        [HttpGet("GetTotalBalancedNumber/1")]
        public ActionResult<float> GetTotalBalancedNum()
        {
            return Ok(_Balanced);
        }
    }
}
