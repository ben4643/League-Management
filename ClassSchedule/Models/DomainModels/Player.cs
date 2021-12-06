using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ClassSchedule.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Display(Name = "Player Name")]
        [StringLength(100, ErrorMessage = "Player name may not exceed 100 characters.")]
        [Required(ErrorMessage = "Please enter a name.")]
        public string PlayerName { get; set; }

        [Display(Name = "League")]
        [Required(ErrorMessage = "Please enter a league")]
        public int LeagueId { get; set; }
        public League League { get; set; }

        [Display(Name = "Team")]
        [Required(ErrorMessage = "Please enter a Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [Display(Name = "Salary")]
        [Required(ErrorMessage = "Please enter a salary")]
        public double Salary { get; set; }

        [Display(Name = "Platform")]
        [Required(ErrorMessage = "Please enter a platform")]
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }


        public ICollection<Match> Matches1 { get; set; }
        public ICollection<Match> Matches2 { get; set; }
        public ICollection<Match> Matches3 { get; set; }
        public ICollection<Match> Matches4 { get; set; }
        public ICollection<Team> Teams { get; set; }

    }
}
