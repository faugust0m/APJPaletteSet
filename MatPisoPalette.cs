using System;
using System.Windows.Forms;

namespace APJPaletteSet
{
    public partial class MatPisoPalette : UserControl
    {
        int groupBox_0_Offset = 4;
        int groupBox_1_Offset = 18;
        int groupBox_2_Offset = 32;
        public MatPisoPalette()
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
        private void ComboBox_1_LostFocus(object sender, EventArgs e, int _pair)
        {
            int _prop = int.Parse(MyEvents.GetCheckedRadio(groupBox_1)) + groupBox_1_Offset;
            string _value = (sender as ComboBox).Text;
            MyProject.SetDetailValue(_prop, _pair, _value);
            (sender as ComboBox).BackColor = System.Drawing.SystemColors.Menu;
        }
        private void ComboBox_2_LostFocus(object sender, EventArgs e, int _pair)
        {
            int _prop = int.Parse(MyEvents.GetCheckedRadio(groupBox_2)) + groupBox_2_Offset;
            string _value = (sender as ComboBox).Text;
            MyProject.SetDetailValue(_prop, _pair, _value);
            (sender as ComboBox).BackColor = System.Drawing.SystemColors.Menu;
        }
        private void RadioButton_0_CheckedChanged(object sender, EventArgs e)
        {
            int _prop = int.Parse(MyEvents.GetCheckedRadio(groupBox_0)) + groupBox_0_Offset;
            comboBox_5_0.Text = MyProject.GetDetailValue(_prop, 0);
            comboBox_5_1.Text = MyProject.GetDetailValue(_prop, 1);
            comboBox_5_2.Text = MyProject.GetDetailValue(_prop, 2);
            comboBox_5_3.Text = MyProject.GetDetailValue(_prop, 3);
            comboBox_5_4.Text = MyProject.GetDetailValue(_prop, 4);
            comboBox_5_5.Text = MyProject.GetDetailValue(_prop, 5);
            comboBox_5_6.Text = MyProject.GetDetailValue(_prop, 6);
            textBox_5_7.Text = MyProject.GetDetailValue(_prop, 7);
            textBox_5_8.Text = MyProject.GetDetailValue(_prop, 8);
        }
        private void RadioButton_1_CheckedChanged(object sender, EventArgs e)
        {
            int _prop = int.Parse(MyEvents.GetCheckedRadio(groupBox_1)) + groupBox_1_Offset;
            comboBox_19_0.Text = MyProject.GetDetailValue(_prop, 0);
            comboBox_19_1.Text = MyProject.GetDetailValue(_prop, 1);
        }
        private void RadioButton_2_CheckedChanged(object sender, EventArgs e)
        {
            int _prop = int.Parse(MyEvents.GetCheckedRadio(groupBox_2)) + groupBox_2_Offset;
            comboBox_33_0.Text = MyProject.GetDetailValue(_prop, 0);
            comboBox_33_1.Text = MyProject.GetDetailValue(_prop, 1);
        }
    }
}