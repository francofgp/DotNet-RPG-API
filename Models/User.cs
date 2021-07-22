using System.Collections.Generic;

namespace dot_net_api_rpg.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<Character> Characters { get; set; }
    }
}