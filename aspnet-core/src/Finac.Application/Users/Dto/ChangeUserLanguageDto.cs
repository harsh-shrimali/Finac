using System.ComponentModel.DataAnnotations;

namespace Finac.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}