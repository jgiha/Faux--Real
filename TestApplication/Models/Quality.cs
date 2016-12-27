using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Quality
    {
        public int QualityID { get; set; }
        public string Quality1 { get; set; }

        public Quality()
        { }
        public Quality(int qualityID, string quality)
        {
            QualityID = qualityID;
            Quality1 = quality;
        }
    }
}
