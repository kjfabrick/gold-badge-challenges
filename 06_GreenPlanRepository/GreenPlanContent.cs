using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_GreenPlanRepository
{
    public class GreenPlanContent
    {
        public string HybridCar { get; set; }
        public string ElectricCar { get; set; }
        
        public GreenPlanContent() { }
        public GreenPlanContent(string hybridCar, string electricCar)
        {
            HybridCar = hybridCar;
            ElectricCar = electricCar;
        }
    }
}
