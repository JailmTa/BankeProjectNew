using BussnesLayer_BankProjectServerSide.PersonTypesLogic;
using DataAccesslayer_BankProjectServerSide.PersonTypesData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankProjectServerSide.Controllers.PersonTpyes
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        [HttpGet("GetAllClients")]
        public ActionResult<IEnumerable<ClientsDataGradeViewDTO>> GetAllClients()
        {
            List<ClientsDataGradeViewDTO> list = clsClientsLogic.GetAll();
            if (list == null)
            {
                return NotFound("The List Is Empty And Nobody At System...");
            }
            return Ok(list);
        }
        [HttpPost("AddNewClient")]
        public ActionResult<int> AddNewClients(ClientsDTO dto)
        {
            ClientsDTO pdto = clsClientsLogic.Find(dto.ID);
            if (pdto == null)
            {
                clsClientsLogic Person = new clsClientsLogic(dto);
                int Request = Person.Save();
                if (Request == 0)
                {
                    return BadRequest("The Person Can\'t Add To System Any Where...");
                }
                return Ok($"{Person.ID}");
            }
            return BadRequest("The Person Is Already At System..");
        }

        [HttpDelete("{ID}", Name = "DeleteClients")]
        public ActionResult<int> DeleteClients(int ID)
        {
            ClientsDTO dto = clsClientsLogic.Find(ID);
            if (dto != null)
            {
                return Ok(clsClientsLogic.Delete(ID));
            }
            return NotFound("The ID You Entered Isn\'t Found...");
        }

        [HttpPut("{ID}", Name = "UpDateClients")]
        public ActionResult<ClientsDTO> UpDateClients(int ID, ClientsDTO dto)
        {
            ClientsDTO pdto = clsClientsLogic.Find(ID);
            dto.ID = ID;
            if (pdto != null)
            {
                clsClientsLogic person = new clsClientsLogic(dto, clsClientsLogic.enMode.UpDate);
                person.Save();
                return Ok(person.CDTO);
            }
            return NotFound("The Person With ID : " + ID + " Can\'t Found...");
        }

        [HttpGet("{ID}", Name = "FindClients")]
        public ActionResult<ClientsDTO> FindClients(int ID)
        {
            ClientsDTO dto = clsClientsLogic.Find(ID);
            if (dto != null)
            {
                return Ok(dto);
            }
            return NotFound("The Person With ID : " + ID + " Can\'t Found...");
        }

        [HttpGet("FindClientsByPerson/{ID}")]
        public ActionResult<ClientsDTO> FindClientsByPerson(int ID)
        {
            ClientsDTO dto = clsClientsLogic.FindByPersonID(ID);
            if (dto != null)
            {
                return Ok(dto);
            }
            return NotFound("The Person With ID : " + ID + " Can\'t Found...");
        }

        [HttpGet("Searching/{Num}/{Text}/{Filter}")]
        public ActionResult<IEnumerable<ClientsDataGradeViewDTO>> FindClientsByPerson(int Num, string Text, string Filter)
        {
            List<ClientsDataGradeViewDTO> dto = clsClientsLogic.GetAllByFiltering(Num, Text, Filter);
            if (dto != null)
            {
                return Ok(dto);
            }
            return NotFound();
        }



    }
}
