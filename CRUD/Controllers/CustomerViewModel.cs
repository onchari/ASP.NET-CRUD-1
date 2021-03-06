﻿using System.ComponentModel.DataAnnotations;

namespace CRUD.Controllers
{
    public class CustomerViewModel
    {
        public long Id { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        [Display(Name ="Mobile No")]
        public string MobileNo { get; set; }
    }
}