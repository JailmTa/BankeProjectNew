using BussnesLayer_BankProjectServerSide.PersonTypesLogic;
using DataAccesslayer_BankProjectServerSide.PersonTypesData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankProjectServerSide.Controllers.PersonTpyes
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet("GetAllUsers")]
        public ActionResult<IEnumerable<UsersDataGradeViewDTO>> GetAllUser()
        {
            List<UsersDataGradeViewDTO> list = clsUserLogic.GetAll();
            if (list == null)
            {
                return NotFound("The List Is Empty And Nobody At System...");
            }
            return Ok(list);
        }
        [HttpPost("AddNewUsers")]
        public ActionResult<int> AddNewUser(UsersDTO dto)
        {
            UsersDTO pdto = clsUserLogic.Find(dto.ID);
            if (pdto == null)
            {
                clsUserLogic Person = new clsUserLogic(dto);
                int Request = Person.Save();
                if (Request == 0)
                {
                    return BadRequest("The Person Can\'t Add To System Any Where...");
                }
                return Ok(Person.ID);
            }
            return BadRequest("The Person Is Already At System..");
        }

        [HttpDelete("{ID}", Name = "DeleteUsers")]
        public ActionResult<int> DeleteUser(int ID)
        {
            UsersDTO dto = clsUserLogic.Find(ID);
            if (dto != null)
            {
                return Ok(clsUserLogic.Delete(ID));
            }
            return NotFound("The ID You Entered Isn\'t Found...");
        }

        [HttpPut("{ID}", Name = "UpDateUsers")]
        public ActionResult<UsersDTO> UpDateUser(int ID, UsersDTO dto)
        {
            UsersDTO pdto = clsUserLogic.Find(ID);
            dto.ID = ID;
            if (pdto != null)
            {
                clsUserLogic person = new clsUserLogic(dto, clsUserLogic.enMode.UpDate);
                person.Save();
                return Ok(person.UDTO);
            }
            return NotFound("The Person With ID : " + ID + " Can\'t Found...");
        }

        [HttpGet("{ID}", Name = "FindUsers")]
        public ActionResult<UsersDTO> FindUser(int ID)
        {
            UsersDTO dto = clsUserLogic.Find(ID);
            if (dto != null)
            {
                return Ok(dto);
            }
            return NotFound("The User With ID : " + ID + " Can\'t Found...");
        }

        [HttpGet("FindUsersByEmail/{Email}")]
        public ActionResult<UsersDTO> FindUserByEmail(string Email)
        {
            UsersDTO dto = clsUserLogic.FindUserByEmai(Email);
            if (dto != null)
            {
                return Ok(dto);
            }
            return NotFound();
        }

        [HttpGet("Searching/{Num}/{Text}/{Filter}")]
        public ActionResult<IEnumerable<UsersDataGradeViewDTO>> FindUserByPerson(int Num, string Text, string Filter)
        {
            List<UsersDataGradeViewDTO> dto = clsUserLogic.SerchingByFilter(Num, Text, Filter);
            if (dto != null)
            {
                return Ok(dto);
            }
            return NotFound();
        }


        [HttpGet("LoginUser/{UserName}/{PassWord}")]
        public ActionResult<UsersDTO> Login(string UserName, string PassWord)
        {
            UsersDTO dto = clsUserLogic.Login(UserName, PassWord);
            if (dto != null)
            {
                return Ok(dto);
            }
            return NotFound();
        }
    }
}
