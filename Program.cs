using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            students.Add(new Student());
            students[0].Name = "Marina";
            students[0].Surname = "Lopez";
            students[0].Age = 15;
            students[0].Grade = 8;

            students.Add(new Student());
            students[1].Name = "Matiss";
            students[1].Surname = "Jackson";
            students[1].Age = 16;
            students[1].Grade = 7;

            students.Add(new Student());
            students[2].Name = "Anna";
            students[2].Surname = "Ozolina";
            students[2].Age = 14;
            students[2].Grade = 7;

            students.Add(new Student());
            students[3].Name = "Babatunde";
            students[3].Surname = "Olatunji";
            students[3].Age = 15;
            students[3].Grade = 8;

            foreach(Student s in students)
            {
                Console.WriteLine(s.Name + " is from " + s.School);
            }          
            
            Console.ReadKey();
        }
    }

    //blueprint, instruction, like for Lego
    class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Grade {get; set;}
        public string School { get; private set; } = "Datorium";

        public Student()
        {
            Console.Write("Hi, I am created! I do not know my name.\n");
            Console.ReadKey();
        }

        public void ChangeSchool(string schoolName)
        {
            if(schoolName != "Datorium" || schoolName != "Stanford" || schoolName != "Oxford")
            {
                //change denied
                Console.WriteLine("Use only authorised schools");
            }
            else
            {
                //change allowed
                this.School = schoolName;
            }
        }

    }

}
