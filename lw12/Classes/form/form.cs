using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classes.Form
{
    public class Form
    {
        public void Top(StringBuilder sb)
        {          
            sb.Append("<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"utf-8\"/>\n<head/>\n<body>\n");
        }
        public void Mid1(StringBuilder sb, int i)
        {
            sb.Append("<p><b>" + i + "</b><p/>\n");
        }
        public void CreaeI(StringBuilder sb)
        {
            sb.Append("<svg width=\"500\" height=\"350\">");
        }
        public void CloseI(StringBuilder sb)
        {
            sb.Append("\n</svg>\n");
        }
        public void Bot(StringBuilder sb)
        {
            sb.Append("</ body >\n </ html > ");
            String result = "res.html";
            using (StreamWriter strw = new StreamWriter(result))
            {
                strw.WriteLine(sb);
            }
            System.Diagnostics.Process.Start(result);
        }
    }
}
