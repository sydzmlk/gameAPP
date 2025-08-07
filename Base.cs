using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace GameApp
{
    public class Base
    {
        public virtual void Hardway(int x)
        {
            Console.WriteLine("1-ci yol ucun ipuclari:");

            Dictionary<int, List<string>> y = new Dictionary<int, List<string>>()
            {
                {1, new List<string>
                    {
                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 1'dir",
                        "7e bolende qaliq bir qalir"
                    }
                },
                {2, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 2'dr",
                        "7e bolende qaliq iki qalir"

                    }
                },
                {3, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 3'dur",
                        "7e bolende qaliq uc qalir"

                    }
                },
                {4, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 4'dur",
                        "7e bolende qaliq 4 qalir"

                    }
                },
                {5, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 5'dir",
                        "7e bolende qaliq 5 qalir"

                    }
                },
                {6, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 6'dir",
                        "7e bolende qaliq 6 qalir"

                    }
                },
                {7, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 7'dir",
                        "7e bolende qaliq sifir qalir"

                    }
                },
                {8, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 8'dir",
                        "7e bolende qaliq bir qalir"

                    }
                },
                {9, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyismeyecek",
                        "Reqemlerinin cemi 9'dur",
                        "7e bolende qaliq iki qalir"

                    }
                },
                {10, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 1 dir",
                        "7e bolende qaliq uc qalir"

                    }
                },
                {11, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 2'dr",
                        "7e bolende qaliq dord qalir"

                    }
                },
                {12, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyismeycek",
                        "Reqemlerinin cemi 3 dur",
                        "7e bolende qaliq bes qalir"

                    }
                },
                {13, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 4'dur",
                        "7e bolende qaliq alti qalir"

                    }
                },
                {14, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 5'dir",
                        "7e bolende qaliq sifir qalir"

                    }
                },
                {15, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyismeyecek",
                        "Reqemlerinin cemi 6 dir",
                        "7e bolende qaliq bir qalir"

                    }
                },
                {16, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 7'dir",
                        "7e bolende qaliq iki qalir"

                    }
                },
                {17, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 8'dir",
                        "7e bolende qaliq uc qalir"

                    }
                },
                 {18, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyismeyecek",
                        "Reqemlerinin cemi 9'dur",
                        "7e bolende qaliq dord qalir"

                    }
                },
                 {19, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi 10 dur",
                        "7e bolende qaliq bes qalir"

                    }
                },
                 {20, new List<string>
                    {

                        "Uzerine 3 vahid gelende tek/cut deyisecek",
                        "Reqemlerinin cemi iki'dir",
                        "7e bolende qaliq alti qalir"

                    }
                }

                
            };
            foreach (var item in y[x])
            {
              Console.WriteLine(item);
                
            }



        }
    }
}
