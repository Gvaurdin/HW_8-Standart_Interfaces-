using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_Standart_Interfaces_
{

    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return DateTime.Compare((x as Student).BirthDate, ((Student)(y)).BirthDate);
            }

            throw new NotImplementedException();
        }
    }

    class Last_NameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return ((Student)x).LastName.CompareTo(((Student)y).LastName);
            }

            throw new NotImplementedException();
        }
    }

    class Student_CardComparer_Number : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return ((Student)x).StudentCard.Number.CompareTo(((Student)y).StudentCard.Number);
            }

            throw new NotImplementedException();
        }
    }

    class Student_CardComparer_SeriesAndNumber : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                int series_compare = ((Student)x).StudentCard.Series.CompareTo(((Student)y).StudentCard.Series);
                if (series_compare == 0)
                {
                    return ((Student)x).StudentCard.Number.CompareTo(((Student)y).StudentCard.Number);
                }
                else return series_compare;
            }

            throw new NotImplementedException();
        }
    }
}
