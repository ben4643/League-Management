using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ClassSchedule.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        [Display(Name = "Team Name")]
        [StringLength(100, ErrorMessage = "Team name may not exceed 100 characters.")]
        [Required(ErrorMessage = "Please enter a name.")]
        public string TeamName { get; set; }

        [Display(Name = "Division")]
        [Required(ErrorMessage = "Please enter a division")]
        public string Division { get; set; }

        public ICollection<Player> Players { get; set; }
        public ICollection<Match> HomeMatches { get; set; }
        public ICollection<Match> AwayMatches { get; set; }       // Navigation property

    }
}
