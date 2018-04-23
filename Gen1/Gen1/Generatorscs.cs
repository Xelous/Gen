using System;
using System.Collections.Generic;
using System.Text;

namespace Gen1
{
    public class Generators
    {

        public static double Distance(PointD p_A, PointD p_B)
        {
            double l_Side1 = Math.Abs(p_A.X - p_B.X);
            double l_Side2 = Math.Abs(p_A.Y - p_B.Y);
            
            return l_Side1 + l_Side2;
        }

        public static double DistanceToNearestNeighbour(PointD p_Point, ref List<PointD> p_List)
        {
            double l_result = 0;

            bool l_first = true;

            foreach (PointD l_p in p_List)
            {
                if ( l_p != p_Point )
                {
                    double l_Dist = Distance(p_Point, l_p);

                    if (l_first ||
                        l_Dist < l_result )
                    {
                        l_result = l_Dist;
                        l_first = false;
                    }
                }
            }

            return l_result;
        }

        public static SitesList GenerateSites(int p_Seed, int p_Dimension, int p_Sites, double p_MinimumSpread)
        {
            SitesList l_result = null;

            List<PointD> l_list = new List<PointD>();

            Random l_r = new Random(p_Seed);

            for (int i = 0; i < p_Sites; ++i)
            {
                do
                {
                    double l_X = l_r.NextDouble() * p_Dimension;
                    double l_Y = l_r.NextDouble() * p_Dimension;
                    PointD l_p = new PointD(l_X, l_Y);

                    if (l_list.Count == 0)
                    {
                        l_list.Add(l_p);
                    }
                    else
                    {
                        if (DistanceToNearestNeighbour(l_p, ref l_list) >= p_MinimumSpread)
                        {
                            l_list.Add(l_p);
                            break;
                        }
                    }
                }
                while (true);
            }

            l_result = new SitesList(p_Dimension, l_list);

            return l_result;
        }

    }
}
