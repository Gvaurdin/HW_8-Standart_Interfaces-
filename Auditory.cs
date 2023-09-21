﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_Standart_Interfaces_
{
    internal class Auditory : IEnumerable
    {
        Student[] students =
{
            new Student {
            FirstName ="John",
            LastName ="Miller",
            BirthDate =new DateTime(1997,3,12),
            StudentCard =new StudentCard { Number=189356,
            Series="AB" }
            },
            new Student {
            FirstName ="Candice",
            LastName ="Leman",
            BirthDate =new DateTime(1998,7,22),
            StudentCard = new StudentCard { Number=345185,
            Series="XA" }
            },
            new Student {
            FirstName ="Joey",
            LastName ="Finch",
            BirthDate = new DateTime(1996,11,30),
            StudentCard = new StudentCard { Number=258322,
            Series="AA" }
            },
            new Student {
            FirstName ="Nicole",
            LastName ="Taylor",
            BirthDate = new DateTime(1996,5,10),
            StudentCard = new StudentCard { Number=513484,
            Series="AA"}
            }
            };
        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }
}
