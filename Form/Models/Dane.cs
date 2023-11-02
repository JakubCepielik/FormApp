using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [RegularExpression(@".{2,}", ErrorMessage = "Pole Imię wymaga conajmniej 2 znaków.")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Pole Nazwisko wymaga conajmniej 2 znaków.")]
        [RegularExpression(@".{2,}", ErrorMessage = "Pole Imię wymaga conajmniej 2 znaków.")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Niepoprawny email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Hasło")]
        [RegularExpression("(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).{8}", ErrorMessage = "Hasło powinno zawierać conajmniej jedną dużą i jedną małą literę oraz jedną cyfre i składać sie z conajmniej 8 znaków.")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Compare("Haslo", ErrorMessage = "Podane hasła róźnią się od siebie.")]
        [DataType(DataType.Password)]
        public string PotwierdzHaslo { get; set; }

        [Required(ErrorMessage = "Prosze podaj numer telefonu")]
        [Phone(ErrorMessage ="Niepoprawny numer telefonu")]
        //[RegularExpression("[0-9]{9}", ErrorMessage = "Niepoprawny format numeru telefonu")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Prosze podaj swoj wiek")]
        [Range(10, 80, ErrorMessage = "Wiek musi być w przedziale 10 a 80.")]
        public string Wiek { get; set; }

        public string Miasto { get; set; }
        public enum Miasta { Kraków = 1, Warszawa = 2, Poznań = 3, Wrocław = 4, Lublin = 5 }

    }
}
