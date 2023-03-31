using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        
        [Display(Name = "Date Of Birth")]
        [Min18YearsIfAMember]
        public DateTime BirthDate { get; set; }
    }
}