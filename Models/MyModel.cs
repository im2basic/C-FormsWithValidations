using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class MyModel
    {
        [Required(ErrorMessage = "Must be at least 4 characters long")]
        [MinLength(4)]
        public string FirstName {get; set;}
        [Required(ErrorMessage = "Must be at least 4 characters long")]
        [MinLength(4)]
        public string LastName {get; set;}
        [Required(ErrorMessage = "Enter valid age")]
        [Range(1,1000, ErrorMessage = "Age must be between 1 and 200")] 
        public int Age {get; set;}
        [Required(ErrorMessage = "Enter valid email")]
        [EmailAddress]
        public string Email {get; set;}
        [Required(ErrorMessage = "Enter valid password")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password {get; set;}
    }
}



        // public MyModel(string firstName, string lastName, int age, string email, string password) 
        // {
        //     this.FirstName = firstName;
        //     this.LastName = lastName;
        //     this.Age = age;
        //     this.Email = email;
        //     this.Password = password;
        // }