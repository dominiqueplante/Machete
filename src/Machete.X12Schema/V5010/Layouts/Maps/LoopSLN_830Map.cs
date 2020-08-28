namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSLN_830Map :
        X12LayoutMap<LoopSLN_830, X12Entity>
    {
        public LoopSLN_830Map()
        {
            Id = "Loop_SLN_830";
            Name = "Loop SLN";
            
            Segment(x => x.SublineItemDetail, 0);
            Segment(x => x.ProductOrItemDescription, 1);
            Segment(x => x.IndividualOrOrganizationalName, 2);
        }
    }
}