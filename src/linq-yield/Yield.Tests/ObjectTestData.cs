﻿#nullable enable

using System.Collections.Generic;
using System.Linq;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Linq.Yield.Tests
{
    internal static class ObjectTestData
    {
        public static IEnumerable<object?[]> NullableObjectTestSource
            =>
            new object?[]
            {
                null,
                PlusFifteenIdRefType,
                SomeTextStructType
            }
            .Select(v => new object?[] { v });
    }
}
