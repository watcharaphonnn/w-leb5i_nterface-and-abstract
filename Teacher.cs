using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_LAB5
{
    internal class Teacher : User, Member, Speaker
    {
        public string Major { get; set; }
        public string Position { get; set; } // อาจารย์, ผศ., รศ., ศ.

        public void Register() { }
        public string GetDetails() => $"[Teacher] {Position}{GetFullName()}, Major: {Major}";

        public void Train() => Console.WriteLine($"{GetFullName()} is training...");
        public void ApproveResult(string name) => Console.WriteLine($"Approved for: {name}");
    }
}
