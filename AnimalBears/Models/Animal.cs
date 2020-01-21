using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalBears.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage ="Please Give your Animal a Name")]
        public string Name { get; set; }

        [Display(Name="Animal Name")]
        [Required(ErrorMessage ="Please select a Type of Animal")]
        public string AnimalName { get; set; }

        [Required(ErrorMessage ="Please select the color of your Animal")]
        public string Color { get; set; }
    }
}
