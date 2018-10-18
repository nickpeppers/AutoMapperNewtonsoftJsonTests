using NUnit.Framework;
using System.Collections.Generic;

namespace AutoMapperNewtonsoftJsonTests
{
    [TestFixture]
    public class ManualCloneTests
    {
        [Test]
        public void TestClone()
        {
            var testModel = SampleTestData.TestModel.ManualClone();
            Assert.NotNull(testModel);
        }

        [Test]
        public void TestCloneList10()
        {
            var testModel = SampleTestData.TestModels10.ManualClone();
            Assert.NotNull(testModel);
            Assert.AreEqual(10, testModel.Count);
        }

        [Test]
        public void TestCloneList50()
        {
            var testModel = SampleTestData.TestModels50.ManualClone();
            Assert.NotNull(testModel);
            Assert.AreEqual(50, testModel.Count);
        }

        [Test]
        public void TestCloneList100()
        {
            var testModel = SampleTestData.TestModels100.ManualClone();
            Assert.NotNull(testModel);
            Assert.AreEqual(100, testModel.Count);
        }

        [Test]
        public void TestClone1000Sequentially()
        {
            var list = new List<ITestModel>();
            for (int i = 0; i < 1000; i++)
            {
                var testModel = SampleTestData.TestModel.ManualClone();
                list.Add(testModel);
            }
            Assert.NotNull(list);
            Assert.AreEqual(1000, list.Count);
        }

        [Test]
        public void TestClone10000Sequentially()
        {
            var list = new List<ITestModel>();
            for (int i = 0; i < 10000; i++)
            {
                var testModel = SampleTestData.TestModel.ManualClone();
                list.Add(testModel);
            }
            Assert.NotNull(list);
            Assert.AreEqual(10000, list.Count);
        }

        [Test]
        public void TestClone100000Sequentially()
        {
            var list = new List<ITestModel>();
            for (int i = 0; i < 100000; i++)
            {
                var testModel = SampleTestData.TestModel.ManualClone();
                list.Add(testModel);
            }
            Assert.NotNull(list);
            Assert.AreEqual(100000, list.Count);
        }
    }
}