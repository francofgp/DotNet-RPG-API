using System.Threading.Tasks;
using dot_net_api_rpg.Dtos.Character;
using dot_net_api_rpg.Dtos.Weapon;
using dot_net_api_rpg.Models;

namespace dot_net_api_rpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}