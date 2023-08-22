using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Entities;

public class Author
{
    [Key]
    public Guid Id { get; set; } //guid: Es responsabilidad del cliente. Mirar web

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    [Required]
    public DateTimeOffset DateOfBirth { get; set; }

    [Required]
    [MaxLength(50)]
    public string MainCategory { get; set; }

    public ICollection<Course> Courses { get; set; }
        = new List<Course>();

    public Author(string firstName, string lastName, string mainCategory) //Hay constructor a pesar de que nos dijo que no.
    { 
        FirstName = firstName;
        LastName = lastName;
        MainCategory = mainCategory;
    }
}

