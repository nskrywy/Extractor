using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extractor.Models
{
    public class ExtractConsumer
    {
        public string Name { get; set; }
        public string SourceFolder { get; set; }
        public string[] FileTypes { get; set; }
        public string TargetServer { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string TargetFolder { get; set; }
        public Encryptor ConsumerEncryptor { get; set; }
        public bool Enabled { get; set; }

    }
}
