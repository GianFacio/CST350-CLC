using System.ComponentModel;

namespace RegisterAndLoginApp.Models
{
    public class Register
    {
        [DisplayName("First Name")]
        public string firstName { get; set; }
        [DisplayName("Last Name")]
        public string lastName { get; set; }
        [DisplayName("Gender")]
        public string sex { get; set; }
        [DisplayName("Age")]
        public string age { get; set; }
        [DisplayName("State")]
        public string state { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Username")]
        public string username { get; set; }
        [DisplayName("Password")]
        public string password { get; set; }



        public Register()
        {

        }

        public Register(string firstName, string lastName, string sex, string age, string state, string email, string username, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.age = age;
            this.state = state;
            this.email = email;
            this.username = username;
            this.password = password;
        }
    }
}
