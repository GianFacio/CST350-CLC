using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;


namespace RegisterAndLoginApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
