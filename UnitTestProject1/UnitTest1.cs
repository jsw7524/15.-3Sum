using System;
using System.Collections.Generic;
using System.Linq;
using _15._3Sum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();
            var result = sln.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
            var answer = new List<List<int>>() { new List<int> { -1, 0, 1 }, new List<int> { -1, -1, 2 } };
            Assert.AreEqual(JsonConvert.SerializeObject(answer.Select(a => a.OrderBy(b => b))), JsonConvert.SerializeObject(result.Select(a => a.OrderBy(b => b))));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution sln = new Solution();
            var result = sln.ThreeSum(new[] { 0, 0 });
            var answer = new List<List<int>>() { };
            Assert.AreEqual(JsonConvert.SerializeObject(answer.Select(a => a.OrderBy(b => b))), JsonConvert.SerializeObject(result.Select(a => a.OrderBy(b => b))));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Solution sln = new Solution();
            var result = sln.ThreeSum(new[] { 0, 0, 0 });
            var answer = new List<List<int>>() { new List<int> { 0, 0, 0 } };
            Assert.AreEqual(JsonConvert.SerializeObject(answer.Select(a => a.OrderBy(b => b))), JsonConvert.SerializeObject(result.Select(a => a.OrderBy(b => b))));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Solution sln = new Solution();
            var result = sln.ThreeSum(new[] { -1, 0, 1, 0 });
            var answer = new List<List<int>>() { new List<int> { -1, 0, 1 } };
            Assert.AreEqual(JsonConvert.SerializeObject(answer.Select(a => a.OrderBy(b => b))), JsonConvert.SerializeObject(result.Select(a => a.OrderBy(b => b))));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Solution sln = new Solution();
            var result = sln.ThreeSum(new[] { 0, 0, 0, 0 });
            var answer = new List<List<int>>() { new List<int> { 0, 0, 0 } };
            Assert.AreEqual(JsonConvert.SerializeObject(answer.Select(a => a.OrderBy(b => b))), JsonConvert.SerializeObject(result.Select(a => a.OrderBy(b => b))));
        }

    }
}
