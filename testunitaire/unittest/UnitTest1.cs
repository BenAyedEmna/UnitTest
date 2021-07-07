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
        public void DeuxiemeGrandNombre_Length1_ArgumentOutOfRangeException()
        {
            //Arrange
            List<int> ListTest = new List<int>();

            //Assert and Act 
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => TuDoisMettreTesFonctionDansUneClass.DeuxiemeGrandNombre(ListTest));
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
            Assert.AreEqual(Max2,22);
        }

        [TestMethod]
        public void DeuxiemeGrandNombre_LengthMillion_ReturnTheNumber()
        {
            //Arrange 
            List<int> ListTest = new List<int>();
            int i;
            var rand = new Random();
            for (i = 0; i < 1000000; i++)
            {
                ListTest.Add(rand.Next());
            }

            //act
            int NbrMax1, Max2;
            NbrMax1 = 0;
            Max2 = TuDoisMettreTesFonctionDansUneClass.DeuxiemeGrandNombre(ListTest);
            foreach (int e in ListTest)
            {
                if (e > Max2)
                    NbrMax1++;
            }
            //Assert
            Assert.AreEqual(NbrMax1, 1);

        }
    }

    




}

