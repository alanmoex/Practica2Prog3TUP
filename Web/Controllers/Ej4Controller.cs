using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Web.Ej4;

namespace Web.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]

    public class Ej4Controller : ControllerBase
    {
        public static List<Character> charactersList = new List<Character>();

        [HttpPost("[action]")]
        public ActionResult CreateStrCharacter([FromBody] StrCharacter strCharacter)
        {
            charactersList.Add(strCharacter);
            return Ok(charactersList);
        }

        [HttpPost("[action]")]
        public ActionResult CreateAgiCharacter([FromBody] AgiCharacter agiCharacter)
        {
            charactersList.Add(agiCharacter);
            return Ok(charactersList);
        }

        [HttpPost("[action]")]
        public ActionResult CreateMagicCharacter([FromBody] MagicCharacter magicCharacter)
        {
            charactersList.Add(magicCharacter);
            return Ok(charactersList);
        }

        [HttpGet("[action]")]
        public ActionResult<string> MoveCharacter([FromBody] string name) 
        {
            Character character = charactersList.Find(c => c.Name == name);
            if (character != null )
            {
                return character.MoveXAxis() + character.MoveYAxis();
            }
            else
            {
                return NotFound();
            }
        }
    }


}


















