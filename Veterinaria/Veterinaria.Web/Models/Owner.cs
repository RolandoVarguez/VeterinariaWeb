using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinaria.Web.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string UserId  { get; set; }
        [ForeignKey ("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}