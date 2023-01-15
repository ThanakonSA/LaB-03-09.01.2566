using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaB_03_09._01._2566
{
    internal class Student
    {
        public String _Name;
        public String _studentId;
        public int _Birthyear;
        public int _High;
        public double _Grade;
        public String _Major;
        public double _Female;

        public Student(String _Name, String _studenId, int _Birthyear, int _High, double _Grade, String _Major) 
        { 
            this._Name = _Name;
            this._studentId = _studenId;
            this._Birthyear = _Birthyear;
            this._High = _High;
            this._Grade = _Grade;
            this._Major = _Major;
        }

        public String Name 
        { 
            get { return _Name; } 
        }
        public String studentId
        {
            get { return _studentId; }
        }
        public int Birthyear
        {
            get { return _Birthyear; }
        }
        public double High
        {
            get { return _High; }
        }
        public double Grade
        {
            get { return _Grade; }
        }
        public String Major
        {
            get { return _Major; }
        }
    }
}
