using System;
namespace TugasInheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person orang = new Person("Budi", 28);
            orang.GetNameAndAge();

            Teacher guru = new Teacher("Daus", 34, "2881", "Math");
            guru.GetNameAndAge();

            Student siswa = new Student("Safira", 19, "2898", "safira@gmail.com");
            siswa.GetNameAndAge();
        }
    }
}