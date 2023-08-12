using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class ListasLegendaPalette
    {
        #region Lista de Controles
        private Panel panel;
        private Label label;

        private Label space_0;
        private Label space_1;
        private Label space_2;
        private Label space_3;
        private Label space_4;
        private Label space_5;

        private GroupBox groupBox_5_0;
        private Label label_5_0;
        private TextBox textBox_5_0;
        private ListBox listBox_5_0;

        private GroupBox groupBox_47_0;
        private Label label_47_0;
        private TextBox textBox_47_0;
        private ListBox listBox_47_0;

        private GroupBox groupBox_61_0;
        private Label label_61_0;
        private TextBox textBox_61_0;
        private ListBox listBox_61_0;

        private GroupBox groupBox_82_0;
        private Label label_82_0;
        private TextBox textBox_82_0;
        private ListBox listBox_82_0;

        private GroupBox groupBox_86_15;
        private Label label_86_15;
        private TextBox textBox_86_15;
        private ListBox listBox_86_15;

        private GroupBox groupBox_86_34;
        private Label label_86_34;
        private TextBox textBox_86_34;
        private ListBox listBox_86_34;

        private GroupBox groupBox_86_57;
        private Label label_86_57;
        private TextBox textBox_86_57;
        private ListBox listBox_86_57;

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
            this.space_5 = new Label();

            this.groupBox_5_0 = new GroupBox();
            this.label_5_0 = new Label();
            this.textBox_5_0 = new TextBox();
            this.listBox_5_0 = new ListBox();

            this.groupBox_47_0 = new GroupBox();
            this.label_47_0 = new Label();
            this.textBox_47_0 = new TextBox();
            this.listBox_47_0 = new ListBox();

            this.groupBox_61_0 = new GroupBox();
            this.label_61_0 = new Label();
            this.textBox_61_0 = new TextBox();
            this.listBox_61_0 = new ListBox();

            this.groupBox_82_0 = new GroupBox();
            this.label_82_0 = new Label();
            this.textBox_82_0 = new TextBox();
            this.listBox_82_0 = new ListBox();

            this.groupBox_86_15 = new GroupBox();
            this.label_86_15 = new Label();
            this.textBox_86_15 = new TextBox();
            this.listBox_86_15 = new ListBox();

            this.groupBox_86_34 = new GroupBox();
            this.label_86_34 = new Label();
            this.textBox_86_34 = new TextBox();
            this.listBox_86_34 = new ListBox();

            this.groupBox_86_57 = new GroupBox();
            this.label_86_57 = new Label();
            this.textBox_86_57 = new TextBox();
            this.listBox_86_57 = new ListBox();
            this.SuspendLayout();
            #endregion
            #region panel + label

            this.panel.Controls.Add(this.groupBox_82_0);  //Vidro
            this.panel.Controls.Add(this.space_5);
            this.panel.Controls.Add(this.groupBox_86_57); //Revestimento
            this.panel.Controls.Add(this.space_4);
            this.panel.Controls.Add(this.groupBox_5_0);   //Piso
            this.panel.Controls.Add(this.space_3);
            this.panel.Controls.Add(this.groupBox_86_34); //Marcenaria
            this.panel.Controls.Add(this.space_2);
            this.panel.Controls.Add(this.groupBox_61_0);  //Teto
            this.panel.Controls.Add(this.space_1);
            this.panel.Controls.Add(this.groupBox_86_15); //Espelho
            this.panel.Controls.Add(this.space_0);
            this.panel.Controls.Add(this.groupBox_47_0);  //Parede

            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);

            #endregion
            #region  groupBox_5_0 
            this.groupBox_5_0.Controls.Add(this.label_5_0);
            this.groupBox_5_0.Controls.Add(this.textBox_5_0);
            this.groupBox_5_0.Controls.Add(this.listBox_5_0);
            this.groupBox_5_0.TabIndex = 0;
            this.groupBox_5_0.Text = "Piso";
            this.groupBox_5_0.Name = "groupBox_5_0 ";
            this.groupBox_5_0.Size = new Size(300, 175);

            this.label_5_0.Name = "label_5_0";
            this.label_5_0.Text = "Novo:";
            this.listBox_5_0.Name = "listBox_5_0";
            MyEvents.ListBox_Events(listBox_5_0, textBox_5_0, "Piso");
            this.textBox_5_0.Name = "textBox_5_0";
            this.textBox_5_0.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_5_0, "Piso");
            };
            #endregion
            #region  groupBox_47_0
            this.groupBox_47_0.Controls.Add(this.label_47_0);
            this.groupBox_47_0.Controls.Add(this.textBox_47_0);
            this.groupBox_47_0.Controls.Add(this.listBox_47_0);
            this.groupBox_47_0.TabIndex = 0;
            this.groupBox_47_0.Text = "Parede";
            this.groupBox_47_0.Name = "groupBox_47_0";
            this.groupBox_47_0.Size = new Size(300, 175);

            this.label_47_0.Name = "label_47_0";
            this.label_47_0.Text = "Novo:";
            this.listBox_47_0.Name = "listBox_47_0";
            MyEvents.ListBox_Events(listBox_47_0, textBox_47_0, "Parede");
            this.textBox_47_0.Name = "textBox_47_0";
            this.textBox_47_0.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_47_0, "Parede");
            };
            #endregion
            #region  groupBox_61_0
            this.groupBox_61_0.Controls.Add(this.label_61_0);
            this.groupBox_61_0.Controls.Add(this.textBox_61_0);
            this.groupBox_61_0.Controls.Add(this.listBox_61_0);
            this.groupBox_61_0.TabIndex = 0;
            this.groupBox_61_0.Text = "Forro";
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
            #region  groupBox_82_0
            this.groupBox_82_0.Controls.Add(this.label_82_0);
            this.groupBox_82_0.Controls.Add(this.textBox_82_0);
            this.groupBox_82_0.Controls.Add(this.listBox_82_0);
            this.groupBox_82_0.TabIndex = 0;
            this.groupBox_82_0.Text = "Vidro";
            this.groupBox_82_0.Name = "groupBox_82_0";
            this.groupBox_82_0.Size = new Size(300, 175);

            this.label_82_0.Name = "label_82_0";
            this.label_82_0.Text = "Novo:";
            this.listBox_82_0.Name = "listBox_82_0";
            MyEvents.ListBox_Events(listBox_82_0, textBox_82_0, "Vidro");
            this.textBox_82_0.Name = "textBox_82_0";
            this.textBox_82_0.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_82_0, "Vidro");
            };
            #endregion
            #region  groupBox_86_15
            this.groupBox_86_15.Controls.Add(this.label_86_15);
            this.groupBox_86_15.Controls.Add(this.textBox_86_15);
            this.groupBox_86_15.Controls.Add(this.listBox_86_15);
            this.groupBox_86_15.TabIndex = 0;
            this.groupBox_86_15.Text = "Espelho";
            this.groupBox_86_15.Name = "groupBox_86_15";
            this.groupBox_86_15.Size = new Size(300, 175);

            this.label_86_15.Name = "label_86_15";
            this.label_86_15.Text = "Novo:";
            this.listBox_86_15.Name = "listBox_86_15";
            MyEvents.ListBox_Events(listBox_86_15, textBox_86_15, "Espelho");
            this.textBox_86_15.Name = "textBox_86_15";
            this.textBox_86_15.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_86_15, "Espelho");
            };
            #endregion
            #region  groupBox_86_34
            this.groupBox_86_34.Controls.Add(this.label_86_34);
            this.groupBox_86_34.Controls.Add(this.textBox_86_34);
            this.groupBox_86_34.Controls.Add(this.listBox_86_34);
            this.groupBox_86_34.TabIndex = 0;
            this.groupBox_86_34.Text = "Marcenaria";
            this.groupBox_86_34.Name = "groupBox_86_34";
            this.groupBox_86_34.Size = new Size(300, 175);

            this.label_86_34.Name = "label_86_34";
            this.label_86_34.Text = "Novo:";
            this.listBox_86_34.Name = "listBox_86_34";
            MyEvents.ListBox_Events(listBox_86_34, textBox_86_34, "Marcenaria");
            this.textBox_86_34.Name = "textBox_86_34";
            this.textBox_86_34.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_86_34, "Marcenaria");
            };
            #endregion
            #region  groupBox_86_57
            this.groupBox_86_57.Controls.Add(this.label_86_57);
            this.groupBox_86_57.Controls.Add(this.textBox_86_57);
            this.groupBox_86_57.Controls.Add(this.listBox_86_57);
            this.groupBox_86_57.TabIndex = 0;
            this.groupBox_86_57.Text = "Revestimento";
            this.groupBox_86_57.Name = "groupBox_86_57";
            this.groupBox_86_57.Size = new Size(300, 175);

            this.label_86_57.Name = "label_86_57";
            this.label_86_57.Text = "Novo:";
            this.listBox_86_57.Name = "listBox_86_57";
            MyEvents.ListBox_Events(listBox_86_57, textBox_86_57, "Revestimento");
            this.textBox_86_57.Name = "textBox_86_57";
            this.textBox_86_57.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_86_57, "Revestimento");
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
            this.label.Text = "Legenda";

            FillComp(listBox_5_0, "Piso");
            FillComp(listBox_47_0, "Parede");
            FillComp(listBox_61_0, "Teto");
            FillComp(listBox_82_0, "Vidro");
            FillComp(listBox_86_15, "Espelho");
            FillComp(listBox_86_34, "Marcenaria");
            FillComp(listBox_86_57, "Revestimento");
        }
        internal void FillList(string combobox)
        {
            switch (combobox)
            {
                case "comboBox_5_0":
                    listBox_5_0.Items.Clear();
                    FillComp(listBox_5_0, "Piso");
                    break;
                case "comboBox_47_0":
                    listBox_47_0.Items.Clear();
                    FillComp(listBox_47_0, "Parede");
                    break;
                case "comboBox_61_0":
                    listBox_61_0.Items.Clear();
                    FillComp(listBox_61_0, "Teto");
                    break;
                case "comboBox_82_0":
                    listBox_82_0.Items.Clear();
                    FillComp(listBox_82_0, "Vidro");
                    break;
                case "comboBox_86_15":
                    listBox_86_15.Items.Clear();
                    FillComp(listBox_86_15, "Espelho");
                    break;
                case "comboBox_86_34":
                    listBox_86_34.Items.Clear();
                    FillComp(listBox_86_34, "Marcenaria");
                    break;
                case "comboBox_86_57":
                    listBox_86_57.Items.Clear();
                    FillComp(listBox_86_57, "Revestimento");
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