﻿namespace Machete.TranslateConfiguration
{
    using Translators.PropertyTranslaters;


    /// <summary>
    /// Translate a property on an entity, used by entity translators
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public interface IPropertyTranslateBuilder<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        /// <summary>
        /// Returns true if there are no definitions for the property
        /// </summary>
        bool IsDefined { get; }

        void Add(IPropertyTranslator<TResult, TInput, TSchema> translator);

        /// <summary>
        /// Clear all translators from the property
        /// </summary>
        void Clear();

        /// <summary>
        /// Build the property translator
        /// </summary>
        /// <returns></returns>
        IPropertyTranslator<TResult, TInput, TSchema> Build();
    }
}