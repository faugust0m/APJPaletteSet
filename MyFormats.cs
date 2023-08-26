using System;
using System.Drawing;
using System.Windows.Forms;

namespace APJPaletteSet
{
    internal class MyFormats
    {
        internal static void TitleLabelFormat(Label label)
        {
            label.Name = "label";
            label.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = SystemColors.ControlDarkDark;
            label.Size = new Size(300, 40);
            label.Location = new Point(10, 10);
            label.Padding = new Padding(5);
            label.Dock = DockStyle.Top;
            label.TabIndex = 0;
        }
        internal static void PictureFormat(PictureBox picture)
        {
            picture.Name = "picture";
            picture.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            picture.Location = new Point(125, 8);
            picture.Size = new Size(16, 16);
            picture.Image = global::APJPaletteSet.Properties.Resources.refreshNull;
            picture.Click += new EventHandler(MyCommands.ReloadPaletteSet);
            picture.MouseHover += new EventHandler(Picture_Hover);
            picture.MouseLeave += new EventHandler(Picture_Leave);
        }
        internal static void PanelFormat(Panel panel)
        {
            panel.TabIndex = 0;
            panel.Name = "panel";
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            panel.Margin = new Padding(0);
            panel.Size = new Size(300, 300);
            panel.Location = new Point(0, 0);
        }
        internal static void GroupBoxFormat(GroupBox groupbox)
        {
            groupbox.AutoSize = true;
            groupbox.TabStop = false;
            groupbox.Dock = DockStyle.Top;
            groupbox.Margin = new Padding(5);
            groupbox.Padding = new Padding(0);
            groupbox.Location = new Point(10, 10);
        }
        internal static void SpaceFormat(Label space)
        {
            space.Name = "space";
            space.Text = "";
            space.Dock = DockStyle.Top;
            space.Size = new Size(300, 20);
            space.Location = new Point(0, 0);
        }
        internal static void ComboBoxFormat(ComboBox combobox)
        {
            combobox.TabIndex = 1000;
            combobox.Anchor = ((AnchorStyles)(((
                    AnchorStyles.Top |
                    AnchorStyles.Left) |
                    AnchorStyles.Right)));
            combobox.Margin = new Padding(2);
            combobox.BackColor = SystemColors.Menu;
            combobox.FlatStyle = FlatStyle.Popup;
            combobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            combobox.MouseWheel += new MouseEventHandler(MyEvents.ComboBox_MouseWheel);
            combobox.GotFocus += new EventHandler(MyEvents.ComboBox_GotFocus);
        }
        internal static void LabelFormat(Label label)
        {
            label.ForeColor = SystemColors.ControlDarkDark;
        }
        internal static void LabelRightFormat(Label label)
        {
            label.ForeColor = SystemColors.ControlDarkDark;
            label.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            label.Size = new Size(18, 13);
        }
        internal static void LinkLabelFormat(LinkLabel linklabel)
        {
            linklabel.Text = "Editar lista";
            linklabel.LinkColor = SystemColors.Highlight;
            linklabel.VisitedLinkColor = SystemColors.Highlight;
        }
        internal static void RadioButtonFormat(RadioButton radiobutton)
        {
            radiobutton.TabStop = false;
            radiobutton.FlatStyle = FlatStyle.System;
            radiobutton.UseVisualStyleBackColor = true;
        }
        internal static void TextBoxFormat(TextBox textbox)
        {
            textbox.TabIndex = 0;
            textbox.Anchor = ((AnchorStyles)(((
                AnchorStyles.Top |
                AnchorStyles.Left) |
                AnchorStyles.Right)));
            textbox.Margin = new Padding(2);
            textbox.BackColor = SystemColors.Menu;
            textbox.BorderStyle = BorderStyle.None;
            textbox.GotFocus += new EventHandler(MyEvents.TextBox_GotFocus);
        }
        internal static string TextBoxName(TextBox textbox)
        {
            return MyProject.GetDetailValue(textbox);
        }
        internal static void Picture_Hover(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = global::APJPaletteSet.Properties.Resources.refresh;
        }
        internal static void Picture_Leave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = global::APJPaletteSet.Properties.Resources.refreshNull;
        }
    }    
}