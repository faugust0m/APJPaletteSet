using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace APJPaletteSet
{
    partial class ObraPalette
    {
        private IContainer components = null;
        string bk = "\n";
        #region Lista de Controles
        private Panel panel;
        private Label label;
        private PictureBox picture;

        private Label space_0;
        private Label space_1;
        private Label space_2;

        private GroupBox groupBox_0;
        private Label label_2_0;
        private TextBox textBox_2_0;
        private ToolTip toolTip_2_0;
        private Label label_2_1;
        private TextBox textBox_2_1;
        private ToolTip toolTip_2_1;
        private Label label_2_2;
        private TextBox textBox_2_2;
        private ToolTip toolTip_2_2;
        private Label label_2_3;
        private TextBox textBox_2_3;
        private ToolTip toolTip_2_3;
        private Label label_2_4;
        private TextBox textBox_2_4;
        private ToolTip toolTip_2_4;
        private Label label_2_5;
        private TextBox textBox_2_5;
        private ToolTip toolTip_2_5;
        private Label label_2_6;
        private TextBox textBox_2_6;
        private ToolTip toolTip_2_6;
        private Label label_2_7;
        private TextBox textBox_2_7;
        private ToolTip toolTip_2_7;
        private Label label_2_8;
        private TextBox textBox_2_8;
        private ToolTip toolTip_2_8;
        private Label label_2_9;
        private TextBox textBox_2_9;
        private ToolTip toolTip_2_9;

        private GroupBox groupBox_1;
        private Label label_2_22;
        private TextBox textBox_2_22;
        private ToolTip toolTip_2_22;
        private Label label_2_23;
        private TextBox textBox_2_23;
        private ToolTip toolTip_2_23;
        private Label label_2_24;
        private TextBox textBox_2_24;
        private ToolTip toolTip_2_24;
        private Label label_2_25;
        private TextBox textBox_2_25;
        private ToolTip toolTip_2_25;

        private GroupBox groupBox_2;
        private Label label_2_26;
        private TextBox textBox_2_26;
        private ToolTip toolTip_2_26;
        private Label label_2_27;
        private TextBox textBox_2_27;
        private ToolTip toolTip_2_27;
        private Label label_2_28;
        private TextBox textBox_2_28;
        private ToolTip toolTip_2_28;
        private Label label_2_29;
        private TextBox textBox_2_29;
        private ToolTip toolTip_2_29;
        private Label label_2_30;
        private TextBox textBox_2_30;
        private ToolTip toolTip_2_30;

        private Label label_2_22s;
        private Label label_2_23s;
        private Label label_2_24s;
        private Label label_2_25s;
        private Label label_2_26s;
        private Label label_2_27s;
        private Label label_2_28s;

        private GroupBox groupBox_3;
        private Label label_2_10;
        private TextBox textBox_2_10;
        private ToolTip toolTip_2_10;
        private Label label_2_11;
        private TextBox textBox_2_11;
        private ToolTip toolTip_2_11;
        private Label label_2_12;
        private TextBox textBox_2_12;
        private ToolTip toolTip_2_12;
        private Label label_2_13;
        private TextBox textBox_2_13;
        private ToolTip toolTip_2_13;

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ToolTip toolTip_radio;
        #endregion
        private void InitializeComponent()
        {
            #region Lista de controles
            this.panel = new ExPanel();
            this.label = new Label();
            this.picture = new PictureBox();

            this.space_0 = new Label();
            this.space_1 = new Label();
            this.space_2 = new Label();

            this.components = new Container();

            this.groupBox_0 = new GroupBox();
            this.label_2_0 = new Label();
            this.textBox_2_0 = new TextBox();
            this.toolTip_2_0 = new ToolTip(this.components);
            this.label_2_1 = new Label();
            this.textBox_2_1 = new TextBox();
            this.toolTip_2_1 = new ToolTip(this.components);
            this.label_2_2 = new Label();
            this.textBox_2_2 = new TextBox();
            this.toolTip_2_2 = new ToolTip(this.components);
            this.label_2_3 = new Label();
            this.textBox_2_3 = new TextBox();
            this.toolTip_2_3 = new ToolTip(this.components);
            this.label_2_4 = new Label();
            this.textBox_2_4 = new TextBox();
            this.toolTip_2_4 = new ToolTip(this.components);
            this.label_2_5 = new Label();
            this.textBox_2_5 = new TextBox();
            this.toolTip_2_5 = new ToolTip(this.components);
            this.label_2_6 = new Label();
            this.textBox_2_6 = new TextBox();
            this.toolTip_2_6 = new ToolTip(this.components);
            this.label_2_7 = new Label();
            this.textBox_2_7 = new TextBox();
            this.toolTip_2_7 = new ToolTip(this.components);
            this.label_2_8 = new Label();
            this.textBox_2_8 = new TextBox();
            this.toolTip_2_8 = new ToolTip(this.components);
            this.label_2_9 = new Label();
            this.textBox_2_9 = new TextBox();
            this.toolTip_2_9 = new ToolTip(this.components);

            this.groupBox_1 = new GroupBox();
            this.label_2_22 = new Label();
            this.textBox_2_22 = new TextBox();
            this.toolTip_2_22 = new ToolTip(this.components);
            this.label_2_23 = new Label();
            this.textBox_2_23 = new TextBox();
            this.toolTip_2_23 = new ToolTip(this.components);
            this.label_2_24 = new Label();
            this.textBox_2_24 = new TextBox();
            this.toolTip_2_24 = new ToolTip(this.components);
            this.label_2_25 = new Label();
            this.textBox_2_25 = new TextBox();
            this.toolTip_2_25 = new ToolTip(this.components);

            this.groupBox_2 = new GroupBox();
            this.label_2_26 = new Label();
            this.textBox_2_26 = new TextBox();
            this.toolTip_2_26 = new ToolTip(this.components);
            this.label_2_27 = new Label();
            this.textBox_2_27 = new TextBox();
            this.toolTip_2_27 = new ToolTip(this.components);
            this.label_2_28 = new Label();
            this.textBox_2_28 = new TextBox();
            this.toolTip_2_28 = new ToolTip(this.components);
            this.label_2_29 = new Label();
            this.textBox_2_29 = new TextBox();
            this.toolTip_2_29 = new ToolTip(this.components);
            this.label_2_30 = new Label();
            this.textBox_2_30 = new TextBox();
            this.toolTip_2_30 = new ToolTip(this.components);

            this.groupBox_3 = new GroupBox();
            this.label_2_10 = new Label();
            this.textBox_2_10 = new TextBox();
            this.toolTip_2_10 = new ToolTip(this.components);
            this.label_2_11 = new Label();
            this.textBox_2_11 = new TextBox();
            this.toolTip_2_11 = new ToolTip(this.components);
            this.label_2_12 = new Label();
            this.textBox_2_12 = new TextBox();
            this.toolTip_2_12 = new ToolTip(this.components);
            this.label_2_13 = new Label();
            this.textBox_2_13 = new TextBox();
            this.toolTip_2_13 = new ToolTip(this.components);

            this.label_2_22s = new Label();
            this.label_2_23s = new Label();
            this.label_2_24s = new Label();
            this.label_2_25s = new Label();
            this.label_2_26s = new Label();
            this.label_2_27s = new Label();
            this.label_2_28s = new Label();

            this.radioButton1 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.radioButton3 = new RadioButton();
            this.toolTip_radio = new ToolTip(this.components);
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
            this.groupBox_0.Controls.Add(this.label_2_0);
            this.groupBox_0.Controls.Add(this.textBox_2_0);
            this.groupBox_0.Controls.Add(this.label_2_1);
            this.groupBox_0.Controls.Add(this.textBox_2_1);
            this.groupBox_0.Controls.Add(this.label_2_2);
            this.groupBox_0.Controls.Add(this.textBox_2_2);
            this.groupBox_0.Controls.Add(this.label_2_3);
            this.groupBox_0.Controls.Add(this.textBox_2_3);
            this.groupBox_0.Controls.Add(this.label_2_4);
            this.groupBox_0.Controls.Add(this.textBox_2_4);
            this.groupBox_0.Controls.Add(this.label_2_5);
            this.groupBox_0.Controls.Add(this.textBox_2_5);
            this.groupBox_0.Controls.Add(this.label_2_6);
            this.groupBox_0.Controls.Add(this.textBox_2_6);
            this.groupBox_0.Controls.Add(this.label_2_7);
            this.groupBox_0.Controls.Add(this.textBox_2_7);
            this.groupBox_0.Controls.Add(this.label_2_8);
            this.groupBox_0.Controls.Add(this.textBox_2_8);
            this.groupBox_0.Controls.Add(this.label_2_9);
            this.groupBox_0.Controls.Add(this.textBox_2_9);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Name = "groupBox_0";
            this.groupBox_0.Text = "Localização";
            this.groupBox_0.Size = new Size(300, 260);

            this.label_2_0.Name = "label_2_0";
            this.label_2_0.Text = "Setor/Região:";
            this.textBox_2_0.Name = "textBox_2_0";
            MyEvents.TextBoxEvents(textBox_2_0);
            string tooltip_2_0 = MyTooltips.TextBox("o setor ou região do projeto") + bk +
                                 MyTooltips.SelosAp();
            this.toolTip_2_0.SetToolTip(this.label_2_0, tooltip_2_0);
            this.toolTip_2_0.SetToolTip(this.textBox_2_0, tooltip_2_0);

            this.label_2_1.Name = "label_2_1";
            this.label_2_1.Text = "Endereço:";
            this.textBox_2_1.Name = "textBox_2_1";
            MyEvents.TextBoxEvents(textBox_2_1);
            string tooltip_2_1 = MyTooltips.TextBox("o endereço do projeto") + bk +
                                 MyTooltips.Selos();
            this.toolTip_2_1.SetToolTip(this.label_2_1, tooltip_2_1);
            this.toolTip_2_1.SetToolTip(this.textBox_2_1, tooltip_2_1);

            this.label_2_2.Name = "label_2_2";
            this.label_2_2.Text = "Condomínio:";
            this.textBox_2_2.Name = "textBox_2_2";
            MyEvents.TextBoxEvents(textBox_2_2);
            string tooltip_2_2 = MyTooltips.TextBox("o condomínio onde se localiza o projeto");
            this.toolTip_2_2.SetToolTip(this.label_2_2, tooltip_2_2);
            this.toolTip_2_2.SetToolTip(this.textBox_2_2, tooltip_2_2);

            this.label_2_3.Name = "label_2_3";
            this.label_2_3.Text = "Bairro:";
            this.textBox_2_3.Name = "textBox_2_3";
            MyEvents.TextBoxEvents(textBox_2_3);
            string tooltip_2_3 = MyTooltips.TextBox("o bairro onde se localiza o projeto");
            this.toolTip_2_3.SetToolTip(this.label_2_3, tooltip_2_3);
            this.toolTip_2_3.SetToolTip(this.textBox_2_3, tooltip_2_3);

            this.label_2_4.Name = "label_2_4";
            this.label_2_4.Text = "Quadra:";
            this.textBox_2_4.Name = "textBox_2_4";
            MyEvents.TextBoxEvents(textBox_2_4);
            string tooltip_2_4 = MyTooltips.TextBox("a quadra onde se localiza o projeto");
            this.toolTip_2_4.SetToolTip(this.label_2_4, tooltip_2_4);
            this.toolTip_2_4.SetToolTip(this.textBox_2_4, tooltip_2_4);

            this.label_2_5.Name = "label_2_5";
            this.label_2_5.Text = "Via:";
            this.textBox_2_5.Name = "textBox_2_5";
            MyEvents.TextBoxEvents(textBox_2_5);
            string tooltip_2_5 = MyTooltips.TextBox("a via principal onde se localiza o projeto");
            this.toolTip_2_5.SetToolTip(this.label_2_5, tooltip_2_5);
            this.toolTip_2_5.SetToolTip(this.textBox_2_5, tooltip_2_5);

            this.label_2_6.Name = "label_2_6";
            this.label_2_6.Text = "Lote:";
            this.textBox_2_6.Name = "textBox_2_6";
            MyEvents.TextBoxEvents(textBox_2_6);
            string tooltip_2_6 = MyTooltips.TextBox("o lote onde se localiza o projeto");
            this.toolTip_2_6.SetToolTip(this.label_2_6, tooltip_2_6);
            this.toolTip_2_6.SetToolTip(this.textBox_2_6, tooltip_2_6);

            this.label_2_7.Name = "label_2_7";
            this.label_2_7.Text = "Complem.:";
            this.textBox_2_7.Name = "textBox_2_7";
            MyEvents.TextBoxEvents(textBox_2_7);
            string tooltip_2_7 = MyTooltips.TextBox("o complemento do endereço onde se localiza o projeto");
            this.toolTip_2_7.SetToolTip(this.label_2_7, tooltip_2_7);
            this.toolTip_2_7.SetToolTip(this.textBox_2_7, tooltip_2_7);

            this.label_2_8.Name = "label_2_8";
            this.label_2_8.Text = "Cidade:";
            this.textBox_2_8.Name = "textBox_2_8";
            MyEvents.TextBoxEvents(textBox_2_8);
            string tooltip_2_8 = MyTooltips.TextBox("a cidade onde se localiza o projeto");
            this.toolTip_2_8.SetToolTip(this.label_2_8, tooltip_2_8);
            this.toolTip_2_8.SetToolTip(this.textBox_2_8, tooltip_2_8);

            this.label_2_9.Name = "label_2_9";
            this.label_2_9.Text = "Estado:";
            this.textBox_2_9.Name = "textBox_2_9";
            MyEvents.TextBoxEvents(textBox_2_9);
            string tooltip_2_9 = MyTooltips.TextBox("o estado onde se localiza o projeto");
            this.toolTip_2_9.SetToolTip(this.label_2_9, tooltip_2_9);
            this.toolTip_2_9.SetToolTip(this.textBox_2_9, tooltip_2_9);

            #endregion
            #region groupBox_1 Taxas
            this.groupBox_1.Controls.Add(this.label_2_22);
            this.groupBox_1.Controls.Add(this.textBox_2_22);
            this.groupBox_1.Controls.Add(this.label_2_23);
            this.groupBox_1.Controls.Add(this.textBox_2_23);
            this.groupBox_1.Controls.Add(this.label_2_24);
            this.groupBox_1.Controls.Add(this.textBox_2_24);
            this.groupBox_1.Controls.Add(this.label_2_25);
            this.groupBox_1.Controls.Add(this.textBox_2_25);
            this.groupBox_1.Controls.Add(this.label_2_22s);
            this.groupBox_1.Controls.Add(this.label_2_23s);
            this.groupBox_1.Controls.Add(this.label_2_24s);            
            this.groupBox_1.Controls.Add(this.label_2_25s);

            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Taxas";
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new Size(300, 125);

            this.label_2_22.Name = "label_2_22";
            this.label_2_22.Text = "Área do terreno:";
            this.textBox_2_22.Name = "textBox_2_22";
            MyEvents.TextBoxEvents(textBox_2_22);
            string tooltip_2_22 = MyTooltips.TextBox("a área do terreno onde será construído o projeto") + bk +
                                  "(metros quadrados, com decimais separados por . 'ponto')";
            this.toolTip_2_22.SetToolTip(this.label_2_22, tooltip_2_22);
            this.toolTip_2_22.SetToolTip(this.textBox_2_22, tooltip_2_22);

            this.label_2_23.Name = "label_2_23";
            this.label_2_23.Text = "Ocupação:";
            this.textBox_2_23.Name = "textBox_2_23";
            MyEvents.TextBoxEvents(textBox_2_23);
            string tooltip_2_23 = MyTooltips.TextBox("a área máxima de projeção da construção sobre a área do terreno") + bk +
                                  "(porcentagem, número de 0 a 100, ex.: 50)";
            this.toolTip_2_23.SetToolTip(this.label_2_23, tooltip_2_23);
            this.toolTip_2_23.SetToolTip(this.textBox_2_23, tooltip_2_23);

            this.label_2_24.Name = "label_2_24";
            this.label_2_24.Text = "Aproveitamento:";
            this.textBox_2_24.Name = "textBox_2_24";
            MyEvents.TextBoxEvents(textBox_2_24);
            string tooltip_2_24 = MyTooltips.TextBox("a área máxima de construção em relação à área do terreno") + bk +
                                  "(converter índice para porcentagem, ex.: 1,5 deve ser inserido como 150)";
            this.toolTip_2_24.SetToolTip(this.label_2_24, tooltip_2_24);
            this.toolTip_2_24.SetToolTip(this.textBox_2_24, tooltip_2_24);

            this.label_2_25.Name = "label_2_25";
            this.label_2_25.Text = "Permeabilidade:";
            this.textBox_2_25.Name = "textBox_2_25";
            MyEvents.TextBoxEvents(textBox_2_25);
            string tooltip_2_25 = MyTooltips.TextBox("a área de permeabilidade mínima em relação à área do terreno") + bk +
                                  "(porcentagem, número de 0 a 100, ex.: 30)";
            this.toolTip_2_25.SetToolTip(this.label_2_25, tooltip_2_25);
            this.toolTip_2_25.SetToolTip(this.textBox_2_25, tooltip_2_25);

            this.label_2_22s.Name = "label_2_22s";
            this.label_2_22s.Text = "m²";

            this.label_2_23s.Name = "label_2_23s";
            this.label_2_23s.Text = "%";

            this.label_2_24s.Name = "label_2_24s";
            this.label_2_24s.Text = "%";

            this.label_2_25s.Name = "label_2_25s";
            this.label_2_25s.Text = "%";
            #endregion
            #region groupBox_2 Níveis
            this.groupBox_2.Controls.Add(this.label_2_26);
            this.groupBox_2.Controls.Add(this.textBox_2_26);
            this.groupBox_2.Controls.Add(this.label_2_27);
            this.groupBox_2.Controls.Add(this.textBox_2_27);
            this.groupBox_2.Controls.Add(this.label_2_28);
            this.groupBox_2.Controls.Add(this.textBox_2_28);
            this.groupBox_2.Controls.Add(this.label_2_29);
            this.groupBox_2.Controls.Add(this.textBox_2_29);
            this.groupBox_2.Controls.Add(this.label_2_30);
            this.groupBox_2.Controls.Add(this.textBox_2_30);
            this.groupBox_2.Controls.Add(this.label_2_26s);
            this.groupBox_2.Controls.Add(this.label_2_27s);
            this.groupBox_2.Controls.Add(this.label_2_28s);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.Text = "Níveis";
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new Size(300, 145);

            this.label_2_26.Name = "label_2_26";
            this.label_2_26.Text = "Nível Base:";
            this.textBox_2_26.Name = "textBox_2_26";
            MyEvents.TextBoxEvents(textBox_2_26);
            string tooltip_2_26 = MyTooltips.TextBox("o valor a ser considerado como nível 0 pelo gerenciador de projeto - Levels") + bk +
                                  "(centímetros, com decimais separados por . 'ponto')";
            this.toolTip_2_26.SetToolTip(this.label_2_26, tooltip_2_26);
            this.toolTip_2_26.SetToolTip(this.textBox_2_26, tooltip_2_26);

            this.label_2_27.Name = "label_2_27";
            this.label_2_27.Text = "Nível Topografia:";
            this.textBox_2_27.Name = "textBox_2_27";
            MyEvents.TextBoxEvents(textBox_2_27);
            string tooltip_2_27 = MyTooltips.TextBox("o nível topográfico a ser referenciado como nível Z = 0 pelo gerenciador de projeto") + bk +
                                  "nas cotas topográficas e de soleira" + bk +
                                  "(metros, com decimais separados por . 'ponto')";
            this.toolTip_2_27.SetToolTip(this.label_2_27, tooltip_2_27);
            this.toolTip_2_27.SetToolTip(this.textBox_2_27, tooltip_2_27);

            this.label_2_28.Name = "label_2_28";
            this.label_2_28.Text = "Cota de Soleira:";
            this.textBox_2_28.Name = "textBox_2_28";
            MyEvents.TextBoxEvents(textBox_2_28);
            string tooltip_2_28 = MyTooltips.TextBox("o nível topográfico a ser referenciado como cota de soleira") + bk +
                                  "(metros, com decimais separados por . 'ponto')";
            this.toolTip_2_28.SetToolTip(this.label_2_28, tooltip_2_28);
            this.toolTip_2_28.SetToolTip(this.textBox_2_28, tooltip_2_28);

            this.label_2_29.Name = "label_2_29";
            this.label_2_29.Text = "Coordenada X:";
            this.textBox_2_29.Name = "textBox_2_29";
            MyEvents.TextBoxEvents(textBox_2_29);
            string tooltip_2_29 = MyTooltips.TextBox("a coordenada X do ponto de origem (X = 0) do terreno") + bk +
                                  "(número, com decimais separados por . 'ponto')";
            this.toolTip_2_29.SetToolTip(this.label_2_29, tooltip_2_29);
            this.toolTip_2_29.SetToolTip(this.textBox_2_29, tooltip_2_29);

            this.label_2_30.Name = "label_2_30";
            this.label_2_30.Text = "Coordenada Y:";
            this.textBox_2_30.Name = "textBox_2_30";
            MyEvents.TextBoxEvents(textBox_2_30);
            string tooltip_2_30 = MyTooltips.TextBox("a coordenada Y do ponto de origem (Y = 0) do terreno") + bk +
                                  "(número, com decimais separados por . 'ponto')";
            this.toolTip_2_30.SetToolTip(this.label_2_30, tooltip_2_30);
            this.toolTip_2_30.SetToolTip(this.textBox_2_30, tooltip_2_30);

            this.label_2_26s.Name = "label_2_26s";
            this.label_2_26s.Text = "cm";

            this.label_2_27s.Name = "label_2_27s";
            this.label_2_27s.Text = "m";

            this.label_2_28s.Name = "label_2_28s";
            this.label_2_28s.Text = "m";
            #endregion
            #region groupBox_3
            this.groupBox_3.Controls.Add(this.label_2_10);
            this.groupBox_3.Controls.Add(this.textBox_2_10);
            this.groupBox_3.Controls.Add(this.label_2_11);
            this.groupBox_3.Controls.Add(this.textBox_2_11);
            this.groupBox_3.Controls.Add(this.label_2_12);
            this.groupBox_3.Controls.Add(this.textBox_2_12);
            this.groupBox_3.Controls.Add(this.label_2_13);
            this.groupBox_3.Controls.Add(this.textBox_2_13);
            this.groupBox_3.Controls.Add(this.radioButton1);
            this.groupBox_3.Controls.Add(this.radioButton2);
            this.groupBox_3.Controls.Add(this.radioButton3);
            this.groupBox_3.TabIndex = 3;
            this.groupBox_3.Text = "Limites";
            this.groupBox_3.Name = "groupBox_3";
            this.groupBox_3.Size = new Size(300, 140);

            this.label_2_10.Name = "label_2_10";
            this.label_2_10.Text = "Lote:";
            this.textBox_2_10.Name = "textBox_2_10";
            this.textBox_2_10.KeyPress += new KeyPressEventHandler(this.TextBox_2_10_Enter);
            this.textBox_2_10.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.TextBox_LostFocus(sender, e, 2, 10);
            };
            string tooltip_2_10 = MyTooltips.TextBoxLimite("o número do lote vizinho");
            this.toolTip_2_10.SetToolTip(this.label_2_10, tooltip_2_10);
            this.toolTip_2_10.SetToolTip(this.textBox_2_10, tooltip_2_10);

            this.label_2_11.Name = "label_2_11";
            this.label_2_11.Text = "Fechamento:";
            this.textBox_2_11.Name = "textBox_2_11";
            this.textBox_2_11.KeyPress += new KeyPressEventHandler(this.TextBox_2_11_Enter);
            this.textBox_2_11.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.TextBox_LostFocus(sender, e, 2, 11);
            };
            string tooltip_2_11 = MyTooltips.TextBoxLimite("o tipo de fechamento");
            this.toolTip_2_11.SetToolTip(this.label_2_11, tooltip_2_11);
            this.toolTip_2_11.SetToolTip(this.textBox_2_11, tooltip_2_11);

            this.label_2_12.Name = "label_2_12";
            this.label_2_12.Text = "Altura:";
            this.textBox_2_12.Name = "textBox_2_12";
            this.textBox_2_12.KeyPress += new KeyPressEventHandler(this.TextBox_2_12_Enter);
            this.textBox_2_12.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.TextBox_LostFocus(sender, e, 2, 12);
            };
            string tooltip_2_12 = MyTooltips.TextBoxLimite("a altura do fechamento");
            this.toolTip_2_12.SetToolTip(this.label_2_12, tooltip_2_12);
            this.toolTip_2_12.SetToolTip(this.textBox_2_12, tooltip_2_12);

            this.label_2_13.Name = "label_2_13";
            this.label_2_13.Text = "Via:";
            this.textBox_2_13.Name = "textBox_2_13";
            this.textBox_2_13.KeyPress += new KeyPressEventHandler(this.TextBox_2_13_Enter);
            this.textBox_2_13.LostFocus += delegate (object sender, EventArgs e) {
                MyEvents.TextBox_LostFocus(sender, e, 2, 13);
            };
            string tooltip_2_13 = MyTooltips.TextBoxLimite("a via");
            this.toolTip_2_13.SetToolTip(this.label_2_13, tooltip_2_13);
            this.toolTip_2_13.SetToolTip(this.textBox_2_13, tooltip_2_13);
            #endregion
            #region radioButton
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Text = "Direito";
            this.radioButton1.Location = new Point(10, 17);
            this.radioButton1.Size = new Size(61, 18);
            this.radioButton1.CheckedChanged += new EventHandler(this.RadioButton_CheckedChanged);

            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Text = "Esquerdo";
            this.radioButton2.Location = new Point(80, 17);
            this.radioButton2.Size = new Size(76, 18);
            this.radioButton2.CheckedChanged += new EventHandler(this.RadioButton_CheckedChanged);

            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Text = "Fundos";
            this.radioButton3.Location = new Point(160, 17);
            this.radioButton3.Size = new Size(66, 18);
            this.radioButton3.CheckedChanged += new EventHandler(this.RadioButton_CheckedChanged);

            string tooltip_radio = "Selecione a referência do limte cujas\n" +
                                   "informações serão modificadas";
            this.toolTip_radio.SetToolTip(this.radioButton1, tooltip_radio);
            this.toolTip_radio.SetToolTip(this.radioButton2, tooltip_radio);
            this.toolTip_radio.SetToolTip(this.radioButton3, tooltip_radio);

            #endregion

            int _padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "ObraPalette";
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

            this.textBox_2_0.Text = MyProject.GetDetailValue(2, 0);
            this.textBox_2_1.Text = MyProject.GetDetailValue(2, 1);
            this.textBox_2_2.Text = MyProject.GetDetailValue(2, 2);
            this.textBox_2_3.Text = MyProject.GetDetailValue(2, 3);
            this.textBox_2_4.Text = MyProject.GetDetailValue(2, 4);
            this.textBox_2_5.Text = MyProject.GetDetailValue(2, 5);
            this.textBox_2_6.Text = MyProject.GetDetailValue(2, 6);
            this.textBox_2_7.Text = MyProject.GetDetailValue(2, 7);
            this.textBox_2_8.Text = MyProject.GetDetailValue(2, 8);
            this.textBox_2_9.Text = MyProject.GetDetailValue(2, 9);

            this.textBox_2_22.Text = MyProject.GetDetailValue(2, 22);
            this.textBox_2_23.Text = MyProject.GetDetailValue(2, 23);
            this.textBox_2_24.Text = MyProject.GetDetailValue(2, 24);
            this.textBox_2_25.Text = MyProject.GetDetailValue(2, 25);

            this.textBox_2_26.Text = MyProject.GetDetailValue(2, 26);
            this.textBox_2_27.Text = MyProject.GetDetailValue(2, 27);
            this.textBox_2_28.Text = MyProject.GetDetailValue(2, 28);
            this.textBox_2_29.Text = MyProject.GetDetailValue(2, 29);
            this.textBox_2_30.Text = MyProject.GetDetailValue(2, 30);

            this.radioButton1.Checked = true;
            this.textBox_2_10.Text = MyProject.GetDetailValue(2, 10);
            this.textBox_2_11.Text = MyProject.GetDetailValue(2, 11);
            this.textBox_2_12.Text = MyProject.GetDetailValue(2, 12);
            this.textBox_2_13.Text = MyProject.GetDetailValue(2, 13);
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
            #region radioButton builder
            foreach (var radiobutton in this.Controls.OfType<RadioButton>())
            {
                MyFormats.RadioButtonFormat(radiobutton);
            }
            #endregion
            #region groupBox_0 builder

            int textBox_0 = -4;
            int label_0 = -5;

            foreach (var textbox in this.groupBox_0.Controls.OfType<TextBox>())
            {
                textBox_0 = textBox_0 + 24;
                textbox.Size = new Size(210, 20);
                textbox.Location = new Point(80, textBox_0);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_0.Controls.OfType<Label>())
            {
                label_0 = label_0 + 24;
                label.Size = new Size(68, 15);
                label.Location = new Point(10, label_0);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_1 builder
            // 
            int textBox_1 = -4;
            int label_1 = -5;

            foreach (var textbox in this.groupBox_1.Controls.OfType<TextBox>())
            {
                textBox_1 = textBox_1 + 24;
                textbox.Size = new Size(100, 20);
                textbox.Location = new Point(175, textBox_1);
                MyFormats.TextBoxFormat(textbox);
                textbox.TextAlign = HorizontalAlignment.Right;
            }

            foreach (var label in this.groupBox_1.Controls.OfType<Label>())
            {
                label_1 = label_1 + 24;
                label.Size = new Size(80, 15);
                label.Location = new Point(10, label_1);
                MyFormats.LabelFormat(label);
            }

            MyFormats.LabelRightFormat(label_2_22s);
            this.label_2_22s.Location = new Point(280, 19);
            MyFormats.LabelRightFormat(label_2_23s);
            this.label_2_23s.Location = new Point(280, 43);
            MyFormats.LabelRightFormat(label_2_24s);
            this.label_2_24s.Location = new Point(280, 67);
            MyFormats.LabelRightFormat(label_2_25s);
            this.label_2_25s.Location = new Point(280, 91);

            #endregion
            #region groupBox_2 builder

            int textBox_2 = -4;
            int label_2 = -5;

            foreach (var textbox in this.groupBox_2.Controls.OfType<TextBox>())
            {
                textBox_2 = textBox_2 + 24;
                textbox.Size = new Size(125, 20);
                textbox.Location = new Point(150, textBox_2);
                MyFormats.TextBoxFormat(textbox);
                textbox.TextAlign = HorizontalAlignment.Right;
            }

            foreach (var label in this.groupBox_2.Controls.OfType<Label>())
            {
                label_2 = label_2 + 24;
                label.Size = new Size(120, 15);
                label.Location = new Point(10, label_2);
                MyFormats.LabelFormat(label);
            }

            MyFormats.LabelRightFormat(label_2_26s);
            this.label_2_26s.Location = new Point(280, 19);
            MyFormats.LabelRightFormat(label_2_27s);
            this.label_2_27s.Location = new Point(280, 43);
            MyFormats.LabelRightFormat(label_2_28s);
            this.label_2_28s.Location = new Point(280, 67);

            #endregion
            #region groupBox_3 builder

            int textBox_3 = 20;
            int label_3 = 19;

            foreach (var textbox in this.groupBox_3.Controls.OfType<TextBox>())
            {
                textBox_3 = textBox_3 + 24;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_3);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_3.Controls.OfType<Label>())
            {
                label_3 = label_3 + 24;
                label.Size = new Size(65, 15);
                label.Location = new Point(20, label_3);
                MyFormats.LabelFormat(label);
            }
            #endregion
        }
    }
}