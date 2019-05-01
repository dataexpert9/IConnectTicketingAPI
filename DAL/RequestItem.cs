using Component.Utility.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL
{
    public class Request
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string TrunkName { get; set; }

        public string CountryName {get;set;}

        public string NetworkName { get; set; }

        public double Rate { get; set; }

        public int Quantity { get; set; }

        public string Comments { get; set; }

        public Status RequestStatus { get; set; }

        public string ImageUrl { get; set; }

        public short RequestType { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [ForeignKey("User")]
        public int Sales_Id { get; set; } // id of person who submitted request.
        public virtual User Sales { get; set; }

        [ForeignKey("User")]
        public int? NOC_Id { get; set; } // id of person who change status of request.
        public virtual  User NOC { get; set; }

        //public virtual Driver Driver { get; set; }

        //[ForeignKey("DriverRating")]
        //public int? DriverRating_Id { get; set; }

        //public virtual DriverRating DriverRating { get; set; }


    }
}
