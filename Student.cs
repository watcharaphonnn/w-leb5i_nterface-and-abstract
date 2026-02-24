using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_LAB5
{
    internal class Student : User, Member
    {
        public string StudentId { get; set; }
        public string Major { get; set; }

        public void Register() { /* Logic การลงทะเบียน */ }
        public string GetDetails() => $"[Student] {GetFullName()}, ID: {StudentId}, Major: {Major}, Contact: {phone}";
    }
}
