using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is Requeried")]
        public string Title { get; set; } 

        public string? Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Deadline { get; set; }

        public string? FilePath { get; set; }
    }
}