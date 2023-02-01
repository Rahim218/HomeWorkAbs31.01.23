using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkAbs31._01._23
{
    internal class Student
    {
        public Student()
        {
            _totalCount++;
            _no = _totalCount;
        }
         int _no;
        public int No { get { return _no; } }
        public string Name;
        private string _groupNo;
        public string GroupNo
        {
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
           
            get
            {
                return _groupNo;
            }
        }

        static int _totalCount;

        public bool CheckGroupNo(string str)
        {
            if (string.IsNullOrWhiteSpace(str) && str.Length != 4)
            {
                return false;
            }
            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
