namespace Mission08_Team0101.Models
{
    public class Habit
    {
        public int HabitId { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; } //Added DueDate as a DateTime type
        public int QuadrantId { get; set; }
        public string CategoryName { get; set; }
        public bool Completed { get; set; }

    }
}
