using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DGFScouting.Models
{
    public class CommittedPlayer
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email must be in format dave@gmail.com")]
        public string Email { get; set; }
    
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid phone number format, please enter numbers only.")]
        public string PhoneNumber { get; set; }

        [Required]
        public int JerseyNumber { get; set; }

        [Required]
        public DateTime CommitmentDate { get; set; }
    }
}