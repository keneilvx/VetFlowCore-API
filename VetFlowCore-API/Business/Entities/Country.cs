using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetFlowCore.Entities
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;
    }
}
