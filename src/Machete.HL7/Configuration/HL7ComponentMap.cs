﻿namespace Machete.HL7
{
    using Formatters;
    using Machete.SchemaConfiguration;


    public class HL7ComponentMap<TComponent, TSchema> :
        HL7EntityMap<TComponent, TSchema>
        where TComponent : TSchema, HL7Component
        where TSchema : HL7Entity
    {
        protected HL7ComponentMap()
        {
            Set(x => x.IsEmpty, IsComponentEmpty, x => x.NoFormat());

            Value(x => x.Fields, 0, x =>
            {
                x.SetRange();
                x.NoFormat();
            });

            IEntityConfigurator<TComponent, TSchema> entityConfigurator = this;

            entityConfigurator.FormatterFactory = formatters => new HL7ComponentFormatter<TComponent, TSchema>(formatters);
        }

        static bool IsComponentEmpty(TextSlice slice)
        {
            for (int i = 0;; i++)
            {
                TextSlice nextSlice;
                if (!slice.TryGetSlice(i, out nextSlice))
                    return true;

                TextSlice nextNextSlice;
                if (nextSlice.TryGetSlice(0, out nextNextSlice))
                    return false;
            }
        }
    }
}