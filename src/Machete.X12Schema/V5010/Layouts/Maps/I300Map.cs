namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I300Map :
        X12LayoutMap<I300, X12Entity>
    {
        public I300Map()
        {
            Id = "I300";
            Name = "300 Reservation (Booking Request) (Ocean)";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}