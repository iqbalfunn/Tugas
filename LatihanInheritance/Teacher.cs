using System;
namespace TugasInheritance
{
    public class Teacher : Person
    {
        public Teacher(string nama, int umur, string idguru, string mapel)
        : base(nama, umur)
        {
            TeacherId = idguru;
            Subject = mapel;
        }

        public string TeacherId { get; set; }
        public string Subject { get; set; }

    }
}