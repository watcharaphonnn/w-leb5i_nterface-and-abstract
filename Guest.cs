using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_LAB5
{
    internal class Guest : User, Member, Speaker
    {
        public string Company { get; set; }
        public string JobPosition { get; set; }

        public void Register() { }
        public string GetDetails() => $"[Guest] {GetFullName()}, Work at: {Company} ({JobPosition})";

        public void Train() => Console.WriteLine($"{GetFullName()} (Guest Speaker) is training...");
        public void ApproveResult(string name) => Console.WriteLine($"Guest Speaker approved: {name}");
    }
}
