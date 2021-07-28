using System.Linq;
using AutoMapper;
using dot_net_api_rpg.Dtos.Character;
using dot_net_api_rpg.Dtos.Skill;
using dot_net_api_rpg.Dtos.Weapon;
using dot_net_api_rpg.Models;

namespace dot_net_api_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            /* Con ForMember mapeamos que nos muestre la relacion de muchos
            a muchos */
            CreateMap<Character, GetCharacterDto>()
            .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();

        }
    }
}