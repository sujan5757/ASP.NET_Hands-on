using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Models;

public class PostModel
{
    public int Id { get; set; }

    public string Title {get; set; }

    [MaxLength(5000)]
    public string Body {get; set; }

    [Display(Name = "Created At")]
    [DataType(DataType.Date)]
    public DateTime CreatedAt {get; set;}


    [Display(Name = "Updated At")]
    [DataType(DataType.Date)]
    public DateTime UpdatedAt {get; set;}

}
