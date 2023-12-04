using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class Student:Person
    {
         public string StudentId {  get; set; }
         public string Program { get; set; }
         public DateTime DateRegistered{ get; set; }
       // public string Name { get; set; }
        public Address address { get; set; }


        public Student(string name, string email, string telNum, string _id, string _program,DateTime dateRegistered)
            : base(name, email, telNum)
        {
            StudentId = _id;
            // Name = _name;
            Program = _program;
            DateRegistered = dateRegistered;
        }
        public void setAddress( string _street)
        {
            address = new Address(_street);
        }
        ///Write an equals methods in person class here not person
        ///

        public static bool operator ==(Student a, Student b)
        {
            return object.Equals(a, b);
        }
        public static bool operator !=(Student a, Student b)
        {
            return !object.Equals(a, b);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Student rhs = obj as Student;
             
            return this.StudentId == rhs.StudentId && this.Program == rhs.Program && this.DateRegistered == rhs.DateRegistered;
        }

        public override int GetHashCode()
        {
            return this.StudentId.GetHashCode() ^ this.StudentId.GetHashCode() ^ this.DateRegistered.GetHashCode();
        }
    }
}
