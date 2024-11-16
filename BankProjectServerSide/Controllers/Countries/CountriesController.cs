using BussnesLayer_BankProjectServerSide.CountriesLogic;
using DataAccesslayer_BankProjectServerSide.CountriesData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankProjectServerSide.Controllers.Countries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet("GetAllCountries")]
        public ActionResult<IEnumerable<Countriy>> GetAllCountries()
        {
            return Ok(clsCountriesLogic.GetAllCountries());
        }

        [HttpGet("Find/{ID}")]
        public ActionResult<Countriy> Find(int ID)
        {
            return Ok(clsCountriesLogic.FindCountry(ID));
        }
    }
}
