namespace TaskManager.Models
{
    public class UserPage
    {
        public Account Account { get; set; }
        public int TasksCount { get; set; }
        public List<string> Tasks { get; set; }
    }
}
