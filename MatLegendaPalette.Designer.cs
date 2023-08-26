using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class MatLegendaPalette
    {
        #region Lista de Controles
        private Panel panel;
        private Label label;
        private PictureBox picture;

        private Label space_0;
        private Label space_1;
        private Label space_2;
        private Label space_3;
        private Label space_4;
        private Label space_5;

        private GroupBox groupBox_0;
        private Label label_106_0;
        private ComboBox comboBox_106_0;
        private Label label_106_1;
        private ComboBox comboBox_106_1;
        private Label label_106_2;
        private ComboBox comboBox_106_2;
        private Label label_106_3;
        private ComboBox comboBox_106_3;
        private Label label_106_4;
        private ComboBox comboBox_106_4;
        private Label label_106_5;
        private ComboBox comboBox_106_5;
        private LinkLabel linkLabel;

        private GroupBox groupBox_1;
        
        private GroupBox groupBox_2;
        
        private GroupBox groupBox_3;
        
        private GroupBox groupBox_4;
        
        private GroupBox groupBox_5;
        
        private GroupBox groupBox_6;
        
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
            this.space_3 = new Label();
            this.space_4 = new Label();
            this.space_5 = new Label();

            this.groupBox_0 = new GroupBox();
            this.label_106_0 = new Label();
            this.comboBox_106_0 = new ComboBox();
            this.label_106_1 = new Label();
            this.comboBox_106_1 = new ComboBox();
            this.label_106_2 = new Label();
            this.comboBox_106_2 = new ComboBox();
            this.label_106_3 = new Label();
            this.comboBox_106_3 = new ComboBox();
            this.label_106_4 = new Label();
            this.comboBox_106_4 = new ComboBox();
            this.label_106_5 = new Label();
            this.comboBox_106_5 = new ComboBox();
            this.linkLabel = new LinkLabel();

            this.groupBox_1 = new GroupBox();

            this.groupBox_2 = new GroupBox();

            this.groupBox_3 = new GroupBox();

            this.groupBox_4 = new GroupBox();

            this.groupBox_5 = new GroupBox();

            this.groupBox_6 = new GroupBox();
            #endregion
            #region panel + label + picture
            this.panel.Controls.Add(this.groupBox_6);
            this.panel.Controls.Add(this.space_5);
            this.panel.Controls.Add(this.groupBox_5);
            this.panel.Controls.Add(this.space_4);
            this.panel.Controls.Add(this.groupBox_4);
            this.panel.Controls.Add(this.space_3);
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
            this.groupBox_0.Controls.Add(this.label_106_0);
            this.groupBox_0.Controls.Add(this.comboBox_106_0);
            this.groupBox_0.Controls.Add(this.label_106_1);
            this.groupBox_0.Controls.Add(this.comboBox_106_1);
            this.groupBox_0.Controls.Add(this.label_106_2);
            this.groupBox_0.Controls.Add(this.comboBox_106_2);
            this.groupBox_0.Controls.Add(this.label_106_3);
            this.groupBox_0.Controls.Add(this.comboBox_106_3);
            this.groupBox_0.Controls.Add(this.label_106_4);
            this.groupBox_0.Controls.Add(this.comboBox_106_4);
            this.groupBox_0.Controls.Add(this.label_106_5);
            this.groupBox_0.Controls.Add(this.comboBox_106_5);
            this.groupBox_0.Controls.Add(this.linkLabel);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Text = "Mármore";
            this.groupBox_0.Name = "groupBox_0";
            //
            // ComboBoxes
            //
            this.label_106_0.Name = "label_106_0";
            this.label_106_0.Text = "01";
            this.comboBox_106_0.Name = "comboBox_106_0";
            this.comboBox_106_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 106, 0);
            };
            this.label_106_1.Name = "label_106_1";
            this.label_106_1.Text = "02";
            this.comboBox_106_1.Name = "comboBox_106_1";
            this.comboBox_106_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 106, 1);
            };
            this.label_106_2.Name = "label_106_2";
            this.label_106_2.Text = "03";
            this.comboBox_106_2.Name = "comboBox_106_2";
            this.comboBox_106_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 106, 2);
            };
            this.label_106_3.Name = "label_106_3";
            this.label_106_3.Text = "04";
            this.comboBox_106_3.Name = "comboBox_106_3";
            this.comboBox_106_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 106, 3);
            };
            this.label_106_4.Name = "label_106_4";
            this.label_106_4.Text = "05";
            this.comboBox_106_4.Name = "comboBox_106_4";
            this.comboBox_106_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 106, 4);
            };
            this.label_106_5.Name = "label_106_5";
            this.label_106_5.Text = "06";
            this.comboBox_106_5.Name = "comboBox_106_5";
            this.comboBox_106_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 106, 5);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
            #endregion
            #region  groupBox_1
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Espelhos";
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new Size(300, 95);
            //
            // ComboBoxes
            //
            #endregion
            #region  groupBox_2
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.Text = "Forro";
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new Size(300, 320);
            //
            // ComboBoxes
            //
            #endregion
            #region groupBox_3
            this.groupBox_3.TabIndex = 3;
            this.groupBox_3.Text = "Marcenaria";
            this.groupBox_3.Name = "groupBox_3";
            this.groupBox_3.Size = new Size(300, 190);
            //
            // ComboBoxes
            //
            #endregion
            #region  groupBox_4
            this.groupBox_4.TabIndex = 4;
            this.groupBox_4.Text = "Pisos";
            this.groupBox_4.Name = "groupBox_4";
            this.groupBox_4.Size = new Size(300, 320);
            //
            // ComboBoxes
            //
            #endregion
            #region  groupBox_5
            this.groupBox_5.TabIndex = 5;
            this.groupBox_5.Text = "Revestimentos";
            this.groupBox_5.Name = "groupBox_5";
            this.groupBox_5.Size = new Size(300, 335);
            //
            // ComboBoxes
            //
            #endregion
            #region  groupBox_6
            this.groupBox_6.TabIndex = 6;
            this.groupBox_6.Text = "Vidros";
            this.groupBox_6.Name = "groupBox_6";
            this.groupBox_6.Size = new Size(300, 142);
            //
            // ComboBoxes
            //
            #endregion

            int _padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "MatLegendaPalette";
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
            #region Fill groupBox_0

            this.comboBox_106_0.Text = MyProject.GetDetailValue(106, 0);
            this.comboBox_106_1.Text = MyProject.GetDetailValue(106, 1);
            this.comboBox_106_2.Text = MyProject.GetDetailValue(106, 2);
            this.comboBox_106_3.Text = MyProject.GetDetailValue(106, 3);
            this.comboBox_106_4.Text = MyProject.GetDetailValue(106, 4);
            this.comboBox_106_5.Text = MyProject.GetDetailValue(106, 5);
            
            foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Mármore"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_106_0.Items.Add(value);
                this.comboBox_106_1.Items.Add(value);
                this.comboBox_106_2.Items.Add(value);
                this.comboBox_106_3.Items.Add(value);
                this.comboBox_106_4.Items.Add(value);
                this.comboBox_106_5.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_1
            #endregion
            #region Fill groupBox_2
            #endregion
            #region Fill groupBox_3
            #endregion
            #region Fill groupBox_4
            #endregion
            #region Fill groupBox_5
            #endregion
            #region Fill groupBox_6
            #endregion
        }
        internal void FillList(string _combobox)
        {
            switch (_combobox)
            {
                case "comboBox_106_0":
                    foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Mármore"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_106_0.Items.Add(value);
                        this.comboBox_106_1.Items.Add(value);
                        this.comboBox_106_2.Items.Add(value);
                        this.comboBox_106_3.Items.Add(value);
                        this.comboBox_106_4.Items.Add(value);
                        this.comboBox_106_5.Items.Add(value);
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

            int comboBox_0 = -6;
            int label_0 = -5;

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

            int comboBox_2 = 4;
            int label_2 = -17;

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
            #region groupBox_4 builder

            int comboBox_4 = 4;
            int label_4 = -17;

            foreach (var combobox in this.groupBox_4.Controls.OfType<ComboBox>())
            {
                comboBox_4 = comboBox_4 + 24;
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, comboBox_4);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_4.Controls.OfType<Label>())
            {
                label_4 = label_4 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_4);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_5 builder

            int comboBox_5 = -6;
            int label_5 = -5;

            foreach (var combobox in this.groupBox_5.Controls.OfType<ComboBox>())
            {
                comboBox_5 = comboBox_5 + 24;
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, comboBox_5);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_5.Controls.OfType<Label>())
            {
                label_5 = label_5 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_5);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_6 builder

            int comboBox_6 = -6;
            int label_6 = -5;

            foreach (var combobox in this.groupBox_6.Controls.OfType<ComboBox>())
            {
                comboBox_6 = comboBox_6 + 24;
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, comboBox_6);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_6.Controls.OfType<Label>())
            {
                label_6 = label_6 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_6);
                MyFormats.LabelFormat(label);
            }
            #endregion
        }
    }
}