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
    /// Interaction logic for RoundedGroupBox.xaml
    /// </summary>
    public partial class RoundedGroupBox : UserControl
    {
        public string Text {
            get { return this.txt.Text; }
            set { this.txt.Text = " "+value+" ";}
        }
        public RoundedGroupBox()
        {
            InitializeComponent();
        }
    }
}
