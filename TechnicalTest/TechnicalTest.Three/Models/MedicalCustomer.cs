using System;
using TechnicalTest.Library;

namespace TechnicalTest.Three
{
    public class MedicalCustomer : Customer
    {
        public MedicalDiscipline Discipline { get; }
        public MedicalCustomer(string name, string age, MedicalDiscipline discipline) : base(name, age)
        {
            Discipline = discipline;
        }

        public override string Specifics()
        {
            switch (Discipline)
            {
                case MedicalDiscipline.Dentist: return "Dentist";
                case MedicalDiscipline.Surgeon: return "Surgeon";
                case MedicalDiscipline.Nurse: return "Nurse";
                default: throw new Exception("No Mapping to this Discipline");
            }
        }
    }
}
