using System.ComponentModel.DataAnnotations;

namespace MatBlazor.Demo
{
    /// <summary>
    /// A class that contains some example parameters.
    /// </summary>
    public class ExampleParameters
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        [Required]
        [StringLength(40)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}