namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C0037Map :
        X12ComponentMap<C0037, X12Entity>
    {
        public C0037Map()
        {
            Value(x => x.TaxInformationIdentificationNumber, 0, x=> x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.ApplicationErrorConditionCode, 1, x=> x.MinLength(1).MaxLength(3));
        }
    }
}