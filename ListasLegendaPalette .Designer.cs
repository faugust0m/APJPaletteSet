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
        private Label space_6;

        private GroupBox groupBox_106_0;
        private Label label_106_0;
        private TextBox textBox_106_0;
        private ListBox listBox_106_0;

        private GroupBox groupBox_107_0;
        private Label label_107_0;
        private TextBox textBox_107_0;
        private ListBox listBox_107_0;

        private GroupBox groupBox_108_0;
        private Label label_108_0;
        private TextBox textBox_108_0;
        private ListBox listBox_108_0;

        private GroupBox groupBox_109_0;
        private Label label_109_0;
        private TextBox textBox_109_0;
        private ListBox listBox_109_0;

        private GroupBox groupBox_110_0;
        private Label label_110_0;
        private TextBox textBox_110_0;
        private ListBox listBox_110_0;

        private GroupBox groupBox_111_0;
        private Label label_111_0;
        private TextBox textBox_111_0;
        private ListBox listBox_111_0;

        private GroupBox groupBox_112_0;
        private Label label_112_0;
        private TextBox textBox_112_0;
        private ListBox listBox_112_0;

        private GroupBox groupBox_82_0;
        private Label label_82_0;
        private TextBox textBox_82_0;
        private ListBox listBox_82_0;

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
            this.space_6 = new Label();

            this.groupBox_106_0 = new GroupBox();
            this.label_106_0 = new Label();
            this.textBox_106_0 = new TextBox();
            this.listBox_106_0 = new ListBox();

            this.groupBox_107_0 = new GroupBox();
            this.label_107_0 = new Label();
            this.textBox_107_0 = new TextBox();
            this.listBox_107_0 = new ListBox();

            this.groupBox_108_0 = new GroupBox();
            this.label_108_0 = new Label();
            this.textBox_108_0 = new TextBox();
            this.listBox_108_0 = new ListBox();

            this.groupBox_109_0 = new GroupBox();
            this.label_109_0 = new Label();
            this.textBox_109_0 = new TextBox();
            this.listBox_109_0 = new ListBox();

            this.groupBox_110_0 = new GroupBox();
            this.label_110_0 = new Label();
            this.textBox_110_0 = new TextBox();
            this.listBox_110_0 = new ListBox();

            this.groupBox_111_0 = new GroupBox();
            this.label_111_0 = new Label();
            this.textBox_111_0 = new TextBox();
            this.listBox_111_0 = new ListBox();

            this.groupBox_112_0 = new GroupBox();
            this.label_112_0 = new Label();
            this.textBox_112_0 = new TextBox();
            this.listBox_112_0 = new ListBox();

            this.groupBox_82_0 = new GroupBox();
            this.label_82_0 = new Label();
            this.textBox_82_0 = new TextBox();
            this.listBox_82_0 = new ListBox();
            this.SuspendLayout();
            #endregion
            #region panel + label

            this.panel.Controls.Add(this.groupBox_82_0);  //Vidro
            this.panel.Controls.Add(this.space_6);
            this.panel.Controls.Add(this.groupBox_112_0); //Espelho
            this.panel.Controls.Add(this.space_5);
            this.panel.Controls.Add(this.groupBox_111_0); //PapelParede
            this.panel.Controls.Add(this.space_4);
            this.panel.Controls.Add(this.groupBox_110_0); //Revestimento
            this.panel.Controls.Add(this.space_3);
            this.panel.Controls.Add(this.groupBox_109_0); //Pintura
            this.panel.Controls.Add(this.space_2);
            this.panel.Controls.Add(this.groupBox_108_0); //Madeira
            this.panel.Controls.Add(this.space_1);
            this.panel.Controls.Add(this.groupBox_107_0); //Granito
            this.panel.Controls.Add(this.space_0);
            this.panel.Controls.Add(this.groupBox_106_0); //Mármore

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
            this.textBox_106_0.Name = "textBox_106_0";
            this.listBox_106_0.Name = "listBox_106_0";
            MyEvents.ListBox_Events(listBox_106_0, textBox_106_0, "Mármore");
            #endregion
            #region  groupBox_107_0
            this.groupBox_107_0.Controls.Add(this.label_107_0);
            this.groupBox_107_0.Controls.Add(this.textBox_107_0);
            this.groupBox_107_0.Controls.Add(this.listBox_107_0);
            this.groupBox_107_0.TabIndex = 1;
            this.groupBox_107_0.Text = "Granito";
            this.groupBox_107_0.Name = "groupBox_107_0";
            this.groupBox_107_0.Size = new Size(300, 175);

            this.label_107_0.Name = "label_107_0";
            this.label_107_0.Text = "Novo:";
            this.textBox_107_0.Name = "textBox_107_0";
            this.listBox_107_0.Name = "listBox_107_0";
            MyEvents.ListBox_Events(listBox_107_0, textBox_107_0, "Granito");
            #endregion
            #region  groupBox_108_0
            this.groupBox_108_0.Controls.Add(this.label_108_0);
            this.groupBox_108_0.Controls.Add(this.textBox_108_0);
            this.groupBox_108_0.Controls.Add(this.listBox_108_0);
            this.groupBox_108_0.TabIndex = 2;
            this.groupBox_108_0.Text = "Madeira";
            this.groupBox_108_0.Name = "groupBox_108_0";
            this.groupBox_108_0.Size = new Size(300, 175);

            this.label_108_0.Name = "label_108_0";
            this.label_108_0.Text = "Novo:";
            this.listBox_108_0.Name = "listBox_108_0";
            this.textBox_108_0.Name = "textBox_108_0";
            MyEvents.ListBox_Events(listBox_108_0, textBox_108_0, "Madeira");
            #endregion
            #region  groupBox_109_0
            this.groupBox_109_0.Controls.Add(this.label_109_0);
            this.groupBox_109_0.Controls.Add(this.textBox_109_0);
            this.groupBox_109_0.Controls.Add(this.listBox_109_0);
            this.groupBox_109_0.TabIndex = 3;
            this.groupBox_109_0.Text = "Pintura";
            this.groupBox_109_0.Name = "groupBox_109_0";
            this.groupBox_109_0.Size = new Size(300, 175);

            this.label_109_0.Name = "label_109_0";
            this.label_109_0.Text = "Novo:";
            this.textBox_109_0.Name = "textBox_109_0";
            this.listBox_109_0.Name = "listBox_109_0";
            MyEvents.ListBox_Events(listBox_109_0, textBox_109_0, "Pintura");
            #endregion
            #region  groupBox_110_0
            this.groupBox_110_0.Controls.Add(this.label_110_0);
            this.groupBox_110_0.Controls.Add(this.textBox_110_0);
            this.groupBox_110_0.Controls.Add(this.listBox_110_0);
            this.groupBox_110_0.TabIndex = 4;
            this.groupBox_110_0.Text = "Revestimento";
            this.groupBox_110_0.Name = "groupBox_110_0";
            this.groupBox_110_0.Size = new Size(300, 175);

            this.label_110_0.Name = "label_110_0";
            this.label_110_0.Text = "Novo:";
            this.textBox_110_0.Name = "textBox_110_0";
            this.listBox_110_0.Name = "listBox_110_0";
            MyEvents.ListBox_Events(listBox_110_0, textBox_110_0, "Revestimento");
            #endregion
            #region  groupBox_111_0
            this.groupBox_111_0.Controls.Add(this.label_111_0);
            this.groupBox_111_0.Controls.Add(this.textBox_111_0);
            this.groupBox_111_0.Controls.Add(this.listBox_111_0);
            this.groupBox_111_0.TabIndex = 5;
            this.groupBox_111_0.Text = "PapelParede";
            this.groupBox_111_0.Name = "groupBox_111_0";
            this.groupBox_111_0.Size = new Size(300, 175);

            this.label_111_0.Name = "label_111_0";
            this.label_111_0.Text = "Novo:";
            this.listBox_111_0.Name = "listBox_111_0";
            this.textBox_111_0.Name = "textBox_111_0";
            MyEvents.ListBox_Events(listBox_111_0, textBox_111_0, "PapelParede");
            #endregion
            #region  groupBox_112_0
            this.groupBox_112_0.Controls.Add(this.label_112_0);
            this.groupBox_112_0.Controls.Add(this.textBox_112_0);
            this.groupBox_112_0.Controls.Add(this.listBox_112_0);
            this.groupBox_112_0.TabIndex = 6;
            this.groupBox_112_0.Text = "Espelho";
            this.groupBox_112_0.Name = "groupBox_112_0";
            this.groupBox_112_0.Size = new Size(300, 175);

            this.label_112_0.Name = "label_112_0";
            this.label_112_0.Text = "Novo:";
            this.textBox_112_0.Name = "textBox_112_0";
            this.listBox_112_0.Name = "listBox_112_0";
            MyEvents.ListBox_Events(listBox_112_0, textBox_112_0, "Espelho");
            #endregion
            #region  groupBox_82_0
            this.groupBox_82_0.Controls.Add(this.label_82_0);
            this.groupBox_82_0.Controls.Add(this.textBox_82_0);
            this.groupBox_82_0.Controls.Add(this.listBox_82_0);
            this.groupBox_82_0.TabIndex = 7;
            this.groupBox_82_0.Text = "Vidro";
            this.groupBox_82_0.Name = "groupBox_82_0";
            this.groupBox_82_0.Size = new Size(300, 175);

            this.label_82_0.Name = "label_82_0";
            this.label_82_0.Text = "Novo:";
            this.textBox_82_0.Name = "textBox_82_0";
            this.listBox_82_0.Name = "listBox_82_0";
            MyEvents.ListBox_Events(listBox_82_0, textBox_82_0, "Vidro");
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
            FillComp(listBox_107_0, "Granito");
            FillComp(listBox_108_0, "Madeira");
            FillComp(listBox_109_0, "Pintura");
            FillComp(listBox_110_0, "Revestimento");
            FillComp(listBox_111_0, "PapelParede");
            FillComp(listBox_112_0, "Espelho");
            FillComp(listBox_82_0,  "Vidro");
        }
        internal void FillList(string combobox)
        {
            switch (combobox)
            {
                case "comboBox_106_0":
                    listBox_106_0.Items.Clear();
                    FillComp(listBox_106_0, "Mármore");
                    break;
                case "comboBox_107_0":
                    listBox_107_0.Items.Clear();
                    FillComp(listBox_107_0, "Granito");
                    break;
                case "comboBox_108_0":
                    listBox_108_0.Items.Clear();
                    FillComp(listBox_108_0, "Madeira");
                    break;
                case "comboBox_109_0":
                    listBox_109_0.Items.Clear();
                    FillComp(listBox_109_0, "Pintura");
                    break;
                case "comboBox_110_0":
                    listBox_110_0.Items.Clear();
                    FillComp(listBox_110_0, "Revestimento");
                    break;
                case "comboBox_111_0":
                    listBox_111_0.Items.Clear();
                    FillComp(listBox_111_0, "PapelParede");
                    break;
                case "comboBox_112_0":
                    listBox_112_0.Items.Clear();
                    FillComp(listBox_112_0, "Espelho");
                    break;
                case "comboBox_82_0":
                    listBox_82_0.Items.Clear();
                    FillComp(listBox_82_0, "Vidro");
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