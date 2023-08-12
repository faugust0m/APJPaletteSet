using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class FornecedoresPalette
    {
        #region Lista de Controles
        private Panel panel;
        private Label label;
        private PictureBox picture;

        private Label space_0;

        private GroupBox groupBox_0;
        private Label label_90_0;
        private TextBox textBox_90_0;
        private Label label_90_1;
        private TextBox textBox_90_1;
        private Label label_90_2;
        private TextBox textBox_90_2;
        private Label label_90_3;
        private TextBox textBox_90_3;
        private Label label_90_4;
        private TextBox textBox_90_4;
        private Label label_90_5;
        private TextBox textBox_90_5;
        private Label label_90_6;
        private TextBox textBox_90_6;
        private Label label_90_7;
        private TextBox textBox_90_7;
        private Label label_90_8;
        private TextBox textBox_90_8;
        private Label label_90_9;
        private TextBox textBox_90_9;

        private GroupBox groupBox_1;
        private Label label_88_0;
        private TextBox textBox_88_0;
        private Label label_88_1;
        private TextBox textBox_88_1;
        private Label label_88_2;
        private TextBox textBox_88_2;
        private Label label_88_3;
        private TextBox textBox_88_3;
        private Label label_88_4;
        private TextBox textBox_88_4;
        private Label label_88_5;
        private TextBox textBox_88_5;
        private Label label_88_6;
        private TextBox textBox_88_6;
        private Label label_88_7;
        private TextBox textBox_88_7;
        private Label label_88_8;
        private TextBox textBox_88_8;
        #endregion
        private void InitializeComponent()
        {
            #region Lista de Controles
            this.panel = new ExPanel();
            this.label = new Label();
            this.picture = new PictureBox();

            this.space_0 = new Label();

            this.groupBox_0 = new GroupBox();
            this.label_90_0 = new Label();
            this.textBox_90_0 = new TextBox();
            this.label_90_1 = new Label();
            this.textBox_90_1 = new TextBox();
            this.label_90_2 = new Label();
            this.textBox_90_2 = new TextBox();
            this.label_90_3 = new Label();
            this.textBox_90_3 = new TextBox();
            this.label_90_4 = new Label();
            this.textBox_90_4 = new TextBox();
            this.label_90_5 = new Label();
            this.textBox_90_5 = new TextBox();
            this.label_90_6 = new Label();
            this.textBox_90_6 = new TextBox();
            this.label_90_7 = new Label();
            this.textBox_90_7 = new TextBox();
            this.label_90_8 = new Label();
            this.textBox_90_8 = new TextBox();
            this.label_90_9 = new Label();
            this.textBox_90_9 = new TextBox();

            this.groupBox_1 = new GroupBox();
            this.label_88_0 = new Label();
            this.textBox_88_0 = new TextBox();
            this.label_88_1 = new Label();
            this.textBox_88_1 = new TextBox();
            this.label_88_2 = new Label();
            this.textBox_88_2 = new TextBox();
            this.label_88_3 = new Label();
            this.textBox_88_3 = new TextBox();
            this.label_88_4 = new Label();
            this.textBox_88_4 = new TextBox();
            this.label_88_5 = new Label();
            this.textBox_88_5 = new TextBox();
            this.label_88_6 = new Label();
            this.textBox_88_6 = new TextBox();
            this.label_88_7 = new Label();
            this.textBox_88_7 = new TextBox();
            this.label_88_8 = new Label();
            this.textBox_88_8 = new TextBox();
            #endregion
            #region panel + label + picture
            this.panel.Controls.Add(this.groupBox_1);
            this.panel.Controls.Add(this.space_0);
            this.panel.Controls.Add(this.groupBox_0);

            MyFormats.PanelFormat(panel);
            MyFormats.TitleLabelFormat(label);
            MyFormats.PictureFormat(picture);

            #endregion
            #region  groupBox_0
            this.groupBox_0.Controls.Add(this.label_90_0);
            this.groupBox_0.Controls.Add(this.textBox_90_0);
            this.groupBox_0.Controls.Add(this.label_90_1);
            this.groupBox_0.Controls.Add(this.textBox_90_1);
            this.groupBox_0.Controls.Add(this.label_90_2);
            this.groupBox_0.Controls.Add(this.textBox_90_2);
            this.groupBox_0.Controls.Add(this.label_90_3);
            this.groupBox_0.Controls.Add(this.textBox_90_3);
            this.groupBox_0.Controls.Add(this.label_90_4);
            this.groupBox_0.Controls.Add(this.textBox_90_4);
            this.groupBox_0.Controls.Add(this.label_90_5);
            this.groupBox_0.Controls.Add(this.textBox_90_5);
            this.groupBox_0.Controls.Add(this.label_90_6);
            this.groupBox_0.Controls.Add(this.textBox_90_6);
            this.groupBox_0.Controls.Add(this.label_90_7);
            this.groupBox_0.Controls.Add(this.textBox_90_7);
            this.groupBox_0.Controls.Add(this.label_90_8);
            this.groupBox_0.Controls.Add(this.textBox_90_8);
            this.groupBox_0.Controls.Add(this.label_90_9);
            this.groupBox_0.Controls.Add(this.textBox_90_9);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Text = "Fornecedores";
            this.groupBox_0.Name = "groupBox_0";
            this.groupBox_0.Size = new Size(300, 240);

            this.label_90_0.Name = "label_90_0";
            this.label_90_0.Text = "Fornecedor A:";
            this.textBox_90_0.Name = "textBox_90_0";
            MyEvents.TextBoxEvents(textBox_90_0);

            this.label_90_1.Name = "label_90_1";
            this.label_90_1.Text = "Fornecedor B:";
            this.textBox_90_1.Name = "textBox_90_1";
            MyEvents.TextBoxEvents(textBox_90_1);

            this.label_90_2.Name = "label_90_2";
            this.label_90_2.Text = "Fornecedor C:";
            this.textBox_90_2.Name = "textBox_90_2";
            MyEvents.TextBoxEvents(textBox_90_2);

            this.label_90_3.Name = "label_90_3";
            this.label_90_3.Text = "Fornecedor D:";
            this.textBox_90_3.Name = "textBox_90_3";
            MyEvents.TextBoxEvents(textBox_90_3);

            this.label_90_4.Name = "label_90_4";
            this.label_90_4.Text = "Fornecedor E:";
            this.textBox_90_4.Name = "textBox_90_4";
            MyEvents.TextBoxEvents(textBox_90_4);

            this.label_90_5.Name = "label_90_5";
            this.label_90_5.Text = "Fornecedor F:";
            this.textBox_90_5.Name = "textBox_90_5";
            MyEvents.TextBoxEvents(textBox_90_5);

            this.label_90_6.Name = "label_90_6";
            this.label_90_6.Text = "Fornecedor G:";
            this.textBox_90_6.Name = "textBox_90_6";
            MyEvents.TextBoxEvents(textBox_90_6);

            this.label_90_7.Name = "label_90_7";
            this.label_90_7.Text = "Fornecedor H:";
            this.textBox_90_7.Name = "textBox_90_7";
            MyEvents.TextBoxEvents(textBox_90_7);

            this.label_90_8.Name = "label_90_8";
            this.label_90_8.Text = "Fornecedor I:";
            this.textBox_90_8.Name = "textBox_90_8";
            MyEvents.TextBoxEvents(textBox_90_8);

            this.label_90_9.Name = "label_90_9";
            this.label_90_9.Text = "Fornecedor J:";
            this.textBox_90_9.Name = "textBox_90_9";
            MyEvents.TextBoxEvents(textBox_90_9);

            #endregion
            #region  groupBox_1
            this.groupBox_1.Controls.Add(this.label_88_0);
            this.groupBox_1.Controls.Add(this.textBox_88_0);
            this.groupBox_1.Controls.Add(this.label_88_1);
            this.groupBox_1.Controls.Add(this.textBox_88_1);
            this.groupBox_1.Controls.Add(this.label_88_2);
            this.groupBox_1.Controls.Add(this.textBox_88_2);
            this.groupBox_1.Controls.Add(this.label_88_3);
            this.groupBox_1.Controls.Add(this.textBox_88_3);
            this.groupBox_1.Controls.Add(this.label_88_4);
            this.groupBox_1.Controls.Add(this.textBox_88_4);
            this.groupBox_1.Controls.Add(this.label_88_5);
            this.groupBox_1.Controls.Add(this.textBox_88_5);
            this.groupBox_1.Controls.Add(this.label_88_6);
            this.groupBox_1.Controls.Add(this.textBox_88_6);
            this.groupBox_1.Controls.Add(this.label_88_7);
            this.groupBox_1.Controls.Add(this.textBox_88_7);
            this.groupBox_1.Controls.Add(this.label_88_8);
            this.groupBox_1.Controls.Add(this.textBox_88_8);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Estimativa de custo (R$/m²)";
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new Size(300, 235);

            this.label_88_0.Name = "label_88_0";
            this.label_88_0.Text = "C1";
            this.textBox_88_0.Name = "textBox_88_0";
            MyEvents.TextBoxEvents(textBox_88_0);

            this.label_88_1.Name = "label_88_1";
            this.label_88_1.Text = "C2";
            this.textBox_88_1.Name = "textBox_88_1";
            MyEvents.TextBoxEvents(textBox_88_1);

            this.label_88_2.Name = "label_88_2";
            this.label_88_2.Text = "C3";
            this.textBox_88_2.Name = "textBox_88_2";
            MyEvents.TextBoxEvents(textBox_88_2);

            this.label_88_3.Name = "label_88_3";
            this.label_88_3.Text = "C4";
            this.textBox_88_3.Name = "textBox_88_3";
            MyEvents.TextBoxEvents(textBox_88_3);

            this.label_88_4.Name = "label_88_4";
            this.label_88_4.Text = "C5";
            this.textBox_88_4.Name = "textBox_88_4";
            MyEvents.TextBoxEvents(textBox_88_4);

            this.label_88_5.Name = "label_88_5";
            this.label_88_5.Text = "C6";
            this.textBox_88_5.Name = "textBox_88_5";
            MyEvents.TextBoxEvents(textBox_88_5);

            this.label_88_6.Name = "label_88_6";
            this.label_88_6.Text = "C7";
            this.textBox_88_6.Name = "textBox_88_6";
            MyEvents.TextBoxEvents(textBox_88_6);

            this.label_88_7.Name = "label_88_7";
            this.label_88_7.Text = "C8";
            this.textBox_88_7.Name = "textBox_88_7";
            MyEvents.TextBoxEvents(textBox_88_7);

            this.label_88_8.Name = "label_88_8";
            this.label_88_8.Text = "C9";
            this.textBox_88_8.Name = "textBox_88_8";
            MyEvents.TextBoxEvents(textBox_88_8);

            #endregion

            int Padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "FornecedoresPalette";
            this.Controls.Add(this.panel);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label);
            this.Padding = new Padding(Padd, 10, 10, 10);
            this.Size = new Size(320, 650);
            this.FormatComponent();
            this.FillComponent();
        }
        internal void FillComponent()
        {
            this.label.Text = MyProject.CurrentProject();

            this.textBox_90_0.Text = MyProject.GetDetailValue(90, 0);
            this.textBox_90_1.Text = MyProject.GetDetailValue(90, 1);
            this.textBox_90_2.Text = MyProject.GetDetailValue(90, 2);
            this.textBox_90_3.Text = MyProject.GetDetailValue(90, 3);
            this.textBox_90_4.Text = MyProject.GetDetailValue(90, 4);
            this.textBox_90_5.Text = MyProject.GetDetailValue(90, 5);
            this.textBox_90_6.Text = MyProject.GetDetailValue(90, 6);
            this.textBox_90_7.Text = MyProject.GetDetailValue(90, 7);
            this.textBox_90_8.Text = MyProject.GetDetailValue(90, 8);
            this.textBox_90_9.Text = MyProject.GetDetailValue(90, 9);

            this.textBox_88_0.Text = MyProject.GetDetailValue(88, 0);
            this.textBox_88_1.Text = MyProject.GetDetailValue(88, 1);
            this.textBox_88_2.Text = MyProject.GetDetailValue(88, 2);
            this.textBox_88_3.Text = MyProject.GetDetailValue(88, 3);
            this.textBox_88_4.Text = MyProject.GetDetailValue(88, 4);
            this.textBox_88_5.Text = MyProject.GetDetailValue(88, 5);
            this.textBox_88_6.Text = MyProject.GetDetailValue(88, 6);
            this.textBox_88_7.Text = MyProject.GetDetailValue(88, 7);
            this.textBox_88_8.Text = MyProject.GetDetailValue(88, 8);
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

            int textBox_0 = -4;
            int label_0 = -5;

            foreach (var textbox in this.groupBox_0.Controls.OfType<TextBox>())
            {
                textBox_0 = textBox_0 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_0);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_0.Controls.OfType<Label>())
            {
                label_0 = label_0 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_0);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_1 builder

            int textBox_1 = -4;
            int label_1 = -5;

            foreach (var textbox in this.groupBox_1.Controls.OfType<TextBox>())
            {
                textBox_1 = textBox_1 + 24;
                textbox.Size = new Size(180, 20);
                textbox.Location = new Point(50, textBox_1);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_1.Controls.OfType<Label>())
            {
                label_1 = label_1 + 24;
                label.Size = new Size(30, 13);
                label.Location = new Point(10, label_1);
                label.ForeColor = SystemColors.ControlDarkDark;
            }
            #endregion
        }
    }
}