using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool IntValueFromTextBox(TextBox p_Text, out int p_Value)
        {
            return int.TryParse(p_Text.Text, out p_Value);
        }

        private void m_Generate_Click(object sender, EventArgs e)
        {
            int l_Sites = 10;
            int l_Dimensions = 512;
            int l_Seed = 0;

            if (IntValueFromTextBox(m_Seed, out l_Seed))
            {
                if (IntValueFromTextBox(m_Dimension, out l_Dimensions))
                {
                    if (IntValueFromTextBox(m_Sites, out l_Sites))
                    {
                        SitesList l_SitesList = Generators.GenerateSites(l_Seed, l_Dimensions, l_Sites, 12);

                        m_Preview.BackgroundImage = GraphicHelpers.RenderSitesList(l_SitesList);
                        m_Preview.BackgroundImageLayout = ImageLayout.None;
                    }
                }
            }
        }
    }
}
