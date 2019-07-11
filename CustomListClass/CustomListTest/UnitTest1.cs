using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;


namespace CustomListTest
{
    [TestClass]
    public class CustomClassTest
    {
        [TestMethod]

        public void Removes_And_Updates_Count()
        {
            // arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            customList.Count = 6;
            int inputValue = 7;
            int expected = 5;
            int actual;
            // act
            customList.Remove(inputValue);
            int actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);




        }

        public void Adds_String_Checks_For_Three()
        {
            // arrange
            CustomList<string> customList = new CustomList<string>();
            string inputValue1 = "one";
            string inputValue2 = "two";
            string inputValue3 = "three";
            int expected = 3;
            int actual;

            // act
            customList.Add(inputValue1);
            customList.Add(inputValue2);
            customList.Add(inputValue3);
            int actual = customList.Count;

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
            int expected = 1;
            actual;
            // act
            customList.Add(inputValue);
            int actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);

    }   }




}
