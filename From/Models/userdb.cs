//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace From.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class userdb
    {
        public int userid { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Hobbies { get; set; }
        public string ImagePath { get; set; }
        public HttpPostedFileBase FileName { get; set; }
        public string Password { get; set; }
    }
}

