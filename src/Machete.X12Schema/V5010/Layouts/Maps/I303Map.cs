namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I303Map :
        X12LayoutMap<I303, X12Entity>
    {
        public I303Map()
        {
            Id = "I303";
            Name = "303 Booking Cancellation (Ocean)";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}