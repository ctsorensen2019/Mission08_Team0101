using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0101.Models
{
    public class Habit
    {
        [Key]
        [Required]
        public int HabitId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; } //Added DueDate as a DateTime type
        [Required]
        public int QuadrantId { get; set; }
        public int CategoryId { get; set; }
        public bool Completed { get; set; }

    }
}
