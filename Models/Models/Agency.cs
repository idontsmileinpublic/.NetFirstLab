using System;

namespace Lab1.Models
{
    public class Agency
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public int IdAdress { get; set; }

        public override string ToString()
        {
            return string.Format($"Назва: {Name};");
        }
    }
}
