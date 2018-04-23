using System;
using System.Collections.Generic;
using System.Text;

namespace Gen1
{
    public class PointD
    {
        public double X, Y;

        public PointD (double p_x, double p_Y)
        {
            X = p_x;
            Y = p_Y;
        }
    }

    public class SitesList
    {
        public List<PointD> Sites;
        public readonly int Dimension;       

        public SitesList(
            int p_Dimension,
            List<PointD> p_Sites)
        {
            Sites = p_Sites;
            Dimension = p_Dimension;
        }

    }
}
