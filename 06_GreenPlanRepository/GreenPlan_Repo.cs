using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_GreenPlanRepository
{
    public class GreenPlan_Repo
    {
        public class GreenPlanContent_Repo
        {
            public List<GreenPlanContent> _contentDirectory = new List<GreenPlanContent>();

            public object HybridCar { get; set; }
            public object ElectricCar { get; set; }

            public bool AddContentToDirectory(GreenPlanContent content)
            {
                int startingCount = _contentDirectory.Count;

                _contentDirectory.Add(content);

                bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
                return wasAdded;
            }

            public List<GreenPlanContent> GetContents()
            {
                return _contentDirectory;
            }
            public GreenPlanContent FindPersonByName(string hybridCar)
            {
                foreach (GreenPlanContent content in _contentDirectory)
                {
                    if (content.HybridCar == hybridCar)
                    {
                        return content;
                    }
                }
                return null;
            }
            public bool UpdateExistingContent(string originalfirstName, GreenPlanContent newContent)
            {
                GreenPlanContent oldContent = FindPersonByName(originalfirstName);

                if (oldContent != null)
                {
                    oldContent.HybridCar = newContent.HybridCar;
                    oldContent.ElectricCar = newContent.ElectricCar;
                    return true;
                }
                else
                {
                    {
                        return false;
                    }
                }
            }
            public bool DeleteCustomerByName(GreenPlanContent existingContent)
            {
                bool deleteResult = _contentDirectory.Remove(existingContent);
                return deleteResult;
            }

            public GreenPlanContent_Repo FindCarByName(string hybridCar)
            {
                throw new NotImplementedException();
            }

            public bool UpdateExistingContent(object hybridCar, object newCar)
            {
                throw new NotImplementedException();
            }
        }
    }
}
