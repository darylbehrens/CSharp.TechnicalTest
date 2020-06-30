using System;
using System.Collections.Generic;
using TechnicalTest.Library;

namespace TechnicalTest.Three
{
    public class TestThreeRepository : IRepository
    {
        public void Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            yield return new TechCustomer("Michael", "Scott", OS.Linux);
            yield return new TechCustomer("Franie", "Glass", OS.Windows);
            yield return new TechCustomer("Holden", "Caufield", OS.Linux);
            yield return new TechCustomer("Winnie", "The Pooh", OS.OSX);
            yield return new TechCustomer("Sarah", "Johnston", OS.Windows);
            yield return new MedicalCustomer("Art", "Vandalay", MedicalDiscipline.Dentist);
            yield return new MedicalCustomer("Bill", "Gates", MedicalDiscipline.Surgeon);
            yield return new MedicalCustomer("Pam", "Beasley", MedicalDiscipline.Nurse);
            yield return new MedicalCustomer("Jane", "Bond", MedicalDiscipline.Surgeon);
        }
    }
}
