﻿namespace Machete
{
    using Texts;


    /// <summary>
    /// The result from a <see cref="IEntityParser{TSchema}.Parse"/> method
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public interface ParseResult<TSchema> :
        EntityResult<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// The remaining text after parsing
        /// </summary>
        StreamText RemainingText { get; }

        /// <summary>
        /// The span for the remaining text, which wasn't parsed after the result
        /// </summary>
        TextSpan RemainingSpan { get; }
    }
}