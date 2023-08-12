using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class MatEsquadriasPalette
    {
        #region Lista de Controles
        private Panel panel;
        private Label label;
        private PictureBox picture;

        private Label space_0;
        private Label space_1;
        private Label space_2;

        private GroupBox groupBox_0;
        private Label label_75_0;
        private ComboBox comboBox_75_0;
        private Label label_75_1;
        private ComboBox comboBox_75_1;
        private Label label_75_2;
        private ComboBox comboBox_75_2;
        private Label label_75_3;
        private ComboBox comboBox_75_3;
        private Label label_75_4;
        private ComboBox comboBox_75_4;
        private LinkLabel linkLabel;
        private RadioButton radioButton_75_1;
        private RadioButton radioButton_75_2;
        private RadioButton radioButton_75_3;
        private RadioButton radioButton_75_4;
        private RadioButton radioButton_75_5;
        private RadioButton radioButton_75_6;

        private GroupBox groupBox_1;
        private Label label_82_0;
        private ComboBox comboBox_82_0;
        private Label label_82_1;
        private ComboBox comboBox_82_1;
        private Label label_82_2;
        private ComboBox comboBox_82_2;
        private Label label_82_3;
        private ComboBox comboBox_82_3;
        private Label label_82_4;
        private ComboBox comboBox_82_4;
        private Label label_82_5;
        private ComboBox comboBox_82_5;

        private GroupBox groupBox_2;
        private Label label_83_0;
        private ComboBox comboBox_83_0;
        private Label label_83_1;
        private ComboBox comboBox_83_1;
        private Label label_83_2;
        private ComboBox comboBox_83_2;
        private Label label_83_3;
        private ComboBox comboBox_83_3;
        private Label label_83_4;
        private ComboBox comboBox_83_4;
        private Label label_83_5;
        private ComboBox comboBox_83_5;

        private GroupBox groupBox_3;
        private Label label_84_0;
        private ComboBox comboBox_84_0;
        private Label label_84_1;
        private ComboBox comboBox_84_1;
        private Label label_84_2;
        private ComboBox comboBox_84_2;
        private Label label_84_3;
        private ComboBox comboBox_84_3;
        private Label label_84_4;
        private ComboBox comboBox_84_4;
        private Label label_84_5;
        private ComboBox comboBox_84_5;
        #endregion
        private void InitializeComponent()
        {
            #region Lista de Controles
            this.panel = new ExPanel();
            this.label = new Label();
            this.picture = new PictureBox();

            this.space_0 = new Label();
            this.space_1 = new Label();
            this.space_2 = new Label();

            this.groupBox_0 = new GroupBox();
            this.label_75_0 = new Label();
            this.comboBox_75_0 = new ComboBox();
            this.label_75_1 = new Label();
            this.comboBox_75_1 = new ComboBox();
            this.label_75_2 = new Label();
            this.comboBox_75_2 = new ComboBox();
            this.label_75_3 = new Label();
            this.comboBox_75_3 = new ComboBox();
            this.label_75_4 = new Label();
            this.comboBox_75_4 = new ComboBox();
            this.linkLabel = new LinkLabel();
            this.radioButton_75_1 = new RadioButton();
            this.radioButton_75_2 = new RadioButton();
            this.radioButton_75_3 = new RadioButton();
            this.radioButton_75_4 = new RadioButton();
            this.radioButton_75_5 = new RadioButton();
            this.radioButton_75_6 = new RadioButton();

            this.groupBox_1 = new GroupBox();
            this.label_82_0 = new Label();
            this.comboBox_82_0 = new ComboBox();
            this.label_82_1 = new Label();
            this.comboBox_82_1 = new ComboBox();
            this.label_82_2 = new Label();
            this.comboBox_82_2 = new ComboBox();
            this.label_82_3 = new Label();
            this.comboBox_82_3 = new ComboBox();
            this.label_82_4 = new Label();
            this.comboBox_82_4 = new ComboBox();
            this.label_82_5 = new Label();
            this.comboBox_82_5 = new ComboBox();

            this.groupBox_2 = new GroupBox();
            this.label_83_0 = new Label();
            this.comboBox_83_0 = new ComboBox();
            this.label_83_1 = new Label();
            this.comboBox_83_1 = new ComboBox();
            this.label_83_2 = new Label();
            this.comboBox_83_2 = new ComboBox();
            this.label_83_3 = new Label();
            this.comboBox_83_3 = new ComboBox();
            this.label_83_4 = new Label();
            this.comboBox_83_4 = new ComboBox();
            this.label_83_5 = new Label();
            this.comboBox_83_5 = new ComboBox();

            this.groupBox_3 = new GroupBox();
            this.label_84_0 = new Label();
            this.comboBox_84_0 = new ComboBox();
            this.label_84_1 = new Label();
            this.comboBox_84_1 = new ComboBox();
            this.label_84_2 = new Label();
            this.comboBox_84_2 = new ComboBox();
            this.label_84_3 = new Label();
            this.comboBox_84_3 = new ComboBox();
            this.label_84_4 = new Label();
            this.comboBox_84_4 = new ComboBox();
            this.label_84_5 = new Label();
            this.comboBox_84_5 = new ComboBox();
            #endregion
            #region panel + label + picture
            this.panel.Controls.Add(this.groupBox_3);
            this.panel.Controls.Add(this.space_2);
            this.panel.Controls.Add(this.groupBox_2);
            this.panel.Controls.Add(this.space_1);
            this.panel.Controls.Add(this.groupBox_1);
            this.panel.Controls.Add(this.space_0);
            this.panel.Controls.Add(this.groupBox_0);

            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);
            MyFormats.PictureFormat(picture);

            #endregion
            #region  groupBox_0
            this.groupBox_0.Controls.Add(this.label_75_0);
            this.groupBox_0.Controls.Add(this.comboBox_75_0);
            this.groupBox_0.Controls.Add(this.label_75_1);
            this.groupBox_0.Controls.Add(this.comboBox_75_1);
            this.groupBox_0.Controls.Add(this.label_75_2);
            this.groupBox_0.Controls.Add(this.comboBox_75_2);
            this.groupBox_0.Controls.Add(this.label_75_3);
            this.groupBox_0.Controls.Add(this.comboBox_75_3);
            this.groupBox_0.Controls.Add(this.label_75_4);
            this.groupBox_0.Controls.Add(this.comboBox_75_4);
            this.groupBox_0.Controls.Add(this.linkLabel);
            this.groupBox_0.Controls.Add(this.radioButton_75_1);
            this.groupBox_0.Controls.Add(this.radioButton_75_2);
            this.groupBox_0.Controls.Add(this.radioButton_75_3);
            this.groupBox_0.Controls.Add(this.radioButton_75_4);
            this.groupBox_0.Controls.Add(this.radioButton_75_5);
            this.groupBox_0.Controls.Add(this.radioButton_75_6);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Text = "Materiais de Esquadrias";
            this.groupBox_0.Name = "groupBox_0";
            //
            // radioButtons
            //
            this.radioButton_75_1.Name = "radioButton_75_1";
            this.radioButton_75_1.Text = "01";
            this.radioButton_75_1.Location = new Point(10, 20);

            this.radioButton_75_2.Name = "radioButton_75_2";
            this.radioButton_75_2.Text = "02";
            this.radioButton_75_2.Location = new Point(50, 20);

            this.radioButton_75_3.Name = "radioButton_75_3";
            this.radioButton_75_3.Text = "03";
            this.radioButton_75_3.Location = new Point(90, 20);

            this.radioButton_75_4.Name = "radioButton_75_4";
            this.radioButton_75_4.Text = "04";
            this.radioButton_75_4.Location = new Point(130, 20);

            this.radioButton_75_5.Name = "radioButton_75_5";
            this.radioButton_75_5.Text = "05";
            this.radioButton_75_5.Location = new Point(170, 20);

            this.radioButton_75_6.Name = "radioButton_75_6";
            this.radioButton_75_6.Text = "06";
            this.radioButton_75_6.Location = new Point(210, 20);
            //
            // textBoxes
            //
            this.label_75_0.Name = "label_75_0";
            this.label_75_0.Text = "Tipo:";
            this.comboBox_75_0.Name = "comboBox_75_0";
            this.comboBox_75_0.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 0);
            };
            this.label_75_1.Name = "label_75_1";
            this.label_75_1.Text = "Padrão:";
            this.comboBox_75_1.Name = "comboBox_75_1";
            this.comboBox_75_1.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 1);
            };
            this.label_75_2.Name = "label_75_2";
            this.label_75_2.Text = "Pintura:";
            this.comboBox_75_2.Name = "comboBox_75_2";
            this.comboBox_75_2.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 2);
            };
            this.label_75_3.Name = "label_75_3";
            this.label_75_3.Text = "Cor:";
            this.comboBox_75_3.Name = "comboBox_75_3";
            this.comboBox_75_3.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 3);
            };
            this.label_75_4.Name = "label_75_4";
            this.label_75_4.Text = "Acabamento:";
            this.comboBox_75_4.Name = "comboBox_75_4";
            this.comboBox_75_4.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 4);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 4);
            };
            #endregion
            #region  groupBox_1
            this.groupBox_1.Controls.Add(this.label_82_0);
            this.groupBox_1.Controls.Add(this.comboBox_82_0);
            this.groupBox_1.Controls.Add(this.label_82_1);
            this.groupBox_1.Controls.Add(this.comboBox_82_1);
            this.groupBox_1.Controls.Add(this.label_82_2);
            this.groupBox_1.Controls.Add(this.comboBox_82_2);
            this.groupBox_1.Controls.Add(this.label_82_3);
            this.groupBox_1.Controls.Add(this.comboBox_82_3);
            this.groupBox_1.Controls.Add(this.label_82_4);
            this.groupBox_1.Controls.Add(this.comboBox_82_4);
            this.groupBox_1.Controls.Add(this.label_82_5);
            this.groupBox_1.Controls.Add(this.comboBox_82_5);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Vidros";
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new Size(300, 165);
            //
            // textBoxes
            //
            this.label_82_0.Name = "label_82_0";
            this.label_82_0.Text = "01";
            this.comboBox_82_0.Name = "comboBox_82_0";
            this.comboBox_82_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 82, 0);
            };
            this.label_82_1.Name = "label_82_1";
            this.label_82_1.Text = "02";
            this.comboBox_82_1.Name = "comboBox_82_1";
            this.comboBox_82_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 82, 1);
            };
            this.label_82_2.Name = "label_82_2";
            this.label_82_2.Text = "03";
            this.comboBox_82_2.Name = "comboBox_82_2";
            this.comboBox_82_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 82, 2);
            };
            this.label_82_3.Name = "label_82_3";
            this.label_82_3.Text = "04";
            this.comboBox_82_3.Name = "comboBox_82_3";
            this.comboBox_82_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 82, 3);
            };
            this.label_82_4.Name = "label_82_4";
            this.label_82_4.Text = "05";
            this.comboBox_82_4.Name = "comboBox_82_4";
            this.comboBox_82_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 82, 4);
            };
            this.label_82_5.Name = "label_82_5";
            this.label_82_5.Text = "06";
            this.comboBox_82_5.Name = "comboBox_82_5";
            this.comboBox_82_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 82, 5);
            };
            #endregion
            #region  groupBox_2
            this.groupBox_2.Controls.Add(this.label_83_0);
            this.groupBox_2.Controls.Add(this.comboBox_83_0);
            this.groupBox_2.Controls.Add(this.label_83_1);
            this.groupBox_2.Controls.Add(this.comboBox_83_1);
            this.groupBox_2.Controls.Add(this.label_83_2);
            this.groupBox_2.Controls.Add(this.comboBox_83_2);
            this.groupBox_2.Controls.Add(this.label_83_3);
            this.groupBox_2.Controls.Add(this.comboBox_83_3);
            this.groupBox_2.Controls.Add(this.label_83_4);
            this.groupBox_2.Controls.Add(this.comboBox_83_4);
            this.groupBox_2.Controls.Add(this.label_83_5);
            this.groupBox_2.Controls.Add(this.comboBox_83_5);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.Text = "Maçanetas e Puxadores";
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new Size(300, 165);
            //
            // textBoxes
            //
            this.label_83_0.Name = "label_83_0";
            this.label_83_0.Text = "01";
            this.comboBox_83_0.Name = "comboBox_83_0";
            this.comboBox_83_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 83, 0);
            };
            this.label_83_1.Name = "label_83_1";
            this.label_83_1.Text = "02";
            this.comboBox_83_1.Name = "comboBox_83_1";
            this.comboBox_83_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 83, 1);
            };
            this.label_83_2.Name = "label_83_2";
            this.label_83_2.Text = "03";
            this.comboBox_83_2.Name = "comboBox_83_2";
            this.comboBox_83_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 83, 2);
            };
            this.label_83_3.Name = "label_83_3";
            this.label_83_3.Text = "04";
            this.comboBox_83_3.Name = "comboBox_83_3";
            this.comboBox_83_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 83, 3);
            };
            this.label_83_4.Name = "label_83_4";
            this.label_83_4.Text = "05";
            this.comboBox_83_4.Name = "comboBox_83_4";
            this.comboBox_83_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 83, 4);
            };
            this.label_83_5.Name = "label_83_5";
            this.label_83_5.Text = "06";
            this.comboBox_83_5.Name = "comboBox_83_5";
            this.comboBox_83_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 83, 5);
            };
            #endregion
            #region groupBox_3
            this.groupBox_3.Controls.Add(this.label_84_0);
            this.groupBox_3.Controls.Add(this.comboBox_84_0);
            this.groupBox_3.Controls.Add(this.label_84_1);
            this.groupBox_3.Controls.Add(this.comboBox_84_1);
            this.groupBox_3.Controls.Add(this.label_84_2);
            this.groupBox_3.Controls.Add(this.comboBox_84_2);
            this.groupBox_3.Controls.Add(this.label_84_3);
            this.groupBox_3.Controls.Add(this.comboBox_84_3);
            this.groupBox_3.Controls.Add(this.label_84_4);
            this.groupBox_3.Controls.Add(this.comboBox_84_4);
            this.groupBox_3.Controls.Add(this.label_84_5);
            this.groupBox_3.Controls.Add(this.comboBox_84_5);
            this.groupBox_3.TabIndex = 3;
            this.groupBox_3.Text = "Dobradiças";
            this.groupBox_3.Name = "groupBox_3";
            this.groupBox_3.Size = new Size(300, 165);
            //
            // textBoxes
            //
            this.label_84_0.Name = "label_84_0";
            this.label_84_0.Text = "01";
            this.comboBox_84_0.Name = "comboBox_84_0";
            this.comboBox_84_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 84, 0);
            };
            this.label_84_1.Name = "label_84_1";
            this.label_84_1.Text = "02";
            this.comboBox_84_1.Name = "comboBox_84_1";
            this.comboBox_84_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 84, 1);
            };
            this.label_84_2.Name = "label_84_2";
            this.label_84_2.Text = "03";
            this.comboBox_84_2.Name = "comboBox_84_2";
            this.comboBox_84_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 84, 2);
            };
            this.label_84_3.Name = "label_84_3";
            this.label_84_3.Text = "04";
            this.comboBox_84_3.Name = "comboBox_84_3";
            this.comboBox_84_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 84, 3);
            };
            this.label_84_4.Name = "label_84_4";
            this.label_84_4.Text = "05";
            this.comboBox_84_4.Name = "comboBox_84_4";
            this.comboBox_84_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 84, 4);
            };
            this.label_84_5.Name = "label_84_5";
            this.label_84_5.Text = "06";
            this.comboBox_84_5.Name = "comboBox_84_5";
            this.comboBox_84_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 84, 5);
            };
            #endregion

            int _padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "MatEsquadriasPalette";
            this.Controls.Add(this.panel);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label);
            this.Padding = new Padding(_padd, 10, 10, 10);
            this.Size = new Size(320, 650);
            this.FormatComponent();
            this.FillComponent();
        }
        internal void FillComponent()
        {
            this.label.Text = MyProject.CurrentProject();

            this.radioButton_75_1.Checked = true;
            this.comboBox_75_0.Text = MyProject.GetDetailValue(75, 0);
            this.comboBox_75_1.Text = MyProject.GetDetailValue(75, 1);
            this.comboBox_75_2.Text = MyProject.GetDetailValue(75, 2);
            this.comboBox_75_3.Text = MyProject.GetDetailValue(75, 3);
            this.comboBox_75_4.Text = MyProject.GetDetailValue(75, 4);

            foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Esquadria"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_75_0.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("EsquadriaPadrão"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_75_1.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("EsquadriaPintura"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_75_2.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("EsquadriaCor"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_75_3.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Acabamento"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_75_4.Items.Add(value);
            }

            this.comboBox_82_0.Text = MyProject.GetDetailValue(82, 0);
            this.comboBox_82_1.Text = MyProject.GetDetailValue(82, 1);
            this.comboBox_82_2.Text = MyProject.GetDetailValue(82, 2);
            this.comboBox_82_3.Text = MyProject.GetDetailValue(82, 3);
            this.comboBox_82_4.Text = MyProject.GetDetailValue(82, 4);
            this.comboBox_82_5.Text = MyProject.GetDetailValue(82, 5);

            foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Vidro"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_82_0.Items.Add(value);
                this.comboBox_82_1.Items.Add(value);
                this.comboBox_82_2.Items.Add(value);
                this.comboBox_82_3.Items.Add(value);
                this.comboBox_82_4.Items.Add(value);
                this.comboBox_82_5.Items.Add(value);
            }

            this.comboBox_83_0.Text = MyProject.GetDetailValue(83, 0);
            this.comboBox_83_1.Text = MyProject.GetDetailValue(83, 1);
            this.comboBox_83_2.Text = MyProject.GetDetailValue(83, 2);
            this.comboBox_83_3.Text = MyProject.GetDetailValue(83, 3);
            this.comboBox_83_4.Text = MyProject.GetDetailValue(83, 4);
            this.comboBox_83_5.Text = MyProject.GetDetailValue(83, 5);

            foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Maçanetas"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_83_0.Items.Add(value);
                this.comboBox_83_1.Items.Add(value);
                this.comboBox_83_2.Items.Add(value);
                this.comboBox_83_3.Items.Add(value);
                this.comboBox_83_4.Items.Add(value);
                this.comboBox_83_5.Items.Add(value);
            }

            this.comboBox_84_0.Text = MyProject.GetDetailValue(84, 0);
            this.comboBox_84_1.Text = MyProject.GetDetailValue(84, 1);
            this.comboBox_84_2.Text = MyProject.GetDetailValue(84, 2);
            this.comboBox_84_3.Text = MyProject.GetDetailValue(84, 3);
            this.comboBox_84_4.Text = MyProject.GetDetailValue(84, 4);
            this.comboBox_84_5.Text = MyProject.GetDetailValue(84, 5);

            foreach (var combobox in this.groupBox_3.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Ferragens"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_84_0.Items.Add(value);
                this.comboBox_84_1.Items.Add(value);
                this.comboBox_84_2.Items.Add(value);
                this.comboBox_84_3.Items.Add(value);
                this.comboBox_84_4.Items.Add(value);
                this.comboBox_84_5.Items.Add(value);
            }
        }
        internal void FillList(string _combobox)
        {
            switch (_combobox)
            {
                case "comboBox_75_0":
                    comboBox_75_0.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Esquadria"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_75_0.Items.Add(value);
                    }
                    break;
                case "comboBox_75_1":
                    comboBox_75_1.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("EsquadriaPadrão"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_75_1.Items.Add(value);
                    }
                    break;
                case "comboBox_75_2":
                    comboBox_75_2.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("EsquadriaPintura"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_75_2.Items.Add(value);
                    }
                    break;
                case "comboBox_75_3":
                    comboBox_75_3.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("EsquadriaCor"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_75_3.Items.Add(value);
                    }
                    break;
                case "comboBox_75_4":
                    comboBox_75_4.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Acabamento"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_75_4.Items.Add(value);
                    }
                    break;



                case "comboBox_82_0":
                    foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Vidro"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_82_0.Items.Add(value);
                        this.comboBox_82_1.Items.Add(value);
                        this.comboBox_82_2.Items.Add(value);
                        this.comboBox_82_3.Items.Add(value);
                        this.comboBox_82_4.Items.Add(value);
                        this.comboBox_82_5.Items.Add(value);
                    }
                    break;



                case "comboBox_83_0":
                    foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Maçanetas"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_83_0.Items.Add(value);
                        this.comboBox_83_1.Items.Add(value);
                        this.comboBox_83_2.Items.Add(value);
                        this.comboBox_83_3.Items.Add(value);
                        this.comboBox_83_4.Items.Add(value);
                        this.comboBox_83_5.Items.Add(value);
                    }
                    break;



                case "comboBox_84_0":
                    foreach (var combobox in this.groupBox_3.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Ferragens"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_84_0.Items.Add(value);
                        this.comboBox_84_1.Items.Add(value);
                        this.comboBox_84_2.Items.Add(value);
                        this.comboBox_84_3.Items.Add(value);
                        this.comboBox_84_4.Items.Add(value);
                        this.comboBox_84_5.Items.Add(value);
                    }
                    break;
            }
        }
        private void FormatComponent()
        {
            #region groupBox builder
            foreach (var groupbox in this.panel.Controls.OfType<GroupBox>())
            {
                MyFormats.GroupBoxFormat(groupbox);
            }
            foreach (var space in this.panel.Controls.OfType<Label>())
            {
                MyFormats.SpaceFormat(space);
            }
            #endregion
            #region groupBox_0 builder

            int comboBox_0 = 23;
            int label_0 = 24;

            foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
            {
                comboBox_0 = comboBox_0 + 24;
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, comboBox_0);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_0.Controls.OfType<Label>())
            {
                label_0 = label_0 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_0);
                MyFormats.LabelFormat(label);
            }

            foreach (var radiobutton in this.groupBox_0.Controls.OfType<RadioButton>())
            {
                radiobutton.Size = new Size(30, 18);
                radiobutton.CheckedChanged += new EventHandler(this.RadioButton_0_CheckedChanged);
                MyFormats.RadioButtonFormat(radiobutton);
            }
            #endregion
            #region groupBox_1 builder

            int comboBox_1 = -6;
            int label_1 = -5;

            foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
            {
                comboBox_1 = comboBox_1 + 24;
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, comboBox_1);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_1.Controls.OfType<Label>())
            {
                label_1 = label_1 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_1);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_2 builder

            int comboBox_2 = -6;
            int label_2 = -5;

            foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
            {
                comboBox_2 = comboBox_2 + 24;
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, comboBox_2);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_2.Controls.OfType<Label>())
            {
                label_2 = label_2 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_2);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_3 builder

            int comboBox_3 = -6;
            int label_3 = -5;

            foreach (var combobox in this.groupBox_3.Controls.OfType<ComboBox>())
            {
                comboBox_3 = comboBox_3 + 24;
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, comboBox_3);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_3.Controls.OfType<Label>())
            {
                label_3 = label_3 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_3);
                MyFormats.LabelFormat(label);
            }
            #endregion
        }
    }
}