using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo 
    {
        [Required]
        public int Id { get; set; }  //nul bir değer geldği zaman REQUİRED  bu alan zorunludur mesajı verecek . 
        [Required(ErrorMessage = "Ad alanı zorunlu!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon alanı zorunlu!")]
        public string? Phone { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Katılım durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; }  //true ,false, null (bool türünün default u false tur .)

    }
}
