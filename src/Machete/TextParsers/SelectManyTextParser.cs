﻿namespace Machete.TextParsers
{
    using System;


    public class SelectManyTextParser<T, TSelect, TResult> :
        ITextParser<TResult>
    {
        readonly ITextParser<T> _parser;
        readonly Func<T, TSelect, TResult> _projector;
        readonly Func<T, ITextParser<TSelect>> _selector;

        public SelectManyTextParser(ITextParser<T> parser, Func<T, ITextParser<TSelect>> selector, Func<T, TSelect, TResult> projector)
        {
            _parser = parser;

            _selector = selector;
            _projector = projector;
        }

        public Result<TextSpan, TResult> Parse(ParseText text, TextSpan span)
        {
            var parsed = _parser.Parse(text, span);
            if (parsed.HasResult)
            {
                T value = parsed.Result;
                var selected = _selector(value).Parse(text, parsed.Next);
                if (selected.HasResult)
                {
                    TResult result = _projector(value, selected.Result);

                    return new Success<TextSpan, TResult>(result, selected.Next);
                }

                return new Unmatched<TextSpan, TResult>(selected.Next);
            }

            return new Unmatched<TextSpan, TResult>(parsed.Next);
        }
    }


    public class SelectManyTextParser<T> :
        ITextParser
    {
        readonly ITextParser<T> _parser;
        readonly Func<T, TextSpan, TextSpan> _projector;
        readonly Func<T, ITextParser> _selector;

        public SelectManyTextParser(ITextParser<T> parser, Func<T, ITextParser> selector, Func<T, TextSpan, TextSpan> projector)
        {
            _parser = parser;

            _selector = selector;
            _projector = projector;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var parsed = _parser.Parse(text, span);
            if (parsed.HasResult)
            {
                T value = parsed.Result;
                var selected = _selector(value).Parse(text, parsed.Next);
                if (selected.HasResult)
                {
                    TextSpan result = _projector(value, selected.Result);

                    return new Success<TextSpan, TextSpan>(result, selected.Next);
                }

                return new Unmatched<TextSpan, TextSpan>(selected.Next);
            }

            return new Unmatched<TextSpan, TextSpan>(parsed.Next);
        }
    }
}