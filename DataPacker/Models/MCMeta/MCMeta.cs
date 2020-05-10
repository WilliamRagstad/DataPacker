using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPacker.Models.MCMeta
{
    class MCMeta
    {
        public datapacker datapacker;
        public pack pack;

        public MCMeta(datapacker datapacker, pack pack)
        {
            this.datapacker = datapacker;
            this.pack = pack;
        }
    }
}
