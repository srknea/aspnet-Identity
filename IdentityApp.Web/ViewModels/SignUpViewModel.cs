using System.ComponentModel.DataAnnotations;

namespace IdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {

        }
        public SignUpViewModel(string userName, string email, string phone, string password)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
        }

        [Required(ErrorMessage = "Kullanıcı Ad alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        [Display(Name = "Telefon :")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre :")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Şifre tekrar alanı boş bırakılamaz")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifre aynı değildir.")]
        [Display(Name = "Şifre Tekrar :")]
        public string PasswordConfirm { get; set; }
    }
}