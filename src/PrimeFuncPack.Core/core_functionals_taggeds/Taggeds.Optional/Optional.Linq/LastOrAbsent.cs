﻿#nullable enable

using System.Collections.Generic;

namespace System.Linq
{
    partial class CollectionsExtensions
    {
        public static Optional<TSource> LastOrAbsent<TSource>(
            this IEnumerable<TSource> source)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));

            return source switch
            {
                IReadOnlyList<TSource> list
                =>
                list.InternalLastOrAbsent(),

                IList<TSource> list
                =>
                list.InternalLastOrAbsent(),

                var enumerable
                =>
                enumerable.InternalLastOrAbsent()
            };
        }

        public static Optional<TSource> LastOrAbsent<TSource>(
            this IEnumerable<TSource> source,
            in Func<TSource, bool> predicate)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));
            _ = predicate ?? throw new ArgumentNullException(nameof(predicate));

            return source switch
            {
                IReadOnlyList<TSource> list
                =>
                list.InternalLastOrAbsent(predicate),

                IList<TSource> list
                =>
                list.InternalLastOrAbsent(predicate),

                var enumerable
                =>
                enumerable.InternalLastOrAbsent(predicate)
            };
        }
    }
}