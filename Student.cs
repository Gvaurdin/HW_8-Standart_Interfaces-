using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_Standart_Interfaces_
{
    internal class Student: IComparable, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public object Clone()
        {
            Student tmp = (Student)this.MemberwiseClone();
            tmp.StudentCard = new StudentCard { Series = this.StudentCard.Series, Number = this.StudentCard.Number };
            return tmp;
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return FirstName.CompareTo((obj as Student).FirstName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName,-10} {LastName,-10} {BirthDate.ToShortDateString(),-15} {StudentCard,-25}";
        }
    }
}
