using AutoMapper;
using dot_net_api_rpg.Dtos.Character;
using dot_net_api_rpg.Dtos.Weapon;
using dot_net_api_rpg.Models;

namespace dot_net_api_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();

        }
    }
}