using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Plugin.PrintPlugin
{
    public interface IPrintPlugin
    {
        bool PrintImage(Stream img);
        bool PrintPdfFile(Stream file);
    }
}
