using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Greeting_Repo
{
    public class CustomerContent_Repo
    {
        public List<CustomerContent_Repo> _contentDirectory = new List<CustomerContent_Repo>();
        public bool AddContentToDirectory(CustomerContent_Repo content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public List<CustomerContent_Repo> GetContents()
        {
            return _contentDirectory;
        }
    }
}
