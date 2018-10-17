using NUnit.Framework;
using System.Collections.Generic;

namespace AutoMapperNewtonsoftJsonTests
{
    [TestFixture]
    public class NewtonsoftCloneTests
    {
        [Test]
        public void TestClone()
        {
            var testModel = SampleTestData.TestModel.JsonClone();
            Assert.NotNull(testModel);
        }

        [Test]
        public void TestCloneList10()
        {
            var testModel = SampleTestData.TestModels10.JsonClone();
            Assert.NotNull(testModel);
        }

        [Test]
        public void TestCloneList50()
        {
            var testModel = SampleTestData.TestModels50.JsonClone();
            Assert.NotNull(testModel);
        }

        [Test]
        public void TestCloneList100()
        {
            var testModel = SampleTestData.TestModels100.JsonClone();
            Assert.NotNull(testModel);
        }

        [Test]
        public void TestClone1000Sequentially()
        {
            var list = new List<ITestModel>();
            for (int i = 0; i < 1000; i++)
            {
                var testModel = SampleTestData.TestModel.JsonClone();
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
                var testModel = SampleTestData.TestModel.JsonClone();
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
                var testModel = SampleTestData.TestModel.JsonClone();
                list.Add(testModel);
            }
            Assert.NotNull(list);
            Assert.AreEqual(100000, list.Count);
        }
    }
}