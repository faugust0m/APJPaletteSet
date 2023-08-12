using System;
using System.Windows.Forms;

namespace APJPaletteSet
{
    public partial class MatEsquadriasPalette : UserControl
    {
        int groupBox_0_Offset = 74;
        public MatEsquadriasPalette()
        {
            InitializeComponent();
        }
        private void ComboBox_0_LostFocus(object sender, EventArgs e, int _pair)
        {
            int _prop = int.Parse(MyEvents.GetCheckedRadio(groupBox_0)) + groupBox_0_Offset;
            string _value = (sender as ComboBox).Text;
            MyProject.SetDetailValue(_prop, _pair, _value);
            (sender as ComboBox).BackColor = System.Drawing.SystemColors.Menu;
        }
        private void RadioButton_0_CheckedChanged(object sender, EventArgs e)
        {
            int _prop = int.Parse(MyEvents.GetCheckedRadio(groupBox_0)) + groupBox_0_Offset;
            comboBox_75_0.Text = MyProject.GetDetailValue(_prop, 0);
            comboBox_75_1.Text = MyProject.GetDetailValue(_prop, 1);
            comboBox_75_2.Text = MyProject.GetDetailValue(_prop, 2);
            comboBox_75_3.Text = MyProject.GetDetailValue(_prop, 3);
            comboBox_75_4.Text = MyProject.GetDetailValue(_prop, 4);
        }
    }
}