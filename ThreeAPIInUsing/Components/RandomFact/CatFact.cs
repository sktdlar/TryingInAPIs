using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ThreeAPIInUsing.Components.RandomFact
{
    [XmlRoot("CatFact")]
    public class CatFact
    {
        [XmlAttribute("fact")]
        public string fact { get; set; }
        [XmlAttribute("length")]
        public int lenght { get; set; }
        public CatFact()
        {
            
        }
    }
}
