using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using dot_net_api_rpg.Dtos.Character;
using dot_net_api_rpg.Models;
using dot_net_api_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_api_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {


        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            //Forma vieja de conseguir el ID sin injection de HTTP Context
            /*             int id = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
             */
            return Ok(await _characterService.GetAllCharacters());
        }

        /*         [AllowAnonymous]*/ //Para permitir sin token
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {

            ServiceResponse<GetCharacterDto> response = await _characterService.UpdateCharacter(updatedCharacter);

            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(await _characterService.UpdateCharacter(updatedCharacter));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ServiceResponse<List<GetCharacterDto>> response = await _characterService.DeleteCharacter(id);

            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}