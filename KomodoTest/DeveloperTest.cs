using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoTest
{
    [TestClass]
    public class DeveloperTest
    {
        [TestMethod]
        public void NewDeveloper()
        {
            DeveloperRepo myRepo = new DeveloperRepo();
            Developer newDeveloper = ParseDeveloperFromInput("Jason,LaPointe,2,false");
            myRepo.AddDeveloper(newDeveloper);
            newDeveloper = ParseDeveloperFromInput("Dawn,Hopkins,3,false");
            myRepo.AddDeveloper(newDeveloper);
            myRepo.ListAllDevelopers();            
            myRepo.RemoveDeveloper(newDeveloper);
            myRepo.ListAllDevelopers();
            

            //Arrange

            //Act

            //Assert

        }
    }
}
