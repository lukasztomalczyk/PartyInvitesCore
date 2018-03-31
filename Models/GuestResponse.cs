
using System;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
            [Required(ErrorMessage = "Proszę podać imię")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Proszę podać Email")]
            [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Proszę podać prawidłowy adres e-mail.")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Proszę podać numer teelfonu")]
            public string Phone { get; set; }
            public bool? WillAttend { get; set; }
    }
}
