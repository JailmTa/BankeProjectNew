using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccesslayer_BankProjectServerSide.PersonTypesData;
using BussnesLayer_BankProjectServerSide.PersonTypesLogic;

namespace BankProjectServerSide.Controllers.PersonTpyes
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet("GetAllPersons")]
        public ActionResult<IEnumerable<PersonsDTO>> GetAllPerson()
        {
            List<PersonsDTO> list = clsPersonLogic.GetAll();
            if (list == null)
            {
                return NotFound("The List Is Empty And Nobody At System...");
            }
            return Ok(list);
        }
        [HttpPost("AddNewPerson")]
        public ActionResult<int> AddNewPerson(PersonsDTO dto)
        {
            PersonsDTO pdto = clsPersonLogic.Find(dto.ID);
            if (pdto == null)
            {
                clsPersonLogic Person = new clsPersonLogic(dto);
                int Request = Person.Save();
                if (Request == 0)
                {
                    return BadRequest("The Person Can\'t Add To System Any Where...");
                }
                return Ok(Person.ID);
            }
            return BadRequest("The Person Is Already At System..");
        }

        [HttpDelete("{ID}", Name = "DeletePerson")]
        public ActionResult<int> DeletePerson(int ID)
        {
            PersonsDTO dto = clsPersonLogic.Find(ID);
            if (dto != null)
            {
                return Ok(clsPersonLogic.Delete(ID));
            }
            return NotFound("The ID You Entered Isn\'t Found...");
        }

        [HttpPut("{ID}", Name = "UpDatePerson")]
        public ActionResult<PersonsDTO> UpDatePerson(int ID, PersonsDTO dto)
        {
            PersonsDTO pdto = clsPersonLogic.Find(ID);
            dto.ID = ID;
            if (pdto != null)
            {
                clsPersonLogic person = new clsPersonLogic(dto, clsPersonLogic.enMode.UpDate);
                person.Save();
                return Ok(person.PDTO);
            }
            return NotFound("The Person With ID : " + ID + " Can\'t Found...");
        }

        [HttpGet("{ID}", Name = "FindPerson")]
        public ActionResult<UsersDTO> FindPerson(int ID)
        {
            PersonsDTO dto = clsPersonLogic.Find(ID);
            if (dto != null)
            {
                return Ok(dto);
            }
            return NotFound("The Person With ID : " + ID + " Can\'t Found...");
        }
    }
}
