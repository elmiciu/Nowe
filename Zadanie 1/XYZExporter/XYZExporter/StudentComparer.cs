using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZExporter
{
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return (x.Imie == y.Imie)
                && (x.Nazwisko == y.Nazwisko)
                && (x.NrIndeksu == y.NrIndeksu);
        }
        public int GetHashCode(Student obj)
        {
            return obj.NrIndeksu.GetHashCode();
        }
    }
}
