using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace APJPaletteSet
{
    partial class PropriedadePalette
    {
        private IContainer components = null;
        #region Lista de Controles
        private Panel panel;
        private Label label;
        private PictureBox picture;

        private Label space_0;
        private Label space_1;
        private Label space_2;

        private GroupBox groupBox_0;
        private Label label_0_14;
        private ComboBox comboBox_0_14;
        private ToolTip toolTip_0_14;
        private Label label_0_15;
        private TextBox textBox_0_15;
        private ToolTip toolTip_0_15;
        private Label label_0_16;
        private TextBox textBox_0_16;
        private ToolTip toolTip_0_16;
        private LinkLabel linkLabel;
        private ToolTip toolTip_link;

        private GroupBox groupBox_1;
        private Label label_0_1;
        private TextBox textBox_0_1;
        private ToolTip toolTip_0_1;
        private Label label_0_2;
        private TextBox textBox_0_2;
        private ToolTip toolTip_0_2;
        private Label label_0_3;
        private TextBox textBox_0_3;
        private ToolTip toolTip_0_3;
        private Label label_0_4;
        private TextBox textBox_0_4;
        private ToolTip toolTip_0_4;
        private Label label_0_5;
        private TextBox textBox_0_5;
        private ToolTip toolTip_0_5;

        private GroupBox groupBox_2;
        private Label label_0_8;
        private TextBox textBox_0_8;
        private ToolTip toolTip_0_8;
        private Label label_0_9;
        private TextBox textBox_0_9;
        private ToolTip toolTip_0_9;
        private Label label_0_10;
        private TextBox textBox_0_10;
        private ToolTip toolTip_0_10;
        private Label label_0_11;
        private TextBox textBox_0_11;
        private ToolTip toolTip_0_11;
        private Label label_0_12;
        private TextBox textBox_0_12;
        private ToolTip toolTip_0_12;

        private GroupBox groupBox_3;
        private Label label_1_0;
        private TextBox textBox_1_0;
        private ToolTip toolTip_1_0;
        private Label label_1_1;
        private TextBox textBox_1_1;
        private ToolTip toolTip_1_1;
        private Label label_1_2;
        private TextBox textBox_1_2;
        private ToolTip toolTip_1_2;
        private Label label_1_3;
        private TextBox textBox_1_3;
        private ToolTip toolTip_1_3;
        private Label label_1_4;
        private TextBox textBox_1_4;
        private ToolTip toolTip_1_4;
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

            this.components = new Container();

            this.groupBox_0 = new GroupBox();
            this.label_0_14 = new Label();
            this.comboBox_0_14 = new ComboBox();
            this.toolTip_0_14 = new ToolTip(this.components);
            this.label_0_15 = new Label();
            this.textBox_0_15 = new TextBox();
            this.toolTip_0_15 = new ToolTip(this.components);
            this.label_0_16 = new Label();
            this.textBox_0_16 = new TextBox();
            this.toolTip_0_16 = new ToolTip(this.components);
            this.linkLabel = new LinkLabel();
            this.toolTip_link = new ToolTip(this.components);

            this.groupBox_1 = new GroupBox();
            this.label_0_1 = new Label();
            this.textBox_0_1 = new TextBox();
            this.toolTip_0_1 = new ToolTip(this.components);
            this.label_0_2 = new Label();
            this.textBox_0_2 = new TextBox();
            this.toolTip_0_2 = new ToolTip(this.components);
            this.label_0_3 = new Label();
            this.textBox_0_3 = new TextBox();
            this.toolTip_0_3 = new ToolTip(this.components);
            this.label_0_4 = new Label();
            this.textBox_0_4 = new TextBox();
            this.toolTip_0_4 = new ToolTip(this.components);
            this.label_0_5 = new Label();
            this.textBox_0_5 = new TextBox();
            this.toolTip_0_5 = new ToolTip(this.components);

            this.groupBox_2 = new GroupBox();
            this.label_0_8 = new Label();
            this.textBox_0_8 = new TextBox();
            this.toolTip_0_8 = new ToolTip(this.components);
            this.label_0_9 = new Label();
            this.textBox_0_9 = new TextBox();
            this.toolTip_0_9 = new ToolTip(this.components);
            this.label_0_10 = new Label();
            this.textBox_0_10 = new TextBox();
            this.toolTip_0_10 = new ToolTip(this.components);
            this.label_0_11 = new Label();
            this.textBox_0_11 = new TextBox();
            this.toolTip_0_11 = new ToolTip(this.components);
            this.label_0_12 = new Label();
            this.textBox_0_12 = new TextBox();
            this.toolTip_0_12 = new ToolTip(this.components);

            this.groupBox_3 = new GroupBox();
            this.label_1_0 = new Label();
            this.textBox_1_0 = new TextBox();
            this.toolTip_1_0 = new ToolTip(this.components);
            this.label_1_1 = new Label();
            this.textBox_1_1 = new TextBox();
            this.toolTip_1_1 = new ToolTip(this.components);
            this.label_1_2 = new Label();
            this.textBox_1_2 = new TextBox();
            this.toolTip_1_2 = new ToolTip(this.components);
            this.label_1_3 = new Label();
            this.textBox_1_3 = new TextBox();
            this.toolTip_1_3 = new ToolTip(this.components);
            this.label_1_4 = new Label();
            this.textBox_1_4 = new TextBox();
            this.toolTip_1_4 = new ToolTip(this.components);
            #endregion
            #region panel + label + picture
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
            #region groupBox_0
            this.groupBox_0.Controls.Add(this.label_0_14);
            this.groupBox_0.Controls.Add(this.comboBox_0_14);
            this.groupBox_0.Controls.Add(this.label_0_15);
            this.groupBox_0.Controls.Add(this.textBox_0_15);
            this.groupBox_0.Controls.Add(this.label_0_16);
            this.groupBox_0.Controls.Add(this.textBox_0_16);
            this.groupBox_0.Controls.Add(this.linkLabel);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Text = "Informações";
            this.groupBox_0.Name = "groupBox_0";

            this.label_0_14.Name = "label_0_14";
            this.label_0_14.Text = "Tipo:";
            this.comboBox_0_14.Name = "textBox_0_14";
            MyEvents.ComboBoxEvents(comboBox_0_14);
            string tooltip_0_14 = "Selecione o tipo de obra a partir da lista;\n" +
                                  "Clique no link 'Editar lista' para modificá-la\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos)";
            this.toolTip_0_14.SetToolTip(this.label_0_14, tooltip_0_14 );
            this.toolTip_0_14.SetToolTip(this.comboBox_0_14,tooltip_0_14 );

            this.label_0_15.Name = "label_0_15";
            this.label_0_15.Text = "Data:";
            this.textBox_0_15.Name = "textBox_0_15";
            MyEvents.TextBoxEvents(textBox_0_15);
            string tooltip_0_15 = "Determine a data de início do projeto\n" +
                                  "ex.: Jul/2022\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos)";
            this.toolTip_0_15.SetToolTip(this.label_0_15, tooltip_0_15);
            this.toolTip_0_15.SetToolTip(this.textBox_0_15, tooltip_0_15);

            this.label_0_16.Name = "label_0_16";
            this.label_0_16.Text = "Pranchas:";
            this.textBox_0_16.Name = "textBox_0_16";
            MyEvents.TextBoxEvents(textBox_0_16);
            string tooltip_0_16 = "Determine a quantidade de pranchas\n" +
                                  "do projeto legal\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos de aprovação)";
            this.toolTip_0_16.SetToolTip(this.label_0_16, tooltip_0_16);
            this.toolTip_0_16.SetToolTip(this.textBox_0_16, tooltip_0_16);

            this.linkLabel.Name = "linkLabel";
            MyFormats.LinkLabelFormat(linkLabel);
            this.linkLabel.LinkClicked += delegate (object sender, LinkLabelLinkClickedEventArgs e) {
                MyEvents.linkLabel_LinkClicked(sender, e, 0);
            this.toolTip_link.SetToolTip(this.linkLabel, "Clique no link para editar a lista de tipos");
            };
            #endregion
            #region groupBox_1
            this.groupBox_1.Controls.Add(this.label_0_1);
            this.groupBox_1.Controls.Add(this.textBox_0_1);
            this.groupBox_1.Controls.Add(this.label_0_2);
            this.groupBox_1.Controls.Add(this.textBox_0_2);
            this.groupBox_1.Controls.Add(this.label_0_3);
            this.groupBox_1.Controls.Add(this.textBox_0_3);
            this.groupBox_1.Controls.Add(this.label_0_4);
            this.groupBox_1.Controls.Add(this.textBox_0_4);
            this.groupBox_1.Controls.Add(this.label_0_5);
            this.groupBox_1.Controls.Add(this.textBox_0_5);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Proprietário principal";
            this.groupBox_1.Name = "groupBox_1";

            this.label_0_1.Name = "label_0_1";
            this.label_0_1.Text = "Nome:";
            this.textBox_0_1.Name = "textBox_0_1";
            MyEvents.TextBoxEvents(textBox_0_1);
            string tooltip_0_1 = "Determine o nome do proprietário\n" +
                                 "principal do projeto\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos)";
            this.toolTip_0_1.SetToolTip(this.label_0_1, tooltip_0_1);
            this.toolTip_0_1.SetToolTip(this.textBox_0_1, tooltip_0_1);

            this.label_0_2.Name = "label_0_2";
            this.label_0_2.Text = "Telefone:";
            this.textBox_0_2.Name = "textBox_0_2";
            MyEvents.TextBoxEvents(textBox_0_2);
            string tooltip_0_2 = "Determine o telefone de contato\n" +
                                 "do proprietário principal";
            this.toolTip_0_2.SetToolTip(this.label_0_2, tooltip_0_2);
            this.toolTip_0_2.SetToolTip(this.textBox_0_2, tooltip_0_2);

            this.label_0_3.Name = "label_0_3";
            this.label_0_3.Text = "e-mail:";
            this.textBox_0_3.Name = "textBox_0_3";
            MyEvents.TextBoxEvents(textBox_0_3);
            string tooltip_0_3 = "Determine o e-mail de contato\n" +
                                 "do proprietário principal";
            this.toolTip_0_3.SetToolTip(this.label_0_3, tooltip_0_3);
            this.toolTip_0_3.SetToolTip(this.textBox_0_3, tooltip_0_3);

            this.label_0_4.Name = "label_0_4";
            this.label_0_4.Text = "CPF/CNPJ:";
            this.textBox_0_4.Name = "textBox_0_4";
            MyEvents.TextBoxEvents(textBox_0_4);
            string tooltip_0_4 = "Determine o CPF ou CNPJ do\n" +
                                 "proprietário principal";
            this.toolTip_0_4.SetToolTip(this.label_0_4, tooltip_0_4);
            this.toolTip_0_4.SetToolTip(this.textBox_0_4, tooltip_0_4);

            this.label_0_5.Name = "label_0_5";
            this.label_0_5.Text = "Endereço:";
            this.textBox_0_5.Name = "textBox_0_5";
            MyEvents.TextBoxEvents(textBox_0_5);
            string tooltip_0_5 = "Determine o endereço de correspondência\n" +
                                 "do proprietário principal";
            this.toolTip_0_5.SetToolTip(this.label_0_5, tooltip_0_5);
            this.toolTip_0_5.SetToolTip(this.textBox_0_5, tooltip_0_5);

            #endregion
            #region groupBox_2
            this.groupBox_2.Controls.Add(this.label_0_8);
            this.groupBox_2.Controls.Add(this.textBox_0_8);
            this.groupBox_2.Controls.Add(this.label_0_9);
            this.groupBox_2.Controls.Add(this.textBox_0_9);
            this.groupBox_2.Controls.Add(this.label_0_10);
            this.groupBox_2.Controls.Add(this.textBox_0_10);
            this.groupBox_2.Controls.Add(this.label_0_11);
            this.groupBox_2.Controls.Add(this.textBox_0_11);
            this.groupBox_2.Controls.Add(this.label_0_12);
            this.groupBox_2.Controls.Add(this.textBox_0_12);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.Text = "Coproprietário(s)";
            this.groupBox_2.Name = "groupBox_2";

            this.label_0_8.Name = "label_0_8";
            this.label_0_8.Text = "Nome:";
            this.textBox_0_8.Name = "textBox_0_8";
            MyEvents.TextBoxEvents(textBox_0_8);
            string tooltip_0_8 = "Determine o nome do coproprietário\n" +
                                 "do projeto";
            this.toolTip_0_8.SetToolTip(this.label_0_8, tooltip_0_8);
            this.toolTip_0_8.SetToolTip(this.textBox_0_8, tooltip_0_8);

            this.label_0_9.Name = "label_0_9";
            this.label_0_9.Text = "Telefone:";
            this.textBox_0_9.Name = "textBox_0_9";
            MyEvents.TextBoxEvents(textBox_0_9);
            string tooltip_0_9 = "Determine o telefone de contato\n" +
                                 "do coproprietário";
            this.toolTip_0_9.SetToolTip(this.label_0_9, tooltip_0_9);
            this.toolTip_0_9.SetToolTip(this.textBox_0_9, tooltip_0_9);

            this.label_0_10.Name = "label_0_10";
            this.label_0_10.Text = "e-mail:";
            this.textBox_0_10.Name = "textBox_0_10";
            MyEvents.TextBoxEvents(textBox_0_10);
            string tooltip_0_10 = "Determine o e-mail de contato\n" +
                                  "do coproprietário";
            this.toolTip_0_10.SetToolTip(this.label_0_10, tooltip_0_10);
            this.toolTip_0_10.SetToolTip(this.textBox_0_10, tooltip_0_10);

            this.label_0_11.Name = "label_0_11";
            this.label_0_11.Text = "CPF/CNPJ:";
            this.textBox_0_11.Name = "textBox_0_11";
            MyEvents.TextBoxEvents(textBox_0_11);
            string tooltip_0_11 = "Determine o CPF ou CNPJ do\n" +
                                  "coproprietário";
            this.toolTip_0_11.SetToolTip(this.label_0_11, tooltip_0_11);
            this.toolTip_0_11.SetToolTip(this.textBox_0_11, tooltip_0_11);

            this.label_0_12.Name = "label_0_12";
            this.label_0_12.Text = "Endereço:";
            this.textBox_0_12.Name = "textBox_0_12";
            MyEvents.TextBoxEvents(textBox_0_12);
            string tooltip_0_12 = "Determine o endereço de correspondência\n" +
                                  "do coproprietário";
            this.toolTip_0_12.SetToolTip(this.label_0_12, tooltip_0_12);
            this.toolTip_0_12.SetToolTip(this.textBox_0_12, tooltip_0_12);
            #endregion
            #region groupBox_3
            this.groupBox_3.Controls.Add(this.label_1_0);
            this.groupBox_3.Controls.Add(this.textBox_1_0);
            this.groupBox_3.Controls.Add(this.label_1_1);
            this.groupBox_3.Controls.Add(this.textBox_1_1);
            this.groupBox_3.Controls.Add(this.label_1_2);
            this.groupBox_3.Controls.Add(this.textBox_1_2);
            this.groupBox_3.Controls.Add(this.label_1_3);
            this.groupBox_3.Controls.Add(this.textBox_1_3);
            this.groupBox_3.Controls.Add(this.label_1_4);
            this.groupBox_3.Controls.Add(this.textBox_1_4);
            this.groupBox_3.TabIndex = 3;
            this.groupBox_3.Text = "Responsáveis";
            this.groupBox_3.Name = "groupBox_3";

            this.label_1_0.Name = "label_1_0";
            this.label_1_0.Text = "Arquiteto:";
            this.textBox_1_0.Name = "textBox_1_0";
            MyEvents.TextBoxEvents(textBox_1_0);
            string tooltip_1_0 = "Determine o nome do profissional\n" +
                                 "responsável pelo projeto\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos)";
            this.toolTip_1_0.SetToolTip(this.label_1_0, tooltip_1_0);
            this.toolTip_1_0.SetToolTip(this.textBox_1_0, tooltip_1_0);

            this.label_1_1.Name = "label_1_1";
            this.label_1_1.Text = "CAU:";
            this.textBox_1_1.Name = "textBox_1_1";
            MyEvents.TextBoxEvents(textBox_1_1);
            string tooltip_1_1 = "Determine o número de registro do\n" +
                                 "profissional responsável pelo projeto\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos)";
            this.toolTip_1_1.SetToolTip(this.label_1_1, tooltip_1_1);
            this.toolTip_1_1.SetToolTip(this.textBox_1_1, tooltip_1_1);

            this.label_1_2.Name = "label_1_2";
            this.label_1_2.Text = "Coorden.:";
            this.textBox_1_2.Name = "textBox_1_2";
            MyEvents.TextBoxEvents(textBox_1_2);
            string tooltip_1_2 = "Determine o nome do coordenador\n" +
                                 "responsável pelo projeto\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos)";
            this.toolTip_1_2.SetToolTip(this.label_1_2, tooltip_1_2);
            this.toolTip_1_2.SetToolTip(this.textBox_1_2, tooltip_1_2);

            this.label_1_3.Name = "label_1_3";
            this.label_1_3.Text = "R. Técnico:";
            this.textBox_1_3.Name = "textBox_1_3";
            MyEvents.TextBoxEvents(textBox_1_3);
            string tooltip_1_3 = "Determine o nome do profissional\n" +
                                 "responsável pela execução do projeto\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos de aprovação)";
            this.toolTip_1_3.SetToolTip(this.label_1_3, tooltip_1_3);
            this.toolTip_1_3.SetToolTip(this.textBox_1_3, tooltip_1_3);

            this.label_1_4.Name = "label_1_4";
            this.label_1_4.Text = "CAU/CREA:";
            this.textBox_1_4.Name = "textBox_1_4";
            MyEvents.TextBoxEvents(textBox_1_4);
            string tooltip_1_4 = "Determine o número de registro do profissional\n" +
                                 "responsável pela execução do projeto\n" +
                                  "\n" +
                                  "(Informação utilizada no preenchimento\n" +
                                  "automático dos selos de aprovação)";
            this.toolTip_1_4.SetToolTip(this.label_1_4, tooltip_1_4);
            this.toolTip_1_4.SetToolTip(this.textBox_1_4, tooltip_1_4);
            #endregion

            int _padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "PropriedadePalette";
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

            this.comboBox_0_14.Text = MyProject.GetDetailValue(0, 14);
            this.textBox_0_15.Text = MyProject.GetDetailValue(0, 15);
            this.textBox_0_16.Text = MyProject.GetDetailValue(0, 16);

            this.comboBox_0_14.Items.Clear();
            foreach (var item in XMLDocs.GetXMLDoc().Descendants("Tipo"))
            {
                string value = item.Attribute("nome").Value;
                this.comboBox_0_14.Items.Add(value);
            }

            this.textBox_0_1.Text = MyProject.GetDetailValue(0, 1);
            this.textBox_0_2.Text = MyProject.GetDetailValue(0, 2);
            this.textBox_0_3.Text = MyProject.GetDetailValue(0, 3);
            this.textBox_0_4.Text = MyProject.GetDetailValue(0, 4);
            this.textBox_0_5.Text = MyProject.GetDetailValue(0, 5);

            this.textBox_0_8.Text  = MyProject.GetDetailValue(0, 8);
            this.textBox_0_9.Text  = MyProject.GetDetailValue(0, 9);
            this.textBox_0_10.Text = MyProject.GetDetailValue(0, 10);
            this.textBox_0_11.Text = MyProject.GetDetailValue(0, 11);
            this.textBox_0_12.Text = MyProject.GetDetailValue(0, 12);

            this.textBox_1_0.Text = MyProject.GetDetailValue(1, 0);
            this.textBox_1_1.Text = MyProject.GetDetailValue(1, 1);
            this.textBox_1_2.Text = MyProject.GetDetailValue(1, 2);
            this.textBox_1_3.Text = MyProject.GetDetailValue(1, 3);
            this.textBox_1_4.Text = MyProject.GetDetailValue(1, 4);
        }
        internal void FillList(string _combobox)
        {
            switch (_combobox)
            {
                case "comboBox_0_14":
                    comboBox_0_14.Items.Clear();
                    foreach (var item in XMLDocs.GetXMLDoc().Descendants("Tipo"))
                    {
                        string value = item.Attribute("nome").Value;
                        comboBox_0_14.Items.Add(value);
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

            int textBox_0 = 20;
            int label_0 = -5;

            foreach (var textbox in this.groupBox_0.Controls.OfType<TextBox>())
            {
                textBox_0 = textBox_0 + 24;
                textbox.Size = new Size(210, 20);
                textbox.Location = new Point(80, textBox_0);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var combobox in this.groupBox_0.Controls.OfType<ComboBox>())
            {
                combobox.Size = new Size(210, 20);
                combobox.Location = new Point(80, 20);
                MyFormats.ComboBoxFormat(combobox);
            }

            foreach (var label in this.groupBox_0.Controls.OfType<Label>())
            {
                label_0 = label_0 + 24;
                label.Size = new Size(65, 13);
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
                textbox.Size = new Size(210, 20);
                textbox.Location = new Point(80, textBox_1);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_1.Controls.OfType<Label>())
            {
                label_1 = label_1 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_1);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_2 builder
            
            int textBox_2 = -4;
            int label_2 = -5;

            foreach (var textbox in this.groupBox_2.Controls.OfType<TextBox>())
            {
                textBox_2 = textBox_2 + 24;
                textbox.Size = new Size(210, 20);
                textbox.Location = new Point(80, textBox_2);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_2.Controls.OfType<Label>())
            {
                label_2 = label_2 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_2);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_3 builder

            int textBox_3 = -4;
            int label_3 = -5;

            foreach (var textbox in this.groupBox_3.Controls.OfType<TextBox>())
            {
                textBox_3 = textBox_3 + 24;
                textbox.Size = new Size(210, 20);
                textbox.Location = new Point(80, textBox_3);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_3.Controls.OfType<Label>())
            {
                label_3 = label_3 + 24;
                label.Size = new Size(65, 13);
                label.Location = new Point(10, label_3);
                MyFormats.LabelFormat(label);
            }
            #endregion
        }
    }
}