using System.Threading.Tasks;
using dot_net_api_rpg.Dtos.Character;
using dot_net_api_rpg.Dtos.CharacterSkill;
using dot_net_api_rpg.Models;

namespace dot_net_api_rpg.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}