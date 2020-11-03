using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges
{
    public class MenuRepository
    {
        private List<Menu> _contentDirectory = new List<Menu>();
        public bool AddContentToDirectory(Menu content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public List<Menu> GetContents()
        {
            return _contentDirectory;
        }
        public Menu ShowAllItems(string mealName)
        {
            foreach (Menu content in _contentDirectory)
            {
                if (content.MealName == mealName)
                {
                    return content;
                }
            }
            return null;
        }
        public bool UpdateExistingContent(string originalmealName, Menu newContent)
        {
            Menu oldContent = ShowAllItems(originalmealName);
            if (oldContent != null)
            {
                oldContent.MealName = newContent.MealName;
                oldContent.Description = newContent.Description;
                oldContent.Ingredients = newContent.Ingredients;
                oldContent.MealID = newContent.MealID;
                oldContent.Price = newContent.Price;
                return true;
            }
            else
            {
                {
                    return false;
                }
            }
        }
        public bool DeleteItemByName(Menu existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        internal Menu GetContentByMealName(string item)
        {
            throw new NotImplementedException();
        }
    }
}