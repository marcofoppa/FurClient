using System.Collections.Generic;

namespace FurClient.BusinessClass
{
    public class Installazione  
    {
        public string Url { get; set; }
        public string Nome { get; set; }
        public IList<string> AslPresenti { get; set; }
    }
}