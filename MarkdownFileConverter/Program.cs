using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MarkdownFileConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var m = new MarkdownSharp.Markdown();

                m.AutoHyperlink = true;
                m.StrictBoldItalic = true;

                string html = m.Transform(File.ReadAllText(args[0]));

                File.WriteAllText(args[1], html);
            }
            catch (Exception e)
            {
                Console.Error.Write(e.ToString());
            }
        }
    }
}
