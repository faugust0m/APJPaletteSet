using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class ListasEsquadriasPalette
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

        private GroupBox groupBox_75_0;
        private Label label_75_0;
        private TextBox textBox_75_0;
        private ListBox listBox_75_0;

        private GroupBox groupBox_75_1;
        private Label label_75_1;
        private TextBox textBox_75_1;
        private ListBox listBox_75_1;

        private GroupBox groupBox_75_2;
        private Label label_75_2;
        private TextBox textBox_75_2;
        private ListBox listBox_75_2;

        private GroupBox groupBox_75_3;
        private Label label_75_3;
        private TextBox textBox_75_3;
        private ListBox listBox_75_3;

        private GroupBox groupBox_82_0;
        private Label label_82_0;
        private TextBox textBox_82_0;
        private ListBox listBox_82_0;

        private GroupBox groupBox_83_0;
        private Label label_83_0;
        private TextBox textBox_83_0;
        private ListBox listBox_83_0;

        private GroupBox groupBox_84_0;
        private Label label_84_0;
        private TextBox textBox_84_0;
        private ListBox listBox_84_0;

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

            this.groupBox_75_0 = new GroupBox();
            this.label_75_0 = new Label();
            this.textBox_75_0 = new TextBox();
            this.listBox_75_0 = new ListBox();

            this.groupBox_75_1 = new GroupBox();
            this.label_75_1 = new Label();
            this.textBox_75_1 = new TextBox();
            this.listBox_75_1 = new ListBox();

            this.groupBox_75_2 = new GroupBox();
            this.label_75_2 = new Label();
            this.textBox_75_2 = new TextBox();
            this.listBox_75_2 = new ListBox();

            this.groupBox_75_3 = new GroupBox();
            this.label_75_3 = new Label();
            this.textBox_75_3 = new TextBox();
            this.listBox_75_3 = new ListBox();

            this.groupBox_82_0 = new GroupBox();
            this.label_82_0 = new Label();
            this.textBox_82_0 = new TextBox();
            this.listBox_82_0 = new ListBox();

            this.groupBox_83_0 = new GroupBox();
            this.label_83_0 = new Label();
            this.textBox_83_0 = new TextBox();
            this.listBox_83_0 = new ListBox();

            this.groupBox_84_0 = new GroupBox();
            this.label_84_0 = new Label();
            this.textBox_84_0 = new TextBox();
            this.listBox_84_0 = new ListBox();
            this.SuspendLayout();
            #endregion
            #region panel + label

            this.panel.Controls.Add(this.groupBox_84_0);  //Ferragens
            this.panel.Controls.Add(this.space_5);
            this.panel.Controls.Add(this.groupBox_83_0);  //Maçanetas
            this.panel.Controls.Add(this.space_4);
            this.panel.Controls.Add(this.groupBox_82_0);  //Vidro
            this.panel.Controls.Add(this.space_3);
            this.panel.Controls.Add(this.groupBox_75_3);  //EsquadriaCor
            this.panel.Controls.Add(this.space_2);
            this.panel.Controls.Add(this.groupBox_75_2);  //EsquadriaPintura
            this.panel.Controls.Add(this.space_1);
            this.panel.Controls.Add(this.groupBox_75_1);  //EsquadriaPadrão
            this.panel.Controls.Add(this.space_0);
            this.panel.Controls.Add(this.groupBox_75_0);  //Esquadria

            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);

            #endregion
            #region  groupBox_75_0
            this.groupBox_75_0.Controls.Add(this.label_75_0);
            this.groupBox_75_0.Controls.Add(this.textBox_75_0);
            this.groupBox_75_0.Controls.Add(this.listBox_75_0);
            this.groupBox_75_0.TabIndex = 0;
            this.groupBox_75_0.Text = "Material";
            this.groupBox_75_0.Name = "groupBox_75_0";
            this.groupBox_75_0.Size = new Size(300, 175);

            this.label_75_0.Name = "label_75_0";
            this.label_75_0.Text = "Novo:";
            this.textBox_75_0.Name = "textBox_75_0";
            this.listBox_75_0.Name = "listBox_75_0";
            MyEvents.ListBox_Events(listBox_75_0, textBox_75_0, "Esquadria");
            #endregion
            #region  groupBox_75_1
            this.groupBox_75_1.Controls.Add(this.label_75_1);
            this.groupBox_75_1.Controls.Add(this.textBox_75_1);
            this.groupBox_75_1.Controls.Add(this.listBox_75_1);
            this.groupBox_75_1.TabIndex = 0;
            this.groupBox_75_1.Text = "Padrão";
            this.groupBox_75_1.Name = "groupBox_75_1";
            this.groupBox_75_1.Size = new Size(300, 175);

            this.label_75_1.Name = "label_75_1";
            this.label_75_1.Text = "Novo:";
            this.textBox_75_1.Name = "textBox_75_1";
            this.listBox_75_1.Name = "listBox_75_1";
            MyEvents.ListBox_Events(listBox_75_1, textBox_75_1, "EsquadriaPadrão");
            #endregion
            #region  groupBox_75_2
            this.groupBox_75_2.Controls.Add(this.label_75_2);
            this.groupBox_75_2.Controls.Add(this.textBox_75_2);
            this.groupBox_75_2.Controls.Add(this.listBox_75_2);
            this.groupBox_75_2.TabIndex = 0;
            this.groupBox_75_2.Text = "Pintura";
            this.groupBox_75_2.Name = "groupBox_75_2";
            this.groupBox_75_2.Size = new Size(300, 175);

            this.label_75_2.Name = "label_75_2";
            this.label_75_2.Text = "Novo:";
            this.textBox_75_2.Name = "textBox_75_2";
            this.listBox_75_2.Name = "listBox_75_2";
            MyEvents.ListBox_Events(listBox_75_2, textBox_75_2, "EsquadriaPintura");
            #endregion
            #region  groupBox_75_3
            this.groupBox_75_3.Controls.Add(this.label_75_3);
            this.groupBox_75_3.Controls.Add(this.textBox_75_3);
            this.groupBox_75_3.Controls.Add(this.listBox_75_3);
            this.groupBox_75_3.TabIndex = 0;
            this.groupBox_75_3.Text = "Cor";
            this.groupBox_75_3.Name = "groupBox_75_3";
            this.groupBox_75_3.Size = new Size(300, 175);

            this.label_75_3.Name = "label_75_3";
            this.label_75_3.Text = "Novo:";
            this.textBox_75_3.Name = "textBox_75_3";
            this.listBox_75_3.Name = "listBox_75_3";
            MyEvents.ListBox_Events(listBox_75_3, textBox_75_3, "EsquadriaCor");
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
            this.textBox_82_0.Name = "textBox_82_0";
            this.listBox_82_0.Name = "listBox_82_0";
            MyEvents.ListBox_Events(listBox_82_0, textBox_82_0, "Vidro");
            #endregion
            #region  groupBox_83_0
            this.groupBox_83_0.Controls.Add(this.label_83_0);
            this.groupBox_83_0.Controls.Add(this.textBox_83_0);
            this.groupBox_83_0.Controls.Add(this.listBox_83_0);
            this.groupBox_83_0.TabIndex = 0;
            this.groupBox_83_0.Text = "Maçanetas";
            this.groupBox_83_0.Name = "groupBox_83_0";
            this.groupBox_83_0.Size = new Size(300, 175);

            this.label_83_0.Name = "label_83_0";
            this.label_83_0.Text = "Novo:";
            this.textBox_83_0.Name = "textBox_83_0";
            this.listBox_83_0.Name = "listBox_83_0";
            MyEvents.ListBox_Events(listBox_83_0, textBox_83_0, "Maçanetas");
            #endregion
            #region  groupBox_84_0
            this.groupBox_84_0.Controls.Add(this.label_84_0);
            this.groupBox_84_0.Controls.Add(this.textBox_84_0);
            this.groupBox_84_0.Controls.Add(this.listBox_84_0);
            this.groupBox_84_0.TabIndex = 0;
            this.groupBox_84_0.Text = "Ferragens";
            this.groupBox_84_0.Name = "groupBox_84_0";
            this.groupBox_84_0.Size = new Size(300, 175);

            this.label_84_0.Name = "label_84_0";
            this.label_84_0.Text = "Novo:";
            this.textBox_84_0.Name = "textBox_84_0";
            this.listBox_84_0.Name = "listBox_84_0";
            MyEvents.ListBox_Events(listBox_84_0, textBox_84_0, "Ferragens");
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
            this.label.Text = "Esquadrias";

            FillComp(listBox_75_0, "Esquadria");
            FillComp(listBox_75_1, "EsquadriaPadrão");
            FillComp(listBox_75_2, "EsquadriaPintura");
            FillComp(listBox_75_3, "EsquadriaCor");
            FillComp(listBox_82_0, "Vidro");
            FillComp(listBox_83_0, "Maçanetas");
            FillComp(listBox_84_0, "Ferragens");
        }
        internal void FillList(string combobox)
        {
            switch (combobox)
            {
                case "comboBox_75_0":
                    listBox_75_0.Items.Clear();
                    FillComp(listBox_75_0, "Esquadria");
                    break;
                case "comboBox_75_1":
                    listBox_75_1.Items.Clear();
                    FillComp(listBox_75_1, "EsquadriaPadrão");
                    break;
                case "comboBox_75_2":
                    listBox_75_2.Items.Clear();
                    FillComp(listBox_75_2, "EsquadriaPintura");
                    break;
                case "comboBox_75_3":
                    listBox_75_3.Items.Clear();
                    FillComp(listBox_75_3, "EsquadriaCor");
                    break;
                case "comboBox_82_0":
                    listBox_82_0.Items.Clear();
                    FillComp(listBox_82_0, "Vidro");
                    break;
                case "comboBox_83_0":
                    listBox_83_0.Items.Clear();
                    FillComp(listBox_83_0, "Maçanetas");
                    break;
                case "comboBox_84_0":
                    listBox_84_0.Items.Clear();
                    FillComp(listBox_84_0, "Ferragens");
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