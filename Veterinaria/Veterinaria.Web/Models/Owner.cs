using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.Web.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}