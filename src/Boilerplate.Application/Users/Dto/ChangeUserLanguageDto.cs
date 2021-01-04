using System.ComponentModel.DataAnnotations;

namespace Boilerplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}