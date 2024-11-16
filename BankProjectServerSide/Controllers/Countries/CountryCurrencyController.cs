using BussnesLayer_BankProjectServerSide;
using DataAccesslayer_BankProjectServerSide.CountriesData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankProjectServerSide.Controllers.Countries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryCurrencyController : ControllerBase
    {
        [HttpGet("GetAllCountries")]
        public ActionResult<IEnumerable<CountryCurrencyDTO>> GetAllCountries()
        {
            return Ok(clsCountryCurrencyData.GetAllCountries());
        }

        [HttpGet("Find/{ID}")]
        public ActionResult<CountryCurrencyDTO> FindCountries(string ID)
        {
            return Ok(clsCountryCurrencyData.FindCurrency(ID));
        }

    }
}
