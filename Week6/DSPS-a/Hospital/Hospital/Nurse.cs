using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital
{
    public class Nurse : Person
    {
        private Data data = new Data();
        public Area Department { get; set; }
        public Nurse(string name, DateOnly birth, Area department) : base(name, birth)
        {
            Department = department;
            ID = data.InsertNurse(this);
        }

        public Nurse(int id, string name, DateOnly birth, Area department) : base(id, name, birth)
        {
            Department = department;
        }

        public override string ToString()
        {
            return $"NURSE: {ID} - {Name} - {Birth} - {Department}";
        }
    }
}
