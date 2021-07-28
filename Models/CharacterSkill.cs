namespace dot_net_api_rpg.Models
{
    public class CharacterSkill
    {
        /* Clase intermedia para la relacion
        Many-To-Many */
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        /* Tambien debemos en el context combinar los dos IDs */
    }
}