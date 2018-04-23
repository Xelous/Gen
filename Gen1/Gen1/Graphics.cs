using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Gen1
{
    public class GraphicHelpers
    {
        public static void DrawCross(
            Graphics p_G,
            Pen p_Pen,
            PointD p_Point,
            int p_Size)
        {
            p_G.DrawLine(
                p_Pen,
                (float)p_Point.X - p_Size,
                (float)p_Point.Y - p_Size,
                (float)p_Point.X + p_Size,
                (float)p_Point.Y + p_Size);

            p_G.DrawLine(
                p_Pen,
                (float)p_Point.X + p_Size,
                (float)p_Point.Y - p_Size,
                (float)p_Point.X - p_Size,
                (float)p_Point.Y + p_Size);
        }

        public static Image RenderSitesList(SitesList p_List)
        {
            Bitmap l_Bitmap = new Bitmap(p_List.Dimension, p_List.Dimension);
            Image l_Image = (Image)l_Bitmap;
            Graphics l_g = Graphics.FromImage(l_Image);
            l_g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            for (int i = 0; i < p_List.Sites.Count; ++i)
            {
                DrawCross(
                    l_g,
                    Pens.Blue,
                    p_List.Sites[i],
                    2);
            }            

            return l_Image;
        }
    }
}
