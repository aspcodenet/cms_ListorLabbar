using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListorLabbar.Lab3
{
    class Student : IComparable<Student>
    {
        public string Namn { get; set; }
        public int Score { get; set; }

        public int CompareTo(Student other)
        {
            if (other.Score > this.Score)
                return 1;
            if (other.Score < this.Score)
                return -1;
            return Namn.CompareTo(other.Namn);

        }
    }
}
