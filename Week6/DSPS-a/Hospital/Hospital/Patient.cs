﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital
{
    public class Patient : Person
    {
        private Data data = new Data();
        public string Problem { get; set; }
        public string Treatment { get; set; }

        public Patient(string name, DateOnly birth, string problem) : base(name, birth)
        {
            Problem = problem;
            Treatment = "None";
            ID = data.InsertPatient(this);
        }

        public Patient(int id, string name, DateOnly birth, string problem, string treatment) : base(id, name, birth)
        {
            Problem = problem;
            Treatment = treatment;
        }


        public override string ToString()
        {
            return $"PATIENT: {ID} - {Name} - {Birth} - {Problem} - {Treatment}";
        }
    }
}
