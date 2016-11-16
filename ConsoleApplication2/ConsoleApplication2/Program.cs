using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CreateSvgFile
{
    public static void Main()
    {

        string path = @"c:\temp\cycle.html";
        string header = "<html>\n<head></head>\n<body>\n<h1>Cycle</h1>\n";
        string footer = "</body>\n</html>";

        string svg = "";
        svg += "<svg width='800' height='800'>\n";
        svg += "<rect  width='800' height='800' style='fill:rgb(70,55,225);' />\n";
        string parabola = "<path stroke='red' stroke-width='2' fill='none' d='";
        for (int i = 0; i <= 7500; i++)
        {
            double t = (double)i / 7500;
            double r = 4.0;

            double x = r * Math.Sin(655 * t);
            double y = r * Math.Cos(230 * t); ;

            String xs = (x * 100 + 400).ToString("0");
            String ys = (-y * 100 + 400).ToString("0");
            if (i == 0)
            {
                parabola += " M " + xs + " " + ys;
            }
            else
            {
                parabola += " L " + xs + " " + ys;
            }

        };
        parabola += " ' />\n";
        svg += parabola;
        svg += "</svg>\n";



        string res = header + svg + footer;
        File.WriteAllText(path, res);
        Console.WriteLine("Ok");
    }
}