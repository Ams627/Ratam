using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratam
{
    class Program
    {
        private static void Main(string[] args)
        {
            // ratam + rad = ulohy
            try
            {
                for (int i = 10000; i < 99999; i++)
                {
                    var r = i / 10000;
                    var a1 = (i % 10000) / 1000;
                    var t = (i % 1000) / 100;
                    var a2 = (i % 100) / 10;
                    var m = i % 10;
                    if (a1 != a2)
                    {
                        continue;
                    }
                    if (r == t || r == a1 || r == m || a1 == t || a1 == m || t == a2 || t == m || a2 == m)
                    {
                        continue;
                    }
                    for (int j = 100; j < 999; j++)
                    {
                        var r2 = j / 100;
                        var a3 = (j % 100) / 10;
                        var d = j % 10;
                        if (r2 != r || a3 != a2 && ((d == r) || (d == a1) || (d == t) || (d == m)))
                        {
                            continue;
                        }

                        var sum = i + j;

                        var set1 = new HashSet<int> { r, a1, t, m, d };
                        var u = sum / 10000;
                        var l = sum % 10000 / 1000;
                        var o = sum % 1000 / 100;
                        var h = sum % 100 / 10;
                        var y = sum % 10;

                        if (u == l || u == o || u == h || u == y || l == o || l == h || l == y || o == h || o == y || h == y)
                        {
                            continue;
                        }

                        var set2 = new HashSet<int> { u, l, o, h, y };
                        if (!set1.Intersect(set2).Any())
                        {
                            Console.Write($"{r}{a1}{t}{a2}{m}");
                            Console.Write($" + {r}{a1}{d}");
                            Console.WriteLine($" = {u}{l}{o}{h}{y}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
