using System;
using System.Windows.Forms;

namespace APJPaletteSet
{
    public partial class ObraPalette : UserControl
    {
        public ObraPalette()
        {
            InitializeComponent();
        }
        private void TextBox_2_10_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string _value = (sender as TextBox).Text;
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
                if (radioButton1.Checked == true) { MyProject.SetDetailValue(2, 10, _value); }
                if (radioButton2.Checked == true) { MyProject.SetDetailValue(2, 14, _value); }
                if (radioButton3.Checked == true) { MyProject.SetDetailValue(2, 18, _value); }
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

            if (e.KeyChar == (char)27)
            {
                if (radioButton1.Checked == true) { MyProject.GetDetailValue(2, 10); }
                if (radioButton2.Checked == true) { MyProject.GetDetailValue(2, 14); }
                if (radioButton3.Checked == true) { MyProject.GetDetailValue(2, 18); }
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
            }
        }
        private void TextBox_2_11_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string _value = (sender as TextBox).Text;
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
                if (radioButton1.Checked == true) { MyProject.SetDetailValue(2, 11, _value); }
                if (radioButton2.Checked == true) { MyProject.SetDetailValue(2, 15, _value); }
                if (radioButton3.Checked == true) { MyProject.SetDetailValue(2, 19, _value); }
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

            if (e.KeyChar == (char)27)
            {
                if (radioButton1.Checked == true) { MyProject.GetDetailValue(2, 11); }
                if (radioButton2.Checked == true) { MyProject.GetDetailValue(2, 15); }
                if (radioButton3.Checked == true) { MyProject.GetDetailValue(2, 19); }
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
            }
        }
        private void TextBox_2_12_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string _value = (sender as TextBox).Text;
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
                if (radioButton1.Checked == true) { MyProject.SetDetailValue(2, 12, _value); }
                if (radioButton2.Checked == true) { MyProject.SetDetailValue(2, 16, _value); }
                if (radioButton3.Checked == true) { MyProject.SetDetailValue(2, 20, _value); }
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

            if (e.KeyChar == (char)27)
            {
                if (radioButton1.Checked == true) { MyProject.GetDetailValue(2, 12); }
                if (radioButton2.Checked == true) { MyProject.GetDetailValue(2, 16); }
                if (radioButton3.Checked == true) { MyProject.GetDetailValue(2, 20); }
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
            }
        }
        private void TextBox_2_13_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string _value = (sender as TextBox).Text;
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
                if (radioButton1.Checked == true) { MyProject.SetDetailValue(2, 13, _value); }
                if (radioButton2.Checked == true) { MyProject.SetDetailValue(2, 17, _value); }
                if (radioButton3.Checked == true) { MyProject.SetDetailValue(2, 21, _value); }
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

            if (e.KeyChar == (char)27)
            {
                if (radioButton1.Checked == true) { MyProject.GetDetailValue(2, 13); }
                if (radioButton2.Checked == true) { MyProject.GetDetailValue(2, 17); }
                if (radioButton3.Checked == true) { MyProject.GetDetailValue(2, 21); }
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.textBox_2_10.Text = MyProject.GetDetailValue(2, 10);
                this.textBox_2_11.Text = MyProject.GetDetailValue(2, 11);
                this.textBox_2_12.Text = MyProject.GetDetailValue(2, 12);
                this.textBox_2_13.Text = MyProject.GetDetailValue(2, 13);
            }

            if (radioButton2.Checked == true)
            {
                this.textBox_2_10.Text = MyProject.GetDetailValue(2, 14);
                this.textBox_2_11.Text = MyProject.GetDetailValue(2, 15);
                this.textBox_2_12.Text = MyProject.GetDetailValue(2, 16);
                this.textBox_2_13.Text = MyProject.GetDetailValue(2, 17);
            }

            if (radioButton3.Checked == true)
            {
                this.textBox_2_10.Text = MyProject.GetDetailValue(2, 18);
                this.textBox_2_11.Text = MyProject.GetDetailValue(2, 19);
                this.textBox_2_12.Text = MyProject.GetDetailValue(2, 20);
                this.textBox_2_13.Text = MyProject.GetDetailValue(2, 21);
            }
        }
    }
}
