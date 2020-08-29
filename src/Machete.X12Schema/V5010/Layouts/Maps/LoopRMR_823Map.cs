namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopRMR_823Map :
        X12LayoutMap<LoopRMR_823, X12Entity>
    {
        public LoopRMR_823Map()
        {
            Id = "Loop_RMR_823";
            Name = "Loop RMR";
            
            Segment(x => x.RemittanceAdviceAccountsReceivableOpenItemReference, 0);
            Segment(x => x.PartyIdentification, 1);
            Segment(x => x.Currency, 2);
            Segment(x => x.ReferenceInformation, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Layout(x => x.LoopIT1, 5);
        }
    }
}