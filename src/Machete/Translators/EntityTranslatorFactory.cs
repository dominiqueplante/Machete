﻿namespace Machete.Translators
{
    using TranslateConfiguration;
    using TranslateConfiguration.Builders;


    public class EntityTranslatorFactory<TResult, TInput, TSchema> :
        IEntityTranslatorFactory<TInput, TSchema>
        where TInput : TSchema
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly IEntityTranslateSpecification<TResult, TInput, TSchema> _specification;

        public EntityTranslatorFactory(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
        {
            _specification = specification;
        }

        public IEntityTranslator<TInput, TSchema> Create(TranslateFactoryContext<TSchema> context)
        {
            var builder = new EntityTranslateBuilder<TResult, TInput, TSchema>(context, _specification.Name);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
}