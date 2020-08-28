namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSHP_830Map :
        X12LayoutMap<LoopSHP_830, X12Entity>
    {
        public LoopSHP_830Map()
        {
            Id = "Loop_SHP_830";
            Name = "Loop SHP";
            
            Segment(x => x.ShippedOrReceivedInformation, 0);
            Segment(x => x.ReferenceInformation, 1);
        }
    }
}