using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class ListasProjetoPalette
    {
        #region Lista de Controles
        private Panel panel;
        private Label label;

        private GroupBox groupBox_0_14;
        private Label label_0_14;
        private TextBox textBox_0_14;
        private ListBox listBox_0_14;

        #endregion
        private void InitializeComponent()
        {
            #region Lista de Controles
            this.panel = new ExPanel();
            this.label = new Label();

            this.groupBox_0_14 = new GroupBox();
            this.label_0_14 = new Label();
            this.textBox_0_14 = new TextBox();
            this.listBox_0_14 = new ListBox();
            this.SuspendLayout();
            #endregion
            #region panel + label

            this.panel.Controls.Add(this.groupBox_0_14);   //Tipo

            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);

            #endregion
            #region  groupBox_0_14
            this.groupBox_0_14.Controls.Add(this.label_0_14);
            this.groupBox_0_14.Controls.Add(this.textBox_0_14);
            this.groupBox_0_14.Controls.Add(this.listBox_0_14);
            this.groupBox_0_14.TabIndex = 0;
            this.groupBox_0_14.Text = "Tipo";
            this.groupBox_0_14.Name = "groupBox_0_14";
            this.groupBox_0_14.Size = new Size(300, 175);

            this.label_0_14.Name = "label_0_14";
            this.label_0_14.Text = "Novo:";
            this.textBox_0_14.Name = "textBox_0_14";
            this.listBox_0_14.Name = "listBox_0_14";
            MyEvents.ListBox_Events(listBox_0_14, textBox_0_14, "Tipo");
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
            this.label.Text = "Projeto";

            FillComp(listBox_0_14, "Tipo");
        }
        internal void FillList(string combobox)
        {
            switch (combobox)
            {
                case "comboBox_0_14":
                    listBox_0_14.Items.Clear();
                    FillComp(listBox_0_14, "Tipo");
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
        }
    }
}