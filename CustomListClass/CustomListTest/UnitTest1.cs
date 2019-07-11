using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;


namespace CustomListTest
{
    [TestClass]
    public class CustomClassTest
    {
        [TestMethod]



            public void Adds_String_Checks_Count_For_Three()
            {
                // arrange
                CustomList<string> customList = new CustomList<string>();
                string inputValue1 = "one";
                string inputValue2 = "two";
                string inputValue3 = "three";
                int expectedCount = 3;

                // act
                customList.Add(inputValue1);
                customList.Add(inputValue2);
                customList.Add(inputValue3);
                int actualCount = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
           }

        public void Add_AddToEmptyList_ValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 10;
            int actual;
            // act
            test.Add(10);
            actual = test[0];
            // assert
            Assert.AreEqual(expected, actual);
        }

        public void Adds_String_Checks_Count_For_One()
        {
            // arrange
            CustomList<string> customList = new CustomList<string>();
            string inputValue = " 1";
            int expectedCount = 1;

            // act
            customList.Add(inputValue);
            int actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);






        }
    }

}
