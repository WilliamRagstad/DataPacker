using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPacker
{
    public interface IViewControl
    {
        void View_OnLoad();
        void View_OnUnLoad();
    }
}
