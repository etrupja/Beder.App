using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(120)]
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int GetAge(DateTime birthDate)
        {
            //Calculate Age
            return 10;
        }

        //Comment added on 05/12/2022

    }
}
