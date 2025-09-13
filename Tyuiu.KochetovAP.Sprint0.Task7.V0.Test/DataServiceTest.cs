﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.KochetovAP.Sprint0.Task7.V0.Lib;

namespace Tyuiu.KochetovAP.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] nums1 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums2 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums3 = new int[] { 2, 2, 2, 2, 2, };

            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);

        }
    }

}
