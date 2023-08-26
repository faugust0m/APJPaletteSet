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

        private GroupBox groupBox_106_0;
        private Label label_106_0;
        private TextBox textBox_106_0;
        private ListBox listBox_106_0;

        private GroupBox groupBox_47_0;

        private GroupBox groupBox_61_0;

        private GroupBox groupBox_82_0;

        private GroupBox groupBox_86_15;

        private GroupBox groupBox_86_34;

        private GroupBox groupBox_86_57;

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

            this.groupBox_106_0 = new GroupBox();
            this.label_106_0 = new Label();
            this.textBox_106_0 = new TextBox();
            this.listBox_106_0 = new ListBox();

            this.groupBox_47_0 = new GroupBox();

            this.groupBox_61_0 = new GroupBox();

            this.groupBox_82_0 = new GroupBox();

            this.groupBox_86_15 = new GroupBox();

            this.groupBox_86_34 = new GroupBox();

            this.groupBox_86_57 = new GroupBox();
            this.SuspendLayout();
            #endregion
            #region panel + label

            this.panel.Controls.Add(this.groupBox_86_57);  //Vidro
            this.panel.Controls.Add(this.space_5);
            this.panel.Controls.Add(this.groupBox_86_34); //Revestimento
            this.panel.Controls.Add(this.space_4);
            this.panel.Controls.Add(this.groupBox_86_15);   //Piso
            this.panel.Controls.Add(this.space_3);
            this.panel.Controls.Add(this.groupBox_82_0); //Marcenaria
            this.panel.Controls.Add(this.space_2);
            this.panel.Controls.Add(this.groupBox_61_0);  //Teto
            this.panel.Controls.Add(this.space_1);
            this.panel.Controls.Add(this.groupBox_47_0); //Espelho
            this.panel.Controls.Add(this.space_0);
            this.panel.Controls.Add(this.groupBox_106_0);  //Mármore

            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);

            #endregion
            #region  groupBox_106_0 
            this.groupBox_106_0.Controls.Add(this.label_106_0);
            this.groupBox_106_0.Controls.Add(this.textBox_106_0);
            this.groupBox_106_0.Controls.Add(this.listBox_106_0);
            this.groupBox_106_0.TabIndex = 0;
            this.groupBox_106_0.Text = "Mármore";
            this.groupBox_106_0.Name = "groupBox_106_0 ";
            this.groupBox_106_0.Size = new Size(300, 175);

            this.label_106_0.Name = "label_106_0";
            this.label_106_0.Text = "Novo:";
            this.listBox_106_0.Name = "listBox_106_0";
            MyEvents.ListBox_Events(listBox_106_0, textBox_106_0, "Mármore");
            this.textBox_106_0.Name = "textBox_106_0";
            this.textBox_106_0.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                MyEvents.TextBox_KeyPress(sender, e, listBox_106_0, "Mármore");
            };
            #endregion
            #region  groupBox_47_0
            this.groupBox_47_0.TabIndex = 0;
            this.groupBox_47_0.Text = "Parede";
            this.groupBox_47_0.Name = "groupBox_47_0";
            this.groupBox_47_0.Size = new Size(300, 175);
            #endregion
            #region  groupBox_61_0
            this.groupBox_61_0.TabIndex = 2;
            this.groupBox_61_0.Text = "Forro";
            this.groupBox_61_0.Name = "groupBox_61_0";
            this.groupBox_61_0.Size = new Size(300, 175);
            #endregion
            #region  groupBox_82_0
            this.groupBox_82_0.TabIndex = 3;
            this.groupBox_82_0.Text = "Vidro";
            this.groupBox_82_0.Name = "groupBox_82_0";
            this.groupBox_82_0.Size = new Size(300, 175);
            #endregion
            #region  groupBox_86_15
            this.groupBox_86_15.TabIndex = 4;
            this.groupBox_86_15.Text = "Espelho";
            this.groupBox_86_15.Name = "groupBox_86_15";
            this.groupBox_86_15.Size = new Size(300, 175);
            #endregion
            #region  groupBox_86_34
            this.groupBox_86_34.TabIndex = 5;
            this.groupBox_86_34.Text = "Marcenaria";
            this.groupBox_86_34.Name = "groupBox_86_34";
            this.groupBox_86_34.Size = new Size(300, 175);
            #endregion
            #region  groupBox_86_57
            this.groupBox_86_57.TabIndex = 6;
            this.groupBox_86_57.Text = "Revestimento";
            this.groupBox_86_57.Name = "groupBox_86_57";
            this.groupBox_86_57.Size = new Size(300, 175);
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
            this.label.Text = "Materiais";

            FillComp(listBox_106_0, "Mármore");
        }
        internal void FillList(string combobox)
        {
            switch (combobox)
            {
                case "comboBox_106_0":
                    listBox_106_0.Items.Clear();
                    FillComp(listBox_106_0, "Mármore");
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