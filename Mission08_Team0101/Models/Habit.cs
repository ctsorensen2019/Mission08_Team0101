using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }  // Foreign Key
        public Category? Category { get; set; }  // Navigation propert
        
        public bool Completed { get; set; }

    }
}
