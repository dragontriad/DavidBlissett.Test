using System;
using System.ComponentModel.DataAnnotations;

namespace DavidBlissett.Test.Shared
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Max Length 100.")]
        public string FirstName { get; set; }

        [StringLength(100, ErrorMessage = "Max Length 100.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Max Length 150.")]
        public string Address1 { get; set; }

        [StringLength(150, ErrorMessage = "Max Length 150.")]
        public string Address2 { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Max Length 20.")]
        public string PostCode { get; set; }

        [StringLength(20, ErrorMessage = "Max Length 20.")]
        public string TelephoneNumber { get; set; }
    }

    public class CustomerModel
    {
        public CustomerModel()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Address1 = string.Empty;
            Address2 = string.Empty;
            PostCode = string.Empty;
            TelephoneNumber = string.Empty;
        }

        public CustomerModel(Customer customer)
        {
            CustomerID = customer.CustomerID;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Address1 = customer.Address1;
            Address2 = customer.Address2;
            PostCode = customer.PostCode;
            TelephoneNumber = customer.TelephoneNumber;
        }

        public static Customer ToCustomerEntity(CustomerModel model)
        {
            return new Customer
            {
                CustomerID = model.CustomerID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address1 = model.Address1,
                Address2 = model.Address2,
                PostCode = model.PostCode,
                TelephoneNumber = model.TelephoneNumber
            };
        }

        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public string TelephoneNumber { get; set; }
    }

}
