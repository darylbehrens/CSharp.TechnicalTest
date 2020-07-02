using System;
using TechnicalTest.Library;

namespace TechnicalTest.Three
{
    public class TechCustomer : Customer
    {
        public OS OperatingSystem { get; }

        public TechCustomer(string name, string age, OS operatingSystem) : base(name, age)
        {
            OperatingSystem = operatingSystem;
        }


        public override string Specifics()
        {
            try
            {
                switch (OperatingSystem)
                {
                    case OS.Linux: return "Linux";
                    case OS.Windows: return "Windows";
                    case OS.OSX: return "OSX";
                    default: throw new Exception("No Mapping to this Operating System");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
