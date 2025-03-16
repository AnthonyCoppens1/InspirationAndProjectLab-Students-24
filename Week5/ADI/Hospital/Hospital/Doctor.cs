using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital
{
    public class Doctor : Person
    {
        private Data data = new Data();
        public string Speciality { get; set; }

        public Doctor(string name, DateOnly birth, string speciality) : base(name, birth)
        {
            Speciality = speciality;
            ID = data.InsertDoctor(this);
        }

        public Doctor(int id, string name, DateOnly birth, string speciality) : base(id, name, birth)
        {
            Speciality = speciality;
        }

        public override string ToString()
        {
            return $"DOCTOR: {ID} - {Name} - {Birth} - {Speciality}";
        }
    }
}
