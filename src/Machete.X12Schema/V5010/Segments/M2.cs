namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface M2 :
        X12Segment
    {
        Value<string> SalesTermsCode { get; }
        
        Value<string> SalesReferenceNumber { get; }
        
        Value<DateTime> SalesReferenceDate { get; }
        
        Value<string> TransportationTermsCode { get; }
        
        Value<string> SalesComment { get; }
        
        Value<DateTime> DeliveryDate { get; }
        
        Value<string> LocationQualifier { get; }
        
        Value<string> LocationIdentifier { get; }
    }
}