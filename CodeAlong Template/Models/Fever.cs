using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlong_Template.Models
{
    public class Fever
    {

        [Required( ErrorMessage ="Please enter tempure level")]
        public float  CheckFever { get; set; }
        public string Unit { get; set; }

        public bool Ishypothermia { get; set; }
}
}
