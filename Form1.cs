using System.Windows.Forms.VisualStyles;

namespace VScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //si premeu aquesta VScrollBar la label1 pasa a ser visible
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (ScrollBarState.Pressed != 0)
            {
                label1.Visible= true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
