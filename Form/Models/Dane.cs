using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Hasło")]
        [RegularExpression("(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).{8}")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string Temat { get; set; }
        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string Tresc { get; set; }
    }
}
