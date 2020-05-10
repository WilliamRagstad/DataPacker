using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPacker.Models.MCMeta
{
    class datapacker
    {
        public string title;
        public string author;
        public string version;

        public datapacker(string title, string author, string version)
        {
            this.title = title;
            this.author = author;
            this.version = version;
        }
    }
}
