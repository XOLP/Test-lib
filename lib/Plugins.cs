using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ds.test.impl
{
   
    public class Plugins : PluginFactory
    {
        private static int PlugsCount = 1;
        private static string vers = "1.0";
        private static string name = "Calculator";
        public string PluginName
        {
            
            get => name;
        }
        public string Version
        {
            get => vers;
        }
        


        public int PluginsCount
        {
            get { return PlugsCount; }
        }
        public string[] GetPluginNames { get; } = new string[] { };
        
        public IPlugin GetPlugin(string pluginName)
        {
            throw new NotImplementedException();
        }

        
        public void Info()
        {
            Console.WriteLine($"Name: {name}; Version: {vers}; PluginsCount: {PluginsCount}");
        }

        public int Run(int x , int y)
        {
            double result;
            result = x * y;
            Console.WriteLine(x + "*" + y + " = " + result);
            result = x + y;
            Console.WriteLine(x + "+" + y + " = " + result);
            result = x - y;
            Console.WriteLine(x + "-" + y + " = " + result);
            result =  Math.Pow(x,y);
            Console.WriteLine(x + "^" + y + " = " + result);
            result = Math.Sqrt(x);
            Console.WriteLine("sqrt(x) = " + result );
            result = Math.Sqrt(y);
            Console.WriteLine("sqrt(y) = " + result);
            result = x + y;
            return 1; 
        }
  
    }
    public interface IPlugin
    {
        string PluginName { get; set; }
        string Version { get; set; }
        System.Drawing.Image Image { get; }
        string Description { get; }
        int Run(int input1, int input2);
    }


}
