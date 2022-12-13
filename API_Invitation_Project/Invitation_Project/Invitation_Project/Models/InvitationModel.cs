using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Invitation_Project.Models
{
    public class InvitationModel
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Eposta { get; set; }
        [Required]
        public bool? KatilmaDurumu { get; set; }
    }
}