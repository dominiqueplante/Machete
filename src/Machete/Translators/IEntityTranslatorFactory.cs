﻿namespace Machete.Translators
{
    public interface IEntityTranslatorFactory<TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
    {
        IEntityTranslator<TInput, TSchema> Create(TranslateFactoryContext<TSchema> context);
    }
}