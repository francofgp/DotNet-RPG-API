using System.Threading.Tasks;
using dot_net_api_rpg.Dtos.Fight;
using dot_net_api_rpg.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_api_rpg.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;

        }

        [HttpPost("Weapon")]
        public async Task<IActionResult> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }
    }
}