﻿namespace Machete
{
    using Texts;


    public static class TextParserExtensions
    {
        /// <summary>
        /// Parses the entire input string using the supplied parser.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="text">The text to parse</param>
        /// <returns></returns>
        public static Result<TextSpan, TextSpan> Parse(this ITextParser parser, ParseText text)
        {
            return parser.Parse(text, new TextSpan(0, text.Length));
        }

        /// <summary>
        /// Creates a temporary <see cref="ParseText"/> for the input string and parses it using the
        /// supplied parser.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="text">The string to parse</param>
        /// <returns></returns>
        public static Result<TextSpan, TextSpan> Parse(this ITextParser parser, string text)
        {
            return parser.Parse(new StringText(text), new TextSpan(0, text.Length));
        }

        /// <summary>
        /// Creates a temporary <see cref="ParseText"/> for the input string and parses it using the
        /// supplied parser.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="text">The string to parse</param>
        /// <param name="span">The text span to parse</param>
        /// <returns></returns>
        public static Result<TextSpan, TextSpan> Parse(this ITextParser parser, string text, TextSpan span)
        {
            return parser.Parse(new StringText(text), span);
        }

        /// <summary>
        /// Creates a temporary <see cref="ParseText"/> for the input string and parses it using the
        /// supplied parser.
        /// </summary>
        /// <typeparam name="T">The TextParser result type</typeparam>
        /// <param name="parser"></param>
        /// <param name="text">The string to parse</param>
        /// <returns></returns>
        public static Result<TextSpan, T> Parse<T>(this ITextParser<T> parser, string text)
        {
            return parser.Parse(new StringText(text), new TextSpan(0, text.Length));
        }
    }
}