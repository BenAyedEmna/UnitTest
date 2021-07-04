using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace unittest
{
    [TestClass]
    public class ToutLesTestDoiventAvoirUnNom
    {
        [TestMethod]
        public void DeuxiemeGrandNombre_ListNull_NullReferenceException()
        {
            List<int> ListTest = null;

            Assert.ThrowsException<System.NullReferenceException>(() => TuDoisMettreTesFonctionDansUneClass.DeuxiemeGrandNombre(ListTest));
        }

        [TestMethod]
        public void DeuxiemeGrandNombre_LengthLessThan2_ArgumentOutOfRangeException()
        {
            //Arrange
            List<int> ListTest = new List<int>();
            ListTest.Add(1);

            //Assert and Act 
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => TuDoisMettreTesFonctionDansUneClass.DeuxiemeGrandNombre(ListTest));
        }

        [TestMethod]
        public void DeuxiemeGrandNombre_LengthGreaterThan2_ReturnTheNumber()
        {
            //Arrange 
            List<int> ListTest = new List<int>();
            ListTest.Add(22);
            ListTest.Add(44);
            ListTest.Add(11);

            //act
            int Max2;
            Max2 = TuDoisMettreTesFonctionDansUneClass.DeuxiemeGrandNombre(ListTest);


            //Assert
            Assert.AreEqual(Max2, ListTest[1]);

        }
    }


}

