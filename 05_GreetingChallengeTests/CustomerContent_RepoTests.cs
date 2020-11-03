using System;
using CustomerContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_GreetingChallengeTests
{
    [TestClass]
    public class CustomerContent_RepoTests
    {
    
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            CustomerContent content = new CustomerContent();
            CustomerContent_Repo repo = new CustomerContent_Repo();

            repo.AddContentToDirectory(content);

            //Act
            List<CustomerContent> contents = repo.GetContents();

            bool directoryHasContent = contents.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            CustomerContent_Repo repo = new CustomerContent_Repo();
            CustomerContent newContent = new CustomerContent("Toy Story", "Toys come to life", 10, Genre.Action, MaturityRating.PG);
            repo.AddContentToDirectory(newContent);
            string title = "Toy Story";

            //Act
            CustomerContent searchResult = repo.GetContentByTitle(title);

            //Assert
            Assert.AreEqual(searchResult.Title, title);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            CustomerContent_Repo repo = new CustomerContent_Repo();
            CustomerContent oldContent = new CustomerContent("Toy Story", "Toys come to life", 10, Genre.Action, MaturityRating.PG);
            repo.AddContentToDirectory(oldContent);

            CustomerContent newContent = new CustomerContent("Toy Story", "Toys come to life", 10, Genre.Action, MaturityRating.PG);

            //Act
            bool updateResult = repo.UpdateExistingContent("Toy Story", newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            CustomerContent_Repo repo = new CustomerContent_Repo();
            CustomerContent content = new CustomerContent("Toy Story", "Toys come to life", 10, Genre.Action, MaturityRating.PG);
            repo.AddContentToDirectory(content);

            //Act
            CustomerContent oldcontent = repo.GetContentByTitle("Toy Story");

            bool removeResult = repo.DeleteExistingContent(oldcontent);

            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
