﻿namespace Machete
{
    using System.Threading.Tasks;


    public static class ParsedResultExtensions
    {
        /// <summary>
        /// Parse the next result, using the supplied parser, asynchronously.
        /// </summary>
        /// <param name="result">The current result</param>
        /// <param name="parser">The parser</param>
        /// <typeparam name="TSchema">The parser schema type</typeparam>
        /// <returns>A Task for the next result</returns>
        public static Task<ParseResult<TSchema>> NextAsync<TSchema>(this ParseResult<TSchema> result, IEntityParser<TSchema> parser)
            where TSchema : Entity
        {
            return parser.ParseAsync(result.RemainingText, result.RemainingSpan);
        }

        /// <summary>
        /// Parse the next result, using the supplied parser.
        /// </summary>
        /// <param name="result">The current result</param>
        /// <param name="parser">The parser</param>
        /// <typeparam name="TSchema">The parser schema type</typeparam>
        /// <returns>The next result</returns>
        public static ParseResult<TSchema> Next<TSchema>(this ParseResult<TSchema> result, IEntityParser<TSchema> parser)
            where TSchema : Entity
        {
            return parser.Parse(result.RemainingText, result.RemainingSpan);
        }
    }
}