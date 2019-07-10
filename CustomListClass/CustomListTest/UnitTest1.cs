using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
using System.Collections.Generic;

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
            string inputValue = "String 1";

            // act
            customList.Add(inputValue);

            // assert
            Assert.AreSame(customList[0], inputValue);

        }
    }
}
