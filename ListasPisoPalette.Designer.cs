﻿using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class ListasPisoPalette
    {
        #region Lista de Controles
        private Panel panel;
        private Label label;

        private Label space_0;
        private Label space_1;
        private Label space_2;
        private Label space_3;

        private GroupBox groupBox_5_0;
        private Label label_5_0;
        private TextBox textBox_5_0;
        private ListBox listBox_5_0;

        private GroupBox groupBox_5_1;
        private Label label_5_1;
        private TextBox textBox_5_1;
        private ListBox listBox_5_1;

        private GroupBox groupBox_5_3;
        private Label label_5_3;
        private TextBox textBox_5_3;
        private ListBox listBox_5_3;

        private GroupBox groupBox_5_4;
        private Label label_5_4;
        private TextBox textBox_5_4;
        private ListBox listBox_5_4;

        private GroupBox groupBox_5_5;
        private Label label_5_5;
        private TextBox textBox_5_5;
        private ListBox listBox_5_5;

        #endregion
        private void InitializeComponent()
        {
            #region Lista de Controles
            this.panel = new ExPanel();
            this.label = new Label();

            this.space_0 = new Label();
            this.space_1 = new Label();
            this.space_2 = new Label();
            this.space_3 = new Label();

            this.groupBox_5_0 = new GroupBox();
            this.label_5_0 = new Label();
            this.textBox_5_0 = new TextBox();
            this.listBox_5_0 = new ListBox();

            this.groupBox_5_1 = new GroupBox();
            this.label_5_1 = new Label();
            this.textBox_5_1 = new TextBox();
            this.listBox_5_1 = new ListBox();

            this.groupBox_5_3 = new GroupBox();
            this.label_5_3 = new Label();
            this.textBox_5_3 = new TextBox();
            this.listBox_5_3 = new ListBox();

            this.groupBox_5_4 = new GroupBox();
            this.label_5_4 = new Label();
            this.textBox_5_4 = new TextBox();
            this.listBox_5_4 = new ListBox();

            this.groupBox_5_5 = new GroupBox();
            this.label_5_5 = new Label();
            this.textBox_5_5 = new TextBox();
            this.listBox_5_5 = new ListBox();
            this.SuspendLayout();
            #endregion
            #region panel + label

            this.panel.Controls.Add(this.groupBox_5_5);   //FabricantePiso
            this.panel.Controls.Add(this.space_3);
            this.panel.Controls.Add(this.groupBox_5_4);   //AcabamentoPiso
            this.panel.Controls.Add(this.space_2);
            this.panel.Controls.Add(this.groupBox_5_3);   //Dimensão
            this.panel.Controls.Add(this.space_1);
            this.panel.Controls.Add(this.groupBox_5_1);   //PisoAbreviado
            this.panel.Controls.Add(this.space_0);
            this.panel.Controls.Add(this.groupBox_5_0);   //Piso

            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);

            #endregion
            #region  groupBox_5_0 
            this.groupBox_5_0.Controls.Add(this.label_5_0);
            this.groupBox_5_0.Controls.Add(this.textBox_5_0);
            this.groupBox_5_0.Controls.Add(this.listBox_5_0);
            this.groupBox_5_0.TabIndex = 0;
            this.groupBox_5_0.Text = "Material";
            this.groupBox_5_0.Name = "groupBox_5_0 ";
            this.groupBox_5_0.Size = new Size(300, 175);

            this.label_5_0.Name = "label_5_0";
            this.label_5_0.Text = "Novo:";
            this.textBox_5_0.Name = "textBox_5_0";
            this.listBox_5_0.Name = "listBox_5_0";
            MyEvents.ListBox_Events(listBox_5_0, textBox_5_0, "Piso");
            #endregion
            #region  groupBox_5_1
            this.groupBox_5_1.Controls.Add(this.label_5_1);
            this.groupBox_5_1.Controls.Add(this.textBox_5_1);
            this.groupBox_5_1.Controls.Add(this.listBox_5_1);
            this.groupBox_5_1.TabIndex = 0;
            this.groupBox_5_1.Text = "Material abreviado";
            this.groupBox_5_1.Name = "groupBox_5_1";
            this.groupBox_5_1.Size = new Size(300, 175);

            this.label_5_1.Name = "label_5_1";
            this.label_5_1.Text = "Novo:";
            this.textBox_5_1.Name = "textBox_5_1";
            this.listBox_5_1.Name = "listBox_5_1";
            MyEvents.ListBox_Events(listBox_5_1, textBox_5_1, "PisoAbreviado");
            #endregion
            #region  groupBox_5_3
            this.groupBox_5_3.Controls.Add(this.label_5_3);
            this.groupBox_5_3.Controls.Add(this.textBox_5_3);
            this.groupBox_5_3.Controls.Add(this.listBox_5_3);
            this.groupBox_5_3.TabIndex = 0;
            this.groupBox_5_3.Text = "Dimensão";
            this.groupBox_5_3.Name = "groupBox_5_3";
            this.groupBox_5_3.Size = new Size(300, 175);

            this.label_5_3.Name = "label_5_3";
            this.label_5_3.Text = "Novo:";
            this.textBox_5_3.Name = "textBox_5_3";
            this.listBox_5_3.Name = "listBox_5_3";
            MyEvents.ListBox_Events(listBox_5_3, textBox_5_3, "Dimensão");
            #endregion
            #region  groupBox_5_4
            this.groupBox_5_4.Controls.Add(this.label_5_4);
            this.groupBox_5_4.Controls.Add(this.textBox_5_4);
            this.groupBox_5_4.Controls.Add(this.listBox_5_4);
            this.groupBox_5_4.TabIndex = 0;
            this.groupBox_5_4.Text = "Acabamento";
            this.groupBox_5_4.Name = "groupBox_5_4";
            this.groupBox_5_4.Size = new Size(300, 175);

            this.label_5_4.Name = "label_5_4";
            this.label_5_4.Text = "Novo:";
            this.textBox_5_4.Name = "textBox_5_4";
            this.listBox_5_4.Name = "listBox_5_4";
            MyEvents.ListBox_Events(listBox_5_4, textBox_5_4, "AcabamentoPiso");
            #endregion
            #region  groupBox_5_5
            this.groupBox_5_5.Controls.Add(this.label_5_5);
            this.groupBox_5_5.Controls.Add(this.textBox_5_5);
            this.groupBox_5_5.Controls.Add(this.listBox_5_5);
            this.groupBox_5_5.TabIndex = 0;
            this.groupBox_5_5.Text = "Fabricante";
            this.groupBox_5_5.Name = "groupBox_5_5";
            this.groupBox_5_5.Size = new Size(300, 175);

            this.label_5_5.Name = "label_5_5";
            this.label_5_5.Text = "Novo:";
            this.textBox_5_5.Name = "textBox_5_5";
            this.listBox_5_5.Name = "listBox_5_5";
            MyEvents.ListBox_Events(listBox_5_5, textBox_5_5, "FabricantePiso");
            #endregion

            int _padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "ListaPalette";
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label);
            this.Padding = new Padding(_padd, 10, 10, 10);
            this.Size = new Size(320, 650);
            this.FormatComponent();
            this.FillComponent();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        internal void FillComp(ListBox listbox, string _group)
        {
            listbox.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants(_group))
            {
                string value = item.Attribute("nome").Value;
                listbox.Items.Add(value);
            }
        }
        internal void FillComponent()
        {
            this.label.Text = "Piso";

            FillComp(listBox_5_0, "Piso");
            FillComp(listBox_5_1, "PisoAbreviado");
            FillComp(listBox_5_3, "Dimensão");
            FillComp(listBox_5_4, "AcabamentoPiso");
            FillComp(listBox_5_5, "FabricantePiso");
        }
        internal void FillList(string combobox)
        {
            switch (combobox)
            {
                case "comboBox_5_0":
                    listBox_5_0.Items.Clear();
                    FillComp(listBox_5_0, "Piso");
                    break;
                case "comboBox_5_1":
                    listBox_5_1.Items.Clear();
                    FillComp(listBox_5_1, "PisoAbreviado");
                    break;
                case "comboBox_5_3":
                    listBox_5_3.Items.Clear();
                    FillComp(listBox_5_3, "Dimensão");
                    break;
                case "comboBox_5_4":
                    listBox_5_4.Items.Clear();
                    FillComp(listBox_5_4, "AcabamentoPiso");
                    break;
                case "comboBox_5_5":
                    listBox_5_5.Items.Clear();
                    FillComp(listBox_5_5, "FabricantePiso");
                    break;
            }
        }
        private void FormatComponent()
        {
            foreach (var groupbox in this.panel.Controls.OfType<GroupBox>())
            {
                MyFormats.GroupBoxFormat(groupbox);

                int textbox_0 = -4;
                int label_0 = -6;

                foreach (var textbox in groupbox.Controls.OfType<TextBox>())
                {
                    textbox_0 = textbox_0 + 24;
                    textbox.Size = new Size(210, 20);
                    textbox.Location = new Point(75, textbox_0);
                    MyFormats.TextBoxFormat(textbox);
                }

                foreach (var label in groupbox.Controls.OfType<Label>())
                {
                    label_0 = label_0 + 24;
                    label.Size = new Size(40, 14);
                    label.Location = new Point(15, label_0);
                    MyFormats.LabelFormat(label);
                }

                foreach (var listbox in groupbox.Controls.OfType<ListBox>())
                {
                    listbox.Anchor = ((AnchorStyles)(((
                        AnchorStyles.Top |
                        AnchorStyles.Left) |
                        AnchorStyles.Right)));
                    listbox.FormattingEnabled = true;
                    listbox.BorderStyle = BorderStyle.None;
                    listbox.Size = new Size(283, 120);
                    listbox.Location = new Point(15, 45);
                }
            }
            foreach (var space in this.panel.Controls.OfType<Label>())
            {
                MyFormats.SpaceFormat(space);
            }
        }
    }
}