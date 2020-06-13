using System.Collections.Generic;
using System.Xml.Serialization;

namespace Farallon
{
    [XmlRoot(ElementName = "trades")]
    public class Trades
    {
        [XmlElement(ElementName = "trade")]
        public List<Trade> Trade { get; set; }
    }
}
