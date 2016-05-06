using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DAL
{
	//[MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {
    }

	public class CustomerMetadata
    {
		[Display(Name = "Customer ID")]
		[Required(ErrorMessage = "Customer ID need to be filled.")]
		[StringLength(5, ErrorMessage = "Max ID characters is 5.")]
		[Remote("CheckCustomerID", "Customers", ErrorMessage ="Customer ID already exist.")]
		public string CustomerID { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name need to be filled.")]
        [StringLength(40, ErrorMessage = "Max Company Name characters is 40.")]
        public string CompanyName { get; set; }
    }
}
