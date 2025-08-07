using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class case3 :Base
    {
        public override void Hardway(int x)
        {
            Console.WriteLine("3-cu yol ucun ipuclari:");

            Dictionary<int, List<string>> y = new Dictionary<int, List<string>>()
            {
                {1, new List<string>
                    {

                   "tek ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "uzerine 2 geldikde tek eded olur",
                   "4'e bolunmur",
                   "kvadrat deyil",
                   "3'e tam bolunmur",
                    }
                },
                {2, new List<string>
                    {

                   "cut ededdir",
                   "uzerine 5 geldike tek eded olur",
                   "5'e bolunmur",
                   "uzerine 2 geldikde cut eded olur",
                   "4'e bolunur",
                   "kvadrat deyil",
                   "3'e tam bolunmur",


                    }
                },
                {3, new List<string>
                    {


                   "tek ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "uzerine 2 geldikde tek eded olur",
                   "4'e bolunmur",
                   "kvadrat deyil",
                   "3'e tam bolunur",


                    }
                },
                {4, new List<string>
                    {


                   "cut ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "uzerine 2 geldikde cut eded olur",
                   "4'e bolunur",
                   "kvadratdir",
                   "3'e tam bolunmur",

                    }
                },
                {5, new List<string>
                    {


                   "tek ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunur",
                   "uzerine 2 geldikde tek eded olur",
                   "4'e bolunmur",
                   "kvadrat deyil",
                   "3'e tam bolunmur",


                    }
                },
                {6, new List<string>
                    {

                   "cut ededdir",
                   "uzerine 5 geldike tek eded olur",
                   "5'e bolunmur",
                   "uzerine 2 geldikde cut eded olur",
                   "4'e bolunmur",
                   "kvadrat deyil",
                   "3'e tam bolunur",



                    }
                },
                {7, new List<string>
                    {
                   
                   "tek ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "uzerine 2 geldikde tek eded olur",
                   "4'e bolunmur",
                   "kvadrat deyil",
                   "3'e tam bolunmur",



                    }
                },
                {8, new List<string>
                    {


                   "cut ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "uzerine 2 geldikde cut eded olur",
                   "4'e bolunur",
                   "kvadrat deyil",
                   "3'e tam bolunmur",

                    }
                },
                {9, new List<string>
                    {

                   "cut ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "uzerine 2 geldikde tek eded olur",
                   "4'e bolunmur",
                   "kvadratdir",
                   "3'e tam bolunur",


                    }
                },
                {10, new List<string>
                    {


                   "cut ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunur",
                   "reqemlerinin cemi 1'dir",
                   "4'e bolunmur",
                   "reqemlerinin ferqi 1'dir",
                   "reqemlerinin hasili 0'dir",


                    }
                },
                {11, new List<string>
                    {


                   "tek ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "reqemlerinin cemi 2'dir",
                   "4'e bolunmur",
                   "reqemlerinin ferqi 0'dir",
                   "reqemlerinin hasili 1'dir",

                    }
                },
                {12, new List<string>
                    {
                   "cut ededdir",
                   "uzerine 5 geldike tek eded olur",
                   "5'e bolunmur",
                   "reqemlerinin cemi 3'dur",
                   "4'e bolunur",
                   "reqemlerinin ferqi -1'dir",
                   "reqemlerinin hasili 2'dir",

                    }
                },
                {13, new List<string>
                    {
                   "tek ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "reqemlerinin cemi 4'dur",
                   "4'e bolunmur",
                   "reqemlerinin ferqi -2'dir",
                   "reqemlerinin hasili 3'dur",

                    }
                },
                {14, new List<string>
                    {

                   "cut ededdir",
                   "uzerine 5 geldike tek eded olur",
                   "5'e bolunmur",
                   "reqemlerinin cemi 5'dir",
                   "4'e bolunmur",
                   "reqemlerinin ferqi -3'dur",
                   "reqemlerinin hasili 5'dir",

                    }
                },
                {15, new List<string>
                    {
                   "cut ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunur",
                   "reqemlerinin cemi 6'dir",
                   "4'e bolunmur",
                   "reqemlerinin ferqi -4'dur",
                   "reqemlerinin hasili 5'dir",


                    }
                },
                {16, new List<string>
                    {

                   "cut ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunur",
                   "reqemlerinin cemi 7'dir",
                   "4'e bolunur",
                   "reqemlerinin ferqi -5'dir",
                   "reqemlerinin hasili 6'dir",

                    }
                },
                {17, new List<string>
                    {
                   "tek ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "reqemlerinin cemi 8'dir",
                   "4'e bolunmur",
                   "reqemlerinin ferqi -6'dir",
                   "reqemlerinin hasili 7'dir",


                    }
                },
                 {18, new List<string>
                    {


                    "cut ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "reqemlerinin cemi 9'dur",
                   "4'e bolunmur",
                   "reqemlerinin ferqi -7'dir",
                   "reqemlerinin hasili 8'dir",

                    }
                },
                 {19, new List<string>
                    {

                   "tek ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunmur",
                   "reqemlerinin cemi 10'dur",
                   "4'e bolunmur",
                   "reqemlerinin ferqi -8'dir",
                   "reqemlerinin hasili 1'dir",

                    }
                },
                 {20, new List<string>
                    {


                   "cut ededdir",
                   "uzerine 5 geldike cut eded olur",
                   "5'e bolunur",
                   "reqemlerinin cemi 2'dir",
                   "4'e bolunur",
                   "reqemlerinin ferqi 2'dir",
                   "reqemlerinin hasili 0'dir",


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
