using System.ComponentModel.DataAnnotations;

namespace UyeOlSayfası.Models
{
    public class RegisterViewModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string RePassword { get; set; }
    }
}