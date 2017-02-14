using PluginContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthPlugin
{
    public class FourthPlugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "Fourth Plugin";
            }
        }

        public void Do()
        {
            System.Windows.MessageBox.Show("The Fourth Plugin");
        }
    }
}
