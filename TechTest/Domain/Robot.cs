using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechTest.Domain
{
    public class Robot
    {
        [Key]
        public int Id { get; set; }
        public string ConditionExpertise { get; set; }
    }
}
