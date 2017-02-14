using System;
using PluginContracts;

namespace ThirdPlugin
{
    public class ThirdPlugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "Third Plugin";
            }
        }

        public void Do()
        {
            System.Windows.MessageBox.Show("Do Something in Third Plugin");
        }
    }
}
