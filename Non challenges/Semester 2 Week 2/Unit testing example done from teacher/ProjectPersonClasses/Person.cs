using System;

namespace ProjectPersonClasses
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }



        public string GetInfo() {
            return $"{this.Name}{Id.ToString(!)}";
        }
    }
}
