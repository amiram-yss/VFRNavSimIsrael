using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VFRNavSim.Custom_Controls
{
    /// <summary>
    /// Interaction logic for RoundedTextBox.xaml
    /// </summary>
    public partial class RoundedTextBox : UserControl
    {
        public event EventHandler TextChanged;
        public event EventHandler KeyPress;

        public string Text
        {
            get { return this.txt.Text; }
            set { this.txt.Text = value; }
        }

        public RoundedTextBox()
        {
            InitializeComponent();
            txt.Focus();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            brdFrame.CornerRadius = new CornerRadius((sender as UserControl).ActualHeight / 2);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextChanged != null)
                TextChanged(this, new EventArgs());
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.KeyPress != null)
                this.KeyPress(this, new System.Windows.Forms.KeyPressEventArgs((char)e.Key));
        }
    }
}
