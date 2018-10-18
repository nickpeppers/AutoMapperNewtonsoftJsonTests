using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AutoMapperNewtonsoftJsonTests
{
    public class PlatformIndependentTests
    {
        readonly Stopwatch _stopwatch = new Stopwatch();
        string _debugTestText;

        public PlatformIndependentTests()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ITestModel, TestModel>().ReverseMap();
            });

            ManualCloneTests();
            AutoMapperTests();
            NewtonsoftJsonTests();

            Console.WriteLine(_debugTestText);
        }

        void ManualCloneTests()
        {
            _stopwatch.Start();
            var testModel = SampleTestData.TestModel.ManualClone();
            _stopwatch.Stop();
            _debugTestText += "TestModel ManualClone: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            var testModels = SampleTestData.TestModels10.ManualClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels10 ManualClone: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            testModels = SampleTestData.TestModels50.ManualClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels50 ManualClone: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            testModels = SampleTestData.TestModels100.ManualClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels100 ManualClone: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            var list = new List<ITestModel>();
            for (int i = 0; i < 1000; i++)
            {
                var model = SampleTestData.TestModel.ManualClone();
                list.Add(testModel);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels1000Sequencial ManualClone: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            list = new List<ITestModel>();
            for (int i = 0; i < 10000; i++)
            {
                var model = SampleTestData.TestModel.ManualClone();
                list.Add(model);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels10000Sequencial ManualClone: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            list = new List<ITestModel>();
            for (int i = 0; i < 100000; i++)
            {
                var model = SampleTestData.TestModel.ManualClone();
                list.Add(model);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels100000Sequencial ManualClone: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _debugTestText += "\n=============================";
        }

        void AutoMapperTests()
        {
            _stopwatch.Start();
            var testModel = SampleTestData.TestModel.AutoMapperClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModel AutoMapperCloner: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            var testModels = SampleTestData.TestModels10.AutoMapperClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels10 AutoMapperCloner: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            testModels = SampleTestData.TestModels50.AutoMapperClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels50 AutoMapperCloner: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            testModels = SampleTestData.TestModels100.AutoMapperClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels100 AutoMapperCloner: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            var list = new List<ITestModel>();
            for (int i = 0; i < 1000; i++)
            {
                var model = SampleTestData.TestModel.AutoMapperClone();
                list.Add(testModel);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels1000Sequencial AutoMapperCloner: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            list = new List<ITestModel>();
            for (int i = 0; i < 10000; i++)
            {
                var model = SampleTestData.TestModel.AutoMapperClone();
                list.Add(model);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels10000Sequencial AutoMapperCloner: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            list = new List<ITestModel>();
            for (int i = 0; i < 100000; i++)
            {
                var model = SampleTestData.TestModel.AutoMapperClone();
                list.Add(model);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels100000Sequencial AutoMapperCloner: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _debugTestText += "\n=============================";
        }

        void NewtonsoftJsonTests()
        {
            _stopwatch.Start();
            var testModel = SampleTestData.TestModel.JsonClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModel NewtonsoftJson: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            var testModels = SampleTestData.TestModels10.JsonClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels10 NewtonsoftJson: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            testModels = SampleTestData.TestModels50.JsonClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels50 NewtonsoftJson: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            testModels = SampleTestData.TestModels100.JsonClone();
            _stopwatch.Stop();
            _debugTestText += "\nTestModels100 NewtonsoftJson: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            var list = new List<ITestModel>();
            for (int i = 0; i < 1000; i++)
            {
                var model = SampleTestData.TestModel.JsonClone();
                list.Add(testModel);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels1000Sequencial NewtonsoftJson: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            list = new List<ITestModel>();
            for (int i = 0; i < 10000; i++)
            {
                var model = SampleTestData.TestModel.JsonClone();
                list.Add(model);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels10000Sequencial NewtonsoftJson: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _stopwatch.Start();
            list = new List<ITestModel>();
            for (int i = 0; i < 100000; i++)
            {
                var model = SampleTestData.TestModel.JsonClone();
                list.Add(model);
            }
            _stopwatch.Stop();
            _debugTestText += "\nTestModels100000Sequencial NewtonsoftJson: " + _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();

            _debugTestText += "\n=============================";
        }
    }
}