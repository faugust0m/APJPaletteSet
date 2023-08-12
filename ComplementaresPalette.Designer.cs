using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APJPaletteSet
{
    partial class ComplementaresPalette
    {
        #region Lista de Controles
        private Panel panel;
        private Label label;
        private PictureBox picture;

        private Label space_0;
        private Label space_1;
        private Label space_2;
        private Label space_3;
        private Label space_4;
        private Label space_5;
        private Label space_6;
        private Label space_7;
        private Label space_8;
        private Label space_9;
        private Label space_10;
        private Label space_11;
        private Label space_12;

        private GroupBox groupBox_0;
        private Label label_91_0;
        private TextBox textBox_91_0;
        private Label label_91_1;
        private TextBox textBox_91_1;
        private Label label_91_2;
        private TextBox textBox_91_2;
        private Label label_91_3;
        private TextBox textBox_91_3;
        private Label label_91_4;
        private TextBox textBox_91_4;
        private Label label_91_5;
        private TextBox textBox_91_5;
        private Label label_91_6;
        private TextBox textBox_91_6;
        private Label label_91_7;
        private TextBox textBox_91_7;
        private Label label_91_8;
        private TextBox textBox_91_8;
        private Label label_91_9;
        private TextBox textBox_91_9;
        private Label label_91_10;
        private ComboBox comboBox_91_10;
        private Label label_91_11;
        private TextBox textBox_91_11;

        private GroupBox groupBox_1;
        private Label label_92_0;
        private TextBox textBox_92_0;
        private Label label_92_1;
        private TextBox textBox_92_1;
        private Label label_92_2;
        private TextBox textBox_92_2;
        private Label label_92_3;
        private TextBox textBox_92_3;
        private Label label_92_4;
        private TextBox textBox_92_4;
        private Label label_92_5;
        private TextBox textBox_92_5;
        private Label label_92_6;
        private TextBox textBox_92_6;
        private Label label_92_7;
        private TextBox textBox_92_7;
        private Label label_92_8;
        private TextBox textBox_92_8;
        private Label label_92_9;
        private TextBox textBox_92_9;
        private Label label_92_10;
        private ComboBox comboBox_92_10;
        private Label label_92_11;
        private TextBox textBox_92_11;

        private GroupBox groupBox_2;
        private Label label_93_0;
        private TextBox textBox_93_0;
        private Label label_93_1;
        private TextBox textBox_93_1;
        private Label label_93_2;
        private TextBox textBox_93_2;
        private Label label_93_3;
        private TextBox textBox_93_3;
        private Label label_93_4;
        private TextBox textBox_93_4;
        private Label label_93_5;
        private TextBox textBox_93_5;
        private Label label_93_6;
        private TextBox textBox_93_6;
        private Label label_93_7;
        private TextBox textBox_93_7;
        private Label label_93_8;
        private TextBox textBox_93_8;
        private Label label_93_9;
        private TextBox textBox_93_9;
        private Label label_93_10;
        private ComboBox comboBox_93_10;
        private Label label_93_11;
        private TextBox textBox_93_11;

        private GroupBox groupBox_3;
        private Label label_94_0;
        private TextBox textBox_94_0;
        private Label label_94_1;
        private TextBox textBox_94_1;
        private Label label_94_2;
        private TextBox textBox_94_2;
        private Label label_94_3;
        private TextBox textBox_94_3;
        private Label label_94_4;
        private TextBox textBox_94_4;
        private Label label_94_5;
        private TextBox textBox_94_5;
        private Label label_94_6;
        private TextBox textBox_94_6;
        private Label label_94_7;
        private TextBox textBox_94_7;
        private Label label_94_8;
        private TextBox textBox_94_8;
        private Label label_94_9;
        private TextBox textBox_94_9;
        private Label label_94_10;
        private ComboBox comboBox_94_10;
        private Label label_94_11;
        private TextBox textBox_94_11;

        private GroupBox groupBox_4;
        private Label label_95_0;
        private TextBox textBox_95_0;
        private Label label_95_1;
        private TextBox textBox_95_1;
        private Label label_95_2;
        private TextBox textBox_95_2;
        private Label label_95_3;
        private TextBox textBox_95_3;
        private Label label_95_4;
        private TextBox textBox_95_4;
        private Label label_95_5;
        private TextBox textBox_95_5;
        private Label label_95_6;
        private TextBox textBox_95_6;
        private Label label_95_7;
        private TextBox textBox_95_7;
        private Label label_95_8;
        private TextBox textBox_95_8;
        private Label label_95_9;
        private TextBox textBox_95_9;
        private Label label_95_10;
        private ComboBox comboBox_95_10;
        private Label label_95_11;
        private TextBox textBox_95_11;

        private GroupBox groupBox_5;
        private Label label_96_0;
        private TextBox textBox_96_0;
        private Label label_96_1;
        private TextBox textBox_96_1;
        private Label label_96_2;
        private TextBox textBox_96_2;
        private Label label_96_3;
        private TextBox textBox_96_3;
        private Label label_96_4;
        private TextBox textBox_96_4;
        private Label label_96_5;
        private TextBox textBox_96_5;
        private Label label_96_6;
        private TextBox textBox_96_6;
        private Label label_96_7;
        private TextBox textBox_96_7;
        private Label label_96_8;
        private TextBox textBox_96_8;
        private Label label_96_9;
        private TextBox textBox_96_9;
        private Label label_96_10;
        private ComboBox comboBox_96_10;
        private Label label_96_11;
        private TextBox textBox_96_11;

        private GroupBox groupBox_6;
        private Label label_97_0;
        private TextBox textBox_97_0;
        private Label label_97_1;
        private TextBox textBox_97_1;
        private Label label_97_2;
        private TextBox textBox_97_2;
        private Label label_97_3;
        private TextBox textBox_97_3;
        private Label label_97_4;
        private TextBox textBox_97_4;
        private Label label_97_5;
        private TextBox textBox_97_5;
        private Label label_97_6;
        private TextBox textBox_97_6;
        private Label label_97_7;
        private TextBox textBox_97_7;
        private Label label_97_8;
        private TextBox textBox_97_8;
        private Label label_97_9;
        private TextBox textBox_97_9;
        private Label label_97_10;
        private ComboBox comboBox_97_10;
        private Label label_97_11;
        private TextBox textBox_97_11;

        private GroupBox groupBox_7;
        private Label label_98_0;
        private TextBox textBox_98_0;
        private Label label_98_1;
        private TextBox textBox_98_1;
        private Label label_98_2;
        private TextBox textBox_98_2;
        private Label label_98_3;
        private TextBox textBox_98_3;
        private Label label_98_4;
        private TextBox textBox_98_4;
        private Label label_98_5;
        private TextBox textBox_98_5;
        private Label label_98_6;
        private TextBox textBox_98_6;
        private Label label_98_7;
        private TextBox textBox_98_7;
        private Label label_98_8;
        private TextBox textBox_98_8;
        private Label label_98_9;
        private TextBox textBox_98_9;
        private Label label_98_10;
        private ComboBox comboBox_98_10;
        private Label label_98_11;
        private TextBox textBox_98_11;

        private GroupBox groupBox_8;
        private Label label_99_0;
        private TextBox textBox_99_0;
        private Label label_99_1;
        private TextBox textBox_99_1;
        private Label label_99_2;
        private TextBox textBox_99_2;
        private Label label_99_3;
        private TextBox textBox_99_3;
        private Label label_99_4;
        private TextBox textBox_99_4;
        private Label label_99_5;
        private TextBox textBox_99_5;
        private Label label_99_6;
        private TextBox textBox_99_6;
        private Label label_99_7;
        private TextBox textBox_99_7;
        private Label label_99_8;
        private TextBox textBox_99_8;
        private Label label_99_9;
        private TextBox textBox_99_9;
        private Label label_99_10;
        private ComboBox comboBox_99_10;
        private Label label_99_11;
        private TextBox textBox_99_11;

        private GroupBox groupBox_9;
        private Label label_100_0;
        private TextBox textBox_100_0;
        private Label label_100_1;
        private TextBox textBox_100_1;
        private Label label_100_2;
        private TextBox textBox_100_2;
        private Label label_100_3;
        private TextBox textBox_100_3;
        private Label label_100_4;
        private TextBox textBox_100_4;
        private Label label_100_5;
        private TextBox textBox_100_5;
        private Label label_100_6;
        private TextBox textBox_100_6;
        private Label label_100_7;
        private TextBox textBox_100_7;
        private Label label_100_8;
        private TextBox textBox_100_8;
        private Label label_100_9;
        private TextBox textBox_100_9;
        private Label label_100_10;
        private ComboBox comboBox_100_10;
        private Label label_100_11;
        private TextBox textBox_100_11;

        private GroupBox groupBox_10;
        private Label label_101_0;
        private TextBox textBox_101_0;
        private Label label_101_1;
        private TextBox textBox_101_1;
        private Label label_101_2;
        private TextBox textBox_101_2;
        private Label label_101_3;
        private TextBox textBox_101_3;
        private Label label_101_4;
        private TextBox textBox_101_4;
        private Label label_101_5;
        private TextBox textBox_101_5;
        private Label label_101_6;
        private TextBox textBox_101_6;
        private Label label_101_7;
        private TextBox textBox_101_7;
        private Label label_101_8;
        private TextBox textBox_101_8;
        private Label label_101_9;
        private TextBox textBox_101_9;
        private Label label_101_10;
        private ComboBox comboBox_101_10;
        private Label label_101_11;
        private TextBox textBox_101_11;

        private GroupBox groupBox_11;
        private Label label_102_0;
        private TextBox textBox_102_0;
        private Label label_102_1;
        private TextBox textBox_102_1;
        private Label label_102_2;
        private TextBox textBox_102_2;
        private Label label_102_3;
        private TextBox textBox_102_3;
        private Label label_102_4;
        private TextBox textBox_102_4;
        private Label label_102_5;
        private TextBox textBox_102_5;
        private Label label_102_6;
        private TextBox textBox_102_6;
        private Label label_102_7;
        private TextBox textBox_102_7;
        private Label label_102_8;
        private TextBox textBox_102_8;
        private Label label_102_9;
        private TextBox textBox_102_9;
        private Label label_102_10;
        private ComboBox comboBox_102_10;
        private Label label_102_11;
        private TextBox textBox_102_11;

        private GroupBox groupBox_12;
        private Label label_103_0;
        private TextBox textBox_103_0;
        private Label label_103_1;
        private TextBox textBox_103_1;
        private Label label_103_2;
        private TextBox textBox_103_2;
        private Label label_103_3;
        private TextBox textBox_103_3;
        private Label label_103_4;
        private TextBox textBox_103_4;
        private Label label_103_5;
        private TextBox textBox_103_5;
        private Label label_103_6;
        private TextBox textBox_103_6;
        private Label label_103_7;
        private TextBox textBox_103_7;
        private Label label_103_8;
        private TextBox textBox_103_8;
        private Label label_103_9;
        private TextBox textBox_103_9;
        private Label label_103_10;
        private ComboBox comboBox_103_10;
        private Label label_103_11;
        private TextBox textBox_103_11;

        private GroupBox groupBox_13;
        private Label label_104_0;
        private TextBox textBox_104_0;
        private Label label_104_1;
        private TextBox textBox_104_1;
        private Label label_104_2;
        private TextBox textBox_104_2;
        private Label label_104_3;
        private TextBox textBox_104_3;
        private Label label_104_4;
        private TextBox textBox_104_4;
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
            this.space_3 = new Label();
            this.space_4 = new Label();
            this.space_5 = new Label();
            this.space_6 = new Label();
            this.space_7 = new Label();
            this.space_8 = new Label();
            this.space_9 = new Label();
            this.space_10 = new Label();
            this.space_11 = new Label();
            this.space_12 = new Label();

            this.groupBox_0 = new GroupBox();
            this.label_91_10 = new Label();
            this.comboBox_91_10 = new ComboBox();
            this.label_91_0 = new Label();
            this.textBox_91_0 = new TextBox();
            this.label_91_1 = new Label();
            this.textBox_91_1 = new TextBox();
            this.label_91_2 = new Label();
            this.textBox_91_2 = new TextBox();
            this.label_91_3 = new Label();
            this.textBox_91_3 = new TextBox();
            this.label_91_4 = new Label();
            this.textBox_91_4 = new TextBox();
            this.label_91_11 = new Label();
            this.textBox_91_11 = new TextBox();
            this.label_91_5 = new Label();
            this.textBox_91_5 = new TextBox();
            this.label_91_6 = new Label();
            this.textBox_91_6 = new TextBox();
            this.label_91_7 = new Label();
            this.textBox_91_7 = new TextBox();
            this.label_91_8 = new Label();
            this.textBox_91_8 = new TextBox();
            this.label_91_9 = new Label();
            this.textBox_91_9 = new TextBox();

            this.groupBox_1 = new GroupBox();
            this.label_92_10 = new Label();
            this.comboBox_92_10 = new ComboBox();
            this.label_92_0 = new Label();
            this.textBox_92_0 = new TextBox();
            this.label_92_1 = new Label();
            this.textBox_92_1 = new TextBox();
            this.label_92_2 = new Label();
            this.textBox_92_2 = new TextBox();
            this.label_92_3 = new Label();
            this.textBox_92_3 = new TextBox();
            this.label_92_4 = new Label();
            this.textBox_92_4 = new TextBox();
            this.label_92_11 = new Label();
            this.textBox_92_11 = new TextBox();
            this.label_92_5 = new Label();
            this.textBox_92_5 = new TextBox();
            this.label_92_6 = new Label();
            this.textBox_92_6 = new TextBox();
            this.label_92_7 = new Label();
            this.textBox_92_7 = new TextBox();
            this.label_92_8 = new Label();
            this.textBox_92_8 = new TextBox();
            this.label_92_9 = new Label();
            this.textBox_92_9 = new TextBox();

            this.groupBox_2 = new GroupBox();
            this.label_93_10 = new Label();
            this.comboBox_93_10 = new ComboBox();
            this.label_93_0 = new Label();
            this.textBox_93_0 = new TextBox();
            this.label_93_1 = new Label();
            this.textBox_93_1 = new TextBox();
            this.label_93_2 = new Label();
            this.textBox_93_2 = new TextBox();
            this.label_93_3 = new Label();
            this.textBox_93_3 = new TextBox();
            this.label_93_4 = new Label();
            this.textBox_93_4 = new TextBox();
            this.label_93_11 = new Label();
            this.textBox_93_11 = new TextBox();
            this.label_93_5 = new Label();
            this.textBox_93_5 = new TextBox();
            this.label_93_6 = new Label();
            this.textBox_93_6 = new TextBox();
            this.label_93_7 = new Label();
            this.textBox_93_7 = new TextBox();
            this.label_93_8 = new Label();
            this.textBox_93_8 = new TextBox();
            this.label_93_9 = new Label();
            this.textBox_93_9 = new TextBox();

            this.groupBox_3 = new GroupBox();
            this.label_94_10 = new Label();
            this.comboBox_94_10 = new ComboBox();
            this.label_94_0 = new Label();
            this.textBox_94_0 = new TextBox();
            this.label_94_1 = new Label();
            this.textBox_94_1 = new TextBox();
            this.label_94_2 = new Label();
            this.textBox_94_2 = new TextBox();
            this.label_94_3 = new Label();
            this.textBox_94_3 = new TextBox();
            this.label_94_4 = new Label();
            this.textBox_94_4 = new TextBox();
            this.label_94_11 = new Label();
            this.textBox_94_11 = new TextBox();
            this.label_94_5 = new Label();
            this.textBox_94_5 = new TextBox();
            this.label_94_6 = new Label();
            this.textBox_94_6 = new TextBox();
            this.label_94_7 = new Label();
            this.textBox_94_7 = new TextBox();
            this.label_94_8 = new Label();
            this.textBox_94_8 = new TextBox();
            this.label_94_9 = new Label();
            this.textBox_94_9 = new TextBox();

            this.groupBox_4 = new GroupBox();
            this.label_95_10 = new Label();
            this.comboBox_95_10 = new ComboBox();
            this.label_95_0 = new Label();
            this.textBox_95_0 = new TextBox();
            this.label_95_1 = new Label();
            this.textBox_95_1 = new TextBox();
            this.label_95_2 = new Label();
            this.textBox_95_2 = new TextBox();
            this.label_95_3 = new Label();
            this.textBox_95_3 = new TextBox();
            this.label_95_4 = new Label();
            this.textBox_95_4 = new TextBox();
            this.label_95_11 = new Label();
            this.textBox_95_11 = new TextBox();
            this.label_95_5 = new Label();
            this.textBox_95_5 = new TextBox();
            this.label_95_6 = new Label();
            this.textBox_95_6 = new TextBox();
            this.label_95_7 = new Label();
            this.textBox_95_7 = new TextBox();
            this.label_95_8 = new Label();
            this.textBox_95_8 = new TextBox();
            this.label_95_9 = new Label();
            this.textBox_95_9 = new TextBox();

            this.groupBox_5 = new GroupBox();
            this.label_96_10 = new Label();
            this.comboBox_96_10 = new ComboBox();
            this.label_96_0 = new Label();
            this.textBox_96_0 = new TextBox();
            this.label_96_1 = new Label();
            this.textBox_96_1 = new TextBox();
            this.label_96_2 = new Label();
            this.textBox_96_2 = new TextBox();
            this.label_96_3 = new Label();
            this.textBox_96_3 = new TextBox();
            this.label_96_4 = new Label();
            this.textBox_96_4 = new TextBox();
            this.label_96_11 = new Label();
            this.textBox_96_11 = new TextBox();
            this.label_96_5 = new Label();
            this.textBox_96_5 = new TextBox();
            this.label_96_6 = new Label();
            this.textBox_96_6 = new TextBox();
            this.label_96_7 = new Label();
            this.textBox_96_7 = new TextBox();
            this.label_96_8 = new Label();
            this.textBox_96_8 = new TextBox();
            this.label_96_9 = new Label();
            this.textBox_96_9 = new TextBox();

            this.groupBox_6 = new GroupBox();
            this.label_97_10 = new Label();
            this.comboBox_97_10 = new ComboBox();
            this.label_97_0 = new Label();
            this.textBox_97_0 = new TextBox();
            this.label_97_1 = new Label();
            this.textBox_97_1 = new TextBox();
            this.label_97_2 = new Label();
            this.textBox_97_2 = new TextBox();
            this.label_97_3 = new Label();
            this.textBox_97_3 = new TextBox();
            this.label_97_4 = new Label();
            this.textBox_97_4 = new TextBox();
            this.label_97_11 = new Label();
            this.textBox_97_11 = new TextBox();
            this.label_97_5 = new Label();
            this.textBox_97_5 = new TextBox();
            this.label_97_6 = new Label();
            this.textBox_97_6 = new TextBox();
            this.label_97_7 = new Label();
            this.textBox_97_7 = new TextBox();
            this.label_97_8 = new Label();
            this.textBox_97_8 = new TextBox();
            this.label_97_9 = new Label();
            this.textBox_97_9 = new TextBox();

            this.groupBox_7 = new GroupBox();
            this.label_98_10 = new Label();
            this.comboBox_98_10 = new ComboBox();
            this.label_98_0 = new Label();
            this.textBox_98_0 = new TextBox();
            this.label_98_1 = new Label();
            this.textBox_98_1 = new TextBox();
            this.label_98_2 = new Label();
            this.textBox_98_2 = new TextBox();
            this.label_98_3 = new Label();
            this.textBox_98_3 = new TextBox();
            this.label_98_4 = new Label();
            this.textBox_98_4 = new TextBox();
            this.label_98_11 = new Label();
            this.textBox_98_11 = new TextBox();
            this.label_98_5 = new Label();
            this.textBox_98_5 = new TextBox();
            this.label_98_6 = new Label();
            this.textBox_98_6 = new TextBox();
            this.label_98_7 = new Label();
            this.textBox_98_7 = new TextBox();
            this.label_98_8 = new Label();
            this.textBox_98_8 = new TextBox();
            this.label_98_9 = new Label();
            this.textBox_98_9 = new TextBox();

            this.groupBox_8 = new GroupBox();
            this.label_99_10 = new Label();
            this.comboBox_99_10 = new ComboBox();
            this.label_99_0 = new Label();
            this.textBox_99_0 = new TextBox();
            this.label_99_1 = new Label();
            this.textBox_99_1 = new TextBox();
            this.label_99_2 = new Label();
            this.textBox_99_2 = new TextBox();
            this.label_99_3 = new Label();
            this.textBox_99_3 = new TextBox();
            this.label_99_4 = new Label();
            this.textBox_99_4 = new TextBox();
            this.label_99_11 = new Label();
            this.textBox_99_11 = new TextBox();
            this.label_99_5 = new Label();
            this.textBox_99_5 = new TextBox();
            this.label_99_6 = new Label();
            this.textBox_99_6 = new TextBox();
            this.label_99_7 = new Label();
            this.textBox_99_7 = new TextBox();
            this.label_99_8 = new Label();
            this.textBox_99_8 = new TextBox();
            this.label_99_9 = new Label();
            this.textBox_99_9 = new TextBox();

            this.groupBox_9 = new GroupBox();
            this.label_100_10 = new Label();
            this.comboBox_100_10 = new ComboBox();
            this.label_100_0 = new Label();
            this.textBox_100_0 = new TextBox();
            this.label_100_1 = new Label();
            this.textBox_100_1 = new TextBox();
            this.label_100_2 = new Label();
            this.textBox_100_2 = new TextBox();
            this.label_100_3 = new Label();
            this.textBox_100_3 = new TextBox();
            this.label_100_4 = new Label();
            this.textBox_100_4 = new TextBox();
            this.label_100_11 = new Label();
            this.textBox_100_11 = new TextBox();
            this.label_100_5 = new Label();
            this.textBox_100_5 = new TextBox();
            this.label_100_6 = new Label();
            this.textBox_100_6 = new TextBox();
            this.label_100_7 = new Label();
            this.textBox_100_7 = new TextBox();
            this.label_100_8 = new Label();
            this.textBox_100_8 = new TextBox();
            this.label_100_9 = new Label();
            this.textBox_100_9 = new TextBox();

            this.groupBox_10 = new GroupBox();
            this.label_101_10 = new Label();
            this.comboBox_101_10 = new ComboBox();
            this.label_101_0 = new Label();
            this.textBox_101_0 = new TextBox();
            this.label_101_1 = new Label();
            this.textBox_101_1 = new TextBox();
            this.label_101_2 = new Label();
            this.textBox_101_2 = new TextBox();
            this.label_101_3 = new Label();
            this.textBox_101_3 = new TextBox();
            this.label_101_4 = new Label();
            this.textBox_101_4 = new TextBox();
            this.label_101_11 = new Label();
            this.textBox_101_11 = new TextBox();
            this.label_101_5 = new Label();
            this.textBox_101_5 = new TextBox();
            this.label_101_6 = new Label();
            this.textBox_101_6 = new TextBox();
            this.label_101_7 = new Label();
            this.textBox_101_7 = new TextBox();
            this.label_101_8 = new Label();
            this.textBox_101_8 = new TextBox();
            this.label_101_9 = new Label();
            this.textBox_101_9 = new TextBox();

            this.groupBox_11 = new GroupBox();
            this.label_102_10 = new Label();
            this.comboBox_102_10 = new ComboBox();
            this.label_102_0 = new Label();
            this.textBox_102_0 = new TextBox();
            this.label_102_1 = new Label();
            this.textBox_102_1 = new TextBox();
            this.label_102_2 = new Label();
            this.textBox_102_2 = new TextBox();
            this.label_102_3 = new Label();
            this.textBox_102_3 = new TextBox();
            this.label_102_4 = new Label();
            this.textBox_102_4 = new TextBox();
            this.label_102_11 = new Label();
            this.textBox_102_11 = new TextBox();
            this.label_102_5 = new Label();
            this.textBox_102_5 = new TextBox();
            this.label_102_6 = new Label();
            this.textBox_102_6 = new TextBox();
            this.label_102_7 = new Label();
            this.textBox_102_7 = new TextBox();
            this.label_102_8 = new Label();
            this.textBox_102_8 = new TextBox();
            this.label_102_9 = new Label();
            this.textBox_102_9 = new TextBox();

            this.groupBox_12 = new GroupBox();
            this.label_103_10 = new Label();
            this.comboBox_103_10 = new ComboBox();
            this.label_103_0 = new Label();
            this.textBox_103_0 = new TextBox();
            this.label_103_1 = new Label();
            this.textBox_103_1 = new TextBox();
            this.label_103_2 = new Label();
            this.textBox_103_2 = new TextBox();
            this.label_103_3 = new Label();
            this.textBox_103_3 = new TextBox();
            this.label_103_4 = new Label();
            this.textBox_103_4 = new TextBox();
            this.label_103_11 = new Label();
            this.textBox_103_11 = new TextBox();
            this.label_103_5 = new Label();
            this.textBox_103_5 = new TextBox();
            this.label_103_6 = new Label();
            this.textBox_103_6 = new TextBox();
            this.label_103_7 = new Label();
            this.textBox_103_7 = new TextBox();
            this.label_103_8 = new Label();
            this.textBox_103_8 = new TextBox();
            this.label_103_9 = new Label();
            this.textBox_103_9 = new TextBox();

            this.groupBox_13 = new GroupBox();
            this.label_104_0 = new Label();
            this.textBox_104_0 = new TextBox();
            this.label_104_1 = new Label();
            this.textBox_104_1 = new TextBox();
            this.label_104_2 = new Label();
            this.textBox_104_2 = new TextBox();
            this.label_104_3 = new Label();
            this.textBox_104_3 = new TextBox();
            this.label_104_4 = new Label();
            this.textBox_104_4 = new TextBox();
            #endregion
            #region panel + label + picture
            this.panel.Controls.Add(this.groupBox_13);
            this.panel.Controls.Add(this.space_12);
            this.panel.Controls.Add(this.groupBox_12);
            this.panel.Controls.Add(this.space_11);
            this.panel.Controls.Add(this.groupBox_11);
            this.panel.Controls.Add(this.space_10);
            this.panel.Controls.Add(this.groupBox_10);
            this.panel.Controls.Add(this.space_9);
            this.panel.Controls.Add(this.groupBox_9);
            this.panel.Controls.Add(this.space_8);
            this.panel.Controls.Add(this.groupBox_8);
            this.panel.Controls.Add(this.space_7);
            this.panel.Controls.Add(this.groupBox_7);
            this.panel.Controls.Add(this.space_6);
            this.panel.Controls.Add(this.groupBox_6);
            this.panel.Controls.Add(this.space_5);
            this.panel.Controls.Add(this.groupBox_5);
            this.panel.Controls.Add(this.space_4);
            this.panel.Controls.Add(this.groupBox_4);
            this.panel.Controls.Add(this.space_3);
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
            this.groupBox_0.Controls.Add(this.label_91_10);
            this.groupBox_0.Controls.Add(this.comboBox_91_10);
            this.groupBox_0.Controls.Add(this.label_91_0);
            this.groupBox_0.Controls.Add(this.textBox_91_0);
            this.groupBox_0.Controls.Add(this.label_91_1);
            this.groupBox_0.Controls.Add(this.textBox_91_1);
            this.groupBox_0.Controls.Add(this.label_91_2);
            this.groupBox_0.Controls.Add(this.textBox_91_2);
            this.groupBox_0.Controls.Add(this.label_91_3);
            this.groupBox_0.Controls.Add(this.textBox_91_3);
            this.groupBox_0.Controls.Add(this.label_91_4);
            this.groupBox_0.Controls.Add(this.textBox_91_4);
            this.groupBox_0.Controls.Add(this.label_91_11);
            this.groupBox_0.Controls.Add(this.textBox_91_11);
            this.groupBox_0.Controls.Add(this.label_91_5);
            this.groupBox_0.Controls.Add(this.textBox_91_5);
            this.groupBox_0.Controls.Add(this.label_91_6);
            this.groupBox_0.Controls.Add(this.textBox_91_6);
            this.groupBox_0.Controls.Add(this.label_91_7);
            this.groupBox_0.Controls.Add(this.textBox_91_7);
            this.groupBox_0.Controls.Add(this.label_91_8);
            this.groupBox_0.Controls.Add(this.textBox_91_8);
            this.groupBox_0.Controls.Add(this.label_91_9);
            this.groupBox_0.Controls.Add(this.textBox_91_9);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.Text = "Construção";
            this.groupBox_0.Name = "groupBox_0";
            this.groupBox_0.Size = new Size(300, 285);

            this.label_91_0.Name = "label_91_0";
            this.label_91_0.Text = "- Responsável:";
            this.textBox_91_0.Name = "textBox_91_0";
            MyEvents.TextBoxEvents(textBox_91_0);

            this.label_91_1.Name = "label_91_1";
            this.label_91_1.Text = "- Telefone:";
            this.textBox_91_1.Name = "textBox_91_1";
            MyEvents.TextBoxEvents(textBox_91_1);

            this.label_91_2.Name = "label_91_2";
            this.label_91_2.Text = "- e-mail:";
            this.textBox_91_2.Name = "textBox_91_2";
            MyEvents.TextBoxEvents(textBox_91_2);

            this.label_91_3.Name = "label_91_3";
            this.label_91_3.Text = "- Observações:";
            this.textBox_91_3.Name = "textBox_91_3";
            MyEvents.TextBoxEvents(textBox_91_3);

            this.label_91_4.Name = "label_91_4";
            this.label_91_4.Text = "- Endereço:";
            this.textBox_91_4.Name = "textBox_91_4";
            MyEvents.TextBoxEvents(textBox_91_4);

            this.label_91_5.Name = "label_91_5";
            this.label_91_5.Text = "- Empresa A:";
            this.textBox_91_5.Name = "textBox_91_5";
            MyEvents.TextBoxEvents(textBox_91_5, comboBox_91_10);

            this.label_91_6.Name = "label_91_6";
            this.label_91_6.Text = "- Empresa B:";
            this.textBox_91_6.Name = "textBox_91_6";
            MyEvents.TextBoxEvents(textBox_91_6, comboBox_91_10);

            this.label_91_7.Name = "label_91_7";
            this.label_91_7.Text = "- Empresa C:";
            this.textBox_91_7.Name = "textBox_91_7";
            MyEvents.TextBoxEvents(textBox_91_7, comboBox_91_10);

            this.label_91_8.Name = "label_91_8";
            this.label_91_8.Text = "- Empresa D:";
            this.textBox_91_8.Name = "textBox_91_8";
            MyEvents.TextBoxEvents(textBox_91_8, comboBox_91_10);

            this.label_91_9.Name = "label_91_9";
            this.label_91_9.Text = "- Empresa E:";
            this.textBox_91_9.Name = "textBox_91_9";
            MyEvents.TextBoxEvents(textBox_91_9, comboBox_91_10);

            this.label_91_10.Name = "label_91_10";
            this.label_91_10.Text = "Contratada:";
            this.comboBox_91_10.Name = "comboBox_91_10";
            this.comboBox_91_10.Location = new Point(90, 18);
            this.comboBox_91_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_91_10);
            this.comboBox_91_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 91, 10);
            };
            this.label_91_11.Name = "label_91_11";
            this.label_91_11.Text = "Orçamentos:";
            this.textBox_91_11.Name = "textBox_91_10";
            this.textBox_91_11.Hide();
            #endregion
            #region groupBox_1
            this.groupBox_1.Controls.Add(this.label_92_10);
            this.groupBox_1.Controls.Add(this.comboBox_92_10);
            this.groupBox_1.Controls.Add(this.label_92_0);
            this.groupBox_1.Controls.Add(this.textBox_92_0);
            this.groupBox_1.Controls.Add(this.label_92_1);
            this.groupBox_1.Controls.Add(this.textBox_92_1);
            this.groupBox_1.Controls.Add(this.label_92_2);
            this.groupBox_1.Controls.Add(this.textBox_92_2);
            this.groupBox_1.Controls.Add(this.label_92_3);
            this.groupBox_1.Controls.Add(this.textBox_92_3);
            this.groupBox_1.Controls.Add(this.label_92_4);
            this.groupBox_1.Controls.Add(this.textBox_92_4);
            this.groupBox_1.Controls.Add(this.label_92_11);
            this.groupBox_1.Controls.Add(this.textBox_92_11);
            this.groupBox_1.Controls.Add(this.label_92_5);
            this.groupBox_1.Controls.Add(this.textBox_92_5);
            this.groupBox_1.Controls.Add(this.label_92_6);
            this.groupBox_1.Controls.Add(this.textBox_92_6);
            this.groupBox_1.Controls.Add(this.label_92_7);
            this.groupBox_1.Controls.Add(this.textBox_92_7);
            this.groupBox_1.Controls.Add(this.label_92_8);
            this.groupBox_1.Controls.Add(this.textBox_92_8);
            this.groupBox_1.Controls.Add(this.label_92_9);
            this.groupBox_1.Controls.Add(this.textBox_92_9);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.Text = "Estrutura";
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new Size(300, 285);

            this.label_92_0.Name = "label_92_0";
            this.label_92_0.Text = "- Responsável:";
            this.textBox_92_0.Name = "textBox_92_0";
            MyEvents.TextBoxEvents(textBox_92_0);

            this.label_92_1.Name = "label_92_1";
            this.label_92_1.Text = "- Telefone:";
            this.textBox_92_1.Name = "textBox_92_1";
            MyEvents.TextBoxEvents(textBox_92_1);

            this.label_92_2.Name = "label_92_2";
            this.label_92_2.Text = "- e-mail:";
            this.textBox_92_2.Name = "textBox_92_2";
            MyEvents.TextBoxEvents(textBox_92_2);

            this.label_92_3.Name = "label_92_3";
            this.label_92_3.Text = "- Observações:";
            this.textBox_92_3.Name = "textBox_92_3";
            MyEvents.TextBoxEvents(textBox_92_3);

            this.label_92_4.Name = "label_92_4";
            this.label_92_4.Text = "- Endereço:";
            this.textBox_92_4.Name = "textBox_92_4";
            MyEvents.TextBoxEvents(textBox_92_4);

            this.label_92_5.Name = "label_92_5";
            this.label_92_5.Text = "- Empresa A:";
            this.textBox_92_5.Name = "textBox_92_5";
            MyEvents.TextBoxEvents(textBox_92_5, comboBox_92_10);

            this.label_92_6.Name = "label_92_6";
            this.label_92_6.Text = "- Empresa B:";
            this.textBox_92_6.Name = "textBox_92_6";
            MyEvents.TextBoxEvents(textBox_92_6, comboBox_92_10);

            this.label_92_7.Name = "label_92_7";
            this.label_92_7.Text = "- Empresa C:";
            this.textBox_92_7.Name = "textBox_92_7";
            MyEvents.TextBoxEvents(textBox_92_7, comboBox_92_10);

            this.label_92_8.Name = "label_92_8";
            this.label_92_8.Text = "- Empresa D:";
            this.textBox_92_8.Name = "textBox_92_8";
            MyEvents.TextBoxEvents(textBox_92_8, comboBox_92_10);

            this.label_92_9.Name = "label_92_9";
            this.label_92_9.Text = "- Empresa E:";
            this.textBox_92_9.Name = "textBox_92_9";
            MyEvents.TextBoxEvents(textBox_92_9, comboBox_92_10);

            this.label_92_10.Name = "label_92_10";
            this.label_92_10.Text = "Contratada:";
            this.comboBox_92_10.Name = "comboBox_92_10";
            this.comboBox_92_10.Location = new Point(90, 18);
            this.comboBox_92_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_92_10);
            this.comboBox_92_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 92, 10);
            };
            this.label_92_11.Name = "label_92_11";
            this.label_92_11.Text = "Orçamentos:";
            this.textBox_92_11.Name = "textBox_92_10";
            this.textBox_92_11.Hide();
            #endregion
            #region groupBox_2
            this.groupBox_2.Controls.Add(this.label_93_10);
            this.groupBox_2.Controls.Add(this.comboBox_93_10);
            this.groupBox_2.Controls.Add(this.label_93_0);
            this.groupBox_2.Controls.Add(this.textBox_93_0);
            this.groupBox_2.Controls.Add(this.label_93_1);
            this.groupBox_2.Controls.Add(this.textBox_93_1);
            this.groupBox_2.Controls.Add(this.label_93_2);
            this.groupBox_2.Controls.Add(this.textBox_93_2);
            this.groupBox_2.Controls.Add(this.label_93_3);
            this.groupBox_2.Controls.Add(this.textBox_93_3);
            this.groupBox_2.Controls.Add(this.label_93_4);
            this.groupBox_2.Controls.Add(this.textBox_93_4);
            this.groupBox_2.Controls.Add(this.label_93_11);
            this.groupBox_2.Controls.Add(this.textBox_93_11);
            this.groupBox_2.Controls.Add(this.label_93_5);
            this.groupBox_2.Controls.Add(this.textBox_93_5);
            this.groupBox_2.Controls.Add(this.label_93_6);
            this.groupBox_2.Controls.Add(this.textBox_93_6);
            this.groupBox_2.Controls.Add(this.label_93_7);
            this.groupBox_2.Controls.Add(this.textBox_93_7);
            this.groupBox_2.Controls.Add(this.label_93_8);
            this.groupBox_2.Controls.Add(this.textBox_93_8);
            this.groupBox_2.Controls.Add(this.label_93_9);
            this.groupBox_2.Controls.Add(this.textBox_93_9);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.Text = "Hidrosanitário";
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new Size(300, 285);

            this.label_93_0.Name = "label_93_0";
            this.label_93_0.Text = "- Responsável:";
            this.textBox_93_0.Name = "textBox_93_0";
            MyEvents.TextBoxEvents(textBox_93_0);

            this.label_93_1.Name = "label_93_1";
            this.label_93_1.Text = "- Telefone:";
            this.textBox_93_1.Name = "textBox_93_1";
            MyEvents.TextBoxEvents(textBox_93_1);

            this.label_93_2.Name = "label_93_2";
            this.label_93_2.Text = "- e-mail:";
            this.textBox_93_2.Name = "textBox_93_2";
            MyEvents.TextBoxEvents(textBox_93_2);

            this.label_93_3.Name = "label_93_3";
            this.label_93_3.Text = "- Observações:";
            this.textBox_93_3.Name = "textBox_93_3";
            MyEvents.TextBoxEvents(textBox_93_3);

            this.label_93_4.Name = "label_93_4";
            this.label_93_4.Text = "- Endereço:";
            this.textBox_93_4.Name = "textBox_93_4";
            MyEvents.TextBoxEvents(textBox_93_4);

            this.label_93_5.Name = "label_93_5";
            this.label_93_5.Text = "- Empresa A:";
            this.textBox_93_5.Name = "textBox_93_5";
            MyEvents.TextBoxEvents(textBox_93_5, comboBox_93_10);

            this.label_93_6.Name = "label_93_6";
            this.label_93_6.Text = "- Empresa B:";
            this.textBox_93_6.Name = "textBox_93_6";
            MyEvents.TextBoxEvents(textBox_93_6, comboBox_93_10);

            this.label_93_7.Name = "label_93_7";
            this.label_93_7.Text = "- Empresa C:";
            this.textBox_93_7.Name = "textBox_93_7";
            MyEvents.TextBoxEvents(textBox_93_7, comboBox_93_10);

            this.label_93_8.Name = "label_93_8";
            this.label_93_8.Text = "- Empresa D:";
            this.textBox_93_8.Name = "textBox_93_8";
            MyEvents.TextBoxEvents(textBox_93_8, comboBox_93_10);

            this.label_93_9.Name = "label_93_9";
            this.label_93_9.Text = "- Empresa E:";
            this.textBox_93_9.Name = "textBox_93_9";
            MyEvents.TextBoxEvents(textBox_93_9, comboBox_93_10);

            this.label_93_10.Name = "label_93_10";
            this.label_93_10.Text = "Contratada:";
            this.comboBox_93_10.Name = "comboBox_93_10";
            this.comboBox_93_10.Location = new Point(90, 18);
            this.comboBox_93_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_93_10);
            this.comboBox_93_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 93, 10);
            };
            this.label_93_11.Name = "label_93_11";
            this.label_93_11.Text = "Orçamentos:";
            this.textBox_93_11.Name = "textBox_93_10";
            this.textBox_93_11.Hide();
            #endregion
            #region groupBox_3
            this.groupBox_3.Controls.Add(this.label_94_10);
            this.groupBox_3.Controls.Add(this.comboBox_94_10);
            this.groupBox_3.Controls.Add(this.label_94_0);
            this.groupBox_3.Controls.Add(this.textBox_94_0);
            this.groupBox_3.Controls.Add(this.label_94_1);
            this.groupBox_3.Controls.Add(this.textBox_94_1);
            this.groupBox_3.Controls.Add(this.label_94_2);
            this.groupBox_3.Controls.Add(this.textBox_94_2);
            this.groupBox_3.Controls.Add(this.label_94_3);
            this.groupBox_3.Controls.Add(this.textBox_94_3);
            this.groupBox_3.Controls.Add(this.label_94_4);
            this.groupBox_3.Controls.Add(this.textBox_94_4);
            this.groupBox_3.Controls.Add(this.label_94_11);
            this.groupBox_3.Controls.Add(this.textBox_94_11);
            this.groupBox_3.Controls.Add(this.label_94_5);
            this.groupBox_3.Controls.Add(this.textBox_94_5);
            this.groupBox_3.Controls.Add(this.label_94_6);
            this.groupBox_3.Controls.Add(this.textBox_94_6);
            this.groupBox_3.Controls.Add(this.label_94_7);
            this.groupBox_3.Controls.Add(this.textBox_94_7);
            this.groupBox_3.Controls.Add(this.label_94_8);
            this.groupBox_3.Controls.Add(this.textBox_94_8);
            this.groupBox_3.Controls.Add(this.label_94_9);
            this.groupBox_3.Controls.Add(this.textBox_94_9);
            this.groupBox_3.TabIndex = 3;
            this.groupBox_3.Text = "Elétrico";
            this.groupBox_3.Name = "groupBox_3";
            this.groupBox_3.Size = new Size(300, 285);

            this.label_94_0.Name = "label_94_0";
            this.label_94_0.Text = "- Responsável:";
            this.textBox_94_0.Name = "textBox_94_0";
            MyEvents.TextBoxEvents(textBox_94_0);

            this.label_94_1.Name = "label_94_1";
            this.label_94_1.Text = "- Telefone:";
            this.textBox_94_1.Name = "textBox_94_1";
            MyEvents.TextBoxEvents(textBox_94_1);

            this.label_94_2.Name = "label_94_2";
            this.label_94_2.Text = "- e-mail:";
            this.textBox_94_2.Name = "textBox_94_2";
            MyEvents.TextBoxEvents(textBox_94_2);

            this.label_94_3.Name = "label_94_3";
            this.label_94_3.Text = "- Observações:";
            this.textBox_94_3.Name = "textBox_94_3";
            MyEvents.TextBoxEvents(textBox_94_3);

            this.label_94_4.Name = "label_94_4";
            this.label_94_4.Text = "- Endereço:";
            this.textBox_94_4.Name = "textBox_94_4";
            MyEvents.TextBoxEvents(textBox_94_4);

            this.label_94_5.Name = "label_94_5";
            this.label_94_5.Text = "- Empresa A:";
            this.textBox_94_5.Name = "textBox_94_5";
            MyEvents.TextBoxEvents(textBox_94_5, comboBox_94_10);

            this.label_94_6.Name = "label_94_6";
            this.label_94_6.Text = "- Empresa B:";
            this.textBox_94_6.Name = "textBox_94_6";
            MyEvents.TextBoxEvents(textBox_94_6, comboBox_94_10);

            this.label_94_7.Name = "label_94_7";
            this.label_94_7.Text = "- Empresa C:";
            this.textBox_94_7.Name = "textBox_94_7";
            MyEvents.TextBoxEvents(textBox_94_7, comboBox_94_10);

            this.label_94_8.Name = "label_94_8";
            this.label_94_8.Text = "- Empresa D:";
            this.textBox_94_8.Name = "textBox_94_8";
            MyEvents.TextBoxEvents(textBox_94_8, comboBox_94_10);

            this.label_94_9.Name = "label_94_9";
            this.label_94_9.Text = "- Empresa E:";
            this.textBox_94_9.Name = "textBox_94_9";
            MyEvents.TextBoxEvents(textBox_94_9, comboBox_94_10);

            this.label_94_10.Name = "label_94_10";
            this.label_94_10.Text = "Contratada:";
            this.comboBox_94_10.Name = "comboBox_94_10";
            this.comboBox_94_10.Location = new Point(90, 18);
            this.comboBox_94_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_94_10);
            this.comboBox_94_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 94, 10);
            };
            this.label_94_11.Name = "label_94_11";
            this.label_94_11.Text = "Orçamentos:";
            this.textBox_94_11.Name = "textBox_94_0";
            this.textBox_94_11.Hide();
            #endregion
            #region groupBox_4
            this.groupBox_4.Controls.Add(this.label_95_10);
            this.groupBox_4.Controls.Add(this.comboBox_95_10);
            this.groupBox_4.Controls.Add(this.label_95_0);
            this.groupBox_4.Controls.Add(this.textBox_95_0);
            this.groupBox_4.Controls.Add(this.label_95_1);
            this.groupBox_4.Controls.Add(this.textBox_95_1);
            this.groupBox_4.Controls.Add(this.label_95_2);
            this.groupBox_4.Controls.Add(this.textBox_95_2);
            this.groupBox_4.Controls.Add(this.label_95_3);
            this.groupBox_4.Controls.Add(this.textBox_95_3);
            this.groupBox_4.Controls.Add(this.label_95_4);
            this.groupBox_4.Controls.Add(this.textBox_95_4);
            this.groupBox_4.Controls.Add(this.label_95_11);
            this.groupBox_4.Controls.Add(this.textBox_95_11);
            this.groupBox_4.Controls.Add(this.label_95_5);
            this.groupBox_4.Controls.Add(this.textBox_95_5);
            this.groupBox_4.Controls.Add(this.label_95_6);
            this.groupBox_4.Controls.Add(this.textBox_95_6);
            this.groupBox_4.Controls.Add(this.label_95_7);
            this.groupBox_4.Controls.Add(this.textBox_95_7);
            this.groupBox_4.Controls.Add(this.label_95_8);
            this.groupBox_4.Controls.Add(this.textBox_95_8);
            this.groupBox_4.Controls.Add(this.label_95_9);
            this.groupBox_4.Controls.Add(this.textBox_95_9);
            this.groupBox_4.TabIndex = 4;
            this.groupBox_4.Text = "Luminotécnico";
            this.groupBox_4.Name = "groupBox_4";
            this.groupBox_4.Size = new Size(300, 285);

            this.label_95_0.Name = "label_95_0";
            this.label_95_0.Text = "- Responsável:";
            this.textBox_95_0.Name = "textBox_95_0";
            MyEvents.TextBoxEvents(textBox_95_0);

            this.label_95_1.Name = "label_95_1";
            this.label_95_1.Text = "- Telefone:";
            this.textBox_95_1.Name = "textBox_95_1";
            MyEvents.TextBoxEvents(textBox_95_1);

            this.label_95_2.Name = "label_95_2";
            this.label_95_2.Text = "- e-mail:";
            this.textBox_95_2.Name = "textBox_95_2";
            MyEvents.TextBoxEvents(textBox_95_2);

            this.label_95_3.Name = "label_95_3";
            this.label_95_3.Text = "- Observações:";
            this.textBox_95_3.Name = "textBox_95_3";
            MyEvents.TextBoxEvents(textBox_95_3);

            this.label_95_4.Name = "label_95_4";
            this.label_95_4.Text = "- Endereço:";
            this.textBox_95_4.Name = "textBox_95_4";
            MyEvents.TextBoxEvents(textBox_95_4);

            this.label_95_5.Name = "label_95_5";
            this.label_95_5.Text = "- Empresa A:";
            this.textBox_95_5.Name = "textBox_95_5";
            MyEvents.TextBoxEvents(textBox_95_5, comboBox_95_10);

            this.label_95_6.Name = "label_95_6";
            this.label_95_6.Text = "- Empresa B:";
            this.textBox_95_6.Name = "textBox_95_6";
            MyEvents.TextBoxEvents(textBox_95_6, comboBox_95_10);

            this.label_95_7.Name = "label_95_7";
            this.label_95_7.Text = "- Empresa C:";
            this.textBox_95_7.Name = "textBox_95_7";
            MyEvents.TextBoxEvents(textBox_95_7, comboBox_95_10);

            this.label_95_8.Name = "label_95_8";
            this.label_95_8.Text = "- Empresa D:";
            this.textBox_95_8.Name = "textBox_95_8";
            MyEvents.TextBoxEvents(textBox_95_8, comboBox_95_10);

            this.label_95_9.Name = "label_95_9";
            this.label_95_9.Text = "- Empresa E:";
            this.textBox_95_9.Name = "textBox_95_9";
            MyEvents.TextBoxEvents(textBox_95_9, comboBox_95_10);

            this.label_95_10.Name = "label_95_10";
            this.label_95_10.Text = "Contratada:";
            this.comboBox_95_10.Name = "comboBox_95_10";
            this.comboBox_95_10.Location = new Point(90, 18);
            this.comboBox_95_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_95_10);
            this.comboBox_95_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 95, 10);
            };
            this.label_95_11.Name = "label_95_11";
            this.label_95_11.Text = "Orçamentos:";
            this.textBox_95_11.Name = "textBox_95_0";
            this.textBox_95_11.Hide();
            #endregion
            #region groupBox_5
            this.groupBox_5.Controls.Add(this.label_96_10);
            this.groupBox_5.Controls.Add(this.comboBox_96_10);
            this.groupBox_5.Controls.Add(this.label_96_0);
            this.groupBox_5.Controls.Add(this.textBox_96_0);
            this.groupBox_5.Controls.Add(this.label_96_1);
            this.groupBox_5.Controls.Add(this.textBox_96_1);
            this.groupBox_5.Controls.Add(this.label_96_2);
            this.groupBox_5.Controls.Add(this.textBox_96_2);
            this.groupBox_5.Controls.Add(this.label_96_3);
            this.groupBox_5.Controls.Add(this.textBox_96_3);
            this.groupBox_5.Controls.Add(this.label_96_4);
            this.groupBox_5.Controls.Add(this.textBox_96_4);
            this.groupBox_5.Controls.Add(this.label_96_11);
            this.groupBox_5.Controls.Add(this.textBox_96_11);
            this.groupBox_5.Controls.Add(this.label_96_5);
            this.groupBox_5.Controls.Add(this.textBox_96_5);
            this.groupBox_5.Controls.Add(this.label_96_6);
            this.groupBox_5.Controls.Add(this.textBox_96_6);
            this.groupBox_5.Controls.Add(this.label_96_7);
            this.groupBox_5.Controls.Add(this.textBox_96_7);
            this.groupBox_5.Controls.Add(this.label_96_8);
            this.groupBox_5.Controls.Add(this.textBox_96_8);
            this.groupBox_5.Controls.Add(this.label_96_9);
            this.groupBox_5.Controls.Add(this.textBox_96_9);
            this.groupBox_5.TabIndex = 5;
            this.groupBox_5.Text = "Automação";
            this.groupBox_5.Name = "groupBox_5";
            this.groupBox_5.Size = new Size(300, 285);

            this.label_96_0.Name = "label_96_0";
            this.label_96_0.Text = "- Responsável:";
            this.textBox_96_0.Name = "textBox_96_0";
            MyEvents.TextBoxEvents(textBox_96_0);

            this.label_96_1.Name = "label_96_1";
            this.label_96_1.Text = "- Telefone:";
            this.textBox_96_1.Name = "textBox_96_1";
            MyEvents.TextBoxEvents(textBox_96_1);

            this.label_96_2.Name = "label_96_2";
            this.label_96_2.Text = "- e-mail:";
            this.textBox_96_2.Name = "textBox_96_2";
            MyEvents.TextBoxEvents(textBox_96_2);

            this.label_96_3.Name = "label_96_3";
            this.label_96_3.Text = "- Observações:";
            this.textBox_96_3.Name = "textBox_96_3";
            MyEvents.TextBoxEvents(textBox_96_3);

            this.label_96_4.Name = "label_96_4";
            this.label_96_4.Text = "- Endereço:";
            this.textBox_96_4.Name = "textBox_96_4";
            MyEvents.TextBoxEvents(textBox_96_4);

            this.label_96_5.Name = "label_96_5";
            this.label_96_5.Text = "- Empresa A:";
            this.textBox_96_5.Name = "textBox_96_5";
            MyEvents.TextBoxEvents(textBox_96_5, comboBox_96_10);

            this.label_96_6.Name = "label_96_6";
            this.label_96_6.Text = "- Empresa B:";
            this.textBox_96_6.Name = "textBox_96_6";
            MyEvents.TextBoxEvents(textBox_96_6, comboBox_96_10);

            this.label_96_7.Name = "label_96_7";
            this.label_96_7.Text = "- Empresa C:";
            this.textBox_96_7.Name = "textBox_96_7";
            MyEvents.TextBoxEvents(textBox_96_7, comboBox_96_10);

            this.label_96_8.Name = "label_96_8";
            this.label_96_8.Text = "- Empresa D:";
            this.textBox_96_8.Name = "textBox_96_8";
            MyEvents.TextBoxEvents(textBox_96_8, comboBox_96_10);

            this.label_96_9.Name = "label_96_9";
            this.label_96_9.Text = "- Empresa E:";
            this.textBox_96_9.Name = "textBox_96_9";
            MyEvents.TextBoxEvents(textBox_96_9, comboBox_96_10);

            this.label_96_10.Name = "label_96_10";
            this.label_96_10.Text = "Contratada:";
            this.comboBox_96_10.Name = "comboBox_96_10";
            this.comboBox_96_10.Location = new Point(90, 18);
            this.comboBox_96_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_96_10);
            this.comboBox_96_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 96, 10);
            };
            this.label_96_11.Name = "label_96_11";
            this.label_96_11.Text = "Orçamentos:";
            this.textBox_96_11.Name = "textBox_96_0";
            this.textBox_96_11.Hide();
            #endregion
            #region groupBox_6
            this.groupBox_6.Controls.Add(this.label_97_10);
            this.groupBox_6.Controls.Add(this.comboBox_97_10);
            this.groupBox_6.Controls.Add(this.label_97_0);
            this.groupBox_6.Controls.Add(this.textBox_97_0);
            this.groupBox_6.Controls.Add(this.label_97_1);
            this.groupBox_6.Controls.Add(this.textBox_97_1);
            this.groupBox_6.Controls.Add(this.label_97_2);
            this.groupBox_6.Controls.Add(this.textBox_97_2);
            this.groupBox_6.Controls.Add(this.label_97_3);
            this.groupBox_6.Controls.Add(this.textBox_97_3);
            this.groupBox_6.Controls.Add(this.label_97_4);
            this.groupBox_6.Controls.Add(this.textBox_97_4);
            this.groupBox_6.Controls.Add(this.label_97_11);
            this.groupBox_6.Controls.Add(this.textBox_97_11);
            this.groupBox_6.Controls.Add(this.label_97_5);
            this.groupBox_6.Controls.Add(this.textBox_97_5);
            this.groupBox_6.Controls.Add(this.label_97_6);
            this.groupBox_6.Controls.Add(this.textBox_97_6);
            this.groupBox_6.Controls.Add(this.label_97_7);
            this.groupBox_6.Controls.Add(this.textBox_97_7);
            this.groupBox_6.Controls.Add(this.label_97_8);
            this.groupBox_6.Controls.Add(this.textBox_97_8);
            this.groupBox_6.Controls.Add(this.label_97_9);
            this.groupBox_6.Controls.Add(this.textBox_97_9);
            this.groupBox_6.TabIndex = 6;
            this.groupBox_6.Text = "Esquadrias";
            this.groupBox_6.Name = "groupBox_6";
            this.groupBox_6.Size = new Size(300, 285);

            this.label_97_0.Name = "label_97_0";
            this.label_97_0.Text = "- Responsável:";
            this.textBox_97_0.Name = "textBox_97_0";
            MyEvents.TextBoxEvents(textBox_97_0);

            this.label_97_1.Name = "label_97_1";
            this.label_97_1.Text = "- Telefone:";
            this.textBox_97_1.Name = "textBox_97_1";
            MyEvents.TextBoxEvents(textBox_97_1);

            this.label_97_2.Name = "label_97_2";
            this.label_97_2.Text = "- e-mail:";
            this.textBox_97_2.Name = "textBox_97_2";
            MyEvents.TextBoxEvents(textBox_97_2);

            this.label_97_3.Name = "label_97_3";
            this.label_97_3.Text = "- Observações:";
            this.textBox_97_3.Name = "textBox_97_3";
            MyEvents.TextBoxEvents(textBox_97_3);

            this.label_97_4.Name = "label_97_4";
            this.label_97_4.Text = "- Endereço:";
            this.textBox_97_4.Name = "textBox_97_4";
            MyEvents.TextBoxEvents(textBox_97_4);

            this.label_97_5.Name = "label_97_5";
            this.label_97_5.Text = "- Empresa A:";
            this.textBox_97_5.Name = "textBox_97_5";
            MyEvents.TextBoxEvents(textBox_97_5, comboBox_97_10);

            this.label_97_6.Name = "label_97_6";
            this.label_97_6.Text = "- Empresa B:";
            this.textBox_97_6.Name = "textBox_97_6";
            MyEvents.TextBoxEvents(textBox_97_6, comboBox_97_10);

            this.label_97_7.Name = "label_97_7";
            this.label_97_7.Text = "- Empresa C:";
            this.textBox_97_7.Name = "textBox_97_7";
            MyEvents.TextBoxEvents(textBox_97_7, comboBox_97_10);

            this.label_97_8.Name = "label_97_8";
            this.label_97_8.Text = "- Empresa D:";
            this.textBox_97_8.Name = "textBox_97_8";
            MyEvents.TextBoxEvents(textBox_97_8, comboBox_97_10);

            this.label_97_9.Name = "label_97_9";
            this.label_97_9.Text = "- Empresa E:";
            this.textBox_97_9.Name = "textBox_97_9";
            MyEvents.TextBoxEvents(textBox_97_9, comboBox_97_10);

            this.label_97_10.Name = "label_97_10";
            this.label_97_10.Text = "Contratada:";
            this.comboBox_97_10.Name = "comboBox_97_10";
            this.comboBox_97_10.Location = new Point(90, 18);
            this.comboBox_97_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_97_10);
            this.comboBox_97_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 97, 10);
            };
            this.label_97_11.Name = "label_97_11";
            this.label_97_11.Text = "Orçamentos:";
            this.textBox_97_11.Name = "textBox_97_0";
            this.textBox_97_11.Hide();
            #endregion
            #region groupBox_7
            this.groupBox_7.Controls.Add(this.label_98_10);
            this.groupBox_7.Controls.Add(this.comboBox_98_10);
            this.groupBox_7.Controls.Add(this.label_98_0);
            this.groupBox_7.Controls.Add(this.textBox_98_0);
            this.groupBox_7.Controls.Add(this.label_98_1);
            this.groupBox_7.Controls.Add(this.textBox_98_1);
            this.groupBox_7.Controls.Add(this.label_98_2);
            this.groupBox_7.Controls.Add(this.textBox_98_2);
            this.groupBox_7.Controls.Add(this.label_98_3);
            this.groupBox_7.Controls.Add(this.textBox_98_3);
            this.groupBox_7.Controls.Add(this.label_98_4);
            this.groupBox_7.Controls.Add(this.textBox_98_4);
            this.groupBox_7.Controls.Add(this.label_98_11);
            this.groupBox_7.Controls.Add(this.textBox_98_11);
            this.groupBox_7.Controls.Add(this.label_98_5);
            this.groupBox_7.Controls.Add(this.textBox_98_5);
            this.groupBox_7.Controls.Add(this.label_98_6);
            this.groupBox_7.Controls.Add(this.textBox_98_6);
            this.groupBox_7.Controls.Add(this.label_98_7);
            this.groupBox_7.Controls.Add(this.textBox_98_7);
            this.groupBox_7.Controls.Add(this.label_98_8);
            this.groupBox_7.Controls.Add(this.textBox_98_8);
            this.groupBox_7.Controls.Add(this.label_98_9);
            this.groupBox_7.Controls.Add(this.textBox_98_9);
            this.groupBox_7.TabIndex = 7;
            this.groupBox_7.Text = "Cozinha/Armários";
            this.groupBox_7.Name = "groupBox_7";
            this.groupBox_7.Size = new Size(300, 285);

            this.label_98_0.Name = "label_98_0";
            this.label_98_0.Text = "- Responsável:";
            this.textBox_98_0.Name = "textBox_98_0";
            MyEvents.TextBoxEvents(textBox_98_0);

            this.label_98_1.Name = "label_98_1";
            this.label_98_1.Text = "- Telefone:";
            this.textBox_98_1.Name = "textBox_98_1";
            MyEvents.TextBoxEvents(textBox_98_1);

            this.label_98_2.Name = "label_98_2";
            this.label_98_2.Text = "- e-mail:";
            this.textBox_98_2.Name = "textBox_98_2";
            MyEvents.TextBoxEvents(textBox_98_2);

            this.label_98_3.Name = "label_98_3";
            this.label_98_3.Text = "- Observações:";
            this.textBox_98_3.Name = "textBox_98_3";
            MyEvents.TextBoxEvents(textBox_98_3);

            this.label_98_4.Name = "label_98_4";
            this.label_98_4.Text = "- Endereço:";
            this.textBox_98_4.Name = "textBox_98_4";
            MyEvents.TextBoxEvents(textBox_98_4);

            this.label_98_5.Name = "label_98_5";
            this.label_98_5.Text = "- Empresa A:";
            this.textBox_98_5.Name = "textBox_98_5";
            MyEvents.TextBoxEvents(textBox_98_5, comboBox_98_10);

            this.label_98_6.Name = "label_98_6";
            this.label_98_6.Text = "- Empresa B:";
            this.textBox_98_6.Name = "textBox_98_6";
            MyEvents.TextBoxEvents(textBox_98_6, comboBox_98_10);

            this.label_98_7.Name = "label_98_7";
            this.label_98_7.Text = "- Empresa C:";
            this.textBox_98_7.Name = "textBox_98_7";
            MyEvents.TextBoxEvents(textBox_98_7, comboBox_98_10);

            this.label_98_8.Name = "label_98_8";
            this.label_98_8.Text = "- Empresa D:";
            this.textBox_98_8.Name = "textBox_98_8";
            MyEvents.TextBoxEvents(textBox_98_8, comboBox_98_10);

            this.label_98_9.Name = "label_98_9";
            this.label_98_9.Text = "- Empresa E:";
            this.textBox_98_9.Name = "textBox_98_9";
            MyEvents.TextBoxEvents(textBox_98_9, comboBox_98_10);

            this.label_98_10.Name = "label_98_10";
            this.label_98_10.Text = "Contratada:";
            this.comboBox_98_10.Name = "comboBox_98_10";
            this.comboBox_98_10.Location = new Point(90, 18);
            this.comboBox_98_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_98_10);
            this.comboBox_98_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 98, 10);
            };
            this.label_98_11.Name = "label_98_11";
            this.label_98_11.Text = "Orçamentos:";
            this.textBox_98_11.Name = "textBox_98_0";
            this.textBox_98_11.Hide();
            #endregion
            #region groupBox_8
            this.groupBox_8.Controls.Add(this.label_99_10);
            this.groupBox_8.Controls.Add(this.comboBox_99_10);
            this.groupBox_8.Controls.Add(this.label_99_0);
            this.groupBox_8.Controls.Add(this.textBox_99_0);
            this.groupBox_8.Controls.Add(this.label_99_1);
            this.groupBox_8.Controls.Add(this.textBox_99_1);
            this.groupBox_8.Controls.Add(this.label_99_2);
            this.groupBox_8.Controls.Add(this.textBox_99_2);
            this.groupBox_8.Controls.Add(this.label_99_3);
            this.groupBox_8.Controls.Add(this.textBox_99_3);
            this.groupBox_8.Controls.Add(this.label_99_4);
            this.groupBox_8.Controls.Add(this.textBox_99_4);
            this.groupBox_8.Controls.Add(this.label_99_11);
            this.groupBox_8.Controls.Add(this.textBox_99_11);
            this.groupBox_8.Controls.Add(this.label_99_5);
            this.groupBox_8.Controls.Add(this.textBox_99_5);
            this.groupBox_8.Controls.Add(this.label_99_6);
            this.groupBox_8.Controls.Add(this.textBox_99_6);
            this.groupBox_8.Controls.Add(this.label_99_7);
            this.groupBox_8.Controls.Add(this.textBox_99_7);
            this.groupBox_8.Controls.Add(this.label_99_8);
            this.groupBox_8.Controls.Add(this.textBox_99_8);
            this.groupBox_8.Controls.Add(this.label_99_9);
            this.groupBox_8.Controls.Add(this.textBox_99_9);
            this.groupBox_8.TabIndex = 8;
            this.groupBox_8.Text = "Marcenaria";
            this.groupBox_8.Name = "groupBox_8";
            this.groupBox_8.Size = new Size(300, 285);

            this.label_99_0.Name = "label_99_0";
            this.label_99_0.Text = "- Responsável:";
            this.textBox_99_0.Name = "textBox_99_0";
            MyEvents.TextBoxEvents(textBox_99_0);

            this.label_99_1.Name = "label_99_1";
            this.label_99_1.Text = "- Telefone:";
            this.textBox_99_1.Name = "textBox_99_1";
            MyEvents.TextBoxEvents(textBox_99_1);

            this.label_99_2.Name = "label_99_2";
            this.label_99_2.Text = "- e-mail:";
            this.textBox_99_2.Name = "textBox_99_2";
            MyEvents.TextBoxEvents(textBox_99_2);

            this.label_99_3.Name = "label_99_3";
            this.label_99_3.Text = "- Observações:";
            this.textBox_99_3.Name = "textBox_99_3";
            MyEvents.TextBoxEvents(textBox_99_3);

            this.label_99_4.Name = "label_99_4";
            this.label_99_4.Text = "- Endereço:";
            this.textBox_99_4.Name = "textBox_99_4";
            MyEvents.TextBoxEvents(textBox_99_4);

            this.label_99_5.Name = "label_99_5";
            this.label_99_5.Text = "- Empresa A:";
            this.textBox_99_5.Name = "textBox_99_5";
            MyEvents.TextBoxEvents(textBox_99_5, comboBox_99_10);

            this.label_99_6.Name = "label_99_6";
            this.label_99_6.Text = "- Empresa B:";
            this.textBox_99_6.Name = "textBox_99_6";
            MyEvents.TextBoxEvents(textBox_99_6, comboBox_99_10);

            this.label_99_7.Name = "label_99_7";
            this.label_99_7.Text = "- Empresa C:";
            this.textBox_99_7.Name = "textBox_99_7";
            MyEvents.TextBoxEvents(textBox_99_7, comboBox_99_10);

            this.label_99_8.Name = "label_99_8";
            this.label_99_8.Text = "- Empresa D:";
            this.textBox_99_8.Name = "textBox_99_8";
            MyEvents.TextBoxEvents(textBox_99_8, comboBox_99_10);

            this.label_99_9.Name = "label_99_9";
            this.label_99_9.Text = "- Empresa E:";
            this.textBox_99_9.Name = "textBox_99_9";
            MyEvents.TextBoxEvents(textBox_99_9, comboBox_99_10);

            this.label_99_10.Name = "label_99_10";
            this.label_99_10.Text = "Contratada:";
            this.comboBox_99_10.Name = "comboBox_99_10";
            this.comboBox_99_10.Location = new Point(90, 18);
            this.comboBox_99_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_99_10);
            this.comboBox_99_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 99, 10);
            };
            this.label_99_11.Name = "label_99_11";
            this.label_99_11.Text = "Orçamentos:";
            this.textBox_99_11.Name = "textBox_99_0";
            this.textBox_99_11.Hide();
            #endregion
            #region  groupBox_9
            this.groupBox_9.Controls.Add(this.label_100_10);
            this.groupBox_9.Controls.Add(this.comboBox_100_10);
            this.groupBox_9.Controls.Add(this.label_100_0);
            this.groupBox_9.Controls.Add(this.textBox_100_0);
            this.groupBox_9.Controls.Add(this.label_100_1);
            this.groupBox_9.Controls.Add(this.textBox_100_1);
            this.groupBox_9.Controls.Add(this.label_100_2);
            this.groupBox_9.Controls.Add(this.textBox_100_2);
            this.groupBox_9.Controls.Add(this.label_100_3);
            this.groupBox_9.Controls.Add(this.textBox_100_3);
            this.groupBox_9.Controls.Add(this.label_100_4);
            this.groupBox_9.Controls.Add(this.textBox_100_4);
            this.groupBox_9.Controls.Add(this.label_100_11);
            this.groupBox_9.Controls.Add(this.textBox_100_11);
            this.groupBox_9.Controls.Add(this.label_100_5);
            this.groupBox_9.Controls.Add(this.textBox_100_5);
            this.groupBox_9.Controls.Add(this.label_100_6);
            this.groupBox_9.Controls.Add(this.textBox_100_6);
            this.groupBox_9.Controls.Add(this.label_100_7);
            this.groupBox_9.Controls.Add(this.textBox_100_7);
            this.groupBox_9.Controls.Add(this.label_100_8);
            this.groupBox_9.Controls.Add(this.textBox_100_8);
            this.groupBox_9.Controls.Add(this.label_100_9);
            this.groupBox_9.Controls.Add(this.textBox_100_9);
            this.groupBox_9.TabIndex = 9;
            this.groupBox_9.Text = "Pedras";
            this.groupBox_9.Name = "groupBox_9";
            this.groupBox_9.Size = new Size(300, 285);

            this.label_100_0.Name = "label_100_0";
            this.label_100_0.Text = "- Responsável:";
            this.textBox_100_0.Name = "textBox_100_0";
            MyEvents.TextBoxEvents(textBox_100_0);

            this.label_100_1.Name = "label_100_1";
            this.label_100_1.Text = "- Telefone:";
            this.textBox_100_1.Name = "textBox_100_1";
            MyEvents.TextBoxEvents(textBox_100_1);

            this.label_100_2.Name = "label_100_2";
            this.label_100_2.Text = "- e-mail:";
            this.textBox_100_2.Name = "textBox_100_2";
            MyEvents.TextBoxEvents(textBox_100_2);

            this.label_100_3.Name = "label_100_3";
            this.label_100_3.Text = "- Observações:";
            this.textBox_100_3.Name = "textBox_100_3";
            MyEvents.TextBoxEvents(textBox_100_3);

            this.label_100_4.Name = "label_100_4";
            this.label_100_4.Text = "- Endereço:";
            this.textBox_100_4.Name = "textBox_100_4";
            MyEvents.TextBoxEvents(textBox_100_4);

            this.label_100_5.Name = "label_100_5";
            this.label_100_5.Text = "- Empresa A:";
            this.textBox_100_5.Name = "textBox_100_5";
            MyEvents.TextBoxEvents(textBox_100_5, comboBox_100_10);

            this.label_100_6.Name = "label_100_6";
            this.label_100_6.Text = "- Empresa B:";
            this.textBox_100_6.Name = "textBox_100_6";
            MyEvents.TextBoxEvents(textBox_100_6, comboBox_100_10);

            this.label_100_7.Name = "label_100_7";
            this.label_100_7.Text = "- Empresa C:";
            this.textBox_100_7.Name = "textBox_100_7";
            MyEvents.TextBoxEvents(textBox_100_7, comboBox_100_10);

            this.label_100_8.Name = "label_100_8";
            this.label_100_8.Text = "- Empresa D:";
            this.textBox_100_8.Name = "textBox_100_8";
            MyEvents.TextBoxEvents(textBox_100_8, comboBox_100_10);

            this.label_100_9.Name = "label_100_9";
            this.label_100_9.Text = "- Empresa E:";
            this.textBox_100_9.Name = "textBox_100_9";
            MyEvents.TextBoxEvents(textBox_100_9, comboBox_100_10);

            this.label_100_10.Name = "label_100_10";
            this.label_100_10.Text = "Contratada:";
            this.comboBox_100_10.Name = "comboBox_100_10";
            this.comboBox_100_10.Location = new Point(90, 18);
            this.comboBox_100_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_100_10);
            this.comboBox_100_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 100, 10);
            };
            this.label_100_11.Name = "label_100_11";
            this.label_100_11.Text = "Orçamentos:";
            this.textBox_100_11.Name = "textBox_100_0";
            this.textBox_100_11.Hide();
            #endregion
            #region groupBox_10
            this.groupBox_10.Controls.Add(this.label_101_10);
            this.groupBox_10.Controls.Add(this.comboBox_101_10);
            this.groupBox_10.Controls.Add(this.label_101_0);
            this.groupBox_10.Controls.Add(this.textBox_101_0);
            this.groupBox_10.Controls.Add(this.label_101_1);
            this.groupBox_10.Controls.Add(this.textBox_101_1);
            this.groupBox_10.Controls.Add(this.label_101_2);
            this.groupBox_10.Controls.Add(this.textBox_101_2);
            this.groupBox_10.Controls.Add(this.label_101_3);
            this.groupBox_10.Controls.Add(this.textBox_101_3);
            this.groupBox_10.Controls.Add(this.label_101_4);
            this.groupBox_10.Controls.Add(this.textBox_101_4);
            this.groupBox_10.Controls.Add(this.label_101_11);
            this.groupBox_10.Controls.Add(this.textBox_101_11);
            this.groupBox_10.Controls.Add(this.label_101_5);
            this.groupBox_10.Controls.Add(this.textBox_101_5);
            this.groupBox_10.Controls.Add(this.label_101_6);
            this.groupBox_10.Controls.Add(this.textBox_101_6);
            this.groupBox_10.Controls.Add(this.label_101_7);
            this.groupBox_10.Controls.Add(this.textBox_101_7);
            this.groupBox_10.Controls.Add(this.label_101_8);
            this.groupBox_10.Controls.Add(this.textBox_101_8);
            this.groupBox_10.Controls.Add(this.label_101_9);
            this.groupBox_10.Controls.Add(this.textBox_101_9);
            this.groupBox_10.TabIndex = 10;
            this.groupBox_10.Text = "Revestimentos";
            this.groupBox_10.Name = "groupBox_10";
            this.groupBox_10.Size = new Size(300, 285);

            this.label_101_0.Name = "label_101_0";
            this.label_101_0.Text = "- Responsável:";
            this.textBox_101_0.Name = "textBox_101_0";
            MyEvents.TextBoxEvents(textBox_101_0);

            this.label_101_1.Name = "label_101_1";
            this.label_101_1.Text = "- Telefone:";
            this.textBox_101_1.Name = "textBox_101_1";
            MyEvents.TextBoxEvents(textBox_101_1);

            this.label_101_2.Name = "label_101_2";
            this.label_101_2.Text = "- e-mail:";
            this.textBox_101_2.Name = "textBox_101_2";
            MyEvents.TextBoxEvents(textBox_101_2);

            this.label_101_3.Name = "label_101_3";
            this.label_101_3.Text = "- Observações:";
            this.textBox_101_3.Name = "textBox_101_3";
            MyEvents.TextBoxEvents(textBox_101_3);

            this.label_101_4.Name = "label_101_4";
            this.label_101_4.Text = "- Endereço:";
            this.textBox_101_4.Name = "textBox_101_4";
            MyEvents.TextBoxEvents(textBox_101_4);

            this.label_101_5.Name = "label_101_5";
            this.label_101_5.Text = "- Empresa A:";
            this.textBox_101_5.Name = "textBox_101_5";
            MyEvents.TextBoxEvents(textBox_101_5, comboBox_101_10);

            this.label_101_6.Name = "label_101_6";
            this.label_101_6.Text = "- Empresa B:";
            this.textBox_101_6.Name = "textBox_101_6";
            MyEvents.TextBoxEvents(textBox_101_6, comboBox_101_10);

            this.label_101_7.Name = "label_101_7";
            this.label_101_7.Text = "- Empresa C:";
            this.textBox_101_7.Name = "textBox_101_7";
            MyEvents.TextBoxEvents(textBox_101_7, comboBox_101_10);

            this.label_101_8.Name = "label_101_8";
            this.label_101_8.Text = "- Empresa D:";
            this.textBox_101_8.Name = "textBox_101_8";
            MyEvents.TextBoxEvents(textBox_101_8, comboBox_101_10);

            this.label_101_9.Name = "label_101_9";
            this.label_101_9.Text = "- Empresa E:";
            this.textBox_101_9.Name = "textBox_101_9";
            MyEvents.TextBoxEvents(textBox_101_9, comboBox_101_10);

            this.label_101_10.Name = "label_101_10";
            this.label_101_10.Text = "Contratada:";
            this.comboBox_101_10.Name = "comboBox_101_10";
            this.comboBox_101_10.Location = new Point(90, 18);
            this.comboBox_101_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_101_10);
            this.comboBox_101_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 101, 10);
            };
            this.label_101_11.Name = "label_101_11";
            this.label_101_11.Text = "Orçamentos:";
            this.textBox_101_11.Name = "textBox_101_0";
            this.textBox_101_11.Hide();
            #endregion
            #region groupBox_11
            this.groupBox_11.Controls.Add(this.label_102_10);
            this.groupBox_11.Controls.Add(this.comboBox_102_10);
            this.groupBox_11.Controls.Add(this.label_102_0);
            this.groupBox_11.Controls.Add(this.textBox_102_0);
            this.groupBox_11.Controls.Add(this.label_102_1);
            this.groupBox_11.Controls.Add(this.textBox_102_1);
            this.groupBox_11.Controls.Add(this.label_102_2);
            this.groupBox_11.Controls.Add(this.textBox_102_2);
            this.groupBox_11.Controls.Add(this.label_102_3);
            this.groupBox_11.Controls.Add(this.textBox_102_3);
            this.groupBox_11.Controls.Add(this.label_102_4);
            this.groupBox_11.Controls.Add(this.textBox_102_4);
            this.groupBox_11.Controls.Add(this.label_102_11);
            this.groupBox_11.Controls.Add(this.textBox_102_11);
            this.groupBox_11.Controls.Add(this.label_102_5);
            this.groupBox_11.Controls.Add(this.textBox_102_5);
            this.groupBox_11.Controls.Add(this.label_102_6);
            this.groupBox_11.Controls.Add(this.textBox_102_6);
            this.groupBox_11.Controls.Add(this.label_102_7);
            this.groupBox_11.Controls.Add(this.textBox_102_7);
            this.groupBox_11.Controls.Add(this.label_102_8);
            this.groupBox_11.Controls.Add(this.textBox_102_8);
            this.groupBox_11.Controls.Add(this.label_102_9);
            this.groupBox_11.Controls.Add(this.textBox_102_9);
            this.groupBox_11.TabIndex = 11;
            this.groupBox_11.Text = "Climatização";
            this.groupBox_11.Name = "groupBox_11";
            this.groupBox_11.Size = new Size(300, 285);

            this.label_102_0.Name = "label_102_0";
            this.label_102_0.Text = "- Responsável:";
            this.textBox_102_0.Name = "textBox_102_0";
            MyEvents.TextBoxEvents(textBox_102_0);

            this.label_102_1.Name = "label_102_1";
            this.label_102_1.Text = "- Telefone:";
            this.textBox_102_1.Name = "textBox_102_1";
            MyEvents.TextBoxEvents(textBox_102_1);

            this.label_102_2.Name = "label_102_2";
            this.label_102_2.Text = "- e-mail:";
            this.textBox_102_2.Name = "textBox_102_2";
            MyEvents.TextBoxEvents(textBox_102_2);

            this.label_102_3.Name = "label_102_3";
            this.label_102_3.Text = "- Observações:";
            this.textBox_102_3.Name = "textBox_102_3";
            MyEvents.TextBoxEvents(textBox_102_3);

            this.label_102_4.Name = "label_102_4";
            this.label_102_4.Text = "- Endereço:";
            this.textBox_102_4.Name = "textBox_102_4";
            MyEvents.TextBoxEvents(textBox_102_4);

            this.label_102_5.Name = "label_102_5";
            this.label_102_5.Text = "- Empresa A:";
            this.textBox_102_5.Name = "textBox_102_5";
            MyEvents.TextBoxEvents(textBox_102_5, comboBox_102_10);

            this.label_102_6.Name = "label_102_6";
            this.label_102_6.Text = "- Empresa B:";
            this.textBox_102_6.Name = "textBox_102_6";
            MyEvents.TextBoxEvents(textBox_102_6, comboBox_102_10);

            this.label_102_7.Name = "label_102_7";
            this.label_102_7.Text = "- Empresa C:";
            this.textBox_102_7.Name = "textBox_102_7";
            MyEvents.TextBoxEvents(textBox_102_7, comboBox_102_10);

            this.label_102_8.Name = "label_102_8";
            this.label_102_8.Text = "- Empresa D:";
            this.textBox_102_8.Name = "textBox_102_8";
            MyEvents.TextBoxEvents(textBox_102_8, comboBox_102_10);

            this.label_102_9.Name = "label_102_9";
            this.label_102_9.Text = "- Empresa E:";
            this.textBox_102_9.Name = "textBox_102_9";
            MyEvents.TextBoxEvents(textBox_102_9, comboBox_102_10);

            this.label_102_10.Name = "label_102_10";
            this.label_102_10.Text = "Contratada:";
            this.comboBox_102_10.Name = "comboBox_102_10";
            this.comboBox_102_10.Location = new Point(90, 18);
            this.comboBox_102_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_102_10);
            this.comboBox_102_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 102, 10);
            };
            this.label_102_11.Name = "label_102_11";
            this.label_102_11.Text = "Orçamentos:";
            this.textBox_102_11.Name = "textBox_102_0";
            this.textBox_102_11.Hide();
            #endregion
            #region groupBox_12
            this.groupBox_12.Controls.Add(this.label_103_10);
            this.groupBox_12.Controls.Add(this.comboBox_103_10);
            this.groupBox_12.Controls.Add(this.label_103_0);
            this.groupBox_12.Controls.Add(this.textBox_103_0);
            this.groupBox_12.Controls.Add(this.label_103_1);
            this.groupBox_12.Controls.Add(this.textBox_103_1);
            this.groupBox_12.Controls.Add(this.label_103_2);
            this.groupBox_12.Controls.Add(this.textBox_103_2);
            this.groupBox_12.Controls.Add(this.label_103_3);
            this.groupBox_12.Controls.Add(this.textBox_103_3);
            this.groupBox_12.Controls.Add(this.label_103_4);
            this.groupBox_12.Controls.Add(this.textBox_103_4);
            this.groupBox_12.Controls.Add(this.label_103_11);
            this.groupBox_12.Controls.Add(this.textBox_103_11);
            this.groupBox_12.Controls.Add(this.label_103_5);
            this.groupBox_12.Controls.Add(this.textBox_103_5);
            this.groupBox_12.Controls.Add(this.label_103_6);
            this.groupBox_12.Controls.Add(this.textBox_103_6);
            this.groupBox_12.Controls.Add(this.label_103_7);
            this.groupBox_12.Controls.Add(this.textBox_103_7);
            this.groupBox_12.Controls.Add(this.label_103_8);
            this.groupBox_12.Controls.Add(this.textBox_103_8);
            this.groupBox_12.Controls.Add(this.label_103_9);
            this.groupBox_12.Controls.Add(this.textBox_103_9);
            this.groupBox_12.TabIndex = 12;
            this.groupBox_12.Text = "Paisagismo";
            this.groupBox_12.Name = "groupBox_12";
            this.groupBox_12.Size = new Size(300, 285);

            this.label_103_0.Name = "label_103_0";
            this.label_103_0.Text = "- Responsável:";
            this.textBox_103_0.Name = "textBox_103_0";
            MyEvents.TextBoxEvents(textBox_103_0);

            this.label_103_1.Name = "label_103_1";
            this.label_103_1.Text = "- Telefone:";
            this.textBox_103_1.Name = "textBox_103_1";
            MyEvents.TextBoxEvents(textBox_103_1);

            this.label_103_2.Name = "label_103_2";
            this.label_103_2.Text = "- e-mail:";
            this.textBox_103_2.Name = "textBox_103_2";
            MyEvents.TextBoxEvents(textBox_103_2);

            this.label_103_3.Name = "label_103_3";
            this.label_103_3.Text = "- Observações:";
            this.textBox_103_3.Name = "textBox_103_3";
            MyEvents.TextBoxEvents(textBox_103_3);

            this.label_103_4.Name = "label_103_4";
            this.label_103_4.Text = "- Endereço:";
            this.textBox_103_4.Name = "textBox_103_4";
            MyEvents.TextBoxEvents(textBox_103_4);

            this.label_103_5.Name = "label_103_5";
            this.label_103_5.Text = "- Empresa A:";
            this.textBox_103_5.Name = "textBox_103_5";
            MyEvents.TextBoxEvents(textBox_103_5, comboBox_103_10);

            this.label_103_6.Name = "label_103_6";
            this.label_103_6.Text = "- Empresa B:";
            this.textBox_103_6.Name = "textBox_103_6";
            MyEvents.TextBoxEvents(textBox_103_6, comboBox_103_10);

            this.label_103_7.Name = "label_103_7";
            this.label_103_7.Text = "- Empresa C:";
            this.textBox_103_7.Name = "textBox_103_7";
            MyEvents.TextBoxEvents(textBox_103_7, comboBox_103_10);

            this.label_103_8.Name = "label_103_8";
            this.label_103_8.Text = "- Empresa D:";
            this.textBox_103_8.Name = "textBox_103_8";
            MyEvents.TextBoxEvents(textBox_103_8, comboBox_103_10);

            this.label_103_9.Name = "label_103_9";
            this.label_103_9.Text = "- Empresa E:";
            this.textBox_103_9.Name = "textBox_103_9";
            MyEvents.TextBoxEvents(textBox_103_9, comboBox_103_10);

            this.label_103_10.Name = "label_103_10";
            this.label_103_10.Text = "Contratada:";
            this.comboBox_103_10.Name = "comboBox_103_10";
            this.comboBox_103_10.Location = new Point(90, 18);
            this.comboBox_103_10.Size = new Size(200, 20);
            MyFormats.ComboBoxFormat(comboBox_103_10);
            this.comboBox_103_10.LostFocus += delegate (object sender, EventArgs e)
            {
                MyEvents.ComboBox_LostFocus(sender, e, 103, 10);
            };
            this.label_103_11.Name = "label_103_11";
            this.label_103_11.Text = "Orçamentos:";
            this.textBox_103_11.Name = "textBox_103_0";
            this.textBox_103_11.Hide();
            #endregion
            #region groupBox_13
            this.groupBox_13.Controls.Add(this.label_104_0);
            this.groupBox_13.Controls.Add(this.textBox_104_0);
            this.groupBox_13.Controls.Add(this.label_104_1);
            this.groupBox_13.Controls.Add(this.textBox_104_1);
            this.groupBox_13.Controls.Add(this.label_104_2);
            this.groupBox_13.Controls.Add(this.textBox_104_2);
            this.groupBox_13.Controls.Add(this.label_104_3);
            this.groupBox_13.Controls.Add(this.textBox_104_3);
            this.groupBox_13.Controls.Add(this.label_104_4);
            this.groupBox_13.Controls.Add(this.textBox_104_4);
            this.groupBox_13.TabIndex = 13;
            this.groupBox_13.Text = "Despachante";
            this.groupBox_13.Name = "groupBox_13";
            this.groupBox_13.Size = new Size(300, 130);

            this.label_104_0.Name = "label_104_0";
            this.label_104_0.Text = "- Responsável:";
            this.textBox_104_0.Name = "textBox_104_0";
            MyEvents.TextBoxEvents(textBox_104_0);

            this.label_104_1.Name = "label_104_1";
            this.label_104_1.Text = "- Telefone:";
            this.textBox_104_1.Name = "textBox_104_1";
            MyEvents.TextBoxEvents(textBox_104_1);

            this.label_104_2.Name = "label_104_2";
            this.label_104_2.Text = "- e-mail:";
            this.textBox_104_2.Name = "textBox_104_2";
            MyEvents.TextBoxEvents(textBox_104_2);

            this.label_104_3.Name = "label_104_3";
            this.label_104_3.Text = "- Observações:";
            this.textBox_104_3.Name = "textBox_104_3";
            MyEvents.TextBoxEvents(textBox_104_3);

            this.label_104_4.Name = "label_104_4";
            this.label_104_4.Text = "- Endereço:";
            this.textBox_104_4.Name = "textBox_104_4";
            MyEvents.TextBoxEvents(textBox_104_4);

            #endregion

            int _padd = panel.HorizontalScroll.Enabled ? 10 : 0;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label);
            this.Name = "ComplementaresPalette";
            this.Padding = new Padding(_padd, 10, 10, 10);
            this.Size = new Size(320, 650);
            this.FormatComponent();
            this.FillComponent();
        }
        internal void FillComponent()
        {
            this.label.Text = MyProject.CurrentProject();

            foreach (var groupbox in this.panel.Controls.OfType<GroupBox>())
            {
                foreach (var textbox in groupbox.Controls.OfType<TextBox>())
                {
                    textbox.Text = MyFormats.TextBoxName(textbox);
                }
            }

            this.comboBox_91_10.Items.Clear();
            this.comboBox_91_10.Items.Add(textBox_91_5.Text);
            this.comboBox_91_10.Items.Add(textBox_91_6.Text);
            this.comboBox_91_10.Items.Add(textBox_91_7.Text);
            this.comboBox_91_10.Items.Add(textBox_91_8.Text);
            this.comboBox_91_10.Items.Add(textBox_91_9.Text);
            this.comboBox_91_10.Text = MyProject.GetDetailValue(91, 10);

            this.comboBox_92_10.Items.Clear();
            this.comboBox_92_10.Items.Add(textBox_92_5.Text);
            this.comboBox_92_10.Items.Add(textBox_92_6.Text);
            this.comboBox_92_10.Items.Add(textBox_92_7.Text);
            this.comboBox_92_10.Items.Add(textBox_92_8.Text);
            this.comboBox_92_10.Items.Add(textBox_92_9.Text);
            this.comboBox_92_10.Text = MyProject.GetDetailValue(92, 10);

            this.comboBox_93_10.Items.Clear();
            this.comboBox_93_10.Items.Add(textBox_93_5.Text);
            this.comboBox_93_10.Items.Add(textBox_93_6.Text);
            this.comboBox_93_10.Items.Add(textBox_93_7.Text);
            this.comboBox_93_10.Items.Add(textBox_93_8.Text);
            this.comboBox_93_10.Items.Add(textBox_93_9.Text);
            this.comboBox_93_10.Text = MyProject.GetDetailValue(93, 10);

            this.comboBox_94_10.Items.Clear();
            this.comboBox_94_10.Items.Add(textBox_94_5.Text);
            this.comboBox_94_10.Items.Add(textBox_94_6.Text);
            this.comboBox_94_10.Items.Add(textBox_94_7.Text);
            this.comboBox_94_10.Items.Add(textBox_94_8.Text);
            this.comboBox_94_10.Items.Add(textBox_94_9.Text);
            this.comboBox_94_10.Text = MyProject.GetDetailValue(94, 10);

            this.comboBox_95_10.Items.Clear();
            this.comboBox_95_10.Items.Add(textBox_95_5.Text);
            this.comboBox_95_10.Items.Add(textBox_95_6.Text);
            this.comboBox_95_10.Items.Add(textBox_95_7.Text);
            this.comboBox_95_10.Items.Add(textBox_95_8.Text);
            this.comboBox_95_10.Items.Add(textBox_95_9.Text);
            this.comboBox_95_10.Text = MyProject.GetDetailValue(95, 10);

            this.comboBox_96_10.Items.Clear();
            this.comboBox_96_10.Items.Add(textBox_96_5.Text);
            this.comboBox_96_10.Items.Add(textBox_96_6.Text);
            this.comboBox_96_10.Items.Add(textBox_96_7.Text);
            this.comboBox_96_10.Items.Add(textBox_96_8.Text);
            this.comboBox_96_10.Items.Add(textBox_96_9.Text);
            this.comboBox_96_10.Text = MyProject.GetDetailValue(96, 10);

            this.comboBox_97_10.Items.Clear();
            this.comboBox_97_10.Items.Add(textBox_97_5.Text);
            this.comboBox_97_10.Items.Add(textBox_97_6.Text);
            this.comboBox_97_10.Items.Add(textBox_97_7.Text);
            this.comboBox_97_10.Items.Add(textBox_97_8.Text);
            this.comboBox_97_10.Items.Add(textBox_97_9.Text);
            this.comboBox_97_10.Text = MyProject.GetDetailValue(97, 10);

            this.comboBox_98_10.Items.Clear();
            this.comboBox_98_10.Items.Add(textBox_98_5.Text);
            this.comboBox_98_10.Items.Add(textBox_98_6.Text);
            this.comboBox_98_10.Items.Add(textBox_98_7.Text);
            this.comboBox_98_10.Items.Add(textBox_98_8.Text);
            this.comboBox_98_10.Items.Add(textBox_98_9.Text);
            this.comboBox_98_10.Text = MyProject.GetDetailValue(98, 10);

            this.comboBox_99_10.Items.Clear();
            this.comboBox_99_10.Items.Add(textBox_99_5.Text);
            this.comboBox_99_10.Items.Add(textBox_99_6.Text);
            this.comboBox_99_10.Items.Add(textBox_99_7.Text);
            this.comboBox_99_10.Items.Add(textBox_99_8.Text);
            this.comboBox_99_10.Items.Add(textBox_99_9.Text);
            this.comboBox_99_10.Text = MyProject.GetDetailValue(99, 10);

            this.comboBox_100_10.Items.Clear();
            this.comboBox_100_10.Items.Add(textBox_100_5.Text);
            this.comboBox_100_10.Items.Add(textBox_100_6.Text);
            this.comboBox_100_10.Items.Add(textBox_100_7.Text);
            this.comboBox_100_10.Items.Add(textBox_100_8.Text);
            this.comboBox_100_10.Items.Add(textBox_100_9.Text);
            this.comboBox_100_10.Text = MyProject.GetDetailValue(100, 10);

            this.comboBox_101_10.Items.Clear();
            this.comboBox_101_10.Items.Add(textBox_101_5.Text);
            this.comboBox_101_10.Items.Add(textBox_101_6.Text);
            this.comboBox_101_10.Items.Add(textBox_101_7.Text);
            this.comboBox_101_10.Items.Add(textBox_101_8.Text);
            this.comboBox_101_10.Items.Add(textBox_101_9.Text);
            this.comboBox_101_10.Text = MyProject.GetDetailValue(101, 10);

            this.comboBox_102_10.Items.Clear();
            this.comboBox_102_10.Items.Add(textBox_102_5.Text);
            this.comboBox_102_10.Items.Add(textBox_102_6.Text);
            this.comboBox_102_10.Items.Add(textBox_102_7.Text);
            this.comboBox_102_10.Items.Add(textBox_102_8.Text);
            this.comboBox_102_10.Items.Add(textBox_102_9.Text);
            this.comboBox_102_10.Text = MyProject.GetDetailValue(102, 10);

            this.comboBox_103_10.Items.Clear();
            this.comboBox_103_10.Items.Add(textBox_103_5.Text);
            this.comboBox_103_10.Items.Add(textBox_103_6.Text);
            this.comboBox_103_10.Items.Add(textBox_103_7.Text);
            this.comboBox_103_10.Items.Add(textBox_103_8.Text);
            this.comboBox_103_10.Items.Add(textBox_103_9.Text);
            this.comboBox_103_10.Text = MyProject.GetDetailValue(103, 10);
        }
        internal void FillList(ComboBox combobox, int _index, string _text)
        {
            combobox.Items.RemoveAt(_index);
            combobox.Items.Insert(_index, _text);
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

            int textBox_0 = 18;
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

            int textBox_1 = 18;
            int label_1 = -5;

            foreach (var textbox in this.groupBox_1.Controls.OfType<TextBox>())
            {
                textBox_1 = textBox_1 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_1);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_1.Controls.OfType<Label>())
            {
                label_1 = label_1 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_1);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_2 builder

            int textBox_2 = 18;
            int label_2 = -5;

            foreach (var textbox in this.groupBox_2.Controls.OfType<TextBox>())
            {
                textBox_2 = textBox_2 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_2);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_2.Controls.OfType<Label>())
            {
                label_2 = label_2 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_2);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_3 builder

            int textBox_3 = 18;
            int label_3 = -5;

            foreach (var textbox in this.groupBox_3.Controls.OfType<TextBox>())
            {
                textBox_3 = textBox_3 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_3);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_3.Controls.OfType<Label>())
            {
                label_3 = label_3 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_3);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_4 builder

            int textBox_4 = 18;
            int label_4 = -5;

            foreach (var textbox in this.groupBox_4.Controls.OfType<TextBox>())
            {
                textBox_4 = textBox_4 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_4);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_4.Controls.OfType<Label>())
            {
                label_4 = label_4 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_4);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_5 builder

            int textBox_5 = 18;
            int label_5 = -5;

            foreach (var textbox in this.groupBox_5.Controls.OfType<TextBox>())
            {
                textBox_5 = textBox_5 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_5);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_5.Controls.OfType<Label>())
            {
                label_5 = label_5 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_5);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_6 builder

            int textBox_6 = 18;
            int label_6 = -5;

            foreach (var textbox in this.groupBox_6.Controls.OfType<TextBox>())
            {
                textBox_6 = textBox_6 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_6);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_6.Controls.OfType<Label>())
            {
                label_6 = label_6 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_6);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_7 builder
            
            int textBox_7 = 18;
            int label_7 = -5;

            foreach (var textbox in this.groupBox_7.Controls.OfType<TextBox>())
            {
                textBox_7 = textBox_7 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_7);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_7.Controls.OfType<Label>())
            {
                label_7 = label_7 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_7);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_8 builder

            int textBox_8 = 18;
            int label_8 = -5;

            foreach (var textbox in this.groupBox_8.Controls.OfType<TextBox>())
            {
                textBox_8 = textBox_8 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_8);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_8.Controls.OfType<Label>())
            {
                label_8 = label_8 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_8);
                MyFormats.LabelFormat(label);
            }            
            #endregion
            #region groupBox_9 builder

            int textBox_9 = 18;
            int label_9 = -5;

            foreach (var textbox in this.groupBox_9.Controls.OfType<TextBox>())
            {
                textBox_9 = textBox_9 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_9);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_9.Controls.OfType<Label>())
            {
                label_9 = label_9 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_9);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_10 builder
            
            int textBox_10 = 18;
            int label_10 = -5;

            foreach (var textbox in this.groupBox_10.Controls.OfType<TextBox>())
            {
                textBox_10 = textBox_10 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_10);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_10.Controls.OfType<Label>())
            {
                label_10 = label_10 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_10);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_11 builder

            int textBox_11 = 18;
            int label_11 = -5;

            foreach (var textbox in this.groupBox_11.Controls.OfType<TextBox>())
            {
                textBox_11 = textBox_11 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_11);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_11.Controls.OfType<Label>())
            {
                label_11 = label_11 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_11);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_12 builder

            int textBox_12 = 18;
            int label_12 = -5;

            foreach (var textbox in this.groupBox_12.Controls.OfType<TextBox>())
            {
                textBox_12 = textBox_12 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_12);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_12.Controls.OfType<Label>())
            {
                label_12 = label_12 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_12);
                MyFormats.LabelFormat(label);
            }
            #endregion
            #region groupBox_13 builder
            
            int textBox_13 = -4;
            int label_13 = -5;

            foreach (var textbox in this.groupBox_13.Controls.OfType<TextBox>())
            {
                textBox_13 = textBox_13 + 22;
                textbox.Size = new Size(200, 20);
                textbox.Location = new Point(90, textBox_13);
                MyFormats.TextBoxFormat(textbox);
            }

            foreach (var label in this.groupBox_13.Controls.OfType<Label>())
            {
                label_13 = label_13 + 22;
                label.Size = new Size(75, 13);
                label.Location = new Point(10, label_13);
                MyFormats.LabelFormat(label);
            }
            #endregion
        }
    }
}