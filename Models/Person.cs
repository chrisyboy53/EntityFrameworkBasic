using System;
using System.ComponentModel.DataAnnotations;

namespace EntityTest.Models {

    public class Person {

        [KeyAttribute()]
        public int PersonId { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public int Age { get; set; }

    }

}