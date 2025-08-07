using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class case2 :Base
    {
        public override void Hardway(int x)
        {

            Console.WriteLine("2-ci yol ucun ipuclari:");

            Dictionary<int, List<string>> y = new Dictionary<int, List<string>>()
            {
                {1, new List<string>
                    {
                   "3'e bolunende qaliq 1 qalir",
                   "uzerine 5 geldike 3'e bolunmur",
                   "kvadrat deyil",
                   "cut eded deyil",
                   "5'e bolunmur",
                    }
                },
                {2, new List<string>
                    {

                        "3'e bolunende qaliq 2 qalir",
                        "uzerine 5 geldikde 3'e tam bolunur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunmur",
                        

                    }
                },
                {3, new List<string>
                    {


                        "3'e bolunende qaliq 3 qalir",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek ededdir",
                        "5'e bolunmur",

                    }
                },
                {4, new List<string>
                    {


                        "3'e bolunende qaliq 1 qalir",
                        "uzerine 5 geldikde 3'e tam bolunur",
                        "kvadratdir",
                        "tek eded deyil",
                        "5'e bolunmur",

                    }
                },
                {5, new List<string>
                    {


                        "3'e bolunende qaliq 2 qalir",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek ededdir",
                        "5'e bolunur",

                    }
                },
                {6, new List<string>
                    {

                        "3'e tam bolunur",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunmur",

                    }
                },
                {7, new List<string>
                    {


                        "3'e bolunende qaliq 1 qalir",
                        "uzerine 5 geldikde 3'e tam bolunur",
                        "kvadrat deyil",
                        "tek ededdir",
                        "5'e bolunmur",
                    }
                },
                {8, new List<string>
                    {


                        "3'e bolunende qaliq 2 qalir",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunmur",
                    }
                },
                {9, new List<string>
                    {


                        "3'e tam bolunur",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadratdir",
                        "tek eded deyil",
                        "5'e bolunmur",

                    }
                },
                {10, new List<string>
                    {


                        "3'e bolunende qaliq 1 qalir",
                        "uzerine 5 geldikde 3'e tam bolunur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunur",

                    }
                },
                {11, new List<string>
                    {


                        "3'e bolunende qaliq 2 qalir",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek ededdir",
                        "5'e bolunmur",

                    }
                },
                {12, new List<string>
                    {

                        "3'e tam bolunur",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunmur",

                    }
                },
                {13, new List<string>
                    {

                        "3'e bolunende qaliq 1 qalir",
                        "uzerine 5 geldikde 3'e tam bolunur",
                        "kvadrat deyil",
                        "tek ededdir",
                        "5'e bolunmur",
                    }
                },
                {14, new List<string>
                    {

                        "3'e bolunende qaliq 2 qalir",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunmur",
                    }
                },
                {15, new List<string>
                    {

                        "3'e tam bolunur",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunur",

                    }
                },
                {16, new List<string>
                    {

                        "3'e bolunende qaliq 1 qalir",
                        "uzerine 5 geldikde 3'e tam bolunur",
                        "kvadratdir",
                        "tek eded deyil",
                        "5'e bolunmur",
                    }
                },
                {17, new List<string>
                    {

                        "3'e bolunende qaliq 2 qalir",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek ededdir",
                        "5'e bolunmur",

                    }
                },
                 {18, new List<string>
                    {


                        "3'e tam bolunur",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunmur",
                    }
                },
                 {19, new List<string>
                    {


                        "3'e bolunende qaliq 1 qalir",
                        "uzerine 5 geldikde 3'e tam bolunur",
                        "kvadrat deyil",
                        "tek ededdir",
                        "5'e bolunmur",
                    }
                },
                 {20, new List<string>
                    {


                        "3'e bolunende qaliq 2 qalir",
                        "uzerine 5 geldikde 3'e tam bolunmur",
                        "kvadrat deyil",
                        "tek eded deyil",
                        "5'e bolunur",

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
