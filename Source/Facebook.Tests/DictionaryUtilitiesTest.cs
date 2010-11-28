﻿using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Facebook
{
    [TestClass]
    public class DictionaryExtensionsTest
    {
        [Fact(DisplayName = "Merge: When first input contains values and second is null The the result should not be null")]
        public void Merge_WhenFirstInputContainsValuesAndSecondIsNull_TheTheResultShouldNotBeNull()
        {
            IDictionary<string, object> first = new Dictionary<string, object>
                                                    {
                                                        {"prop1", "value1"},
                                                        {"prop2", "value2"}
                                                    };
            IDictionary<string, object> second = null;

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.NotNull(result);
        }

        [Fact(DisplayName = "Merge: When first input contains values and second is null The the count of result should be equal to the count of first input")]
        public void Merge_WhenFirstInputContainsValuesAndSecondIsNull_TheTheCountOfResultShouldBeEqualToTheCountOfFirstInput()
        {
            IDictionary<string, object> first = new Dictionary<string, object>
                                                    {
                                                        {"prop1", "value1"},
                                                        {"prop2", "value2"}
                                                    };
            IDictionary<string, object> second = null;

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(first.Count, result.Count);
        }

        [Fact(DisplayName = "Merge: When first input contains values and second is null The values of result should be same as values of first input")]
        public void Merge_WhenFirstInputContainsValuesAndSecondIsNull_TheValuesOfResultShouldBeSameAsValuesOfFirstInput()
        {
            IDictionary<string, object> first = new Dictionary<string, object>
                                                    {
                                                        {"prop1", "value1"},
                                                        {"prop2", "value2"}
                                                    };
            IDictionary<string, object> second = null;

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(first["prop1"], result["prop1"]);
            Xunit.Assert.Equal(first["prop2"], result["prop2"]);
        }

        [Fact(DisplayName = "Merge: When first input is null and second contains values Then the result should not be null")]
        public void Merge_WhenFirstInputIsNullAndSecondContainsValues_ThenTheResultShouldNotBeNull()
        {
            IDictionary<string, object> first = null;
            IDictionary<string, object> second = new Dictionary<string, object>
                                                     {
                                                        {"prop1", "value1"},
                                                        {"prop2", "value2"}
                                                    };


            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.NotNull(result);
        }

        [Fact(DisplayName = "Merge: When first input is null and second contains values Then the count of the result should be equal to count of second input")]
        public void Merge_WhenFirstInputIsNullAndSecondContainsValues_ThenTheCountOfTheResultShouldBeEqualToCountOfSecondInput()
        {
            IDictionary<string, object> first = null;
            IDictionary<string, object> second = new Dictionary<string, object>
                                                     {
                                                        {"prop1", "value1"},
                                                        {"prop2", "value2"}
                                                    };


            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(second.Count, result.Count);
        }

        [Fact(DisplayName = "Merge: When first input is null and second contains values Then the values of result should be same as values of second input")]
        public void Merge_WhenFirstInputIsNullAndSecondContainsValues_ThenTheValuesOfResultShouldBeSameAsValuesOfSecondInput()
        {
            IDictionary<string, object> first = null;
            IDictionary<string, object> second = new Dictionary<string, object>
                                                    {
                                                        {"prop1", "value1"},
                                                        {"prop2", "value2"}
                                                    };

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(second["prop1"], result["prop1"]);
            Xunit.Assert.Equal(second["prop2"], result["prop2"]);
        }

        [TestMethod]
        public void Merge_Both_Provided()
        {
            var first = new Dictionary<string, object>();
            first["prop1"] = "value1-first";
            first["prop2"] = "value2";
            var second = new Dictionary<string, object>();
            second["prop1"] = "value1-second";
            second["prop3"] = "value3";
            var result = DictionaryUtilities.Merge(first, second);
            Assert.AreEqual(second["prop1"], result["prop1"]);
            Assert.AreEqual(first["prop2"], result["prop2"]);
            Assert.AreEqual(second["prop3"], result["prop3"]);
        }

        [Fact(DisplayName = "Merge: When both inputs are null, the result should not be null")]
        public void Merge_WhenBothInputsAreNull_TheResultShouldNotBeNull()
        {
            IDictionary<string, object> first = null;
            IDictionary<string, object> second = null;

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.NotNull(result);
        }

        [Fact(DisplayName = "Merge: When both inputs are null, the count of result should be 0")]
        public void Merge_WhenBothInputsAreNull_TheCountOfResultShouldBe0()
        {
            IDictionary<string, object> first = null;
            IDictionary<string, object> second = null;

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(0, result.Count);
        }

        [Fact(DisplayName = "Merge: when both inputs are empty and not null, the result should not be null")]
        public void Merge_WhenBothInputsAreEmptyAndNotNull_TheResultShouldNotBeNull()
        {
            var first = new Dictionary<string, object>();
            var second = new Dictionary<string, object>();

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.NotNull(result);
        }

        [Fact(DisplayName = "Merge: when both inputs are empty and not null, the count of result should be 0")]
        public void Merge_WhenBothInputsAreEmptyAndNotNull_TheCountOfResultShouldBe0()
        {
            var first = new Dictionary<string, object>();
            var second = new Dictionary<string, object>();

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(0, result.Count);
        }

        [Fact(DisplayName = "Merge: When first input is null and second is empty and not null, the result should not be null")]
        public void Merge_WhenFirstInputIsNullAndSecondIsEmptyAndNotNull_TheResultShouldNotBeNull()
        {
            IDictionary<string, object> first = null;
            IDictionary<string, object> second = new Dictionary<string, object>();

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.NotNull(result);
        }

        [Fact(DisplayName = "Merge: When first input is null and second is empty and not null, the count of result should be 0")]
        public void Merge_WhenFirstInputIsNullAndSecondIsEmptyAndNotNull_TheCountOfResultShouldBe0()
        {
            IDictionary<string, object> first = null;
            IDictionary<string, object> second = new Dictionary<string, object>();

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(0, result.Count);
        }

        [Fact(DisplayName = "Merge: When first input is empty and not null and second input is null Then the result should not be null")]
        public void Merge_WhenFirstInputIsEmptyAndNotNullAndSecondInputIsNull_ThenTheResultShouldNotBeNull()
        {
            IDictionary<string, object> first = new Dictionary<string, object>();
            IDictionary<string, object> second = null;

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.NotNull(result);
        }

        [Fact(DisplayName = "Merge: When first input is empty and not null and second input is null Then the count of the result should be 0")]
        public void Merge_WhenFirstInputIsEmptyAndNotNullAndSecondInputIsNull_ThenTheCountOfTheResultShouldBe0()
        {
            IDictionary<string, object> first = new Dictionary<string, object>();
            IDictionary<string, object> second = null;

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(0, result.Count);
        }

        [Fact(DisplayName = "Merge: When both the combination of first input and second input contains unique keys Then the result should not be null")]
        public void Merge_WhenBothTheCombinationOfFirstInputAndSecondInputContainsUniqueKeys_ThenTheResultShouldNotBeNull()
        {
            var first = new Dictionary<string, object> { { "prop1", "value1" } };
            var second = new Dictionary<string, object> { { "prop2", "value2" } };

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.NotNull(result);
        }

        [Fact(DisplayName = "Merge: When both the combination of first input and second input contains unique keys Then the count of result should be equal to count of first and second inputs")]
        public void Merge_WhenBothTheCombinationOfFirstInputAndSecondInputContainsUniqueKeys_ThenTheCountOfResultShouldBeEqualToCountOfFirstAndSecondInputs()
        {
            var first = new Dictionary<string, object> { { "prop1", "value1" } };
            var second = new Dictionary<string, object> { { "prop2", "value2" } };

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(2, result.Count);
        }

        [Fact(DisplayName = "Merge: When both the combination of first input and second input contains unique keys Then the values should be equal to the one inserted from first or second")]
        public void Merge_WhenBothTheCombinationOfFirstInputAndSecondInputContainsUniqueKeys_ThenTheValuesShouldBeEqualToTheOneInsertedFromFirstOrSecond()
        {
            var first = new Dictionary<string, object> { { "prop1", "value1" } };
            var second = new Dictionary<string, object> { { "prop2", "value2" } };

            var result = DictionaryUtilities.Merge(first, second);

            Xunit.Assert.Equal(first["prop1"], result["prop1"]);
            Xunit.Assert.Equal(second["prop2"], result["prop2"]);
        }

        [TestMethod]
        public void Dictionary_To_Querystring()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("key1", "value1");
            dict.Add("key2", "value2");
            string actual = DictionaryUtilities.ToJsonQueryString(dict);
            string expected = "key1=value1&key2=value2";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dictionary2_To_Querystring()
        {
            var dict = new Dictionary<string, object>();
            dict.Add("key1", "value1");
            dict.Add("key2", "value2");
            string actual = DictionaryUtilities.ToJsonQueryString(dict);
            string expected = "key1=value1&key2=value2";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NameValueCollection_To_Querystring()
        {
            var nvc = new NameValueCollection();
            nvc.Add("key1", "value1");
            nvc.Add("key2", "value2");
            string actual = DictionaryUtilities.ToJsonQueryString(nvc);
            string expected = "key1=value1&key2=value2";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dictionary_With_Object_To_Querystring()
        {
            var dict = new Dictionary<string, object>();
            dict.Add("key1", "value1");
            dict.Add("key2", "value2");
            var list = new List<string>();
            list.Add("list1");
            list.Add("list2");
            dict.Add("key3", list);
            string actual = DictionaryUtilities.ToJsonQueryString(dict);
            string expected = "key1=value1&key2=value2&key3=%5B%22list1%22%2C%22list2%22%5D";
            Assert.AreEqual(expected, actual);
        }
    }
}