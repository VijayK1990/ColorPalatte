using ColorViewer.Models;
using System;

namespace ColorViewer.Controllers
{
    public static class ARGBPercentController
    {
        public static ARGBPercentLimit GetARGBLimit(int A, int R, int G, int B)
        {
            ARGBPercentLimit Limit = new ARGBPercentLimit();
            int NonZeroCount = GetNonZeroStatusForARGB(A, R, G, B);

            if (NonZeroCount == 0)
            {
                Limit = new ARGBPercentLimit()
                {
                    A = 0,
                    R = 0,
                    G = 0,
                    B = 0
                };
            }
            else if (NonZeroCount > 0)
            {
                if (A == 0)
                {
                    Limit.A = 0;
                }
                else
                {
                    Limit.A = Convert.ToSingle(100 / NonZeroCount);
                }

                if (R == 0)
                {
                    Limit.R = 0;
                }
                else
                {
                    Limit.R = Convert.ToSingle(100 / NonZeroCount);
                }

                if (G == 0)
                {
                    Limit.G = 0;
                }
                else
                {
                    Limit.G = Convert.ToSingle(100 / NonZeroCount);
                }

                if (B == 0)
                {
                    Limit.B = 0;
                }
                else
                {
                    Limit.B = Convert.ToSingle(100 / NonZeroCount);
                }
            }

            return Limit;
        }

        private static int GetNonZeroStatusForARGB(int A, int R, int G, int B)
        {
            int NonZeroCount = 0;

            if (A > 0)
            {
                NonZeroCount++;
            }
            if (R > 0)
            {
                NonZeroCount++;
            }
            if (G > 0)
            {
                NonZeroCount++;
            }
            if (B > 0)
            {
                NonZeroCount++;
            }

            return NonZeroCount;
        }
    }
}
