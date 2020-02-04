//namespace Machete.Benchmarking
//{
//    using System;
//    using System.Linq;
//    using BenchmarkDotNet.Attributes;
//    using BenchmarkDotNet.Attributes.Columns;
//    using Configuration;
//    using NUnit.Framework;
//    using Testing;
//    using Texts;
//    using X12;
//    using X12Schema.V5010;

//    public abstract class MacheteTestHarness<TSchema> :
//        IMacheteTestHarness<TSchema>
//        where TSchema : Entity
//    {
//        readonly Lazy<ISchema<TSchema>> _schema;
//        readonly Lazy<IEntityParser<TSchema>> _parser;
//        readonly Lazy<IFormatter<TSchema>> _formatter;

//        public MacheteTestHarness()
//        {
//            _schema = new Lazy<ISchema<TSchema>>(CreateSchema);
//            _parser = new Lazy<IEntityParser<TSchema>>(() => CreateParser(Schema));
//            _formatter = new Lazy<IFormatter<TSchema>>(() => CreateFormatter(Schema));
//        }

//        public ISchema<TSchema> Schema => _schema.Value;
//        public IEntityParser<TSchema> Parser => _parser.Value;
//        public IFormatter<TSchema> Formatter => _formatter.Value;

//        protected abstract ISchema<TSchema> CreateSchema();
//        protected abstract IEntityParser<TSchema> CreateParser(ISchema<TSchema> schema);
//        protected abstract IFormatter<TSchema> CreateFormatter(ISchema<TSchema> schema);
//    }

//    class Harness :
//        MacheteTestHarness<TSchema>
//    {
//        protected override ISchema<TSchema> CreateSchema()
//        {
//            return Machete.Schema.Factory.CreateHL7<TSchema>(cfg => cfg.AddFromNamespaceContaining<TVersion>());
//        }

//        protected override IEntityParser<TSchema> CreateParser(ISchema<TSchema> schema)
//        {
//            return Machete.Parser.Factory.CreateHL7(schema);
//        }

//        protected override IFormatter<TSchema> CreateFormatter(ISchema<TSchema> schema)
//        {
//            return Machete.Formatter.Factory.CreateHL7(schema);
//        }
//    }


//    public class X12MacheteTestHarness<TVersion, TSchema> :
//        IMacheteTestHarness<TSchema>
//        where TSchema : X12Entity
//        where TVersion : TSchema
//    {
//        static readonly MacheteTestHarness<TSchema> _harness = new Harness();

//        public ISchema<TSchema> Schema => _harness.Schema;
//        public IEntityParser<TSchema> Parser => _harness.Parser;
//        public IFormatter<TSchema> Formatter => _harness.Formatter;

//        public string CleanupText(string text)
//        {
//            string cleaned = text
//                .Replace("\r\n", "\r")
//                .Replace("\n", "\r")
//                .Replace("\r\r", "\r")
//                .Trim('\r', '\n');

//            string trimmed = string.Join("\r",
//                cleaned.Split('\r').Select(line => line.TrimEnd('|')).ToArray());

//            return trimmed;
//        }



//        public static class EntityParserExtensions
//    {
//        public static ParseResult<TSchema> Parse<TSchema>(this IEntityParser<TSchema> parser, string text)
//            where TSchema : Entity
//        {
//            if (text == null)
//                throw new ArgumentNullException(nameof(text));

//            var stringText = new StringText(text);

//            return parser.Parse(stringText, new TextSpan(0, stringText.Length));
//        }
//    }


//    [Config(typeof(DotNetCoreBenchmarkConfig))]
//    [MinColumn, MaxColumn]
//    public class X12ParserBenchmarks
//    {
//        const string message =
//            @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";


//        public X12ParserBenchmarks()
//        {
//            return Machete.Schema.Factory.CreateX12<X5010>(cfg => cfg.AddFromNamespaceContaining<TVersion>());


//            EntityResult<X12Entity> entityResult = Parser.Parse(message);

//            Assert.That(Schema.TryGetLayout(out ILayoutParserFactory<X12MessageLayout, X12Entity> layout), Is.True);

//            IParser<X12Entity, X12MessageLayout> query = entityResult.CreateQuery(layout);

//            Result<Cursor<X12Entity>, X12MessageLayout> result = entityResult.Query(query);

//            Assert.That(result.HasResult, Is.True);
//            Assert.That(result.Select(x => x.ISA), Is.Not.Null);
//            Assert.That(result.Select(x => x.ISA).HasValue, Is.True);

//            Value<DateTime> isaDate = result.Select(x => x.ISA).Select(x => x.Date);
//            Assert.That(isaDate.HasValue, Is.True);
//            Assert.That(isaDate.Value, Is.EqualTo(new DateTime(2009, 6, 1, 4, 6, 0)));

//            Assert.That(result.Select(x => x.GS).HasValue, Is.True);
//            Assert.That(result.Select(x => x.TransactionSetHeader).HasValue, Is.True);
//        }
//    }
//}