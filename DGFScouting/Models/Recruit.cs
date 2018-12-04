using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DGFScouting.Models
{
    public class Recruit
    {
        public int RecruitId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(11)]
        public string Position { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        [StringLength(255)]
        public string Notes { get; set; }

        public DateTime AddedAt { get; set; }

        // Creates one to many relationship between Recruit and Scouting Report
        public ICollection<ScoutingReport> ScoutingReports { get; set; }
    }
}