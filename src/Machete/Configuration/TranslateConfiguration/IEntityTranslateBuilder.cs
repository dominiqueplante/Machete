﻿namespace Machete.TranslateConfiguration
{
    using System;
    using Translators.PropertyTranslaters;


    public interface IEntityTranslateBuilder<out TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        /// <summary>
        /// The implementation type for this result
        /// </summary>
        Type ImplementationType { get; }

        /// <summary>
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <param name="translateSpecificationType"></param>
        /// <param name="translateFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TIn"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TIn, TSchema> GetEntityTranslator<T, TIn>(Type translateSpecificationType, Func<IEntityTranslateSpecification<T, TIn, TSchema>> translateFactory)
            where T : TSchema
            where TIn : TSchema;

        /// <summary>
        /// Adds a translater for a property by name
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="translator"></param>
        void Add(string propertyName, IPropertyTranslator<TResult, TInput, TSchema> translator);

        /// <summary>
        /// Copy all values from the input to the result, assigning unmatched properties to Missing
        /// </summary>
        void CopyAll();

        /// <summary>
        /// Exclude all properties from the input, assiging all unassigned properties to Missing
        /// </summary>
        void ExcludeAll();

        /// <summary>
        /// Remove all translators from all properties
        /// </summary>
        void Clear();

        /// <summary>
        /// Remove all translators from the specified property
        /// </summary>
        /// <param name="propertyName"></param>
        void Clear(string propertyName);
    }
}