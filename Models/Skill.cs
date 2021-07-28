using System.Collections.Generic;

namespace dot_net_api_rpg.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }

        /* Este atributo es para la relacion many to many, 
        tiene que estar acá y en el character */
        public List<CharacterSkill> CharacterSkills { get; set; }
    }
}