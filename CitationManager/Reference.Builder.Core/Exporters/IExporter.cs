using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference.Builder.Core.Exporters
{
    public interface IExporter
    {
        bool Export(ListView itemList);
    }
}
