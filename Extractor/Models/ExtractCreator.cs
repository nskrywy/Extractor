using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extractor.Models
{
    public class ExtractCreator
    {
        public string Name { get; set; }
        public string[] StoredProcedures { get; set; }
        public string Folder { get; set; }
        public int[] BusinessUnits { get; set; }
        public string TargetEnvironment { get; set; }
        public bool Enabled { get; set; }
    }
}
