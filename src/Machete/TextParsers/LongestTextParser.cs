﻿namespace Machete.TextParsers
{
    public class LongestTextParser :
        ITextParser
    {
        readonly ITextParser _parser;
        readonly ITextParser[] _parsers;

        public LongestTextParser(ITextParser parser, ITextParser[] parsers)
        {
            _parser = parser;
            _parsers = parsers;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var input = _parser.Parse(text, span);
            Result<TextSpan, TextSpan> result = new Unmatched<TextSpan, TextSpan>(input.Next);

            if (input.HasResult)
            {
                var inputSpan = input.Result;

                int longest = inputSpan.Start;
                for (int index = 0; index < _parsers.Length; index++)
                {
                    var parsed = _parsers[index].Parse(text, inputSpan);
                    if (parsed.HasResult && parsed.Next.Start > longest)
                        result = parsed;
                }
            }
            
            return result;
        }
    }
}