using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Student
    {
        private int _StudentNumber;
        private string _FirstName;
        private string _LastName;
        private decimal _GPA;
        private string _Classification;
        private string _Major;

        public Student(string ln, string fn)
        {
            _LastName = ln;
            _FirstName = fn;
        }

        public Student(string ln, string fn, int sn)
        {
            _LastName = ln;
            _FirstName = fn;
            _StudentNumber = sn;
            _GPA = 0.00m;
        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

        public decimal GPA
        {
            get { return _GPA; }
            set { _GPA = value; }
        }

        public string FullName
        {
            get { return $"{_FirstName} {_LastName}"; }
        }
        

    }
}
