using System;

namespace ProvaDevVisualAPI.Models
{
    public class Person
    {

        public Person() => Birthday = DateTime.Now.ToString("yyyy/MM/dd");

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Birthday { get; set; }

        public string CPF { get; set; }

        public string Address { get; set; }
    }
}