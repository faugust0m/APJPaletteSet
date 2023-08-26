/*using System;
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
        private Label label_86_P;
        private Label label_86_1;
        private ComboBox comboBox_86_1;
        private CheckBox checkBox_86_1;
        private Label label_86_2;
        private ComboBox comboBox_86_2;
        private CheckBox checkBox_86_2;
        private Label label_86_3;
        private ComboBox comboBox_86_3;
        private CheckBox checkBox_86_3;
        private Label label_86_4;
        private ComboBox comboBox_86_4;
        private CheckBox checkBox_86_4;
        private Label label_86_5;
        private ComboBox comboBox_86_5;
        private CheckBox checkBox_86_5;
        private Label label_86_6;
        private ComboBox comboBox_86_6;
        private CheckBox checkBox_86_6;
        private Label label_86_7;
        private ComboBox comboBox_86_7;
        private CheckBox checkBox_86_7;
        private Label label_86_8;
        private ComboBox comboBox_86_8;
        private CheckBox checkBox_86_8;
        private Label label_86_9;
        private ComboBox comboBox_86_9;
        private CheckBox checkBox_86_9;
        private Label label_86_10;
        private ComboBox comboBox_86_10;
        private CheckBox checkBox_86_10;
        private Label label_86_11;
        private ComboBox comboBox_86_11;
        private CheckBox checkBox_86_11;
        private Label label_86_12;
        private ComboBox comboBox_86_12;
        private CheckBox checkBox_86_12;
        private LinkLabel linkLabel;

        private GroupBox groupBox_1;
        private Label label_86_15;
        private ComboBox comboBox_86_15;
        private Label label_86_16;
        private ComboBox comboBox_86_16;
        private Label label_86_17;
        private ComboBox comboBox_86_17;

        private GroupBox groupBox_2;
        private Label label_86_F;
        private Label label_86_20;
        private ComboBox comboBox_86_20;
        private CheckBox checkBox_86_20;
        private Label label_86_21;
        private ComboBox comboBox_86_21;
        private CheckBox checkBox_86_21;
        private Label label_86_22;
        private ComboBox comboBox_86_22;
        private CheckBox checkBox_86_22;
        private Label label_86_23;
        private ComboBox comboBox_86_23;
        private CheckBox checkBox_86_23;
        private Label label_86_24;
        private ComboBox comboBox_86_24;
        private CheckBox checkBox_86_24;
        private Label label_86_25;
        private ComboBox comboBox_86_25;
        private CheckBox checkBox_86_25;
        private Label label_86_26;
        private ComboBox comboBox_86_26;
        private CheckBox checkBox_86_26;
        private Label label_86_27;
        private ComboBox comboBox_86_27;
        private CheckBox checkBox_86_27;
        private Label label_86_28;
        private ComboBox comboBox_86_28;
        private CheckBox checkBox_86_28;
        private Label label_86_29;
        private ComboBox comboBox_86_29;
        private CheckBox checkBox_86_29;
        private Label label_86_30;
        private ComboBox comboBox_86_30;
        private CheckBox checkBox_86_30;
        private Label label_86_31;
        private ComboBox comboBox_86_31;
        private CheckBox checkBox_86_31;

        private GroupBox groupBox_3;
        private Label label_86_34;
        private ComboBox comboBox_86_34;
        private Label label_86_35;
        private ComboBox comboBox_86_35;
        private Label label_86_36;
        private ComboBox comboBox_86_36;
        private Label label_86_37;
        private ComboBox comboBox_86_37;
        private Label label_86_38;
        private ComboBox comboBox_86_38;
        private Label label_86_39;
        private ComboBox comboBox_86_39;
        private Label label_86_40;
        private ComboBox comboBox_86_40;

        private GroupBox groupBox_4;
        private Label label_86_S;
        private Label label_86_43;
        private ComboBox comboBox_86_43;
        private CheckBox checkBox_86_43;
        private Label label_86_44;
        private ComboBox comboBox_86_44;
        private CheckBox checkBox_86_44;
        private Label label_86_45;
        private ComboBox comboBox_86_45;
        private CheckBox checkBox_86_45;
        private Label label_86_46;
        private ComboBox comboBox_86_46;
        private CheckBox checkBox_86_46;
        private Label label_86_47;
        private ComboBox comboBox_86_47;
        private CheckBox checkBox_86_47;
        private Label label_86_48;
        private ComboBox comboBox_86_48;
        private CheckBox checkBox_86_48;
        private Label label_86_49;
        private ComboBox comboBox_86_49;
        private CheckBox checkBox_86_49;
        private Label label_86_50;
        private ComboBox comboBox_86_50;
        private CheckBox checkBox_86_50;
        private Label label_86_51;
        private ComboBox comboBox_86_51;
        private CheckBox checkBox_86_51;
        private Label label_86_52;
        private ComboBox comboBox_86_52;
        private CheckBox checkBox_86_52;
        private Label label_86_53;
        private ComboBox comboBox_86_53;
        private CheckBox checkBox_86_53;
        private Label label_86_54;
        private ComboBox comboBox_86_54;
        private CheckBox checkBox_86_54;

        private GroupBox groupBox_5;
        private Label label_86_57;
        private ComboBox comboBox_86_57;
        private Label label_86_58;
        private ComboBox comboBox_86_58;
        private Label label_86_59;
        private ComboBox comboBox_86_59;
        private Label label_86_60;
        private ComboBox comboBox_86_60;
        private Label label_86_61;
        private ComboBox comboBox_86_61;
        private Label label_86_62;
        private ComboBox comboBox_86_62;
        private Label label_86_63;
        private ComboBox comboBox_86_63;
        private Label label_86_64;
        private ComboBox comboBox_86_64;
        private Label label_86_65;
        private ComboBox comboBox_86_65;
        private Label label_86_66;
        private ComboBox comboBox_86_66;
        private Label label_86_67;
        private ComboBox comboBox_86_67;
        private Label label_86_68;
        private ComboBox comboBox_86_68;
        private Label label_86_69;
        private ComboBox comboBox_86_69;

        private GroupBox groupBox_6;
        private Label label_86_72;
        private ComboBox comboBox_86_72;
        private Label label_86_73;
        private ComboBox comboBox_86_73;
        private Label label_86_74;
        private ComboBox comboBox_86_74;
        private Label label_86_75;
        private ComboBox comboBox_86_75;
        private Label label_86_76;
        private ComboBox comboBox_86_76;
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
            this.label_86_P = new Label();
            this.label_86_1 = new Label();
            this.comboBox_86_1 = new ComboBox();
            this.checkBox_86_1 = new CheckBox();
            this.label_86_2 = new Label();
            this.comboBox_86_2 = new ComboBox();
            this.checkBox_86_2 = new CheckBox();
            this.label_86_3 = new Label();
            this.comboBox_86_3 = new ComboBox();
            this.checkBox_86_3 = new CheckBox();
            this.label_86_4 = new Label();
            this.comboBox_86_4 = new ComboBox();
            this.checkBox_86_4 = new CheckBox();
            this.label_86_5 = new Label();
            this.comboBox_86_5 = new ComboBox();
            this.checkBox_86_5 = new CheckBox();
            this.label_86_6 = new Label();
            this.comboBox_86_6 = new ComboBox();
            this.checkBox_86_6 = new CheckBox();
            this.label_86_7 = new Label();
            this.comboBox_86_7 = new ComboBox();
            this.checkBox_86_7 = new CheckBox();
            this.label_86_8 = new Label();
            this.comboBox_86_8 = new ComboBox();
            this.checkBox_86_8 = new CheckBox();
            this.label_86_9 = new Label();
            this.comboBox_86_9 = new ComboBox();
            this.checkBox_86_9 = new CheckBox();
            this.label_86_10 = new Label();
            this.comboBox_86_10 = new ComboBox();
            this.checkBox_86_10 = new CheckBox();
            this.label_86_11 = new Label();
            this.comboBox_86_11 = new ComboBox();
            this.checkBox_86_11 = new CheckBox();
            this.label_86_12 = new Label();
            this.comboBox_86_12 = new ComboBox();
            this.checkBox_86_12 = new CheckBox();
            this.linkLabel = new LinkLabel();

            this.groupBox_1 = new GroupBox();
            this.label_86_15 = new Label();
            this.comboBox_86_15 = new ComboBox();
            this.label_86_16 = new Label();
            this.comboBox_86_16 = new ComboBox();
            this.label_86_17 = new Label();
            this.comboBox_86_17 = new ComboBox();

            this.groupBox_2 = new GroupBox();
            this.label_86_F = new Label();
            this.label_86_20 = new Label();
            this.comboBox_86_20 = new ComboBox();
            this.checkBox_86_20 = new CheckBox();
            this.label_86_21 = new Label();
            this.comboBox_86_21 = new ComboBox();
            this.checkBox_86_21 = new CheckBox();
            this.label_86_22 = new Label();
            this.comboBox_86_22 = new ComboBox();
            this.checkBox_86_22 = new CheckBox();
            this.label_86_23 = new Label();
            this.comboBox_86_23 = new ComboBox();
            this.checkBox_86_23 = new CheckBox();
            this.label_86_24 = new Label();
            this.comboBox_86_24 = new ComboBox();
            this.checkBox_86_24 = new CheckBox();
            this.label_86_25 = new Label();
            this.comboBox_86_25 = new ComboBox();
            this.checkBox_86_25 = new CheckBox();
            this.label_86_26 = new Label();
            this.comboBox_86_26 = new ComboBox();
            this.checkBox_86_26 = new CheckBox();
            this.label_86_27 = new Label();
            this.comboBox_86_27 = new ComboBox();
            this.checkBox_86_27 = new CheckBox();
            this.label_86_28 = new Label();
            this.comboBox_86_28 = new ComboBox();
            this.checkBox_86_28 = new CheckBox();
            this.label_86_29 = new Label();
            this.comboBox_86_29 = new ComboBox();
            this.checkBox_86_29 = new CheckBox();
            this.label_86_30 = new Label();
            this.comboBox_86_30 = new ComboBox();
            this.checkBox_86_30 = new CheckBox();
            this.label_86_31 = new Label();
            this.comboBox_86_31 = new ComboBox();
            this.checkBox_86_31 = new CheckBox();

            this.groupBox_3 = new GroupBox();
            this.label_86_34 = new Label();
            this.comboBox_86_34 = new ComboBox();
            this.label_86_35 = new Label();
            this.comboBox_86_35 = new ComboBox();
            this.label_86_36 = new Label();
            this.comboBox_86_36 = new ComboBox();
            this.label_86_37 = new Label();
            this.comboBox_86_37 = new ComboBox();
            this.label_86_38 = new Label();
            this.comboBox_86_38 = new ComboBox();
            this.label_86_39 = new Label();
            this.comboBox_86_39 = new ComboBox();
            this.label_86_40 = new Label();
            this.comboBox_86_40 = new ComboBox();

            this.groupBox_4 = new GroupBox();
            this.label_86_S = new Label();
            this.label_86_43 = new Label();
            this.comboBox_86_43 = new ComboBox();
            this.checkBox_86_43 = new CheckBox();
            this.label_86_44 = new Label();
            this.comboBox_86_44 = new ComboBox();
            this.checkBox_86_44 = new CheckBox();
            this.label_86_45 = new Label();
            this.comboBox_86_45 = new ComboBox();
            this.checkBox_86_45 = new CheckBox();
            this.label_86_46 = new Label();
            this.comboBox_86_46 = new ComboBox();
            this.checkBox_86_46 = new CheckBox();
            this.label_86_47 = new Label();
            this.comboBox_86_47 = new ComboBox();
            this.checkBox_86_47 = new CheckBox();
            this.label_86_48 = new Label();
            this.comboBox_86_48 = new ComboBox();
            this.checkBox_86_48 = new CheckBox();
            this.label_86_49 = new Label();
            this.comboBox_86_49 = new ComboBox();
            this.checkBox_86_49 = new CheckBox();
            this.label_86_50 = new Label();
            this.comboBox_86_50 = new ComboBox();
            this.checkBox_86_50 = new CheckBox();
            this.label_86_51 = new Label();
            this.comboBox_86_51 = new ComboBox();
            this.checkBox_86_51 = new CheckBox();
            this.label_86_52 = new Label();
            this.comboBox_86_52 = new ComboBox();
            this.checkBox_86_52 = new CheckBox();
            this.label_86_53 = new Label();
            this.comboBox_86_53 = new ComboBox();
            this.checkBox_86_53 = new CheckBox();
            this.label_86_54 = new Label();
            this.comboBox_86_54 = new ComboBox();
            this.checkBox_86_54 = new CheckBox();

            this.groupBox_5 = new GroupBox();
            this.label_86_57 = new Label();
            this.comboBox_86_57 = new ComboBox();
            this.label_86_58 = new Label();
            this.comboBox_86_58 = new ComboBox();
            this.label_86_59 = new Label();
            this.comboBox_86_59 = new ComboBox();
            this.label_86_60 = new Label();
            this.comboBox_86_60 = new ComboBox();
            this.label_86_61 = new Label();
            this.comboBox_86_61 = new ComboBox();
            this.label_86_62 = new Label();
            this.comboBox_86_62 = new ComboBox();
            this.label_86_63 = new Label();
            this.comboBox_86_63 = new ComboBox();
            this.label_86_64 = new Label();
            this.comboBox_86_64 = new ComboBox();
            this.label_86_65 = new Label();
            this.comboBox_86_65 = new ComboBox();
            this.label_86_66 = new Label();
            this.comboBox_86_66 = new ComboBox();
            this.label_86_67 = new Label();
            this.comboBox_86_67 = new ComboBox();
            this.label_86_68 = new Label();
            this.comboBox_86_68 = new ComboBox();
            this.label_86_69 = new Label();
            this.comboBox_86_69 = new ComboBox();

            this.groupBox_6 = new GroupBox();
            this.label_86_72 = new Label();
            this.comboBox_86_72 = new ComboBox();
            this.label_86_73 = new Label();
            this.comboBox_86_73 = new ComboBox();
            this.label_86_74 = new Label();
            this.comboBox_86_74 = new ComboBox();
            this.label_86_75 = new Label();
            this.comboBox_86_75 = new ComboBox();
            this.label_86_76 = new Label();
            this.comboBox_86_76 = new ComboBox();
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
            this.groupBox_0.Controls.Add(this.label_86_P);
            this.groupBox_0.Controls.Add(this.label_86_1);
            this.groupBox_0.Controls.Add(this.comboBox_86_1);
            this.groupBox_0.Controls.Add(this.checkBox_86_1);
            this.groupBox_0.Controls.Add(this.label_86_2);
            this.groupBox_0.Controls.Add(this.comboBox_86_2);
            this.groupBox_0.Controls.Add(this.checkBox_86_2);
            this.groupBox_0.Controls.Add(this.label_86_3);
            this.groupBox_0.Controls.Add(this.comboBox_86_3);
            this.groupBox_0.Controls.Add(this.checkBox_86_3);
            this.groupBox_0.Controls.Add(this.label_86_4);
            this.groupBox_0.Controls.Add(this.comboBox_86_4);
            this.groupBox_0.Controls.Add(this.checkBox_86_4);
            this.groupBox_0.Controls.Add(this.label_86_5);
            this.groupBox_0.Controls.Add(this.comboBox_86_5);
            this.groupBox_0.Controls.Add(this.checkBox_86_5);
            this.groupBox_0.Controls.Add(this.label_86_6);
            this.groupBox_0.Controls.Add(this.comboBox_86_6);
            this.groupBox_0.Controls.Add(this.checkBox_86_6);
            this.groupBox_0.Controls.Add(this.label_86_7);
            this.groupBox_0.Controls.Add(this.comboBox_86_7);
            this.groupBox_0.Controls.Add(this.checkBox_86_7);
            this.groupBox_0.Controls.Add(this.label_86_8);
            this.groupBox_0.Controls.Add(this.comboBox_86_8);
            this.groupBox_0.Controls.Add(this.checkBox_86_8);
            this.groupBox_0.Controls.Add(this.label_86_9);
            this.groupBox_0.Controls.Add(this.comboBox_86_9);
            this.groupBox_0.Controls.Add(this.checkBox_86_9);
            this.groupBox_0.Controls.Add(this.label_86_10);
            this.groupBox_0.Controls.Add(this.comboBox_86_10);
            this.groupBox_0.Controls.Add(this.checkBox_86_10);
            this.groupBox_0.Controls.Add(this.label_86_11);
            this.groupBox_0.Controls.Add(this.comboBox_86_11);
            this.groupBox_0.Controls.Add(this.checkBox_86_11);
            this.groupBox_0.Controls.Add(this.label_86_12);
            this.groupBox_0.Controls.Add(this.comboBox_86_12);
            this.groupBox_0.Controls.Add(this.checkBox_86_12);
            this.groupBox_0.Controls.Add(this.linkLabel);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Text = "Paredes";
            this.groupBox_0.Name = "groupBox_0";
            //
            // ComboBoxes
            //
            this.label_86_1.Name = "label_86_1";
            this.label_86_1.Text = "A1";
            this.comboBox_86_1.Name = "comboBox_86_1";
            this.checkBox_86_1.Name = "checkBox_86_1";
            MyEvents.ComboBoxEvents(comboBox_86_1);
            MyEvents.CheckBoxEvents(checkBox_86_1, comboBox_86_1, 47, 1, "Parede 01");

            this.label_86_2.Name = "label_86_2";
            this.label_86_2.Text = "A2";
            this.comboBox_86_2.Name = "comboBox_86_2";
            this.checkBox_86_2.Name = "checkBox_86_2";
            MyEvents.ComboBoxEvents(comboBox_86_2);
            MyEvents.CheckBoxEvents(checkBox_86_2, comboBox_86_2, 48, 2, "Parede 02");

            this.label_86_3.Name = "label_86_3";
            this.label_86_3.Text = "A3";
            this.comboBox_86_3.Name = "comboBox_86_3";
            this.checkBox_86_3.Name = "checkBox_86_3";
            MyEvents.ComboBoxEvents(comboBox_86_3);
            MyEvents.CheckBoxEvents(checkBox_86_3, comboBox_86_3, 49, 3, "Parede 03");

            this.label_86_4.Name = "label_86_4";
            this.label_86_4.Text = "A4";
            this.comboBox_86_4.Name = "comboBox_86_4";
            this.checkBox_86_4.Name = "checkBox_86_4";
            MyEvents.ComboBoxEvents(comboBox_86_4);
            MyEvents.CheckBoxEvents(checkBox_86_4, comboBox_86_4, 50, 4, "Parede 04");

            this.label_86_5.Name = "label_86_5";
            this.label_86_5.Text = "A5";
            this.comboBox_86_5.Name = "comboBox_86_5";
            this.checkBox_86_5.Name = "checkBox_86_5";
            MyEvents.ComboBoxEvents(comboBox_86_5);
            MyEvents.CheckBoxEvents(checkBox_86_5, comboBox_86_5, 51, 5, "Parede 05");

            this.label_86_6.Name = "label_86_6";
            this.label_86_6.Text = "A6";
            this.comboBox_86_6.Name = "comboBox_86_6";
            this.checkBox_86_6.Name = "checkBox_86_6";
            MyEvents.ComboBoxEvents(comboBox_86_6);
            MyEvents.CheckBoxEvents(checkBox_86_6, comboBox_86_6, 52, 6, "Parede 06");

            this.label_86_7.Name = "label_86_7";
            this.label_86_7.Text = "A7";
            this.comboBox_86_7.Name = "comboBox_86_7";
            this.checkBox_86_7.Name = "checkBox_86_7";
            MyEvents.ComboBoxEvents(comboBox_86_7);
            MyEvents.CheckBoxEvents(checkBox_86_7, comboBox_86_7, 53, 7, "Parede 07");

            this.label_86_8.Name = "label_86_8";
            this.label_86_8.Text = "A8";
            this.comboBox_86_8.Name = "comboBox_86_8";
            this.checkBox_86_8.Name = "checkBox_86_8";
            MyEvents.ComboBoxEvents(comboBox_86_8);
            MyEvents.CheckBoxEvents(checkBox_86_8, comboBox_86_8, 54, 8, "Parede 08");

            this.label_86_9.Name = "label_86_9";
            this.label_86_9.Text = "A9";
            this.comboBox_86_9.Name = "comboBox_86_9";
            this.checkBox_86_9.Name = "checkBox_86_9";
            MyEvents.ComboBoxEvents(comboBox_86_9);
            MyEvents.CheckBoxEvents(checkBox_86_9, comboBox_86_9, 55, 9, "Parede 09");

            this.label_86_10.Name = "label_86_10";
            this.label_86_10.Text = "A10";
            this.comboBox_86_10.Name = "comboBox_86_10";
            this.checkBox_86_10.Name = "checkBox_86_10";
            MyEvents.ComboBoxEvents(comboBox_86_10);
            MyEvents.CheckBoxEvents(checkBox_86_10, comboBox_86_10, 56, 10, "Parede 10");

            this.label_86_11.Name = "label_86_11";
            this.label_86_11.Text = "A11";
            this.comboBox_86_11.Name = "comboBox_86_11";
            this.checkBox_86_11.Name = "checkBox_86_11";
            MyEvents.ComboBoxEvents(comboBox_86_11);
            MyEvents.CheckBoxEvents(checkBox_86_11, comboBox_86_11, 57, 11, "Parede 11");

            this.label_86_12.Name = "label_86_12";
            this.label_86_12.Text = "A12";
            this.comboBox_86_12.Name = "comboBox_86_12";
            this.checkBox_86_12.Name = "checkBox_86_12";
            MyEvents.ComboBoxEvents(comboBox_86_12);
            MyEvents.CheckBoxEvents(checkBox_86_12, comboBox_86_12, 58, 12, "Parede 12");

            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 5);
            };
            #endregion
            #region  groupBox_1
            this.groupBox_1.Controls.Add(this.label_86_15);
            this.groupBox_1.Controls.Add(this.comboBox_86_15);
            this.groupBox_1.Controls.Add(this.label_86_16);
            this.groupBox_1.Controls.Add(this.comboBox_86_16);
            this.groupBox_1.Controls.Add(this.label_86_17);
            this.groupBox_1.Controls.Add(this.comboBox_86_17);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Espelhos";
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new Size(300, 95);
            //
            // ComboBoxes
            //
            this.label_86_15.Name = "label_86_15";
            this.label_86_15.Text = "E1";
            this.comboBox_86_15.Name = "comboBox_86_15";
            this.comboBox_86_15.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 15);
            };
            this.label_86_16.Name = "label_86_16";
            this.label_86_16.Text = "E2";
            this.comboBox_86_16.Name = "comboBox_86_16";
            this.comboBox_86_16.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 16);
            };
            this.label_86_17.Name = "label_86_17";
            this.label_86_17.Text = "E3";
            this.comboBox_86_17.Name = "comboBox_86_17";
            this.comboBox_86_17.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 17);
            };
            #endregion
            #region  groupBox_2
            this.groupBox_2.Controls.Add(this.label_86_F);
            this.groupBox_2.Controls.Add(this.label_86_20);
            this.groupBox_2.Controls.Add(this.comboBox_86_20);
            this.groupBox_2.Controls.Add(this.checkBox_86_20);
            this.groupBox_2.Controls.Add(this.label_86_21);
            this.groupBox_2.Controls.Add(this.comboBox_86_21);
            this.groupBox_2.Controls.Add(this.checkBox_86_21);
            this.groupBox_2.Controls.Add(this.label_86_22);
            this.groupBox_2.Controls.Add(this.comboBox_86_22);
            this.groupBox_2.Controls.Add(this.checkBox_86_22);
            this.groupBox_2.Controls.Add(this.label_86_23);
            this.groupBox_2.Controls.Add(this.comboBox_86_23);
            this.groupBox_2.Controls.Add(this.checkBox_86_23);
            this.groupBox_2.Controls.Add(this.label_86_24);
            this.groupBox_2.Controls.Add(this.comboBox_86_24);
            this.groupBox_2.Controls.Add(this.checkBox_86_24);
            this.groupBox_2.Controls.Add(this.label_86_25);
            this.groupBox_2.Controls.Add(this.comboBox_86_25);
            this.groupBox_2.Controls.Add(this.checkBox_86_25);
            this.groupBox_2.Controls.Add(this.label_86_26);
            this.groupBox_2.Controls.Add(this.comboBox_86_26);
            this.groupBox_2.Controls.Add(this.checkBox_86_26);
            this.groupBox_2.Controls.Add(this.label_86_27);
            this.groupBox_2.Controls.Add(this.comboBox_86_27);
            this.groupBox_2.Controls.Add(this.checkBox_86_27);
            this.groupBox_2.Controls.Add(this.label_86_28);
            this.groupBox_2.Controls.Add(this.comboBox_86_28);
            this.groupBox_2.Controls.Add(this.checkBox_86_28);
            this.groupBox_2.Controls.Add(this.label_86_29);
            this.groupBox_2.Controls.Add(this.comboBox_86_29);
            this.groupBox_2.Controls.Add(this.checkBox_86_29);
            this.groupBox_2.Controls.Add(this.label_86_30);
            this.groupBox_2.Controls.Add(this.comboBox_86_30);
            this.groupBox_2.Controls.Add(this.checkBox_86_30);
            this.groupBox_2.Controls.Add(this.label_86_31);
            this.groupBox_2.Controls.Add(this.comboBox_86_31);
            this.groupBox_2.Controls.Add(this.checkBox_86_31);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.Text = "Forro";
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new Size(300, 320);
            //
            // ComboBoxes
            //
            this.label_86_20.Name = "label_86_20";
            this.label_86_20.Text = "F1";
            this.comboBox_86_20.Name = "comboBox_86_20";
            this.checkBox_86_20.Name = "checkBox_86_20";
            MyEvents.ComboBoxEvents(comboBox_86_20);
            MyEvents.CheckBoxEvents(checkBox_86_20, comboBox_86_20, 61, 20, "Forro 01");

            this.label_86_21.Name = "label_86_21";
            this.label_86_21.Text = "F2";
            this.comboBox_86_21.Name = "comboBox_86_21";
            this.checkBox_86_21.Name = "checkBox_86_21";
            MyEvents.ComboBoxEvents(comboBox_86_21);
            MyEvents.CheckBoxEvents(checkBox_86_21, comboBox_86_21, 62, 21, "Forro 02");

            this.label_86_22.Name = "label_86_22";
            this.label_86_22.Text = "F3";
            this.comboBox_86_22.Name = "comboBox_86_22";
            this.checkBox_86_22.Name = "checkBox_86_22";
            MyEvents.ComboBoxEvents(comboBox_86_22);
            MyEvents.CheckBoxEvents(checkBox_86_22, comboBox_86_22, 63, 22, "Forro 03");

            this.label_86_23.Name = "label_86_23";
            this.label_86_23.Text = "F4";
            this.comboBox_86_23.Name = "comboBox_86_23";
            this.checkBox_86_23.Name = "checkBox_86_23";
            MyEvents.ComboBoxEvents(comboBox_86_23);
            MyEvents.CheckBoxEvents(checkBox_86_23, comboBox_86_23, 64, 23, "Forro 04");

            this.label_86_24.Name = "label_86_24";
            this.label_86_24.Text = "F5";
            this.comboBox_86_24.Name = "comboBox_86_24";
            this.checkBox_86_24.Name = "checkBox_86_24";
            MyEvents.ComboBoxEvents(comboBox_86_24);
            MyEvents.CheckBoxEvents(checkBox_86_24, comboBox_86_24, 65, 24, "Forro 05");

            this.label_86_25.Name = "label_86_25";
            this.label_86_25.Text = "F6";
            this.comboBox_86_25.Name = "comboBox_86_25";
            this.checkBox_86_25.Name = "checkBox_86_25";
            MyEvents.ComboBoxEvents(comboBox_86_25);
            MyEvents.CheckBoxEvents(checkBox_86_25, comboBox_86_25, 66, 25, "Forro 06");

            this.label_86_26.Name = "label_86_26";
            this.label_86_26.Text = "F7";
            this.comboBox_86_26.Name = "comboBox_86_26";
            this.checkBox_86_26.Name = "checkBox_86_26";
            MyEvents.ComboBoxEvents(comboBox_86_26);
            MyEvents.CheckBoxEvents(checkBox_86_26, comboBox_86_26, 67, 26, "Forro 07");

            this.label_86_27.Name = "label_86_27";
            this.label_86_27.Text = "F8";
            this.comboBox_86_27.Name = "comboBox_86_27";
            this.checkBox_86_27.Name = "checkBox_86_27";
            MyEvents.ComboBoxEvents(comboBox_86_27);
            MyEvents.CheckBoxEvents(checkBox_86_27, comboBox_86_27, 68, 27, "Forro 08");

            this.label_86_28.Name = "label_86_28";
            this.label_86_28.Text = "F9";
            this.comboBox_86_28.Name = "comboBox_86_28";
            this.checkBox_86_28.Name = "checkBox_86_28";
            MyEvents.ComboBoxEvents(comboBox_86_28);
            MyEvents.CheckBoxEvents(checkBox_86_28, comboBox_86_28, 69, 28, "Forro 09");

            this.label_86_29.Name = "label_86_29";
            this.label_86_29.Text = "F10";
            this.comboBox_86_29.Name = "comboBox_86_29";
            this.checkBox_86_29.Name = "checkBox_86_29";
            MyEvents.ComboBoxEvents(comboBox_86_29);
            MyEvents.CheckBoxEvents(checkBox_86_29, comboBox_86_29, 70, 29, "Forro 10");

            this.label_86_30.Name = "label_86_30";
            this.label_86_30.Text = "F11";
            this.comboBox_86_30.Name = "comboBox_86_30";
            this.checkBox_86_30.Name = "checkBox_86_30";
            MyEvents.ComboBoxEvents(comboBox_86_30);
            MyEvents.CheckBoxEvents(checkBox_86_30, comboBox_86_30, 71, 30, "Forro 11");

            this.label_86_31.Name = "label_86_31";
            this.label_86_31.Text = "F12";
            this.comboBox_86_31.Name = "comboBox_86_31";
            this.checkBox_86_31.Name = "checkBox_86_31";
            MyEvents.ComboBoxEvents(comboBox_86_31);
            MyEvents.CheckBoxEvents(checkBox_86_31, comboBox_86_31, 72, 31, "Forro 12");

            #endregion
            #region groupBox_3

            this.groupBox_3.Controls.Add(this.label_86_34);
            this.groupBox_3.Controls.Add(this.comboBox_86_34);
            this.groupBox_3.Controls.Add(this.label_86_35);
            this.groupBox_3.Controls.Add(this.comboBox_86_35);
            this.groupBox_3.Controls.Add(this.label_86_36);
            this.groupBox_3.Controls.Add(this.comboBox_86_36);
            this.groupBox_3.Controls.Add(this.label_86_37);
            this.groupBox_3.Controls.Add(this.comboBox_86_37);
            this.groupBox_3.Controls.Add(this.label_86_38);
            this.groupBox_3.Controls.Add(this.comboBox_86_38);
            this.groupBox_3.Controls.Add(this.label_86_39);
            this.groupBox_3.Controls.Add(this.comboBox_86_39);
            this.groupBox_3.Controls.Add(this.label_86_40);
            this.groupBox_3.Controls.Add(this.comboBox_86_40);
            this.groupBox_3.TabIndex = 3;
            this.groupBox_3.Text = "Marcenaria";
            this.groupBox_3.Name = "groupBox_3";
            this.groupBox_3.Size = new Size(300, 190);
            //
            // ComboBoxes
            //
            this.label_86_34.Name = "label_86_34";
            this.label_86_34.Text = "M1";
            this.comboBox_86_34.Name = "comboBox_86_34";
            this.comboBox_86_34.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 34);
            };
            this.label_86_35.Name = "label_86_35";
            this.label_86_35.Text = "M2";
            this.comboBox_86_35.Name = "comboBox_86_35";
            this.comboBox_86_35.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 35);
            };
            this.label_86_36.Name = "label_86_36";
            this.label_86_36.Text = "M3";
            this.comboBox_86_36.Name = "comboBox_86_36";
            this.comboBox_86_36.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 36); 
            };
            this.label_86_37.Name = "label_86_37";
            this.label_86_37.Text = "M4";
            this.comboBox_86_37.Name = "comboBox_86_37";
            this.comboBox_86_37.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 37);
            };
            this.label_86_38.Name = "label_86_38";
            this.label_86_38.Text = "M5";
            this.comboBox_86_38.Name = "comboBox_86_38";
            this.comboBox_86_38.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 38);
            };
            this.label_86_39.Name = "label_86_39";
            this.label_86_39.Text = "M6";
            this.comboBox_86_39.Name = "comboBox_86_39";
            this.comboBox_86_39.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 39);
            };
            this.label_86_40.Name = "label_86_40";
            this.label_86_40.Text = "M7";
            this.comboBox_86_40.Name = "comboBox_86_40";
            this.comboBox_86_40.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 40);
            };
            #endregion
            #region  groupBox_4
            this.groupBox_4.Controls.Add(this.label_86_S);
            this.groupBox_4.Controls.Add(this.label_86_43);
            this.groupBox_4.Controls.Add(this.comboBox_86_43);
            this.groupBox_4.Controls.Add(this.checkBox_86_43);
            this.groupBox_4.Controls.Add(this.label_86_44);
            this.groupBox_4.Controls.Add(this.comboBox_86_44);
            this.groupBox_4.Controls.Add(this.checkBox_86_44);
            this.groupBox_4.Controls.Add(this.label_86_45);
            this.groupBox_4.Controls.Add(this.comboBox_86_45);
            this.groupBox_4.Controls.Add(this.checkBox_86_45);
            this.groupBox_4.Controls.Add(this.label_86_46);
            this.groupBox_4.Controls.Add(this.comboBox_86_46);
            this.groupBox_4.Controls.Add(this.checkBox_86_46);
            this.groupBox_4.Controls.Add(this.label_86_47);
            this.groupBox_4.Controls.Add(this.comboBox_86_47);
            this.groupBox_4.Controls.Add(this.checkBox_86_47);
            this.groupBox_4.Controls.Add(this.label_86_48);
            this.groupBox_4.Controls.Add(this.comboBox_86_48);
            this.groupBox_4.Controls.Add(this.checkBox_86_48);
            this.groupBox_4.Controls.Add(this.label_86_49);
            this.groupBox_4.Controls.Add(this.comboBox_86_49);
            this.groupBox_4.Controls.Add(this.checkBox_86_49);
            this.groupBox_4.Controls.Add(this.label_86_50);
            this.groupBox_4.Controls.Add(this.comboBox_86_50);
            this.groupBox_4.Controls.Add(this.checkBox_86_50);
            this.groupBox_4.Controls.Add(this.label_86_51);
            this.groupBox_4.Controls.Add(this.comboBox_86_51);
            this.groupBox_4.Controls.Add(this.checkBox_86_51);
            this.groupBox_4.Controls.Add(this.label_86_52);
            this.groupBox_4.Controls.Add(this.comboBox_86_52);
            this.groupBox_4.Controls.Add(this.checkBox_86_52);
            this.groupBox_4.Controls.Add(this.label_86_53);
            this.groupBox_4.Controls.Add(this.comboBox_86_53);
            this.groupBox_4.Controls.Add(this.checkBox_86_53);
            this.groupBox_4.Controls.Add(this.label_86_54);
            this.groupBox_4.Controls.Add(this.comboBox_86_54);
            this.groupBox_4.Controls.Add(this.checkBox_86_54);
            this.groupBox_4.TabIndex = 4;
            this.groupBox_4.Text = "Pisos";
            this.groupBox_4.Name = "groupBox_4";
            this.groupBox_4.Size = new Size(300, 320);
            //
            // ComboBoxes
            //
            this.label_86_43.Name = "label_86_43";
            this.label_86_43.Text = "P1";
            this.comboBox_86_43.Name = "comboBox_86_43";
            this.checkBox_86_43.Name = "checkBox_86_43";
            MyEvents.ComboBoxEvents(comboBox_86_43);
            MyEvents.CheckBoxEvents(checkBox_86_43, comboBox_86_43, 5, 43, "Piso 01");

            this.label_86_44.Name = "label_86_44";
            this.label_86_44.Text = "P2";
            this.comboBox_86_44.Name = "comboBox_86_44";
            this.checkBox_86_44.Name = "checkBox_86_44";
            MyEvents.ComboBoxEvents(comboBox_86_44);
            MyEvents.CheckBoxEvents(checkBox_86_44, comboBox_86_44, 6, 44, "Piso 02");

            this.label_86_45.Name = "label_86_45";
            this.label_86_45.Text = "P3";
            this.comboBox_86_45.Name = "comboBox_86_45";
            this.checkBox_86_45.Name = "checkBox_86_45";
            MyEvents.ComboBoxEvents(comboBox_86_45);
            MyEvents.CheckBoxEvents(checkBox_86_45, comboBox_86_45, 7, 45, "Piso 03");

            this.label_86_46.Name = "label_86_46";
            this.label_86_46.Text = "P4";
            this.comboBox_86_46.Name = "comboBox_86_46";
            this.checkBox_86_46.Name = "checkBox_86_46";
            MyEvents.ComboBoxEvents(comboBox_86_46);
            MyEvents.CheckBoxEvents(checkBox_86_46, comboBox_86_46, 8, 46, "Piso 04");

            this.label_86_47.Name = "label_86_47";
            this.label_86_47.Text = "P5";
            this.comboBox_86_47.Name = "comboBox_86_47";
            this.checkBox_86_47.Name = "checkBox_86_47";
            MyEvents.ComboBoxEvents(comboBox_86_47);
            MyEvents.CheckBoxEvents(checkBox_86_47, comboBox_86_47, 9, 47, "Piso 05");

            this.label_86_48.Name = "label_86_48";
            this.label_86_48.Text = "P6";
            this.comboBox_86_48.Name = "comboBox_86_48";
            this.checkBox_86_48.Name = "checkBox_86_48";
            MyEvents.ComboBoxEvents(comboBox_86_48);
            MyEvents.CheckBoxEvents(checkBox_86_48, comboBox_86_48, 10, 48, "Piso 06");

            this.label_86_49.Name = "label_86_49";
            this.label_86_49.Text = "P7";
            this.comboBox_86_49.Name = "comboBox_86_49";
            this.checkBox_86_49.Name = "checkBox_86_49";
            MyEvents.ComboBoxEvents(comboBox_86_49);
            MyEvents.CheckBoxEvents(checkBox_86_49, comboBox_86_49, 11, 49, "Piso 07");

            this.label_86_50.Name = "label_86_50";
            this.label_86_50.Text = "P8";
            this.comboBox_86_50.Name = "comboBox_86_50";
            this.checkBox_86_50.Name = "checkBox_86_50";
            MyEvents.ComboBoxEvents(comboBox_86_50);
            MyEvents.CheckBoxEvents(checkBox_86_50, comboBox_86_50, 12, 50, "Piso 08");

            this.label_86_51.Name = "label_86_51";
            this.label_86_51.Text = "P9";
            this.comboBox_86_51.Name = "comboBox_86_51";
            this.checkBox_86_51.Name = "checkBox_86_51";
            MyEvents.ComboBoxEvents(comboBox_86_51);
            MyEvents.CheckBoxEvents(checkBox_86_51, comboBox_86_51, 13, 51, "Piso 09");

            this.label_86_52.Name = "label_86_52";
            this.label_86_52.Text = "P10";
            this.comboBox_86_52.Name = "comboBox_86_52";
            this.checkBox_86_52.Name = "checkBox_86_52";
            MyEvents.ComboBoxEvents(comboBox_86_52);
            MyEvents.CheckBoxEvents(checkBox_86_52, comboBox_86_52, 14, 52, "Piso 10");

            this.label_86_53.Name = "label_86_53";
            this.label_86_53.Text = "P11";
            this.comboBox_86_53.Name = "comboBox_86_53";
            this.checkBox_86_53.Name = "checkBox_86_53";
            MyEvents.ComboBoxEvents(comboBox_86_53);
            MyEvents.CheckBoxEvents(checkBox_86_53, comboBox_86_53, 15, 53, "Piso 11");

            this.label_86_54.Name = "label_86_54";
            this.label_86_54.Text = "P12";
            this.comboBox_86_54.Name = "comboBox_86_54";
            this.checkBox_86_54.Name = "checkBox_86_54";
            MyEvents.ComboBoxEvents(comboBox_86_54);
            MyEvents.CheckBoxEvents(checkBox_86_54, comboBox_86_54, 16, 54, "Piso 12");

            #endregion
            #region  groupBox_5
            this.groupBox_5.Controls.Add(this.label_86_57);
            this.groupBox_5.Controls.Add(this.comboBox_86_57);
            this.groupBox_5.Controls.Add(this.label_86_58);
            this.groupBox_5.Controls.Add(this.comboBox_86_58);
            this.groupBox_5.Controls.Add(this.label_86_59);
            this.groupBox_5.Controls.Add(this.comboBox_86_59);
            this.groupBox_5.Controls.Add(this.label_86_60);
            this.groupBox_5.Controls.Add(this.comboBox_86_60);
            this.groupBox_5.Controls.Add(this.label_86_61);
            this.groupBox_5.Controls.Add(this.comboBox_86_61);
            this.groupBox_5.Controls.Add(this.label_86_62);
            this.groupBox_5.Controls.Add(this.comboBox_86_62);
            this.groupBox_5.Controls.Add(this.label_86_63);
            this.groupBox_5.Controls.Add(this.comboBox_86_63);
            this.groupBox_5.Controls.Add(this.label_86_64);
            this.groupBox_5.Controls.Add(this.comboBox_86_64);
            this.groupBox_5.Controls.Add(this.label_86_65);
            this.groupBox_5.Controls.Add(this.comboBox_86_65);
            this.groupBox_5.Controls.Add(this.label_86_66);
            this.groupBox_5.Controls.Add(this.comboBox_86_66);
            this.groupBox_5.Controls.Add(this.label_86_67);
            this.groupBox_5.Controls.Add(this.comboBox_86_67);
            this.groupBox_5.Controls.Add(this.label_86_68);
            this.groupBox_5.Controls.Add(this.comboBox_86_68);
            this.groupBox_5.Controls.Add(this.label_86_69);
            this.groupBox_5.Controls.Add(this.comboBox_86_69);
            this.groupBox_5.TabIndex = 5;
            this.groupBox_5.Text = "Revestimentos";
            this.groupBox_5.Name = "groupBox_5";
            this.groupBox_5.Size = new Size(300, 335);
            //
            // ComboBoxes
            //
            this.label_86_57.Name = "label_86_57";
            this.label_86_57.Text = "PP";
            this.comboBox_86_57.Name = "comboBox_86_57";
            this.comboBox_86_57.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 57);
            };
            this.label_86_58.Name = "label_86_58";
            this.label_86_58.Text = "R1";
            this.comboBox_86_58.Name = "comboBox_86_58";
            this.comboBox_86_58.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 58);
            };
            this.label_86_59.Name = "label_86_59";
            this.label_86_59.Text = "R2";
            this.comboBox_86_59.Name = "comboBox_86_59";
            this.comboBox_86_59.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 59);
            };
            this.label_86_60.Name = "label_86_60";
            this.label_86_60.Text = "R3";
            this.comboBox_86_60.Name = "comboBox_86_60";
            this.comboBox_86_60.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 60);
            };
            this.label_86_61.Name = "label_86_61";
            this.label_86_61.Text = "R4";
            this.comboBox_86_61.Name = "comboBox_86_61";
            this.comboBox_86_61.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 61);
            };
            this.label_86_62.Name = "label_86_62";
            this.label_86_62.Text = "R5";
            this.comboBox_86_62.Name = "comboBox_86_62";
            this.comboBox_86_62.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 62);
            };
            this.label_86_63.Name = "label_86_63";
            this.label_86_63.Text = "R6";
            this.comboBox_86_63.Name = "comboBox_86_63";
            this.comboBox_86_63.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 63);
            };
            this.label_86_64.Name = "label_86_64";
            this.label_86_64.Text = "R7";
            this.comboBox_86_64.Name = "comboBox_86_64";
            this.comboBox_86_64.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 64);
            };
            this.label_86_65.Name = "label_86_65";
            this.label_86_65.Text = "R8";
            this.comboBox_86_65.Name = "comboBox_86_65";
            this.comboBox_86_65.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 65);
            };
            this.label_86_66.Name = "label_86_66";
            this.label_86_66.Text = "R9";
            this.comboBox_86_66.Name = "comboBox_86_66";
            this.comboBox_86_66.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 66);
            };
            this.label_86_67.Name = "label_86_67";
            this.label_86_67.Text = "R10";
            this.comboBox_86_67.Name = "comboBox_86_67";
            this.comboBox_86_67.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 67);
            };
            this.label_86_68.Name = "label_86_68";
            this.label_86_68.Text = "R11";
            this.comboBox_86_68.Name = "comboBox_86_68";
            this.comboBox_86_68.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 68);
            };
            this.label_86_69.Name = "label_86_69";
            this.label_86_69.Text = "R12";
            this.comboBox_86_69.Name = "comboBox_86_69";
            this.comboBox_86_69.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 69);
            };
            #endregion
            #region  groupBox_6
            this.groupBox_6.Controls.Add(this.label_86_72);
            this.groupBox_6.Controls.Add(this.comboBox_86_72);
            this.groupBox_6.Controls.Add(this.label_86_73);
            this.groupBox_6.Controls.Add(this.comboBox_86_73);
            this.groupBox_6.Controls.Add(this.label_86_74);
            this.groupBox_6.Controls.Add(this.comboBox_86_74);
            this.groupBox_6.Controls.Add(this.label_86_75);
            this.groupBox_6.Controls.Add(this.comboBox_86_75);
            this.groupBox_6.Controls.Add(this.label_86_76);
            this.groupBox_6.Controls.Add(this.comboBox_86_76);
            this.groupBox_6.TabIndex = 6;
            this.groupBox_6.Text = "Vidros";
            this.groupBox_6.Name = "groupBox_6";
            this.groupBox_6.Size = new Size(300, 142);
            //
            // ComboBoxes
            //
            this.label_86_72.Name = "label_86_72";
            this.label_86_72.Text = "V1";
            this.comboBox_86_72.Name = "comboBox_86_72";
            this.comboBox_86_72.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 72);
            };
            this.label_86_73.Name = "label_86_73";
            this.label_86_73.Text = "V2";
            this.comboBox_86_73.Name = "comboBox_86_73";
            this.comboBox_86_73.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 73);
            };
            this.label_86_74.Name = "label_86_74";
            this.label_86_74.Text = "V3";
            this.comboBox_86_74.Name = "comboBox_86_74";
            this.comboBox_86_74.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 74);
            };
            this.label_86_75.Name = "label_86_75";
            this.label_86_75.Text = "V4";
            this.comboBox_86_75.Name = "comboBox_86_75";
            this.comboBox_86_75.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 75);
            };
            this.label_86_76.Name = "label_86_76";
            this.label_86_76.Text = "V5";
            this.comboBox_86_76.Name = "comboBox_86_76";
            this.comboBox_86_76.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.ComboBox_LostFocus(sender, e, 86, 76);
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

            this.comboBox_86_1.Text = MyProject.GetDetailValue(86, 1);
            if (MyProject.GetDetailValue(86, 1) == "Parede 01") { this.comboBox_86_1.Text = MyProject.GetDetailValue(47, 0); }
            this.comboBox_86_2.Text = MyProject.GetDetailValue(86, 2);
            if (MyProject.GetDetailValue(86, 2) == "Parede 02") { this.comboBox_86_2.Text = MyProject.GetDetailValue(48, 0); }
            this.comboBox_86_3.Text = MyProject.GetDetailValue(86, 3);
            if (MyProject.GetDetailValue(86, 3) == "Parede 03") { this.comboBox_86_3.Text = MyProject.GetDetailValue(49, 0); }
            this.comboBox_86_4.Text = MyProject.GetDetailValue(86, 4);
            if (MyProject.GetDetailValue(86, 4) == "Parede 04") { this.comboBox_86_4.Text = MyProject.GetDetailValue(50, 0); }
            this.comboBox_86_5.Text = MyProject.GetDetailValue(86, 5);
            if (MyProject.GetDetailValue(86, 5) == "Parede 05") { this.comboBox_86_5.Text = MyProject.GetDetailValue(51, 0); }
            this.comboBox_86_6.Text = MyProject.GetDetailValue(86, 6);
            if (MyProject.GetDetailValue(86, 6) == "Parede 06") { this.comboBox_86_6.Text = MyProject.GetDetailValue(52, 0); }
            this.comboBox_86_7.Text = MyProject.GetDetailValue(86, 7);
            if (MyProject.GetDetailValue(86, 7) == "Parede 07") { this.comboBox_86_7.Text = MyProject.GetDetailValue(53, 0); }
            this.comboBox_86_8.Text = MyProject.GetDetailValue(86, 8);
            if (MyProject.GetDetailValue(86, 8) == "Parede 08") { this.comboBox_86_8.Text = MyProject.GetDetailValue(54, 0); }
            this.comboBox_86_9.Text = MyProject.GetDetailValue(86, 9);
            if (MyProject.GetDetailValue(86, 9) == "Parede 09") { this.comboBox_86_9.Text = MyProject.GetDetailValue(55, 0); }
            this.comboBox_86_10.Text = MyProject.GetDetailValue(86, 10);
            if (MyProject.GetDetailValue(86, 10) == "Parede 10") { this.comboBox_86_10.Text = MyProject.GetDetailValue(56, 0); }
            this.comboBox_86_11.Text = MyProject.GetDetailValue(86, 11);
            if (MyProject.GetDetailValue(86, 11) == "Parede 11") { this.comboBox_86_11.Text = MyProject.GetDetailValue(57, 0); }
            this.comboBox_86_12.Text = MyProject.GetDetailValue(86, 12);
            if (MyProject.GetDetailValue(86, 12) == "Parede 12") { this.comboBox_86_12.Text = MyProject.GetDetailValue(58, 0); }

            foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Parede"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_86_1.Items.Add(value);
                this.comboBox_86_2.Items.Add(value);
                this.comboBox_86_3.Items.Add(value);
                this.comboBox_86_4.Items.Add(value);
                this.comboBox_86_5.Items.Add(value);
                this.comboBox_86_6.Items.Add(value);
                this.comboBox_86_7.Items.Add(value);
                this.comboBox_86_8.Items.Add(value);
                this.comboBox_86_9.Items.Add(value);
                this.comboBox_86_10.Items.Add(value);
                this.comboBox_86_11.Items.Add(value);
                this.comboBox_86_12.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_1

            this.comboBox_86_15.Text = MyProject.GetDetailValue(86, 15);
            this.comboBox_86_16.Text = MyProject.GetDetailValue(86, 16);
            this.comboBox_86_17.Text = MyProject.GetDetailValue(86, 17);

            foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Espelho"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_86_15.Items.Add(value);
                this.comboBox_86_16.Items.Add(value);
                this.comboBox_86_17.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_2

            this.comboBox_86_20.Text = MyProject.GetDetailValue(86, 20);
            if (MyProject.GetDetailValue(86, 20) == "Forro 01") { this.comboBox_86_20.Text = MyProject.GetDetailValue(61, 0); }
            this.comboBox_86_21.Text = MyProject.GetDetailValue(86, 21);
            if (MyProject.GetDetailValue(86, 21) == "Forro 02") { this.comboBox_86_21.Text = MyProject.GetDetailValue(62, 0); }
            this.comboBox_86_22.Text = MyProject.GetDetailValue(86, 22);
            if (MyProject.GetDetailValue(86, 22) == "Forro 03") { this.comboBox_86_23.Text = MyProject.GetDetailValue(63, 0); }
            this.comboBox_86_23.Text = MyProject.GetDetailValue(86, 23);
            if (MyProject.GetDetailValue(86, 23) == "Forro 04") { this.comboBox_86_23.Text = MyProject.GetDetailValue(64, 0); }
            this.comboBox_86_24.Text = MyProject.GetDetailValue(86, 24);
            if (MyProject.GetDetailValue(86, 24) == "Forro 05") { this.comboBox_86_24.Text = MyProject.GetDetailValue(65, 0); }
            this.comboBox_86_25.Text = MyProject.GetDetailValue(86, 25);
            if (MyProject.GetDetailValue(86, 25) == "Forro 06") { this.comboBox_86_25.Text = MyProject.GetDetailValue(66, 0); }
            this.comboBox_86_26.Text = MyProject.GetDetailValue(86, 26);
            if (MyProject.GetDetailValue(86, 26) == "Forro 07") { this.comboBox_86_26.Text = MyProject.GetDetailValue(67, 0); }
            this.comboBox_86_27.Text = MyProject.GetDetailValue(86, 27);
            if (MyProject.GetDetailValue(86, 27) == "Forro 08") { this.comboBox_86_27.Text = MyProject.GetDetailValue(68, 0); }
            this.comboBox_86_28.Text = MyProject.GetDetailValue(86, 28);
            if (MyProject.GetDetailValue(86, 28) == "Forro 09") { this.comboBox_86_28.Text = MyProject.GetDetailValue(69, 0); }
            this.comboBox_86_29.Text = MyProject.GetDetailValue(86, 29);
            if (MyProject.GetDetailValue(86, 29) == "Forro 10") { this.comboBox_86_29.Text = MyProject.GetDetailValue(70, 0); }
            this.comboBox_86_30.Text = MyProject.GetDetailValue(86, 30);
            if (MyProject.GetDetailValue(86, 30) == "Forro 11") { this.comboBox_86_30.Text = MyProject.GetDetailValue(71, 0); }
            this.comboBox_86_31.Text = MyProject.GetDetailValue(86, 31);
            if (MyProject.GetDetailValue(86, 31) == "Forro 12") { this.comboBox_86_31.Text = MyProject.GetDetailValue(72, 0); }

            foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Teto"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_86_20.Items.Add(value);
                this.comboBox_86_21.Items.Add(value);
                this.comboBox_86_22.Items.Add(value);
                this.comboBox_86_23.Items.Add(value);
                this.comboBox_86_24.Items.Add(value);
                this.comboBox_86_25.Items.Add(value);
                this.comboBox_86_26.Items.Add(value);
                this.comboBox_86_27.Items.Add(value);
                this.comboBox_86_28.Items.Add(value);
                this.comboBox_86_29.Items.Add(value);
                this.comboBox_86_30.Items.Add(value);
                this.comboBox_86_31.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_3

            this.comboBox_86_34.Text = MyProject.GetDetailValue(86, 34);
            this.comboBox_86_35.Text = MyProject.GetDetailValue(86, 35);
            this.comboBox_86_36.Text = MyProject.GetDetailValue(86, 36);
            this.comboBox_86_37.Text = MyProject.GetDetailValue(86, 37);
            this.comboBox_86_38.Text = MyProject.GetDetailValue(86, 38);
            this.comboBox_86_39.Text = MyProject.GetDetailValue(86, 39);
            this.comboBox_86_40.Text = MyProject.GetDetailValue(86, 40);

            foreach (var combobox in this.groupBox_3.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Marcenaria"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_86_34.Items.Add(value);
                this.comboBox_86_35.Items.Add(value);
                this.comboBox_86_36.Items.Add(value);
                this.comboBox_86_37.Items.Add(value);
                this.comboBox_86_38.Items.Add(value);
                this.comboBox_86_39.Items.Add(value);
                this.comboBox_86_40.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_4

            this.comboBox_86_43.Text = MyProject.GetDetailValue(86, 43);
            if (MyProject.GetDetailValue(86, 43) == "Piso 01") { this.comboBox_86_43.Text = MyProject.GetDetailValue(5, 0); }
            this.comboBox_86_44.Text = MyProject.GetDetailValue(86, 44);
            if (MyProject.GetDetailValue(86, 44) == "Piso 02") { this.comboBox_86_44.Text = MyProject.GetDetailValue(6, 0); }
            this.comboBox_86_45.Text = MyProject.GetDetailValue(86, 45);
            if (MyProject.GetDetailValue(86, 45) == "Piso 03") { this.comboBox_86_45.Text = MyProject.GetDetailValue(7, 0); }
            this.comboBox_86_46.Text = MyProject.GetDetailValue(86, 46);
            if (MyProject.GetDetailValue(86, 46) == "Piso 04") { this.comboBox_86_46.Text = MyProject.GetDetailValue(8, 0); }
            this.comboBox_86_47.Text = MyProject.GetDetailValue(86, 47);
            if (MyProject.GetDetailValue(86, 47) == "Piso 05") { this.comboBox_86_47.Text = MyProject.GetDetailValue(9, 0); }
            this.comboBox_86_48.Text = MyProject.GetDetailValue(86, 48);
            if (MyProject.GetDetailValue(86, 48) == "Piso 06") { this.comboBox_86_48.Text = MyProject.GetDetailValue(10, 0); }
            this.comboBox_86_49.Text = MyProject.GetDetailValue(86, 49);
            if (MyProject.GetDetailValue(86, 49) == "Piso 07") { this.comboBox_86_49.Text = MyProject.GetDetailValue(11, 0); }
            this.comboBox_86_50.Text = MyProject.GetDetailValue(86, 50);
            if (MyProject.GetDetailValue(86, 50) == "Piso 08") { this.comboBox_86_50.Text = MyProject.GetDetailValue(12, 0); }
            this.comboBox_86_51.Text = MyProject.GetDetailValue(86, 51);
            if (MyProject.GetDetailValue(86, 51) == "Piso 09") { this.comboBox_86_51.Text = MyProject.GetDetailValue(13, 0); }
            this.comboBox_86_52.Text = MyProject.GetDetailValue(86, 52);
            if (MyProject.GetDetailValue(86, 52) == "Piso 10") { this.comboBox_86_52.Text = MyProject.GetDetailValue(14, 0); }
            this.comboBox_86_53.Text = MyProject.GetDetailValue(86, 53);
            if (MyProject.GetDetailValue(86, 53) == "Piso 11") { this.comboBox_86_53.Text = MyProject.GetDetailValue(15, 0); }
            this.comboBox_86_54.Text = MyProject.GetDetailValue(86, 54);
            if (MyProject.GetDetailValue(86, 54) == "Piso 12") { this.comboBox_86_54.Text = MyProject.GetDetailValue(16, 0); }

            foreach (var combobox in this.groupBox_4.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Piso"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_86_43.Items.Add(value);
                this.comboBox_86_44.Items.Add(value);
                this.comboBox_86_45.Items.Add(value);
                this.comboBox_86_46.Items.Add(value);
                this.comboBox_86_47.Items.Add(value);
                this.comboBox_86_48.Items.Add(value);
                this.comboBox_86_49.Items.Add(value);
                this.comboBox_86_50.Items.Add(value);
                this.comboBox_86_51.Items.Add(value);
                this.comboBox_86_52.Items.Add(value);
                this.comboBox_86_53.Items.Add(value);
                this.comboBox_86_54.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_5

            this.comboBox_86_57.Text = MyProject.GetDetailValue(86, 57);
            this.comboBox_86_58.Text = MyProject.GetDetailValue(86, 58);
            this.comboBox_86_59.Text = MyProject.GetDetailValue(86, 59);
            this.comboBox_86_60.Text = MyProject.GetDetailValue(86, 60);
            this.comboBox_86_61.Text = MyProject.GetDetailValue(86, 61);
            this.comboBox_86_62.Text = MyProject.GetDetailValue(86, 62);
            this.comboBox_86_63.Text = MyProject.GetDetailValue(86, 63);
            this.comboBox_86_64.Text = MyProject.GetDetailValue(86, 64);
            this.comboBox_86_65.Text = MyProject.GetDetailValue(86, 65);
            this.comboBox_86_66.Text = MyProject.GetDetailValue(86, 66);
            this.comboBox_86_67.Text = MyProject.GetDetailValue(86, 67);
            this.comboBox_86_68.Text = MyProject.GetDetailValue(86, 68);
            this.comboBox_86_69.Text = MyProject.GetDetailValue(86, 69);

            foreach (var combobox in this.groupBox_5.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Revestimento"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_86_57.Items.Add(value);
                this.comboBox_86_58.Items.Add(value);
                this.comboBox_86_59.Items.Add(value);
                this.comboBox_86_60.Items.Add(value);
                this.comboBox_86_61.Items.Add(value);
                this.comboBox_86_62.Items.Add(value);
                this.comboBox_86_63.Items.Add(value);
                this.comboBox_86_64.Items.Add(value);
                this.comboBox_86_65.Items.Add(value);
                this.comboBox_86_66.Items.Add(value);
                this.comboBox_86_67.Items.Add(value);
                this.comboBox_86_68.Items.Add(value);
                this.comboBox_86_69.Items.Add(value);
            }
            #endregion
            #region Fill groupBox_6

            this.comboBox_86_72.Text = MyProject.GetDetailValue(86, 72);
            this.comboBox_86_73.Text = MyProject.GetDetailValue(86, 73);
            this.comboBox_86_74.Text = MyProject.GetDetailValue(86, 74);
            this.comboBox_86_75.Text = MyProject.GetDetailValue(86, 75);
            this.comboBox_86_76.Text = MyProject.GetDetailValue(86, 76);

            foreach (var combobox in this.groupBox_6.Controls.OfType<ComboBox>())
                combobox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Vidro"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_86_72.Items.Add(value);
                this.comboBox_86_73.Items.Add(value);
                this.comboBox_86_74.Items.Add(value);
                this.comboBox_86_75.Items.Add(value);
                this.comboBox_86_76.Items.Add(value);
            }
            #endregion
        }
        internal void FillList(string _combobox)
        {
            switch (_combobox)
            {
                case "comboBox_86_1":
                    foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Parede"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_86_1.Items.Add(value);
                        this.comboBox_86_2.Items.Add(value);
                        this.comboBox_86_3.Items.Add(value);
                        this.comboBox_86_4.Items.Add(value);
                        this.comboBox_86_5.Items.Add(value);
                        this.comboBox_86_6.Items.Add(value);
                        this.comboBox_86_7.Items.Add(value);
                        this.comboBox_86_8.Items.Add(value);
                        this.comboBox_86_9.Items.Add(value);
                        this.comboBox_86_10.Items.Add(value);
                        this.comboBox_86_11.Items.Add(value);
                        this.comboBox_86_12.Items.Add(value);
                    }
                    break;
                case "comboBox_86_15":
                    foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Espelho"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_86_15.Items.Add(value);
                        this.comboBox_86_16.Items.Add(value);
                        this.comboBox_86_17.Items.Add(value);
                    }
                    break;
                case "comboBox_86_20":
                    foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Teto"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_86_20.Items.Add(value);
                        this.comboBox_86_21.Items.Add(value);
                        this.comboBox_86_22.Items.Add(value);
                        this.comboBox_86_23.Items.Add(value);
                        this.comboBox_86_24.Items.Add(value);
                        this.comboBox_86_25.Items.Add(value);
                        this.comboBox_86_26.Items.Add(value);
                        this.comboBox_86_27.Items.Add(value);
                        this.comboBox_86_28.Items.Add(value);
                        this.comboBox_86_29.Items.Add(value);
                        this.comboBox_86_30.Items.Add(value);
                        this.comboBox_86_31.Items.Add(value);
                    }
                    break;
                case "comboBox_86_34":
                    foreach (var combobox in this.groupBox_3.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Marcenaria"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_86_34.Items.Add(value);
                        this.comboBox_86_35.Items.Add(value);
                        this.comboBox_86_36.Items.Add(value);
                        this.comboBox_86_37.Items.Add(value);
                        this.comboBox_86_38.Items.Add(value);
                        this.comboBox_86_39.Items.Add(value);
                        this.comboBox_86_40.Items.Add(value);
                    }
                    break;
                case "comboBox_86_43":
                    foreach (var combobox in this.groupBox_4.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Piso"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_86_43.Items.Add(value);
                        this.comboBox_86_44.Items.Add(value);
                        this.comboBox_86_45.Items.Add(value);
                        this.comboBox_86_46.Items.Add(value);
                        this.comboBox_86_47.Items.Add(value);
                        this.comboBox_86_48.Items.Add(value);
                        this.comboBox_86_49.Items.Add(value);
                        this.comboBox_86_50.Items.Add(value);
                        this.comboBox_86_51.Items.Add(value);
                        this.comboBox_86_52.Items.Add(value);
                        this.comboBox_86_53.Items.Add(value);
                        this.comboBox_86_54.Items.Add(value);
                    }
                    break;
                case "comboBox_86_57":
                    foreach (var combobox in this.groupBox_5.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Revestimento"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_86_57.Items.Add(value);
                        this.comboBox_86_58.Items.Add(value);
                        this.comboBox_86_59.Items.Add(value);
                        this.comboBox_86_60.Items.Add(value);
                        this.comboBox_86_61.Items.Add(value);
                        this.comboBox_86_62.Items.Add(value);
                        this.comboBox_86_63.Items.Add(value);
                        this.comboBox_86_64.Items.Add(value);
                        this.comboBox_86_65.Items.Add(value);
                        this.comboBox_86_66.Items.Add(value);
                        this.comboBox_86_67.Items.Add(value);
                        this.comboBox_86_68.Items.Add(value);
                        this.comboBox_86_69.Items.Add(value);
                    }
                    break;
                case "comboBox_86_72":
                    foreach (var combobox in this.groupBox_6.Controls.OfType<ComboBox>())
                        combobox.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Vidro"))
                    {
                        string value = item.Attribute("nome").Value;
                        this.comboBox_86_72.Items.Add(value);
                        this.comboBox_86_73.Items.Add(value);
                        this.comboBox_86_74.Items.Add(value);
                        this.comboBox_86_75.Items.Add(value);
                        this.comboBox_86_76.Items.Add(value);
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

            int comboBox_0 = 4;
            int label_0 = -17;
            int checkbox_0 = 6;

            foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
            {
                comboBox_0 = comboBox_0 + 24;
                combobox.Size = new Size(200, 20);
                combobox.Location = new Point(55, comboBox_0);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_0.Controls.OfType<Label>())
            {
                label_0 = label_0 + 24;
                label.Size = new Size(25, 13);
                label.Location = new Point(20, label_0);
                MyFormats.LabelFormat(label);
            }

            foreach (var checkbox in this.groupBox_0.Controls.OfType<CheckBox>())
            {
                checkbox_0 = checkbox_0 + 24;
                checkbox.Size = new Size(17, 17);
                checkbox.Location = new Point(268, checkbox_0);
                MyFormats.CheckBoxFormat(checkbox);
            }
            #endregion
            #region groupBox_1 builder

            int comboBox_1 = -6;
            int label_1 = -5;

            foreach (var combobox in this.groupBox_1.Controls.OfType<ComboBox>())
            {
                comboBox_1 = comboBox_1 + 24;
                combobox.Size = new Size(200, 20);
                combobox.Location = new Point(55, comboBox_1);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_1.Controls.OfType<Label>())
            {
                label_1 = label_1 + 24;
                label.Size = new Size(25, 13);
                label.Location = new Point(20, label_1);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_2 builder

            int comboBox_2 = 4;
            int label_2 = -17;
            int checkbox_2 = 6;

            foreach (var combobox in this.groupBox_2.Controls.OfType<ComboBox>())
            {
                comboBox_2 = comboBox_2 + 24;
                combobox.Size = new Size(200, 20);
                combobox.Location = new Point(55, comboBox_2);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_2.Controls.OfType<Label>())
            {
                label_2 = label_2 + 24;
                label.Size = new Size(25, 13);
                label.Location = new Point(20, label_2);
                MyFormats.LabelFormat(label);
            }

            foreach (var checkbox in this.groupBox_2.Controls.OfType<CheckBox>())
            {
                checkbox_2 = checkbox_2 + 24;
                checkbox.Size = new Size(17, 17);
                checkbox.Location = new Point(268, checkbox_2);
                MyFormats.CheckBoxFormat(checkbox);
            }
            #endregion
            #region groupBox_3 builder

            int comboBox_3 = -6;
            int label_3 = -5;

            foreach (var combobox in this.groupBox_3.Controls.OfType<ComboBox>())
            {
                comboBox_3 = comboBox_3 + 24;
                combobox.Size = new Size(200, 20);
                combobox.Location = new Point(55, comboBox_3);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_3.Controls.OfType<Label>())
            {
                label_3 = label_3 + 24;
                label.Size = new Size(25, 13);
                label.Location = new Point(20, label_3);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_4 builder

            int comboBox_4 = 4;
            int label_4 = -17;
            int checkbox_4 = 6;

            foreach (var combobox in this.groupBox_4.Controls.OfType<ComboBox>())
            {
                comboBox_4 = comboBox_4 + 24;
                combobox.Size = new Size(200, 20);
                combobox.Location = new Point(55, comboBox_4);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_4.Controls.OfType<Label>())
            {
                label_4 = label_4 + 24;
                label.Size = new Size(25, 13);
                label.Location = new Point(20, label_4);
                MyFormats.LabelFormat(label);
            }

            foreach (var checkbox in this.groupBox_4.Controls.OfType<CheckBox>())
            {
                checkbox_4 = checkbox_4 + 24;
                checkbox.Size = new Size(17, 17);
                checkbox.Location = new Point(268, checkbox_4);
                MyFormats.CheckBoxFormat(checkbox);
            }
            #endregion
            #region groupBox_5 builder

            int comboBox_5 = -6;
            int label_5 = -5;

            foreach (var combobox in this.groupBox_5.Controls.OfType<ComboBox>())
            {
                comboBox_5 = comboBox_5 + 24;
                combobox.Size = new Size(200, 20);
                combobox.Location = new Point(55, comboBox_5);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_5.Controls.OfType<Label>())
            {
                label_5 = label_5 + 24;
                label.Size = new Size(25, 13);
                label.Location = new Point(20, label_5);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_6 builder

            int comboBox_6 = -6;
            int label_6 = -5;

            foreach (var combobox in this.groupBox_6.Controls.OfType<ComboBox>())
            {
                comboBox_6 = comboBox_6 + 24;
                combobox.Size = new Size(200, 20);
                combobox.Location = new Point(55, comboBox_6);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_6.Controls.OfType<Label>())
            {
                label_6 = label_6 + 24;
                label.Size = new Size(25, 13);
                label.Location = new Point(20, label_6);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region Sync labels
            this.label_86_P.Name = "label_86_P";
            this.label_86_P.Text = "Sync";
            this.label_86_P.Anchor = ((AnchorStyles)((
                AnchorStyles.Top |
                AnchorStyles.Right)));
            this.label_86_P.ForeColor = SystemColors.ControlDarkDark;
            this.label_86_P.Size = new Size(40, 13);
            this.label_86_P.Location = new Point(263, 10);

            this.label_86_F.Name = "label_86_F";
            this.label_86_F.Text = "Sync";
            this.label_86_F.Anchor = ((AnchorStyles)((
                AnchorStyles.Top |
                AnchorStyles.Right)));
            this.label_86_F.ForeColor = SystemColors.ControlDarkDark;
            this.label_86_F.Size = new Size(40, 13);
            this.label_86_F.Location = new Point(263, 10);

            this.label_86_S.Name = "label_86_S";
            this.label_86_S.Text = "Sync";
            this.label_86_S.Anchor = ((AnchorStyles)((
                AnchorStyles.Top |
                AnchorStyles.Right)));
            this.label_86_S.ForeColor = SystemColors.ControlDarkDark;
            this.label_86_S.Size = new Size(40, 13);
            this.label_86_S.Location = new Point(263, 10);
            #endregion
        }
    }
}*/