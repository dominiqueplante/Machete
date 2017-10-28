﻿namespace Machete
{
    using System;
    using System.Diagnostics;


    public static class EntityExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Select<TEntity, T>(this Entity<TEntity> source, Func<TEntity, Value<T>> getter)
            where TEntity : Entity
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return Value.Missing<T>();

            return getter(source.Value) ?? Value.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ValueList<T> Select<TEntity, T>(this Entity<TEntity> source, Func<TEntity, ValueList<T>> getter)
            where TEntity : Entity
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return ValueList.Missing<T>();

            return getter(source.Value) ?? ValueList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Entity<T> Select<TEntity, T>(this Entity<TEntity> source, Func<TEntity, Entity<T>> getter)
            where TEntity : Entity
            where T : Entity
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return Schema.Entity.Missing<T>();

            return getter(source.Value) ?? Schema.Entity.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static EntityList<T> Select<TEntity, T>(this Entity<TEntity> source, Func<TEntity, EntityList<T>> getter)
            where TEntity : Entity
            where T : Entity
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return EntityList.Missing<T>();

            return getter(source.Value) ?? EntityList.Missing<T>();
        }

        /// <summary>
        /// Returns a count of entities in <see cref="EntityList{TSegment}"/>
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int Count<T>(this EntityList<T> source)
            where T : Entity
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return 0;

            int i = 0;
            for (;; i++)
                if (!source.TryGetValue(i, out _))
                    break;

            return i;
        }
    }
}