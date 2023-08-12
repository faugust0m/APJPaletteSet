using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace APJPaletteSet
{    
    partial class MatTetoPalette
    {
        private IContainer components = null;
        #region Lista de Controles
        private Panel panel;
        private Label label;
        private PictureBox picture;

        private GroupBox groupBox_0;
        private Label label_61_0;
        private ComboBox comboBox_61_0;
        private ToolTip toolTip_61_0;
        private Label label_61_1;
        private ComboBox comboBox_61_1;
        private ToolTip toolTip_61_1;
        private Label label_61_2;
        private ComboBox comboBox_61_2;
        private ToolTip toolTip_61_2;
        private Label label_61_3;
        private ComboBox comboBox_61_3;
        private ToolTip toolTip_61_3;
        private Label label_61_4;
        private ComboBox comboBox_61_4;
        private ToolTip toolTip_61_4;
        private Label label_61_5;
        private ComboBox comboBox_61_5;
        private ToolTip toolTip_61_5;
        private Label label_61_6;
        private ComboBox comboBox_61_6;
        private ToolTip toolTip_61_6;
        private LinkLabel linkLabel;
        private ToolTip toolTip_link;
        private RadioButton radioButton_61_1;
        private RadioButton radioButton_61_2;
        private RadioButton radioButton_61_3;
        private RadioButton radioButton_61_4;
        private RadioButton radioButton_61_5;
        private RadioButton radioButton_61_6;
        private RadioButton radioButton_61_7;
        private RadioButton radioButton_61_8;
        private RadioButton radioButton_61_9;
        private RadioButton radioButton_61_10;
        private RadioButton radioButton_61_11;
        private RadioButton radioButton_61_12;
        private ToolTip toolTip_radio;
        #endregion
        private void InitializeComponent()
        {
            #region Lista de Controles
            this.panel = new ExPanel();
            this.label = new Label();
            this.picture = new PictureBox();

            this.components = new Container();

            this.groupBox_0 = new GroupBox();
            this.label_61_0 = new Label();
            this.comboBox_61_0 = new ComboBox();
            this.toolTip_61_0 = new ToolTip(this.components);
            this.label_61_1 = new Label();
            this.comboBox_61_1 = new ComboBox();
            this.toolTip_61_1 = new ToolTip(this.components);
            this.label_61_2 = new Label();
            this.comboBox_61_2 = new ComboBox();
            this.toolTip_61_2 = new ToolTip(this.components);
            this.label_61_3 = new Label();
            this.comboBox_61_3 = new ComboBox();
            this.toolTip_61_3 = new ToolTip(this.components);
            this.label_61_4 = new Label();
            this.comboBox_61_4 = new ComboBox();
            this.toolTip_61_4 = new ToolTip(this.components);
            this.label_61_5 = new Label();
            this.comboBox_61_5 = new ComboBox();
            this.toolTip_61_5 = new ToolTip(this.components);
            this.label_61_6 = new Label();
            this.comboBox_61_6 = new ComboBox();
            this.toolTip_61_6 = new ToolTip(this.components);
            this.linkLabel = new LinkLabel();
            this.toolTip_link = new ToolTip(this.components);
            this.radioButton_61_1 = new RadioButton();
            this.radioButton_61_2 = new RadioButton();
            this.radioButton_61_3 = new RadioButton();
            this.radioButton_61_4 = new RadioButton();
            this.radioButton_61_5 = new RadioButton();
            this.radioButton_61_6 = new RadioButton();
            this.radioButton_61_7 = new RadioButton();
            this.radioButton_61_8 = new RadioButton();
            this.radioButton_61_9 = new RadioButton();
            this.radioButton_61_10 = new RadioButton();
            this.radioButton_61_11 = new RadioButton();
            this.radioButton_61_12 = new RadioButton();
            this.toolTip_radio = new ToolTip(this.components);
            #endregion
            #region panel + label + picture
            this.panel.Controls.Add(this.groupBox_0);
            
            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);
            MyFormats.PictureFormat(picture);

            #endregion
            #region  groupBox_0
            this.groupBox_0.Controls.Add(this.label_61_0);
            this.groupBox_0.Controls.Add(this.comboBox_61_0);
            this.groupBox_0.Controls.Add(this.label_61_1);
            this.groupBox_0.Controls.Add(this.comboBox_61_1);
            this.groupBox_0.Controls.Add(this.label_61_2);
            this.groupBox_0.Controls.Add(this.comboBox_61_2);
            this.groupBox_0.Controls.Add(this.label_61_3);
            this.groupBox_0.Controls.Add(this.comboBox_61_3);
            this.groupBox_0.Controls.Add(this.label_61_4);
            this.groupBox_0.Controls.Add(this.comboBox_61_4);
            this.groupBox_0.Controls.Add(this.label_61_5);
            this.groupBox_0.Controls.Add(this.comboBox_61_5);
            this.groupBox_0.Controls.Add(this.label_61_6);
            this.groupBox_0.Controls.Add(this.comboBox_61_6);
            this.groupBox_0.Controls.Add(this.linkLabel);
            this.groupBox_0.Controls.Add(this.radioButton_61_1);
            this.groupBox_0.Controls.Add(this.radioButton_61_2);
            this.groupBox_0.Controls.Add(this.radioButton_61_3);
            this.groupBox_0.Controls.Add(this.radioButton_61_4);
            this.groupBox_0.Controls.Add(this.radioButton_61_5);
            this.groupBox_0.Controls.Add(this.radioButton_61_6);
            this.groupBox_0.Controls.Add(this.radioButton_61_7);
            this.groupBox_0.Controls.Add(this.radioButton_61_8);
            this.groupBox_0.Controls.Add(this.radioButton_61_9);
            this.groupBox_0.Controls.Add(this.radioButton_61_10);
            this.groupBox_0.Controls.Add(this.radioButton_61_11);
            this.groupBox_0.Controls.Add(this.radioButton_61_12);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Text = "Materiais de Teto";
            this.groupBox_0.Name = "groupBox_0";
            //
            // radioButtons
            //
            this.radioButton_61_1.Name = "radioButton_61_1";
            this.radioButton_61_1.Text = "01";
            this.radioButton_61_1.Location = new Point(10, 20);

            this.radioButton_61_2.Name = "radioButton_61_2";
            this.radioButton_61_2.Text = "02";
            this.radioButton_61_2.Location = new Point(50, 20);

            this.radioButton_61_3.Name = "radioButton_61_3";
            this.radioButton_61_3.Text = "03";
            this.radioButton_61_3.Location = new Point(90, 20);

            this.radioButton_61_4.Name = "radioButton_61_4";
            this.radioButton_61_4.Text = "04";
            this.radioButton_61_4.Location = new Point(130, 20);

            this.radioButton_61_5.Name = "radioButton_61_5";
            this.radioButton_61_5.Text = "05";
            this.radioButton_61_5.Location = new Point(170, 20);

            this.radioButton_61_6.Name = "radioButton_61_6";
            this.radioButton_61_6.Text = "06";
            this.radioButton_61_6.Location = new Point(210, 20);

            this.radioButton_61_7.Name = "radioButton_61_7";
            this.radioButton_61_7.Text = "07";
            this.radioButton_61_7.Location = new Point(10, 40);

            this.radioButton_61_8.Name = "radioButton_61_8";
            this.radioButton_61_8.Text = "08";
            this.radioButton_61_8.Location = new Point(50, 40);

            this.radioButton_61_9.Name = "radioButton_61_9";
            this.radioButton_61_9.Text = "09";
            this.radioButton_61_9.Location = new Point(90, 40);

            this.radioButton_61_10.Name = "radioButton_61_10";
            this.radioButton_61_10.Text = "10";
            this.radioButton_61_10.Location = new Point(130, 40);

            this.radioButton_61_11.Name = "radioButton_61_11";
            this.radioButton_61_11.Text = "11";
            this.radioButton_61_11.Location = new Point(170, 40);

            this.radioButton_61_12.Name = "radioButton_61_12";
            this.radioButton_61_12.Text = "12";
            this.radioButton_61_12.Location = new Point(210, 40);
            //
            // textBoxes
            //
            this.label_61_0.Name = "label_61_0";
            this.label_61_0.Text = "Material:";
            this.comboBox_61_0.Name = "comboBox_61_0";
            this.comboBox_61_0.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 0);
            };
            string tooltip_61_0 = "Selecione a partir da lista o nome do material\n" +
                                  "de teto relacionado ao índice selecionado;\n" +
                                  MyTooltips.Metodo();
            this.toolTip_61_0.SetToolTip(this.label_61_0, tooltip_61_0);
            this.toolTip_61_0.SetToolTip(this.comboBox_61_0, tooltip_61_0);

            this.label_61_1.Name = "label_61_1";
            this.label_61_1.Text = "- Abreviado:";
            this.comboBox_61_1.Name = "comboBox_61_1";
            this.comboBox_61_1.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 1);
            };
            string tooltip_61_1 = "Selecione a partir da lista o nome abreviado\n" +
                                  "do material relacionado ao índice selecionado;\n" +
                                  MyTooltips.Metodo();
            this.toolTip_61_1.SetToolTip(this.label_61_1, tooltip_61_1);
            this.toolTip_61_1.SetToolTip(this.comboBox_61_1, tooltip_61_1);

            this.label_61_2.Name = "label_61_2";
            this.label_61_2.Text = "- Alternativo:";
            this.comboBox_61_2.Name = "comboBox_61_2";
            this.comboBox_61_2.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 2);
            };
            string tooltip_61_2 = "Selecione a partir da lista o nome do material\n" +
                                  "alternativo relacionado ao índice selecionado;\n" +
                                  MyTooltips.Metodo();
            this.toolTip_61_2.SetToolTip(this.label_61_2, tooltip_61_2);
            this.toolTip_61_2.SetToolTip(this.comboBox_61_2, tooltip_61_2);

            this.label_61_3.Name = "label_61_3";
            this.label_61_3.Text = "Altura:";
            this.comboBox_61_3.Name = "comboBox_61_3";
            this.comboBox_61_3.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 3);
            };
            string tooltip_61_3 = "Selecione a partir da lista a altura\n" +
                                  "relacionada ao índice selecionado;\n" +
                                  MyTooltips.Metodo();
            this.toolTip_61_3.SetToolTip(this.label_61_3, tooltip_61_3);
            this.toolTip_61_3.SetToolTip(this.comboBox_61_3, tooltip_61_3);
            
            this.label_61_4.Name = "label_61_4";
            this.label_61_4.Text = "Dimensão:";
            this.comboBox_61_4.Name = "comboBox_61_4";
            this.comboBox_61_4.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 4);
            };
            this.label_61_5.Name = "label_61_5";
            this.label_61_5.Text = "Acabamento:";
            this.comboBox_61_5.Name = "comboBox_61_5";
            this.comboBox_61_5.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 5);
            };
            this.label_61_6.Name = "label_61_6";
            this.label_61_6.Text = "Fabricante:";
            this.comboBox_61_6.Name = "comboBox_61_6";
            this.comboBox_61_6.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 6);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 3);
            };
            #endregion

            int _padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "MatTetoPalette";
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

            this.radioButton_61_1.Checked = true;
            this.comboBox_61_0.Text = MyProject.GetDetailValue(61, 0);
            this.comboBox_61_1.Text = MyProject.GetDetailValue(61, 1);
            this.comboBox_61_2.Text = MyProject.GetDetailValue(61, 2);
            this.comboBox_61_3.Text = MyProject.GetDetailValue(61, 3);
            this.comboBox_61_4.Text = MyProject.GetDetailValue(61, 4);
            this.comboBox_61_5.Text = MyProject.GetDetailValue(61, 5);
            this.comboBox_61_6.Text = MyProject.GetDetailValue(61, 6);

            foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Teto"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_61_0.Items.Add(value);
                this.comboBox_61_2.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("TetoAbreviado"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_61_1.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Altura"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_61_3.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Dimensão"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_61_4.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Acabamento"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_61_5.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("FabricanteTeto"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_61_6.Items.Add(value);
            }
        }
        internal void FillList(string combobox)
        {
            switch (combobox)
            {
                case "comboBox_61_0":
                    comboBox_61_0.Items.Clear();
                    comboBox_61_2.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Teto"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_61_0.Items.Add(value);
                        comboBox_61_2.Items.Add(value);
                    }
                    break;
                case "comboBox_61_1":
                    comboBox_61_1.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("TetoAbreviado"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_61_1.Items.Add(value);
                    }
                    break;
                case "comboBox_61_3":
                    comboBox_61_3.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Altura"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_61_3.Items.Add(value);
                    }
                    break;
                case "comboBox_61_4":
                    comboBox_61_4.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Dimensão"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_61_4.Items.Add(value);
                    }
                    break;
                case "comboBox_61_5":
                    comboBox_61_5.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Acabamento"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_61_5.Items.Add(value);
                    }
                    break;
                case "comboBox_61_6":
                    comboBox_61_6.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("FabricanteTeto"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_61_6.Items.Add(value);
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
            #endregion
            #region groupBox_0 builder

            int comboBox_0 = 43;
            int label_0 = 44;

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
        }
     }
}
