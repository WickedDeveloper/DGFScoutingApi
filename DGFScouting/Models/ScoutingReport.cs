using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DGFScouting.Models
{
    public class ScoutingReport
    {
        public int ScoutingReportId { get; set; }

        [Required]
        public int Skills { get; set; }

        [Required]
        public int TeamPlay { get; set; }

        [Required]
        public int Fitness { get; set; }

        [Required]
        public int Character { get; set; }

        [Required]
        [StringLength(255)]
        public string Notes { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }
    }
}