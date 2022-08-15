using System.ComponentModel.DataAnnotations;

namespace smartwallet1.web.Data.Entities
{
    public class Customer: BaseEntity <Guid>
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Middlename { get; set; }

        [Required]
        [MaxLength(11)]
        public string Country { get; set; }
        public string Maritalstatus { get; set; }
        public string State { get; set; }
        public string city { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime SubmissionDate { get; set; }
        public bool Active { get; set; }
        
    }
}
