﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Git.Test
{
    /// <summary>
    ///  This is a test class, it will contain tests for one business area.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This is a test method, it will test one unit of work exclusively.
        /// </summary>
        [TestMethod]
        public void CompareTwoValues()
        {
            var val1 = "Hello";
            var val2 = "Hello";

            Assert.AreEqual(val1, val2);
        }
    }
}
