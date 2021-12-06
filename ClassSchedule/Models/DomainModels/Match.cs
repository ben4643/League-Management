using System.ComponentModel.DataAnnotations;

namespace ClassSchedule.Models
{
    public class Match
    {
        public int MatchId { get; set; }                    // PK


        [Range(1, 30, ErrorMessage = "Match number must be between 1 and 30. 1-10 are regular season matches, 11-20 are tiebreaker matches, 20-30 are playoff matches")]
        [Required(ErrorMessage = "Please enter a class number.")]
        public int? Number { get; set; }

        [Display(Name = "Time")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter numbers only for match time.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Match time must be 4 characters long.")]
        [Required(ErrorMessage = "Please enter a match time (in military time format).")]
        public string MilitaryTime { get; set; }

        [Display(Name = "Home Team")]
        public int TeamId1 { get; set; }
        public Team HomeTeam { get; set; }

        [Display(Name = "Player A")]
        public int PlayerId1 { get; set; }                  // Foreign key property
        public Player Player1 { get; set; }                // Navigation property

        [Display(Name = "Player B")]
        public int PlayerId2 { get; set; }                  // Foreign key property
        public Player Player2 { get; set; }                // Navigation property

        [Display(Name = "Away Team")]
        public int TeamId2 { get; set; }
        public Team AwayTeam { get; set; }

        [Display(Name = "Player A")]
        public int PlayerId3 { get; set; }                  // Foreign key property
        public Player Player3 { get; set; }                // Navigation property

        [Display(Name = "Player B")]
        public int PlayerId4 { get; set; }                  // Foreign key property
        public Player Player4 { get; set; }                // Navigation property

        [Display(Name = "League")]
        public int LeagueId { get; set; }                      // Foreign key property
        public League League { get; set; }                        // Navigation property
    }
}
