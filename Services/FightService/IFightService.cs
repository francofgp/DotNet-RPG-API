using System.Threading.Tasks;
using dot_net_api_rpg.Dtos.Fight;
using dot_net_api_rpg.Models;

namespace dot_net_api_rpg.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}