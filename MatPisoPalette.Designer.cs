using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace APJPaletteSet
{
    partial class MatPisoPalette
    {
        private IContainer components = null;
        string bk = "\n";
        #region Lista de Controles
        private Panel panel;
        private Label label;
        private PictureBox picture;

        private Label space_0;
        private Label space_1;

        private GroupBox groupBox_0;
        private Label label_5_0;
        private ComboBox comboBox_5_0;
        private ToolTip toolTip_5_0;
        private Label label_5_1;
        private ComboBox comboBox_5_1;
        private ToolTip toolTip_5_1;
        private Label label_5_2;
        private ComboBox comboBox_5_2;
        private ToolTip toolTip_5_2;
        private Label label_5_3;
        private ComboBox comboBox_5_3;
        private ToolTip toolTip_5_3;
        private Label label_5_4;
        private ComboBox comboBox_5_4;
        private ToolTip toolTip_5_4;
        private Label label_5_5;
        private ComboBox comboBox_5_5;
        private ToolTip toolTip_5_5;
        private Label label_5_6;
        private ComboBox comboBox_5_6;
        private ToolTip toolTip_5_6;
        private Label label_5_7;
        private TextBox textBox_5_7;
        private ToolTip toolTip_5_7;
        private Label label_5_8;
        private TextBox textBox_5_8;
        private ToolTip toolTip_5_8;
        private LinkLabel linkLabel;
        private ToolTip toolTip_link;
        private RadioButton radioButton_5_1;
        private RadioButton radioButton_5_2;
        private RadioButton radioButton_5_3;
        private RadioButton radioButton_5_4;
        private RadioButton radioButton_5_5;
        private RadioButton radioButton_5_6;
        private RadioButton radioButton_5_7;
        private RadioButton radioButton_5_8;
        private RadioButton radioButton_5_9;
        private RadioButton radioButton_5_10;
        private RadioButton radioButton_5_11;
        private RadioButton radioButton_5_12;
        private ToolTip toolTip_radio;

        private GroupBox groupBox_1;
        private Label label_19_0;
        private ComboBox comboBox_19_0;
        private Label label_19_1;
        private ComboBox comboBox_19_1;
        private RadioButton radioButton_19_1;
        private RadioButton radioButton_19_2;
        private RadioButton radioButton_19_3;
        private RadioButton radioButton_19_4;
        private RadioButton radioButton_19_5;
        private RadioButton radioButton_19_6;
        private RadioButton radioButton_19_7;
        private RadioButton radioButton_19_8;
        private RadioButton radioButton_19_9;
        private RadioButton radioButton_19_10;
        private RadioButton radioButton_19_11;
        private RadioButton radioButton_19_12;

        private GroupBox groupBox_2;
        private Label label_33_0;
        private ComboBox comboBox_33_0;
        private Label label_33_1;
        private ComboBox comboBox_33_1;
        private RadioButton radioButton_33_1;
        private RadioButton radioButton_33_2;
        private RadioButton radioButton_33_3;
        private RadioButton radioButton_33_4;
        private RadioButton radioButton_33_5;
        private RadioButton radioButton_33_6;
        private RadioButton radioButton_33_7;
        private RadioButton radioButton_33_8;
        private RadioButton radioButton_33_9;
        private RadioButton radioButton_33_10;
        private RadioButton radioButton_33_11;
        private RadioButton radioButton_33_12;
        #endregion
        private void InitializeComponent()
        {
            #region Lista de Controles

            this.panel = new ExPanel();
            this.label = new Label();
            this.picture = new PictureBox();

            this.space_0 = new Label();
            this.space_1 = new Label();

            this.components = new Container();

            this.groupBox_0 = new GroupBox();
            this.label_5_0 = new Label();
            this.comboBox_5_0 = new ComboBox();
            this.toolTip_5_0 = new ToolTip(this.components);
            this.label_5_1 = new Label();
            this.comboBox_5_1 = new ComboBox();
            this.toolTip_5_1 = new ToolTip(this.components);
            this.label_5_2 = new Label();
            this.comboBox_5_2 = new ComboBox();
            this.toolTip_5_2 = new ToolTip(this.components);
            this.label_5_3 = new Label();
            this.comboBox_5_3 = new ComboBox();
            this.toolTip_5_3 = new ToolTip(this.components);
            this.label_5_4 = new Label();
            this.comboBox_5_4 = new ComboBox();
            this.toolTip_5_4 = new ToolTip(this.components);
            this.label_5_5 = new Label();
            this.comboBox_5_5 = new ComboBox();
            this.toolTip_5_5 = new ToolTip(this.components);
            this.label_5_6 = new Label();
            this.comboBox_5_6 = new ComboBox();
            this.toolTip_5_6 = new ToolTip(this.components);
            this.label_5_7 = new Label();
            this.textBox_5_7 = new TextBox();
            this.toolTip_5_7 = new ToolTip(this.components);
            this.label_5_8 = new Label();
            this.textBox_5_8 = new TextBox();
            this.toolTip_5_8 = new ToolTip(this.components);
            this.linkLabel = new LinkLabel();
            this.toolTip_link = new ToolTip(this.components);
            this.radioButton_5_1 = new RadioButton();
            this.radioButton_5_2 = new RadioButton();
            this.radioButton_5_3 = new RadioButton();
            this.radioButton_5_4 = new RadioButton();
            this.radioButton_5_5 = new RadioButton();
            this.radioButton_5_6 = new RadioButton();
            this.radioButton_5_7 = new RadioButton();
            this.radioButton_5_8 = new RadioButton();
            this.radioButton_5_9 = new RadioButton();
            this.radioButton_5_10 = new RadioButton();
            this.radioButton_5_11 = new RadioButton();
            this.radioButton_5_12 = new RadioButton();
            this.toolTip_radio = new ToolTip(this.components);

            this.groupBox_1 = new GroupBox();
            this.label_19_0 = new Label();
            this.comboBox_19_0 = new ComboBox();
            this.label_19_1 = new Label();
            this.comboBox_19_1 = new ComboBox();
            this.radioButton_19_1 = new RadioButton();
            this.radioButton_19_2 = new RadioButton();
            this.radioButton_19_3 = new RadioButton();
            this.radioButton_19_4 = new RadioButton();
            this.radioButton_19_5 = new RadioButton();
            this.radioButton_19_6 = new RadioButton();
            this.radioButton_19_7 = new RadioButton();
            this.radioButton_19_8 = new RadioButton();
            this.radioButton_19_9 = new RadioButton();
            this.radioButton_19_10 = new RadioButton();
            this.radioButton_19_11 = new RadioButton();
            this.radioButton_19_12 = new RadioButton();

            this.groupBox_2 = new GroupBox();
            this.label_33_0 = new Label();
            this.comboBox_33_0 = new ComboBox();
            this.label_33_1 = new Label();
            this.comboBox_33_1 = new ComboBox();
            this.radioButton_33_1 = new RadioButton();
            this.radioButton_33_2 = new RadioButton();
            this.radioButton_33_3 = new RadioButton();
            this.radioButton_33_4 = new RadioButton();
            this.radioButton_33_5 = new RadioButton();
            this.radioButton_33_6 = new RadioButton();
            this.radioButton_33_7 = new RadioButton();
            this.radioButton_33_8 = new RadioButton();
            this.radioButton_33_9 = new RadioButton();
            this.radioButton_33_10 = new RadioButton();
            this.radioButton_33_11 = new RadioButton();
            this.radioButton_33_12 = new RadioButton();
            #endregion
            #region panel + label + picture
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
            this.groupBox_0.Controls.Add(this.label_5_0);
            this.groupBox_0.Controls.Add(this.comboBox_5_0);
            this.groupBox_0.Controls.Add(this.label_5_1);
            this.groupBox_0.Controls.Add(this.comboBox_5_1);
            this.groupBox_0.Controls.Add(this.label_5_2);
            this.groupBox_0.Controls.Add(this.comboBox_5_2);
            this.groupBox_0.Controls.Add(this.label_5_3);
            this.groupBox_0.Controls.Add(this.comboBox_5_3);
            this.groupBox_0.Controls.Add(this.label_5_4);
            this.groupBox_0.Controls.Add(this.comboBox_5_4);
            this.groupBox_0.Controls.Add(this.label_5_5);
            this.groupBox_0.Controls.Add(this.comboBox_5_5);
            this.groupBox_0.Controls.Add(this.label_5_6);
            this.groupBox_0.Controls.Add(this.comboBox_5_6);
            this.groupBox_0.Controls.Add(this.label_5_7);
            this.groupBox_0.Controls.Add(this.textBox_5_7);
            this.groupBox_0.Controls.Add(this.label_5_8);
            this.groupBox_0.Controls.Add(this.textBox_5_8);
            this.groupBox_0.Controls.Add(this.linkLabel);
            this.groupBox_0.Controls.Add(this.radioButton_5_1);
            this.groupBox_0.Controls.Add(this.radioButton_5_2);
            this.groupBox_0.Controls.Add(this.radioButton_5_3);
            this.groupBox_0.Controls.Add(this.radioButton_5_4);
            this.groupBox_0.Controls.Add(this.radioButton_5_5);
            this.groupBox_0.Controls.Add(this.radioButton_5_6);
            this.groupBox_0.Controls.Add(this.radioButton_5_7);
            this.groupBox_0.Controls.Add(this.radioButton_5_8);
            this.groupBox_0.Controls.Add(this.radioButton_5_9);
            this.groupBox_0.Controls.Add(this.radioButton_5_10);
            this.groupBox_0.Controls.Add(this.radioButton_5_11);
            this.groupBox_0.Controls.Add(this.radioButton_5_12);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Text = "Materiais de Piso/Rodapé";
            this.groupBox_0.Name = "groupBox_0";
            this.groupBox_0.Size = new Size(300, 285);
            //
            // radioButtons
            //
            this.radioButton_5_1.Name = "radioButton_5_1";
            this.radioButton_5_1.Text = "01";
            this.radioButton_5_1.Location = new Point(10, 20);
            this.toolTip_radio.SetToolTip(this.radioButton_5_1, MyTooltips.Radio());
            this.radioButton_5_2.Name = "radioButton_5_2";
            this.radioButton_5_2.Text = "02";
            this.radioButton_5_2.Location = new Point(50, 20);
            this.toolTip_radio.SetToolTip(this.radioButton_5_2, MyTooltips.Radio());
            this.radioButton_5_3.Name = "radioButton_5_3";
            this.radioButton_5_3.Text = "03";
            this.radioButton_5_3.Location = new Point(90, 20);
            this.toolTip_radio.SetToolTip(this.radioButton_5_3, MyTooltips.Radio());
            this.radioButton_5_4.Name = "radioButton_5_4";
            this.radioButton_5_4.Text = "04";
            this.radioButton_5_4.Location = new Point(130, 20);
            this.toolTip_radio.SetToolTip(this.radioButton_5_4, MyTooltips.Radio());
            this.radioButton_5_5.Name = "radioButton_5_5";
            this.radioButton_5_5.Text = "05";
            this.radioButton_5_5.Location = new Point(170, 20);
            this.toolTip_radio.SetToolTip(this.radioButton_5_5, MyTooltips.Radio());
            this.radioButton_5_6.Name = "radioButton_5_6";
            this.radioButton_5_6.Text = "06";
            this.radioButton_5_6.Location = new Point(210, 20);
            this.toolTip_radio.SetToolTip(this.radioButton_5_6, MyTooltips.Radio());
            this.radioButton_5_7.Name = "radioButton_5_7";
            this.radioButton_5_7.Text = "07";
            this.radioButton_5_7.Location = new Point(10, 40);
            this.toolTip_radio.SetToolTip(this.radioButton_5_7, MyTooltips.Radio());
            this.radioButton_5_8.Name = "radioButton_5_8";
            this.radioButton_5_8.Text = "08";
            this.radioButton_5_8.Location = new Point(50, 40);
            this.toolTip_radio.SetToolTip(this.radioButton_5_8, MyTooltips.Radio());
            this.radioButton_5_9.Name = "radioButton_5_9";
            this.radioButton_5_9.Text = "09";
            this.radioButton_5_9.Location = new Point(90, 40);
            this.toolTip_radio.SetToolTip(this.radioButton_5_9, MyTooltips.Radio());
            this.radioButton_5_10.Name = "radioButton_5_10";
            this.radioButton_5_10.Text = "10";
            this.radioButton_5_10.Location = new Point(130, 40);
            this.toolTip_radio.SetToolTip(this.radioButton_5_10, MyTooltips.Radio());
            this.radioButton_5_11.Name = "radioButton_5_11";
            this.radioButton_5_11.Text = "11";
            this.radioButton_5_11.Location = new Point(170, 40);
            this.toolTip_radio.SetToolTip(this.radioButton_5_11, MyTooltips.Radio());
            this.radioButton_5_12.Name = "radioButton_5_12";
            this.radioButton_5_12.Text = "12";
            this.radioButton_5_12.Location = new Point(210, 40);
            this.toolTip_radio.SetToolTip(this.radioButton_5_12, MyTooltips.Radio());
            //
            // textBoxes
            //
            this.label_5_0.Name = "label_5_0";
            this.label_5_0.Text = "Material:";
            this.comboBox_5_0.Name = "comboBox_5_0";
            this.comboBox_5_0.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 0);
            };
            string tooltip_5_0 = MyTooltips.ComboBoxList("o nome do material de piso") + bk +
                                 MyTooltips.Tag();
            this.toolTip_5_0.SetToolTip(this.label_5_0, tooltip_5_0);
            this.toolTip_5_0.SetToolTip(this.comboBox_5_0, tooltip_5_0);

            this.label_5_1.Name = "label_5_1";
            this.label_5_1.Text = "- Abreviado:";
            this.comboBox_5_1.Name = "comboBox_5_1";
            this.comboBox_5_1.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 1);
            };
            this.label_5_2.Name = "label_5_2";
            this.label_5_2.Text = "- Alternativo:";
            this.comboBox_5_2.Name = "comboBox_5_2";
            this.comboBox_5_2.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 2);
            };
            this.label_5_3.Name = "label_5_3";
            this.label_5_3.Text = "Dimensão:";
            this.comboBox_5_3.Name = "comboBox_5_3";
            this.comboBox_5_3.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 3);
            };
            this.label_5_4.Name = "label_5_4";
            this.label_5_4.Text = "Acabamento:";
            this.comboBox_5_4.Name = "comboBox_5_4";
            this.comboBox_5_4.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 4);
            };

            this.label_5_5.Name = "label_5_5";
            this.label_5_5.Text = "Fabricante:";
            this.comboBox_5_5.Name = "comboBox_5_5";
            this.comboBox_5_5.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 5);
            };
            this.label_5_6.Name = "label_5_6";
            this.label_5_6.Text = "Rodapé:";
            this.comboBox_5_6.Name = "comboBox_5_6";
            this.comboBox_5_6.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_0_LostFocus(sender, e, 6);
            };
            this.label_5_7.Name = "label_5_7";
            this.label_5_7.Text = "- Altura:";
            this.textBox_5_7.Name = "textBox_5_7";
            MyEvents.TextBoxEvents(textBox_5_7);

            this.label_5_8.Name = "label_5_8";
            this.label_5_8.Text = "- Largura:";
            this.textBox_5_8.Name = "textBox_5_8";
            MyEvents.TextBoxEvents(textBox_5_8);

            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 1);
            };
            this.toolTip_link.SetToolTip(this.linkLabel, MyTooltips.Link("de materiais relacionados ao piso"));
            #endregion
            #region  groupBox_1
            this.groupBox_1.Controls.Add(this.label_19_0);
            this.groupBox_1.Controls.Add(this.comboBox_19_0);
            this.groupBox_1.Controls.Add(this.label_19_1);
            this.groupBox_1.Controls.Add(this.comboBox_19_1);
            this.groupBox_1.Controls.Add(this.radioButton_19_1);
            this.groupBox_1.Controls.Add(this.radioButton_19_2);
            this.groupBox_1.Controls.Add(this.radioButton_19_3);
            this.groupBox_1.Controls.Add(this.radioButton_19_4);
            this.groupBox_1.Controls.Add(this.radioButton_19_5);
            this.groupBox_1.Controls.Add(this.radioButton_19_6);
            this.groupBox_1.Controls.Add(this.radioButton_19_7);
            this.groupBox_1.Controls.Add(this.radioButton_19_8);
            this.groupBox_1.Controls.Add(this.radioButton_19_9);
            this.groupBox_1.Controls.Add(this.radioButton_19_10);
            this.groupBox_1.Controls.Add(this.radioButton_19_11);
            this.groupBox_1.Controls.Add(this.radioButton_19_12);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Materiais de Soleira";
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new Size(300, 120);
            // 
            // radioButtons
            // 
            this.radioButton_19_1.Name = "radioButton_19_1";
            this.radioButton_19_1.Text = "01";
            this.radioButton_19_1.Location = new Point(10, 20);
            
            this.radioButton_19_2.Name = "radioButton_19_2";
            this.radioButton_19_2.Text = "02";
            this.radioButton_19_2.Location = new Point(50, 20);

            this.radioButton_19_3.Name = "radioButton_19_3";
            this.radioButton_19_3.Text = "03";
            this.radioButton_19_3.Location = new Point(90, 20);

            this.radioButton_19_4.Name = "radioButton_19_4";
            this.radioButton_19_4.Text = "04";
            this.radioButton_19_4.Location = new Point(130, 20);

            this.radioButton_19_5.Name = "radioButton_19_5";
            this.radioButton_19_5.Text = "05";
            this.radioButton_19_5.Location = new Point(170, 20);

            this.radioButton_19_6.Name = "radioButton_19_6";
            this.radioButton_19_6.Text = "06";
            this.radioButton_19_6.Location = new Point(210, 20);

            this.radioButton_19_7.Name = "radioButton_19_7";
            this.radioButton_19_7.Text = "07";
            this.radioButton_19_7.Location = new Point(10, 40);

            this.radioButton_19_8.Name = "radioButton_19_8";
            this.radioButton_19_8.Text = "08";
            this.radioButton_19_8.Location = new Point(50, 40);

            this.radioButton_19_9.Name = "radioButton_19_9";
            this.radioButton_19_9.Text = "09";
            this.radioButton_19_9.Location = new Point(90, 40);

            this.radioButton_19_10.Name = "radioButton_19_10";
            this.radioButton_19_10.Text = "10";
            this.radioButton_19_10.Location = new Point(130, 40);

            this.radioButton_19_11.Name = "radioButton_19_11";
            this.radioButton_19_11.Text = "11";
            this.radioButton_19_11.Location = new Point(170, 40);

            this.radioButton_19_12.Name = "radioButton_19_12";
            this.radioButton_19_12.Text = "12";
            this.radioButton_19_12.Location = new Point(210, 40);
            // 
            // textBoxes
            //
            this.label_19_0.Name = "label_19_0";
            this.label_19_0.Text = "Material:";
            this.comboBox_19_0.Name = "comboBox_19_0";
            this.comboBox_19_0.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_1_LostFocus(sender, e, 0);
            };
            this.label_19_1.Name = "label_19_1";
            this.label_19_1.Text = "- Abreviado:";
            this.comboBox_19_1.Name = "comboBox_19_1";
            this.comboBox_19_1.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_1_LostFocus(sender, e, 1);
            };
            #endregion
            #region  groupBox_2
            this.groupBox_2.Controls.Add(this.label_33_0);
            this.groupBox_2.Controls.Add(this.comboBox_33_0);
            this.groupBox_2.Controls.Add(this.label_33_1);
            this.groupBox_2.Controls.Add(this.comboBox_33_1);
            this.groupBox_2.Controls.Add(this.radioButton_33_1);
            this.groupBox_2.Controls.Add(this.radioButton_33_2);
            this.groupBox_2.Controls.Add(this.radioButton_33_3);
            this.groupBox_2.Controls.Add(this.radioButton_33_4);
            this.groupBox_2.Controls.Add(this.radioButton_33_5);
            this.groupBox_2.Controls.Add(this.radioButton_33_6);
            this.groupBox_2.Controls.Add(this.radioButton_33_7);
            this.groupBox_2.Controls.Add(this.radioButton_33_8);
            this.groupBox_2.Controls.Add(this.radioButton_33_9);
            this.groupBox_2.Controls.Add(this.radioButton_33_10);
            this.groupBox_2.Controls.Add(this.radioButton_33_11);
            this.groupBox_2.Controls.Add(this.radioButton_33_12);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.Text = "Materiais de Peitoril";
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new Size(300, 120);
            // 
            // radioButtons
            // 
            this.radioButton_33_1.Name = "radioButton_33_1";
            this.radioButton_33_1.Text = "01";
            this.radioButton_33_1.Location = new Point(10, 20);

            this.radioButton_33_2.Name = "radioButton_33_2";
            this.radioButton_33_2.Text = "02";
            this.radioButton_33_2.Location = new Point(50, 20);

            this.radioButton_33_3.Name = "radioButton_33_3";
            this.radioButton_33_3.Text = "03";
            this.radioButton_33_3.Location = new Point(90, 20);

            this.radioButton_33_4.Name = "radioButton_33_4";
            this.radioButton_33_4.Text = "04";
            this.radioButton_33_4.Location = new Point(130, 20);

            this.radioButton_33_5.Name = "radioButton_33_5";
            this.radioButton_33_5.Text = "05";
            this.radioButton_33_5.Location = new Point(170, 20);

            this.radioButton_33_6.Name = "radioButton_33_6";
            this.radioButton_33_6.Text = "06";
            this.radioButton_33_6.Location = new Point(210, 20);

            this.radioButton_33_7.Name = "radioButton_33_7";
            this.radioButton_33_7.Text = "07";
            this.radioButton_33_7.Location = new Point(10, 40);

            this.radioButton_33_8.Name = "radioButton_33_8";
            this.radioButton_33_8.Text = "08";
            this.radioButton_33_8.Location = new Point(50, 40);

            this.radioButton_33_9.Name = "radioButton_33_9";
            this.radioButton_33_9.Text = "09";
            this.radioButton_33_9.Location = new Point(90, 40);

            this.radioButton_33_10.Name = "radioButton_33_10";
            this.radioButton_33_10.Text = "10";
            this.radioButton_33_10.Location = new Point(130, 40);

            this.radioButton_33_11.Name = "radioButton_33_11";
            this.radioButton_33_11.Text = "11";
            this.radioButton_33_11.Location = new Point(170, 40);

            this.radioButton_33_12.Name = "radioButton_33_12";
            this.radioButton_33_12.Text = "12";
            this.radioButton_33_12.Location = new Point(210, 40);
            // 
            // textBoxes
            //
            this.label_33_0.Name = "label_33_0";
            this.label_33_0.Text = "Material:";
            this.comboBox_33_0.Name = "comboBox_33_0";
            this.comboBox_33_0.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_2_LostFocus(sender, e, 0);
            };
            this.label_33_1.Name = "label_33_1";
            this.label_33_1.Text = "- Abreviado:";
            this.comboBox_33_1.Name = "comboBox_33_1";
            this.comboBox_33_1.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_2_LostFocus(sender, e, 1);
            };
            #endregion

            int _padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "MatPisoPalette";
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
            this.radioButton_5_1.Checked = true;
            this.comboBox_5_0.Text = MyProject.GetDetailValue(5, 0);
            this.comboBox_5_1.Text = MyProject.GetDetailValue(5, 1);
            this.comboBox_5_2.Text = MyProject.GetDetailValue(5, 2);
            this.comboBox_5_3.Text = MyProject.GetDetailValue(5, 3);
            this.comboBox_5_4.Text = MyProject.GetDetailValue(5, 4);
            this.comboBox_5_5.Text = MyProject.GetDetailValue(5, 5);
            this.comboBox_5_6.Text = MyProject.GetDetailValue(5, 6);
            this.textBox_5_7.Text = MyProject.GetDetailValue(5, 7);
            this.textBox_5_8.Text = MyProject.GetDetailValue(5, 8);

            foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Piso"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_5_0.Items.Add(value);
                this.comboBox_5_2.Items.Add(value);
                this.comboBox_5_6.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("PisoAbreviado"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_5_1.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Dimensão"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_5_3.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("AcabamentoPiso"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_5_4.Items.Add(value);
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("FabricantePiso"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_5_5.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_1
            this.radioButton_19_1.Checked = true;
            this.comboBox_19_0.Text = MyProject.GetDetailValue(19, 0);
            this.comboBox_19_1.Text = MyProject.GetDetailValue(19, 1);

            foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
            {
                combobox.Items.Clear();
            }
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Piso"))
                this.comboBox_19_0.Items.Add(item.Value);
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("PisoAbreviado"))
                this.comboBox_19_1.Items.Add(item.Value);
            #endregion
            #region Fill groupBox_2
            this.radioButton_33_1.Checked = true;
            this.comboBox_33_0.Text = MyProject.GetDetailValue(33, 0);
            this.comboBox_33_1.Text = MyProject.GetDetailValue(33, 1);

            foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Piso"))
                this.comboBox_33_0.Items.Add(item.Value);
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("PisoAbreviado"))
                this.comboBox_33_1.Items.Add(item.Value);
            #endregion
        }
        internal void FillList(string _combobox)
        {
            switch (_combobox)
            {
                case "comboBox_5_0":
                    comboBox_5_0.Items.Clear();
                    comboBox_5_2.Items.Clear();
                    comboBox_5_6.Items.Clear();
                    comboBox_19_0.Items.Clear();
                    comboBox_33_0.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Piso"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_5_0.Items.Add(value);
                        comboBox_5_2.Items.Add(value);
                        comboBox_5_6.Items.Add(value);
                        comboBox_19_0.Items.Add(value);
                        comboBox_33_0.Items.Add(value);
                    }
                    break;
                case "comboBox_5_1":
                    comboBox_5_1.Items.Clear();
                    comboBox_19_1.Items.Clear();
                    comboBox_33_1.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("PisoAbreviado"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_5_1.Items.Add(value);
                        comboBox_19_1.Items.Add(value);
                        comboBox_33_1.Items.Add(value);
                    }
                    break;
                case "comboBox_5_3":
                    comboBox_5_3.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Dimensão"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_5_3.Items.Add(value);
                    }
                    break;
                case "comboBox_5_4":
                    comboBox_5_4.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("AcabamentoPiso"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_5_4.Items.Add(value);
                    }
                    break;
                case "comboBox_5_5":
                    comboBox_5_5.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("FabricantePiso"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_5_5.Items.Add(value);
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

            int textBox_0 = 213;
            int comboBox_0 = 43;
            int label_0 = 44;

            foreach (var textbox in this.groupBox_0.Controls.OfType<TextBox>())
            {
                textBox_0 = textBox_0 + 24;
                textbox.Size = new Size(210, 20);
                textbox.Location = new Point(80, textBox_0);
                MyFormats.TextBoxFormat(textbox);
            }

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

            int comboBox_1 = 43;
            int label_1 = 44;

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

            foreach (var radiobutton in this.groupBox_1.Controls.OfType<RadioButton>())
            {
                radiobutton.Size = new Size(30, 18);
                radiobutton.CheckedChanged += new EventHandler(this.RadioButton_1_CheckedChanged);
                MyFormats.RadioButtonFormat(radiobutton);
            }
            #endregion
            #region groupBox_2 builder

            int comboBox_2 = 43;
            int label_2 = 44;

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

            foreach (var radiobutton in this.groupBox_2.Controls.OfType<RadioButton>())
            {
                radiobutton.Size = new Size(30, 18);
                radiobutton.CheckedChanged += new EventHandler(this.RadioButton_2_CheckedChanged);
                MyFormats.RadioButtonFormat(radiobutton);
            }
            #endregion
        }
    }
}