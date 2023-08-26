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
        private Label space_6;

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
        private Label label_107_0;
        private ComboBox comboBox_107_0;
        private Label label_107_1;
        private ComboBox comboBox_107_1;
        private Label label_107_2;
        private ComboBox comboBox_107_2;
        private Label label_107_3;
        private ComboBox comboBox_107_3;
        private Label label_107_4;
        private ComboBox comboBox_107_4;
        private Label label_107_5;
        private ComboBox comboBox_107_5;

        private GroupBox groupBox_2;
        private Label label_108_0;
        private ComboBox comboBox_108_0;
        private Label label_108_1;
        private ComboBox comboBox_108_1;
        private Label label_108_2;
        private ComboBox comboBox_108_2;
        private Label label_108_3;
        private ComboBox comboBox_108_3;
        private Label label_108_4;
        private ComboBox comboBox_108_4;
        private Label label_108_5;
        private ComboBox comboBox_108_5;

        private GroupBox groupBox_3;
        private Label label_109_0;
        private ComboBox comboBox_109_0;
        private Label label_109_1;
        private ComboBox comboBox_109_1;
        private Label label_109_2;
        private ComboBox comboBox_109_2;
        private Label label_109_3;
        private ComboBox comboBox_109_3;
        private Label label_109_4;
        private ComboBox comboBox_109_4;
        private Label label_109_5;
        private ComboBox comboBox_109_5;

        private GroupBox groupBox_4;
        private Label label_110_0;
        private ComboBox comboBox_110_0;
        private Label label_110_1;
        private ComboBox comboBox_110_1;
        private Label label_110_2;
        private ComboBox comboBox_110_2;
        private Label label_110_3;
        private ComboBox comboBox_110_3;
        private Label label_110_4;
        private ComboBox comboBox_110_4;
        private Label label_110_5;
        private ComboBox comboBox_110_5;

        private GroupBox groupBox_5;
        private Label label_111_0;
        private ComboBox comboBox_111_0;
        private Label label_111_1;
        private ComboBox comboBox_111_1;
        private Label label_111_2;
        private ComboBox comboBox_111_2;
        private Label label_111_3;
        private ComboBox comboBox_111_3;
        private Label label_111_4;
        private ComboBox comboBox_111_4;
        private Label label_111_5;
        private ComboBox comboBox_111_5;

        private GroupBox groupBox_6;
        private Label label_112_0;
        private ComboBox comboBox_112_0;
        private Label label_112_1;
        private ComboBox comboBox_112_1;
        private Label label_112_2;
        private ComboBox comboBox_112_2;
        private Label label_112_3;
        private ComboBox comboBox_112_3;
        private Label label_112_4;
        private ComboBox comboBox_112_4;
        private Label label_112_5;
        private ComboBox comboBox_112_5;

        private GroupBox groupBox_7;
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
            this.space_6 = new Label();

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
            this.label_107_0 = new Label();
            this.comboBox_107_0 = new ComboBox();
            this.label_107_1 = new Label();
            this.comboBox_107_1 = new ComboBox();
            this.label_107_2 = new Label();
            this.comboBox_107_2 = new ComboBox();
            this.label_107_3 = new Label();
            this.comboBox_107_3 = new ComboBox();
            this.label_107_4 = new Label();
            this.comboBox_107_4 = new ComboBox();
            this.label_107_5 = new Label();
            this.comboBox_107_5 = new ComboBox();

            this.groupBox_2 = new GroupBox();
            this.label_108_0 = new Label();
            this.comboBox_108_0 = new ComboBox();
            this.label_108_1 = new Label();
            this.comboBox_108_1 = new ComboBox();
            this.label_108_2 = new Label();
            this.comboBox_108_2 = new ComboBox();
            this.label_108_3 = new Label();
            this.comboBox_108_3 = new ComboBox();
            this.label_108_4 = new Label();
            this.comboBox_108_4 = new ComboBox();
            this.label_108_5 = new Label();
            this.comboBox_108_5 = new ComboBox();

            this.groupBox_3 = new GroupBox();
            this.label_109_0 = new Label();
            this.comboBox_109_0 = new ComboBox();
            this.label_109_1 = new Label();
            this.comboBox_109_1 = new ComboBox();
            this.label_109_2 = new Label();
            this.comboBox_109_2 = new ComboBox();
            this.label_109_3 = new Label();
            this.comboBox_109_3 = new ComboBox();
            this.label_109_4 = new Label();
            this.comboBox_109_4 = new ComboBox();
            this.label_109_5 = new Label();
            this.comboBox_109_5 = new ComboBox();

            this.groupBox_4 = new GroupBox();
            this.label_110_0 = new Label();
            this.comboBox_110_0 = new ComboBox();
            this.label_110_1 = new Label();
            this.comboBox_110_1 = new ComboBox();
            this.label_110_2 = new Label();
            this.comboBox_110_2 = new ComboBox();
            this.label_110_3 = new Label();
            this.comboBox_110_3 = new ComboBox();
            this.label_110_4 = new Label();
            this.comboBox_110_4 = new ComboBox();
            this.label_110_5 = new Label();
            this.comboBox_110_5 = new ComboBox();

            this.groupBox_5 = new GroupBox();
            this.label_111_0 = new Label();
            this.comboBox_111_0 = new ComboBox();
            this.label_111_1 = new Label();
            this.comboBox_111_1 = new ComboBox();
            this.label_111_2 = new Label();
            this.comboBox_111_2 = new ComboBox();
            this.label_111_3 = new Label();
            this.comboBox_111_3 = new ComboBox();
            this.label_111_4 = new Label();
            this.comboBox_111_4 = new ComboBox();
            this.label_111_5 = new Label();
            this.comboBox_111_5 = new ComboBox();

            this.groupBox_6 = new GroupBox();
            this.label_112_0 = new Label();
            this.comboBox_112_0 = new ComboBox();
            this.label_112_1 = new Label();
            this.comboBox_112_1 = new ComboBox();
            this.label_112_2 = new Label();
            this.comboBox_112_2 = new ComboBox();
            this.label_112_3 = new Label();
            this.comboBox_112_3 = new ComboBox();
            this.label_112_4 = new Label();
            this.comboBox_112_4 = new ComboBox();
            this.label_112_5 = new Label();
            this.comboBox_112_5 = new ComboBox();

            this.groupBox_7 = new GroupBox();
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
            #endregion
            #region panel + label + picture
            this.panel.Controls.Add(this.groupBox_7);
            this.panel.Controls.Add(this.space_6);
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
            this.groupBox_1.Controls.Add(this.label_107_0);
            this.groupBox_1.Controls.Add(this.comboBox_107_0);
            this.groupBox_1.Controls.Add(this.label_107_1);
            this.groupBox_1.Controls.Add(this.comboBox_107_1);
            this.groupBox_1.Controls.Add(this.label_107_2);
            this.groupBox_1.Controls.Add(this.comboBox_107_2);
            this.groupBox_1.Controls.Add(this.label_107_3);
            this.groupBox_1.Controls.Add(this.comboBox_107_3);
            this.groupBox_1.Controls.Add(this.label_107_4);
            this.groupBox_1.Controls.Add(this.comboBox_107_4);
            this.groupBox_1.Controls.Add(this.label_107_5);
            this.groupBox_1.Controls.Add(this.comboBox_107_5);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Granito";
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new Size(300, 95);
            //
            // ComboBoxes
            //
            this.label_107_0.Name = "label_107_0";
            this.label_107_0.Text = "01";
            this.comboBox_107_0.Name = "comboBox_107_0";
            this.comboBox_107_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 107, 0);
            };
            this.label_107_1.Name = "label_107_1";
            this.label_107_1.Text = "02";
            this.comboBox_107_1.Name = "comboBox_107_1";
            this.comboBox_107_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 107, 1);
            };
            this.label_107_2.Name = "label_107_2";
            this.label_107_2.Text = "03";
            this.comboBox_107_2.Name = "comboBox_107_2";
            this.comboBox_107_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 107, 2);
            };
            this.label_107_3.Name = "label_107_3";
            this.label_107_3.Text = "04";
            this.comboBox_107_3.Name = "comboBox_107_3";
            this.comboBox_107_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 107, 3);
            };
            this.label_107_4.Name = "label_107_4";
            this.label_107_4.Text = "05";
            this.comboBox_107_4.Name = "comboBox_107_4";
            this.comboBox_107_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 107, 4);
            };
            this.label_107_5.Name = "label_107_5";
            this.label_107_5.Text = "06";
            this.comboBox_107_5.Name = "comboBox_107_5";
            this.comboBox_107_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 107, 5);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
            #endregion
            #region  groupBox_2
            this.groupBox_2.Controls.Add(this.label_108_0);
            this.groupBox_2.Controls.Add(this.comboBox_108_0);
            this.groupBox_2.Controls.Add(this.label_108_1);
            this.groupBox_2.Controls.Add(this.comboBox_108_1);
            this.groupBox_2.Controls.Add(this.label_108_2);
            this.groupBox_2.Controls.Add(this.comboBox_108_2);
            this.groupBox_2.Controls.Add(this.label_108_3);
            this.groupBox_2.Controls.Add(this.comboBox_108_3);
            this.groupBox_2.Controls.Add(this.label_108_4);
            this.groupBox_2.Controls.Add(this.comboBox_108_4);
            this.groupBox_2.Controls.Add(this.label_108_5);
            this.groupBox_2.Controls.Add(this.comboBox_108_5);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.Text = "Madeira";
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new Size(300, 320);
            //
            // ComboBoxes
            //
            this.label_108_0.Name = "label_108_0";
            this.label_108_0.Text = "01";
            this.comboBox_108_0.Name = "comboBox_108_0";
            this.comboBox_108_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 108, 0);
            };
            this.label_108_1.Name = "label_108_1";
            this.label_108_1.Text = "02";
            this.comboBox_108_1.Name = "comboBox_108_1";
            this.comboBox_108_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 108, 1);
            };
            this.label_108_2.Name = "label_108_2";
            this.label_108_2.Text = "03";
            this.comboBox_108_2.Name = "comboBox_108_2";
            this.comboBox_108_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 108, 2);
            };
            this.label_108_3.Name = "label_108_3";
            this.label_108_3.Text = "04";
            this.comboBox_108_3.Name = "comboBox_108_3";
            this.comboBox_108_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 108, 3);
            };
            this.label_108_4.Name = "label_108_4";
            this.label_108_4.Text = "05";
            this.comboBox_108_4.Name = "comboBox_108_4";
            this.comboBox_108_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 108, 4);
            };
            this.label_108_5.Name = "label_108_5";
            this.label_108_5.Text = "06";
            this.comboBox_108_5.Name = "comboBox_108_5";
            this.comboBox_108_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 108, 5);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
            #endregion
            #region groupBox_3
            this.groupBox_3.Controls.Add(this.label_109_0);
            this.groupBox_3.Controls.Add(this.comboBox_109_0);
            this.groupBox_3.Controls.Add(this.label_109_1);
            this.groupBox_3.Controls.Add(this.comboBox_109_1);
            this.groupBox_3.Controls.Add(this.label_109_2);
            this.groupBox_3.Controls.Add(this.comboBox_109_2);
            this.groupBox_3.Controls.Add(this.label_109_3);
            this.groupBox_3.Controls.Add(this.comboBox_109_3);
            this.groupBox_3.Controls.Add(this.label_109_4);
            this.groupBox_3.Controls.Add(this.comboBox_109_4);
            this.groupBox_3.Controls.Add(this.label_109_5);
            this.groupBox_3.Controls.Add(this.comboBox_109_5);
            this.groupBox_3.TabIndex = 3;
            this.groupBox_3.Text = "Pintura";
            this.groupBox_3.Name = "groupBox_3";
            this.groupBox_3.Size = new Size(300, 190);
            //
            // ComboBoxes
            //
            this.label_109_0.Name = "label_109_0";
            this.label_109_0.Text = "01";
            this.comboBox_109_0.Name = "comboBox_109_0";
            this.comboBox_109_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 109, 0);
            };
            this.label_109_1.Name = "label_109_1";
            this.label_109_1.Text = "02";
            this.comboBox_109_1.Name = "comboBox_109_1";
            this.comboBox_109_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 109, 1);
            };
            this.label_109_2.Name = "label_109_2";
            this.label_109_2.Text = "03";
            this.comboBox_109_2.Name = "comboBox_109_2";
            this.comboBox_109_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 109, 2);
            };
            this.label_109_3.Name = "label_109_3";
            this.label_109_3.Text = "04";
            this.comboBox_109_3.Name = "comboBox_109_3";
            this.comboBox_109_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 109, 3);
            };
            this.label_109_4.Name = "label_109_4";
            this.label_109_4.Text = "05";
            this.comboBox_109_4.Name = "comboBox_109_4";
            this.comboBox_109_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 109, 4);
            };
            this.label_109_5.Name = "label_109_5";
            this.label_109_5.Text = "06";
            this.comboBox_109_5.Name = "comboBox_109_5";
            this.comboBox_109_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 109, 5);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
            #endregion
            #region  groupBox_4
            this.groupBox_4.Controls.Add(this.label_110_0);
            this.groupBox_4.Controls.Add(this.comboBox_110_0);
            this.groupBox_4.Controls.Add(this.label_110_1);
            this.groupBox_4.Controls.Add(this.comboBox_110_1);
            this.groupBox_4.Controls.Add(this.label_110_2);
            this.groupBox_4.Controls.Add(this.comboBox_110_2);
            this.groupBox_4.Controls.Add(this.label_110_3);
            this.groupBox_4.Controls.Add(this.comboBox_110_3);
            this.groupBox_4.Controls.Add(this.label_110_4);
            this.groupBox_4.Controls.Add(this.comboBox_110_4);
            this.groupBox_4.Controls.Add(this.label_110_5);
            this.groupBox_4.Controls.Add(this.comboBox_110_5);
            this.groupBox_4.TabIndex = 4;
            this.groupBox_4.Text = "Revestimento";
            this.groupBox_4.Name = "groupBox_4";
            this.groupBox_4.Size = new Size(300, 320);
            //
            // ComboBoxes
            //
            this.label_110_0.Name = "label_110_0";
            this.label_110_0.Text = "01";
            this.comboBox_110_0.Name = "comboBox_110_0";
            this.comboBox_110_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 110, 0);
            };
            this.label_110_1.Name = "label_110_1";
            this.label_110_1.Text = "02";
            this.comboBox_110_1.Name = "comboBox_110_1";
            this.comboBox_110_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 110, 1);
            };
            this.label_110_2.Name = "label_110_2";
            this.label_110_2.Text = "03";
            this.comboBox_110_2.Name = "comboBox_110_2";
            this.comboBox_110_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 110, 2);
            };
            this.label_110_3.Name = "label_110_3";
            this.label_110_3.Text = "04";
            this.comboBox_110_3.Name = "comboBox_110_3";
            this.comboBox_110_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 110, 3);
            };
            this.label_110_4.Name = "label_110_4";
            this.label_110_4.Text = "05";
            this.comboBox_110_4.Name = "comboBox_110_4";
            this.comboBox_110_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 110, 4);
            };
            this.label_110_5.Name = "label_110_5";
            this.label_110_5.Text = "06";
            this.comboBox_110_5.Name = "comboBox_110_5";
            this.comboBox_110_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 110, 5);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
            #endregion
            #region  groupBox_5
            this.groupBox_5.Controls.Add(this.label_111_0);
            this.groupBox_5.Controls.Add(this.comboBox_111_0);
            this.groupBox_5.Controls.Add(this.label_111_1);
            this.groupBox_5.Controls.Add(this.comboBox_111_1);
            this.groupBox_5.Controls.Add(this.label_111_2);
            this.groupBox_5.Controls.Add(this.comboBox_111_2);
            this.groupBox_5.Controls.Add(this.label_111_3);
            this.groupBox_5.Controls.Add(this.comboBox_111_3);
            this.groupBox_5.Controls.Add(this.label_111_4);
            this.groupBox_5.Controls.Add(this.comboBox_111_4);
            this.groupBox_5.Controls.Add(this.label_111_5);
            this.groupBox_5.Controls.Add(this.comboBox_111_5);
            this.groupBox_5.TabIndex = 5;
            this.groupBox_5.Text = "Papel Parede";
            this.groupBox_5.Name = "groupBox_5";
            this.groupBox_5.Size = new Size(300, 335);
            //
            // ComboBoxes
            //
            this.label_111_0.Name = "label_111_0";
            this.label_111_0.Text = "01";
            this.comboBox_111_0.Name = "comboBox_111_0";
            this.comboBox_111_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 111, 0);
            };
            this.label_111_1.Name = "label_111_1";
            this.label_111_1.Text = "02";
            this.comboBox_111_1.Name = "comboBox_111_1";
            this.comboBox_111_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 111, 1);
            };
            this.label_111_2.Name = "label_111_2";
            this.label_111_2.Text = "03";
            this.comboBox_111_2.Name = "comboBox_111_2";
            this.comboBox_111_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 111, 2);
            };
            this.label_111_3.Name = "label_111_3";
            this.label_111_3.Text = "04";
            this.comboBox_111_3.Name = "comboBox_111_3";
            this.comboBox_111_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 111, 3);
            };
            this.label_111_4.Name = "label_111_4";
            this.label_111_4.Text = "05";
            this.comboBox_111_4.Name = "comboBox_111_4";
            this.comboBox_111_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 111, 4);
            };
            this.label_111_5.Name = "label_111_5";
            this.label_111_5.Text = "06";
            this.comboBox_111_5.Name = "comboBox_111_5";
            this.comboBox_111_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 111, 5);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
            #endregion
            #region  groupBox_6
            this.groupBox_6.Controls.Add(this.label_112_0);
            this.groupBox_6.Controls.Add(this.comboBox_112_0);
            this.groupBox_6.Controls.Add(this.label_112_1);
            this.groupBox_6.Controls.Add(this.comboBox_112_1);
            this.groupBox_6.Controls.Add(this.label_112_2);
            this.groupBox_6.Controls.Add(this.comboBox_112_2);
            this.groupBox_6.Controls.Add(this.label_112_3);
            this.groupBox_6.Controls.Add(this.comboBox_112_3);
            this.groupBox_6.Controls.Add(this.label_112_4);
            this.groupBox_6.Controls.Add(this.comboBox_112_4);
            this.groupBox_6.Controls.Add(this.label_112_5);
            this.groupBox_6.Controls.Add(this.comboBox_112_5);
            this.groupBox_6.TabIndex = 6;
            this.groupBox_6.Text = "Espelho";
            this.groupBox_6.Name = "groupBox_6";
            this.groupBox_6.Size = new Size(300, 142);
            //
            // ComboBoxes
            //
            this.label_112_0.Name = "label_112_0";
            this.label_112_0.Text = "01";
            this.comboBox_112_0.Name = "comboBox_112_0";
            this.comboBox_112_0.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 112, 0);
            };
            this.label_112_1.Name = "label_112_1";
            this.label_112_1.Text = "02";
            this.comboBox_112_1.Name = "comboBox_112_1";
            this.comboBox_112_1.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 112, 1);
            };
            this.label_112_2.Name = "label_112_2";
            this.label_112_2.Text = "03";
            this.comboBox_112_2.Name = "comboBox_112_2";
            this.comboBox_112_2.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 112, 2);
            };
            this.label_112_3.Name = "label_112_3";
            this.label_112_3.Text = "04";
            this.comboBox_112_3.Name = "comboBox_112_3";
            this.comboBox_112_3.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 112, 3);
            };
            this.label_112_4.Name = "label_112_4";
            this.label_112_4.Text = "05";
            this.comboBox_112_4.Name = "comboBox_112_4";
            this.comboBox_112_4.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 112, 4);
            };
            this.label_112_5.Name = "label_112_5";
            this.label_112_5.Text = "06";
            this.comboBox_112_5.Name = "comboBox_112_5";
            this.comboBox_112_5.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 112, 5);
            };
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
            #endregion
            #region  groupBox_7
            this.groupBox_7.Controls.Add(this.label_82_0);
            this.groupBox_7.Controls.Add(this.comboBox_82_0);
            this.groupBox_7.Controls.Add(this.label_82_1);
            this.groupBox_7.Controls.Add(this.comboBox_82_1);
            this.groupBox_7.Controls.Add(this.label_82_2);
            this.groupBox_7.Controls.Add(this.comboBox_82_2);
            this.groupBox_7.Controls.Add(this.label_82_3);
            this.groupBox_7.Controls.Add(this.comboBox_82_3);
            this.groupBox_7.Controls.Add(this.label_82_4);
            this.groupBox_7.Controls.Add(this.comboBox_82_4);
            this.groupBox_7.Controls.Add(this.label_82_5);
            this.groupBox_7.Controls.Add(this.comboBox_82_5);
            this.groupBox_7.TabIndex = 7;
            this.groupBox_7.Text = "Vidro";
            this.groupBox_7.Name = "groupBox_7";
            this.groupBox_7.Size = new Size(300, 142);
            //
            // ComboBoxes
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
            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
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
            this.comboBox_107_0.Text = MyProject.GetDetailValue(107, 0);
            this.comboBox_107_1.Text = MyProject.GetDetailValue(107, 1);
            this.comboBox_107_2.Text = MyProject.GetDetailValue(107, 2);
            this.comboBox_107_3.Text = MyProject.GetDetailValue(107, 3);
            this.comboBox_107_4.Text = MyProject.GetDetailValue(107, 4);
            this.comboBox_107_5.Text = MyProject.GetDetailValue(107, 5);

            foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Granito"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_107_0.Items.Add(value);
                this.comboBox_107_1.Items.Add(value);
                this.comboBox_107_2.Items.Add(value);
                this.comboBox_107_3.Items.Add(value);
                this.comboBox_107_4.Items.Add(value);
                this.comboBox_107_5.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_2
            this.comboBox_108_0.Text = MyProject.GetDetailValue(108, 0);
            this.comboBox_108_1.Text = MyProject.GetDetailValue(108, 1);
            this.comboBox_108_2.Text = MyProject.GetDetailValue(108, 2);
            this.comboBox_108_3.Text = MyProject.GetDetailValue(108, 3);
            this.comboBox_108_4.Text = MyProject.GetDetailValue(108, 4);
            this.comboBox_108_5.Text = MyProject.GetDetailValue(108, 5);

            foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Madeira"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_108_0.Items.Add(value);
                this.comboBox_108_1.Items.Add(value);
                this.comboBox_108_2.Items.Add(value);
                this.comboBox_108_3.Items.Add(value);
                this.comboBox_108_4.Items.Add(value);
                this.comboBox_108_5.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_3
            this.comboBox_109_0.Text = MyProject.GetDetailValue(109, 0);
            this.comboBox_109_1.Text = MyProject.GetDetailValue(109, 1);
            this.comboBox_109_2.Text = MyProject.GetDetailValue(109, 2);
            this.comboBox_109_3.Text = MyProject.GetDetailValue(109, 3);
            this.comboBox_109_4.Text = MyProject.GetDetailValue(109, 4);
            this.comboBox_109_5.Text = MyProject.GetDetailValue(109, 5);

            foreach (var combobox in this.groupBox_3.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Pintura"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_109_0.Items.Add(value);
                this.comboBox_109_1.Items.Add(value);
                this.comboBox_109_2.Items.Add(value);
                this.comboBox_109_3.Items.Add(value);
                this.comboBox_109_4.Items.Add(value);
                this.comboBox_109_5.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_4
            this.comboBox_110_0.Text = MyProject.GetDetailValue(110, 0);
            this.comboBox_110_1.Text = MyProject.GetDetailValue(110, 1);
            this.comboBox_110_2.Text = MyProject.GetDetailValue(110, 2);
            this.comboBox_110_3.Text = MyProject.GetDetailValue(110, 3);
            this.comboBox_110_4.Text = MyProject.GetDetailValue(110, 4);
            this.comboBox_110_5.Text = MyProject.GetDetailValue(110, 5);

            foreach (var combobox in this.groupBox_4.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Revestimento"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_110_0.Items.Add(value);
                this.comboBox_110_1.Items.Add(value);
                this.comboBox_110_2.Items.Add(value);
                this.comboBox_110_3.Items.Add(value);
                this.comboBox_110_4.Items.Add(value);
                this.comboBox_110_5.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_5
            this.comboBox_111_0.Text = MyProject.GetDetailValue(111, 0);
            this.comboBox_111_1.Text = MyProject.GetDetailValue(111, 1);
            this.comboBox_111_2.Text = MyProject.GetDetailValue(111, 2);
            this.comboBox_111_3.Text = MyProject.GetDetailValue(111, 3);
            this.comboBox_111_4.Text = MyProject.GetDetailValue(111, 4);
            this.comboBox_111_5.Text = MyProject.GetDetailValue(111, 5);

            foreach (var combobox in this.groupBox_5.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("PapelParede"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_111_0.Items.Add(value);
                this.comboBox_111_1.Items.Add(value);
                this.comboBox_111_2.Items.Add(value);
                this.comboBox_111_3.Items.Add(value);
                this.comboBox_111_4.Items.Add(value);
                this.comboBox_111_5.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_6
            this.comboBox_112_0.Text = MyProject.GetDetailValue(112, 0);
            this.comboBox_112_1.Text = MyProject.GetDetailValue(112, 1);
            this.comboBox_112_2.Text = MyProject.GetDetailValue(112, 2);
            this.comboBox_112_3.Text = MyProject.GetDetailValue(112, 3);
            this.comboBox_112_4.Text = MyProject.GetDetailValue(112, 4);
            this.comboBox_112_5.Text = MyProject.GetDetailValue(112, 5);

            foreach (var combobox in this.groupBox_6.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Espelho"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_112_0.Items.Add(value);
                this.comboBox_112_1.Items.Add(value);
                this.comboBox_112_2.Items.Add(value);
                this.comboBox_112_3.Items.Add(value);
                this.comboBox_112_4.Items.Add(value);
                this.comboBox_112_5.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_7
            this.comboBox_82_0.Text = MyProject.GetDetailValue(82, 0);
            this.comboBox_82_1.Text = MyProject.GetDetailValue(82, 1);
            this.comboBox_82_2.Text = MyProject.GetDetailValue(82, 2);
            this.comboBox_82_3.Text = MyProject.GetDetailValue(82, 3);
            this.comboBox_82_4.Text = MyProject.GetDetailValue(82, 4);
            this.comboBox_82_5.Text = MyProject.GetDetailValue(82, 5);

            foreach (var combobox in this.groupBox_7.Controls.OfType<ComboBox>())
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
                case "comboBox_107_0":
                    foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Granito"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_107_0.Items.Add(value);
                        this.comboBox_107_1.Items.Add(value);
                        this.comboBox_107_2.Items.Add(value);
                        this.comboBox_107_3.Items.Add(value);
                        this.comboBox_107_4.Items.Add(value);
                        this.comboBox_107_5.Items.Add(value);
                    }
                    break;
                case "comboBox_108_0":
                    foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Madeira"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_108_0.Items.Add(value);
                        this.comboBox_108_1.Items.Add(value);
                        this.comboBox_108_2.Items.Add(value);
                        this.comboBox_108_3.Items.Add(value);
                        this.comboBox_108_4.Items.Add(value);
                        this.comboBox_108_5.Items.Add(value);
                    }
                    break;
                case "comboBox_109_0":
                    foreach (var combobox in this.groupBox_3.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Pintura"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_109_0.Items.Add(value);
                        this.comboBox_109_1.Items.Add(value);
                        this.comboBox_109_2.Items.Add(value);
                        this.comboBox_109_3.Items.Add(value);
                        this.comboBox_109_4.Items.Add(value);
                        this.comboBox_109_5.Items.Add(value);
                    }
                    break;
                case "comboBox_110_0":
                    foreach (var combobox in this.groupBox_4.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Revestimento"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_110_0.Items.Add(value);
                        this.comboBox_110_1.Items.Add(value);
                        this.comboBox_110_2.Items.Add(value);
                        this.comboBox_110_3.Items.Add(value);
                        this.comboBox_110_4.Items.Add(value);
                        this.comboBox_110_5.Items.Add(value);
                    }
                    break;
                case "comboBox_111_0":
                    foreach (var combobox in this.groupBox_5.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("PapelParede"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_111_0.Items.Add(value);
                        this.comboBox_111_1.Items.Add(value);
                        this.comboBox_111_2.Items.Add(value);
                        this.comboBox_111_3.Items.Add(value);
                        this.comboBox_111_4.Items.Add(value);
                        this.comboBox_111_5.Items.Add(value);
                    }
                    break;
                case "comboBox_112_0":
                    foreach (var combobox in this.groupBox_6.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Espelho"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_112_0.Items.Add(value);
                        this.comboBox_112_1.Items.Add(value);
                        this.comboBox_112_2.Items.Add(value);
                        this.comboBox_112_3.Items.Add(value);
                        this.comboBox_112_4.Items.Add(value);
                        this.comboBox_112_5.Items.Add(value);
                    }
                    break;
                case "comboBox_82_0":
                    foreach (var combobox in this.groupBox_7.Controls.OfType<ComboBox>())
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
            #region groupBox_4 builder

            int comboBox_4 = -6;
            int label_4 = -5;

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
            #region groupBox_7 builder

            int comboBox_7 = -6;
            int label_7 = -5;

            foreach (var combobox in this.groupBox_7.Controls.OfType<ComboBox>())
            {
                comboBox_7 = comboBox_7 + 24;
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, comboBox_7);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_7.Controls.OfType<Label>())
            {
                label_7 = label_7 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_7);
                MyFormats.LabelFormat(label);
            }
            #endregion
        }
    }
}