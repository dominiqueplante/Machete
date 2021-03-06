// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BAR_P06_PATIENT (GroupMap) - 
    /// </summary>
    public class BAR_P06_PATIENTMap :
        HL7V26LayoutMap<BAR_P06_PATIENT>
    {
        public BAR_P06_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PV1, 1);
        }
    }
}