using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;


namespace CustomListTest
{
    [TestClass]
    public class CustomClassTest
    {
        [TestMethod]
        public void Custom_List_Adds_String_To_Empty_List()
        {
            // arrange
            CustomList<string> customList = new CustomList<string>();
            string inputValue = "1";

            // act
            customList.Add(inputValue);

            // assert
            Assert.AreSame(customList[0], inputValue);

        }

        public void Custom_List_Adds_String_Checks_Count_For_One()
        {
            // arrange
            CustomList<string> customList = new CustomList<string>();
            string inputValue = " 1";
            int expectedCount = 1;

            // act
            customList.Add(inputValue);
            int actualCount = customList.Count;

            // assert
            Assert.AreEqual(expectedCount, actualCount);

        }
    }

}
