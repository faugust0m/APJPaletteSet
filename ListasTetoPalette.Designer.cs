using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class ListasTetoPalette
    {
        #region Lista de Controles
        private Panel panel;
        private Label label;

        private Label space_0;
        private Label space_1;
        private Label space_2;
        private Label space_3;
        private Label space_4;

        private GroupBox groupBox_5_3;
        private Label label_5_3;
        private TextBox textBox_5_3;
        private ListBox listBox_5_3;

        private GroupBox groupBox_47_4;
        private Label label_47_4;
        private TextBox textBox_47_4;
        private ListBox listBox_47_4;

        private GroupBox groupBox_61_0;
        private Label label_61_0;
        private TextBox textBox_61_0;
        private ListBox listBox_61_0;

        private GroupBox groupBox_61_1;
        private Label label_61_1;
        private TextBox textBox_61_1;
        private ListBox listBox_61_1;

        private GroupBox groupBox_61_3;
        private Label label_61_3;
        private TextBox textBox_61_3;
        private ListBox listBox_61_3;

        private GroupBox groupBox_61_6;
        private Label label_61_6;
        private TextBox textBox_61_6;
        private ListBox listBox_61_6;

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
            this.space_4 = new Label();

            this.groupBox_5_3 = new GroupBox();
            this.label_5_3 = new Label();
            this.textBox_5_3 = new TextBox();
            this.listBox_5_3 = new ListBox();

            this.groupBox_47_4 = new GroupBox();
            this.label_47_4 = new Label();
            this.textBox_47_4 = new TextBox();
            this.listBox_47_4 = new ListBox();

            this.groupBox_61_0 = new GroupBox();
            this.label_61_0 = new Label();
            this.textBox_61_0 = new TextBox();
            this.listBox_61_0 = new ListBox();

            this.groupBox_61_1 = new GroupBox();
            this.label_61_1 = new Label();
            this.textBox_61_1 = new TextBox();
            this.listBox_61_1 = new ListBox();

            this.groupBox_61_3 = new GroupBox();
            this.label_61_3 = new Label();
            this.textBox_61_3 = new TextBox();
            this.listBox_61_3 = new ListBox();

            this.groupBox_61_6 = new GroupBox();
            this.label_61_6 = new Label();
            this.textBox_61_6 = new TextBox();
            this.listBox_61_6 = new ListBox();
            this.SuspendLayout();
            #endregion
            #region panel + label

            this.panel.Controls.Add(this.groupBox_61_6);  //FabricanteTeto
            this.panel.Controls.Add(this.space_4);
            this.panel.Controls.Add(this.groupBox_47_4);  //Acabamento
            this.panel.Controls.Add(this.space_3);
            this.panel.Controls.Add(this.groupBox_5_3);   //Dimensão
            this.panel.Controls.Add(this.space_2);
            this.panel.Controls.Add(this.groupBox_61_3);  //Altura
            this.panel.Controls.Add(this.space_1);
            this.panel.Controls.Add(this.groupBox_61_1);  //TetoAbreviado
            this.panel.Controls.Add(this.space_0);
            this.panel.Controls.Add(this.groupBox_61_0);  //Teto

            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);

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
            this.listBox_5_3.Name = "listBox_5_3";
            MyEvents.ListBox_Events(listBox_5_3, textBox_5_3, "Dimensão");
            this.textBox_5_3.Name = "textBox_5_3";
            this.textBox_5_3.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_5_3, "Dimensão");
            };
            #endregion
            #region  groupBox_47_4
            this.groupBox_47_4.Controls.Add(this.label_47_4);
            this.groupBox_47_4.Controls.Add(this.textBox_47_4);
            this.groupBox_47_4.Controls.Add(this.listBox_47_4);
            this.groupBox_47_4.TabIndex = 0;
            this.groupBox_47_4.Text = "Acabamento";
            this.groupBox_47_4.Name = "groupBox_47_4";
            this.groupBox_47_4.Size = new Size(300, 175);

            this.label_47_4.Name = "label_47_4";
            this.label_47_4.Text = "Novo:";
            this.listBox_47_4.Name = "listBox_47_4";
            MyEvents.ListBox_Events(listBox_47_4, textBox_47_4, "Acabamento");
            this.textBox_47_4.Name = "textBox_47_4";
            this.textBox_47_4.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_47_4, "Acabamento");
            };
            #endregion
            #region  groupBox_61_0
            this.groupBox_61_0.Controls.Add(this.label_61_0);
            this.groupBox_61_0.Controls.Add(this.textBox_61_0);
            this.groupBox_61_0.Controls.Add(this.listBox_61_0);
            this.groupBox_61_0.TabIndex = 0;
            this.groupBox_61_0.Text = "Material";
            this.groupBox_61_0.Name = "groupBox_61_0";
            this.groupBox_61_0.Size = new Size(300, 175);

            this.label_61_0.Name = "label_61_0";
            this.label_61_0.Text = "Novo:";
            this.listBox_61_0.Name = "listBox_61_0";
            MyEvents.ListBox_Events(listBox_61_0, textBox_61_0, "Teto");
            this.textBox_61_0.Name = "textBox_61_0";
            this.textBox_61_0.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_61_0, "Teto");
            };
            #endregion
            #region  groupBox_61_1
            this.groupBox_61_1.Controls.Add(this.label_61_1);
            this.groupBox_61_1.Controls.Add(this.textBox_61_1);
            this.groupBox_61_1.Controls.Add(this.listBox_61_1);
            this.groupBox_61_1.TabIndex = 0;
            this.groupBox_61_1.Text = "Material abreviado";
            this.groupBox_61_1.Name = "groupBox_61_1";
            this.groupBox_61_1.Size = new Size(300, 175);

            this.label_61_1.Name = "label_61_1";
            this.label_61_1.Text = "Novo:";
            this.listBox_61_1.Name = "listBox_61_1";
            MyEvents.ListBox_Events(listBox_61_1, textBox_61_1, "TetoAbreviado");
            this.textBox_61_1.Name = "textBox_61_1";
            this.textBox_61_1.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_61_1, "TetoAbreviado");
            };
            #endregion
            #region  groupBox_61_3
            this.groupBox_61_3.Controls.Add(this.label_61_3);
            this.groupBox_61_3.Controls.Add(this.textBox_61_3);
            this.groupBox_61_3.Controls.Add(this.listBox_61_3);
            this.groupBox_61_3.TabIndex = 0;
            this.groupBox_61_3.Text = "Altura";
            this.groupBox_61_3.Name = "groupBox_61_3";
            this.groupBox_61_3.Size = new Size(300, 175);

            this.label_61_3.Name = "label_61_3";
            this.label_61_3.Text = "Novo:";
            this.listBox_61_3.Name = "listBox_61_3";
            MyEvents.ListBox_Events(listBox_61_3, textBox_61_3, "Altura");
            this.textBox_61_3.Name = "textBox_61_3";
            this.textBox_61_3.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_61_3, "Altura");
            };
            #endregion
            #region  groupBox_61_6
            this.groupBox_61_6.Controls.Add(this.label_61_6);
            this.groupBox_61_6.Controls.Add(this.textBox_61_6);
            this.groupBox_61_6.Controls.Add(this.listBox_61_6);
            this.groupBox_61_6.TabIndex = 0;
            this.groupBox_61_6.Text = "Fabricante";
            this.groupBox_61_6.Name = "groupBox_61_6";
            this.groupBox_61_6.Size = new Size(300, 175);

            this.label_61_6.Name = "label_61_6";
            this.label_61_6.Text = "Novo:";
            this.listBox_61_6.Name = "listBox_61_6";
            MyEvents.ListBox_Events(listBox_61_6, textBox_61_6, "FabricanteTeto");
            this.textBox_61_6.Name = "textBox_61_6";
            this.textBox_61_6.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_61_6, "FabricanteTeto");
            };
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
            this.label.Text = "Teto";

            FillComp(listBox_5_3, "Dimensão");
            FillComp(listBox_47_4, "Acabamento");
            FillComp(listBox_61_0, "Teto");
            FillComp(listBox_61_1, "TetoAbreviado");
            FillComp(listBox_61_3, "Altura");
            FillComp(listBox_61_6, "FabricanteTeto");
        }
        internal void FillList(string combobox)
        {
            switch (combobox)
            {
                case "comboBox_61_0":
                    listBox_61_0.Items.Clear();
                    FillComp(listBox_61_0, "Teto");
                    break;
                case "comboBox_61_1":
                    listBox_61_1.Items.Clear();
                    FillComp(listBox_61_1, "TetoAbreviado");
                    break;
                case "comboBox_61_3":
                    listBox_61_3.Items.Clear();
                    FillComp(listBox_61_3, "Altura");
                    break;
                case "comboBox_61_6":
                    listBox_61_6.Items.Clear();
                    FillComp(listBox_61_6, "FabricanteTeto");
                    break;
                case "comboBox_5_3":
                    listBox_5_3.Items.Clear();
                    FillComp(listBox_5_3, "Dimensão");
                    break;
                case "comboBox_47_4":
                    listBox_47_4.Items.Clear();
                    FillComp(listBox_47_4, "Acabamento");
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