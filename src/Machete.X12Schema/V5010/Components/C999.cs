namespace Machete.X12Schema.V5010
{
    using X12;


    public interface C999 :
        X12Component
    {
        Value<int> DataElementReferenceNumber1 { get; }
        
        Value<int> DataElementReferenceNumber2 { get; }
    }
}