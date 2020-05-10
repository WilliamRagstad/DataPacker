using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPacker.Models.MCMeta
{
    class pack
    {
        public int pack_format;
        public string description;

        public pack(int pack_format, string description)
        {
            this.pack_format = pack_format;
            this.description = description;
        }
    }
}
