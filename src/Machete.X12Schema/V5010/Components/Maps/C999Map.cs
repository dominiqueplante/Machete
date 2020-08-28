namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C999Map :
        X12ComponentMap<C999, X12Entity>
    {
        public C999Map()
        {
            Value(x => x.DataElementReferenceNumber1, 0, x => x.MinLength(1).MaxLength(4).IsRequired());
            Value(x => x.DataElementReferenceNumber2, 1, x => x.MinLength(1).MaxLength(4));
        }
    }
}