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
    /// Interaction logic for RoundedButton.xaml
    /// </summary>
    public partial class RoundedButton : UserControl
    {
        public event EventHandler Click;

        public new double FontSize {
            get { return this.txt.FontSize; }
            set { this.txt.FontSize = value; }
        }

        public string Text
        {
            get { return this.txt.Text; }
            set {this.txt.Text = value; }
        }

        public RoundedButton()
        {
            InitializeComponent();
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            brdFrame.Background = new SolidColorBrush(Color.FromArgb(128+64, (byte)124, (byte)0x00, (byte)211));
        }

        private void BrdFrame_MouseLeave(object sender, MouseEventArgs e)
        {
            brdFrame.Background = new SolidColorBrush(Color.FromArgb(255, (byte)124, (byte)0x00, (byte)211));
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            brdFrame.CornerRadius = new CornerRadius((sender as UserControl).ActualHeight/2);
        }

        private void BrdFrame_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            brdFrame.Background = new SolidColorBrush(Color.FromArgb(128, (byte)124, (byte)0x00, (byte)211));
            if (Click != null)
                Click(this, new EventArgs());
        }

        private void BrdFrame_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            brdFrame.Background = new SolidColorBrush(Color.FromArgb(128+64, (byte)124, (byte)0x00, (byte)211));
        }
    }
}
