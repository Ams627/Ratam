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
                    if (r == t || t == m | r == m)
                    {
                        continue;
                    }
                    for (int j = 100; i < 999; j++)
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

                        var set2 = new HashSet<int> { sum / 10000, sum % 10000 / 1000, sum % 1000 / 100, sum % 100 / 10, sum % 10 };

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
