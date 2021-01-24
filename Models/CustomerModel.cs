using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalc.Models
{
    public class CustomerModel
    {
        [Required(ErrorMessage = "Enter Customer Name")]
        [Display(Name = "Customer Name")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Date of Birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Dob { get; set; }

        [Required(ErrorMessage = "Enter your Age")]
        [Display(Name = "Age")]
        [Range(1, 120, ErrorMessage = "Age must be between 1-120 in years.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Occupation")]
        [Display(Name = "Occupation")]
        public string occupation { get; set; }

        [Required(ErrorMessage = "Enter Sum Insured")]
        [Display(Name = "Death- Sum Insured")]
        [Range(1, 500000000, ErrorMessage = "Sum Insured must be between 1-500000000 in amount")]
        [DisplayFormat(DataFormatString = "{0:#}")]
        public float DeathSumInsured { get; set; }

        [Display(Name = "Premium Amount")]
        public string PremiumAmount { get; set; }

        public IEnumerable<Occupation> Occupations { get; set; }
     
    }
}
