using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student : Person
    {
        public Student(string name, string surname, byte age, int iq, int language) : base(name, surname, age)
        {
            this.IQRank = iq;
            this.LanguageRank = language;
        }
        private int _iqRank;
        private int _languageRank;
        public int IQRank
        {
            get { return _iqRank; }
            set
            {
                if (Age > 6 && Age < 20)
                {
                    _iqRank = value;
                }
            }
        }
        public int LanguageRank
        {
            get { return _languageRank; }
                set
            {
                if (Age > 6 && Age < 20)
                {
                    _iqRank = value;
                }
            }
        }
        public void ExamResult()
        {
            if (this.IQRank + this.LanguageRank < 120)
            {
                Console.WriteLine("Student failed");
            }
            else
            {
                Console.WriteLine("Students passed");
            }
        }
    }
}
