using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Hospital
    {
        private Data data = new Data();
        public int ID { get; set; }
        public string Name { get; set; }

        public Hospital(string name)
        {
            Name = name;
            ID = data.InsertHospital(this);
        }

        public Hospital(string name, List<Person> people)
        {
            Name = name;
            ID = data.InsertHospital(this, people);
        }

        public void AddPerson(Person person)
        {
            data.AddPeopleToHospital(person.ID, this.ID);
        }

        public List<Patient> GetPatients()
        {
            return data.SelectPatients(this.ID);
        }


        public List<Person> GetStaff()
        {
            return data.SelectStaff(this.ID);
        }

        public override string ToString()
        {
            string s = $"HOSPITAL {Name} - {ID}\n";
            s += "---PATIENTS:\n";
            foreach (Patient p in GetPatients())
            {
                s += $"* {p}\n";
            }

            s += "---STAFF:\n";
            foreach (Person p in GetStaff())
            {
                s += $"* {p}\n";
            }
            return s;
        }
    }
}
