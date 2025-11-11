using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    public record ProductRecord
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<string> Comments { get; set; } = new();


    }
}
