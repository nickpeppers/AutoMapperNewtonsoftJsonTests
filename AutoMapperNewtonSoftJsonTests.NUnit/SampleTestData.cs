﻿using System.Collections.Generic;

namespace AutoMapperNewtonsoftJsonTests
{
    public static class SampleTestData
    {
        static readonly Dictionary<int, string> _dictionary = new Dictionary<int, string>
        {
            { 0, "test" },
            { 1, "test" },
            { 2, "test" },
            { 3, "test" },
            { 4, "test" },
            { 5, "test" },
            { 6, "test" },
            { 7, "test" },
            { 8, "test" },
            { 9, "test" },
        };

        public static readonly TestModel TestModel = new TestModel
        {
            Id = 0,
            Description = "Description",
            DoubleValue = 100,
            FloatValue = 100f,
            StringList = new List<string> { "string1", "string2", "string3", "string4", "string5" },
            Dictionary = _dictionary,
            ListOfDictionaries = new List<Dictionary<int, string>>
            {
                _dictionary,
                _dictionary,
                _dictionary,
                _dictionary,
                _dictionary,
                _dictionary,
                _dictionary,
                _dictionary,
                _dictionary,
                _dictionary,
            }
        };

        public static List<TestModel> TestModels10 = new List<TestModel>
        {
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel
        };

        public static List<TestModel> TestModels50 = new List<TestModel>
        {
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel
        };

        public static List<TestModel> TestModels100 = new List<TestModel>
        {
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel,
            TestModel
        };
    }
}