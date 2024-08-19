using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class student
    {
        [Required(ErrorMessage ="name is must needed")] //custom error msg if you want use this 
        [StringLength(6 , MinimumLength =3,ErrorMessage ="minimum 3 letters and maximum 6")]
        public string name { get; set; }
        [Required(ErrorMessage = "Email is must needed")] 
        //[EmailAddress] // we can use but it will show error
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$\r\n", ErrorMessage ="should be in the form xyz23@gmail.com")]
        public string email { get; set; }

        [Required(ErrorMessage = "age is must needed")] 
        [Range(10,18,ErrorMessage = "minimum age is 10 and maximum is 18")]
        public int? age { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$",
            ErrorMessage = "Password must be at least 8 characters long and include at least one letter and one number.")]
        public string password { get; set; }

        [Required(ErrorMessage = "confirm Password is required.")]
        [Compare("password",ErrorMessage ="Both password must be same" )]
        public string confirmpassword { get; set; }
        [Required(ErrorMessage = "Websiteurl is required.")]
        [Url(ErrorMessage ="Invalid url")]
        public string websiteurl { get; set; }

    }
}
