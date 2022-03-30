using System.ComponentModel.DataAnnotations;

namespace LanchesM.ViewModel
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "senha")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
