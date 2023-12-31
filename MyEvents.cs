﻿using System;
using System.Windows.Forms;

namespace APJPaletteSet
{
    public static class MyEvents
    {
        //Eventos gerais
        internal static void TextBoxEvents(TextBox textbox)
        {
            //Recebe o controle e determina propriedade e par pelo seu nome;
            string _textboxname = textbox.Name.ToString();
            string [] _textsplit = _textboxname.Split('_');
            int _prop = int.Parse(_textsplit[1]);
            int _pair = int.Parse(_textsplit[2]);

            textbox.LostFocus += delegate (object sender, EventArgs e) {
                TextBox_LostFocus(sender, e, _prop, _pair);
            };
            textbox.KeyPress += delegate (object sender, KeyPressEventArgs e) {
                TextBox_KeyPress(sender, e, _prop, _pair);
            };
        }
        internal static void TextBoxEvents(TextBox textbox, ComboBox combobox)
        {
            //Recebe o controle e determina propriedade e par pelo seu nome;
            //Utilizado apenas na paleta "Complementares" para ativar o comboBox;
            string _textboxname = textbox.Name.ToString();
            string[] _textsplit = _textboxname.Split('_');
            int _prop = int.Parse(_textsplit[1]);
            int _pair = int.Parse(_textsplit[2]);

            textbox.TextChanged += delegate (object sender, EventArgs e) {
                TextBox_TextChanged(sender, e, combobox, _pair);
            };
            textbox.LostFocus += delegate (object sender, EventArgs e) {
                TextBox_LostFocus(sender, e, _prop, _pair);
            };
            textbox.KeyPress += delegate (object sender, KeyPressEventArgs e) {
                TextBox_KeyPress(sender, e, combobox, _prop, _pair);
            };
        }
        internal static void ComboBoxEvents(ComboBox combobox)
        {
            //Recebe o controle e determina propriedade e par pelo seu nome;
            string _comboboxname = combobox.Name.ToString();
            string[] _textsplit = _comboboxname.Split('_');
            int _prop = int.Parse(_textsplit[1]);
            int _pair = int.Parse(_textsplit[2]);

            combobox.LostFocus += delegate (object sender, EventArgs e) {
                ComboBox_LostFocus(sender, e, _prop, _pair);
            };
        }
        
        //Eventos específicos
        internal static void TextBox_TextChanged(object sender, EventArgs e, ComboBox combobox, int _pair)
        {
            int _index = combobox.SelectedIndex;
            if (_pair == _index + 5)
            {
                combobox.Text = (sender as TextBox).Text;
            }
        }
        internal static void TextBox_GotFocus(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = System.Drawing.SystemColors.Window;
        }
        internal static void TextBox_LostFocus(object sender, EventArgs e, int _prop, int _pair)
        {
            //Recebe propriedade e par do método TextBoxEvents;
            //Recebe direto do controle na paleta "Obra";
            string _value = (sender as TextBox).Text;
            string _stored = MyProject.GetDetailValue(_prop, _pair);
            if (_value == _stored) { (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu; }
        }
        internal static void TextBox_KeyPress(object sender, KeyPressEventArgs e, int _prop, int _pair)
        {
            //Recebe controle, propriedade e par do método TextBoxEvents;
            //Utilizado nas caixas de texto comuns;
            if (e.KeyChar == (char)13)
            {
                string _value = (sender as TextBox).Text;
                MyProject.SetDetailValue(_prop, _pair, _value);
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
                (sender as TextBox).Parent.SelectNextControl((sender as TextBox), true, true, true, true);
            }

            if (e.KeyChar == (char)27)
            {
                (sender as TextBox).Text = MyProject.GetDetailValue(_prop, _pair);
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
            }
        }
        internal static void TextBox_KeyPress(object sender, KeyPressEventArgs e, ComboBox combobox, int _prop, int _pair)
        {
            //Recebe controle, propriedade e par do método TextBoxEvents;
            //Utilizado na paleta "Complementares, vinculando as caixas de orçamento com a lista;
            if (e.KeyChar == (char)13)
            {
                string _value = (sender as TextBox).Text;
                int _index = combobox.SelectedIndex;

                MyProject.SetDetailValue(_prop, _pair, _value);
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
                MyCommands.ReloadCompIndex(combobox, _pair - 5, (sender as TextBox).Text, 9);
                (sender as TextBox).Parent.SelectNextControl((sender as TextBox), true, true, true, true);

                if (_pair == _index + 5)
                {
                    combobox.Text = (sender as TextBox).Text;
                    MyProject.SetDetailValue(_prop, 10, _value);
                }
            }

            if (e.KeyChar == (char)27)
            {
                (sender as TextBox).Text = MyProject.GetDetailValue(_prop, _pair);
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        public static void ComboBox_GotFocus(object sender, EventArgs e)
        {
            (sender as ComboBox).BackColor = System.Drawing.SystemColors.Window;
        }
        public static void ComboBox_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
        public static void ComboBox_LostFocus(object sender, EventArgs e, int _prop, int _pair)
        {
            //Recebe propriedade e par do método ComboBoxEvents;
            //Recebe direto do controle na paleta "Legenda"/"Esquadrias";
            string _value = (sender as ComboBox).Text;
            MyProject.SetDetailValue(_prop, _pair, _value);
            (sender as ComboBox).BackColor = System.Drawing.SystemColors.Menu;
        }

        public static string GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked) { return radio.Text; }
            }
            return null;
        }
        public static void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e, int _index)
        {
            MyCommands.ShowMyPaletteListLink(_index);
        }


        //Eventos exclusivos das listas
        internal static void ListBox_Events(ListBox listbox, TextBox textbox, string _group)
        {
            //Atualiza a caixa de texto de acordo com a seleção da lista
            listbox.SelectedIndexChanged += delegate (object sender, EventArgs e) {
                ListBox_SelectedIndexChanged(sender, e, textbox);
            };
            //Apaga o item selecionado na lista
            listbox.KeyDown += delegate (object sender, KeyEventArgs e) {
                ListBox_KeyDown(sender, e, textbox, _group);
            };
            //Limpa a seleção da lista
            listbox.LostFocus += delegate (object sender, EventArgs e)
            {
                ListBox_LostFocus(sender, e);
            };
            //Atualiza a lista abaixo da caixa
            textbox.KeyPress += delegate (object sender, KeyPressEventArgs e) {
                TextBox_KeyPress(sender, e, listbox, _group);
            };
            //Limpa a caixa de texto sobre a lista
            textbox.LostFocus += delegate (object sender, EventArgs e) {
                TextBox_LostFocus(sender, e);
            };
        }
        //Eventos específicos da lista

        internal static void ListBox_SelectedIndexChanged(object sender, EventArgs e, TextBox textbox)
        {
            try
            {
                string _text = (sender as ListBox).SelectedItem.ToString();
                textbox.Text = _text;
            }
            catch (NullReferenceException) {
                textbox.Text = "";
            }
        }
        internal static void ListBox_KeyDown(object sender, KeyEventArgs e, TextBox textbox, string _group)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string _value = (sender as ListBox).SelectedItem.ToString();
                textbox.Text = "";
                XMLDocs.DelXMLDoc(_group, _value);
                SwitchGroup(_group);
            }
        }
        internal static void ListBox_LostFocus(object sender, EventArgs e)
        {
            (sender as ListBox).SelectedIndex = -1;
        }

        internal static void TextBox_KeyPress(object sender, KeyPressEventArgs e, ListBox listbox, string _group)
        {
            if (e.KeyChar == (char)13)
            {
                string _value = (sender as TextBox).Text;
                (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;

                if (_value != "")
                {
                    if (XMLDocs.ViewXMLDoc(_group, _value) == "Existe")
                    {
                        (sender as TextBox).Text = "";
                    }
                    else
                    {
                        XMLDocs.AddXMLDoc(_group, _value);
                        SwitchGroup(_group);
                    }
                }
            }
        }
        internal static void TextBox_LostFocus(object sender, EventArgs e)
        {
            //Limpa a caixa de texto sobre as lista
            (sender as TextBox).BackColor = System.Drawing.SystemColors.Menu;
        }

        internal static void SwitchGroup(string _group)
        {
            //Vincula a atualização das lists e comboboxes ao tipo de material
            switch (_group)
            {

                case "Tipo":
                    MyCommands.ReloadComp(1, "comboBox_0_14");
                    break;



                case "Piso":
                    MyCommands.ReloadComp(2, "comboBox_5_0"); //Atualiza lista piso
                    MyCommands.ReloadComp(6, "comboBox_5_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(3, "comboBox_5_0"); //Atualiza combobox piso
                    break;
                case "PisoAbreviado":
                    MyCommands.ReloadComp(2, "comboBox_5_1"); //Atualiza lista piso
                    MyCommands.ReloadComp(3, "comboBox_5_1"); //Atualiza combobox
                    break;
                case "AcabamentoPiso":
                    MyCommands.ReloadComp(2, "comboBox_5_4"); //Atualiza lista piso
                    MyCommands.ReloadComp(3, "comboBox_5_4"); //Atualiza combobox
                    break;
                case "FabricantePiso":
                    MyCommands.ReloadComp(2, "comboBox_5_5"); //Atualiza lista piso
                    MyCommands.ReloadComp(3, "comboBox_5_5"); //Atualiza combobox
                    break;



                case "Parede":
                    MyCommands.ReloadComp(3, "comboBox_47_0"); //Atualiza lista parede
                    MyCommands.ReloadComp(6, "comboBox_47_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(4, "comboBox_47_0"); //Atualiza combobox parede
                    break;
                case "ParedeAbreviado":
                    MyCommands.ReloadComp(3, "comboBox_47_1"); //Atualiza lista parede
                    MyCommands.ReloadComp(4, "comboBox_47_1"); //Atualiza combobox parede
                    break;
                case "FabricanteParede":
                    MyCommands.ReloadComp(3, "comboBox_47_5"); //Atualiza lista parede
                    MyCommands.ReloadComp(4, "comboBox_47_5"); //Atualiza combobox parede
                    break;



                case "Teto":
                    MyCommands.ReloadComp(4, "comboBox_61_0"); //Atualiza lista teto
                    MyCommands.ReloadComp(6, "comboBox_61_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(5, "comboBox_61_0"); //Atualiza combobox teto
                    break;
                case "TetoAbreviado":
                    MyCommands.ReloadComp(4, "comboBox_61_1"); //Atualiza lista teto
                    MyCommands.ReloadComp(5, "comboBox_61_1"); //Atualiza combobox legenda
                    break;
                case "FabricanteTeto":
                    MyCommands.ReloadComp(4, "comboBox_61_6"); //Atualiza lista teto
                    break;



                case "Esquadria":
                    MyCommands.ReloadComp(5, "comboBox_75_0"); //Atualiza lista esquadria
                    MyCommands.ReloadComp(6, "comboBox_75_0"); //Atualiza combobox esquadria
                    break;
                case "EsquadriaPadrão":
                    MyCommands.ReloadComp(5, "comboBox_75_1"); //Atualiza lista esquadria
                    MyCommands.ReloadComp(6, "comboBox_75_1"); //Atualiza combobox esquadria
                    break;
                case "EsquadriaPintura":
                    MyCommands.ReloadComp(5, "comboBox_75_2"); //Atualiza lista esquadria
                    MyCommands.ReloadComp(6, "comboBox_75_2"); //Atualiza combobox esquadria
                    break;
                case "EsquadriaCor":
                    MyCommands.ReloadComp(5, "comboBox_75_3"); //Atualiza lista esquadria
                    MyCommands.ReloadComp(6, "comboBox_75_3"); //Atualiza combobox esquadria
                    break;



                case "Vidro":
                    MyCommands.ReloadComp(5, "comboBox_82_0"); //Atualiza lista esquadrias
                    MyCommands.ReloadComp(6, "comboBox_82_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(6, "comboBox_82_0"); //Atualiza combobox esquadrias
                    MyCommands.ReloadComp(7, "comboBox_82_0"); //Atualiza combobox legenda
                    break;
                case "Maçanetas":
                    MyCommands.ReloadComp(5, "comboBox_83_0"); //Atualiza lista esquadrias
                    MyCommands.ReloadComp(6, "comboBox_83_0"); //Atualiza combobox esquadrias
                    break;
                case "Ferragens":
                    MyCommands.ReloadComp(5, "comboBox_84_0"); //Atualiza lista esquadrias
                    MyCommands.ReloadComp(6, "comboBox_84_0"); //Atualiza combobox esquadrias
                    break;



                case "Mármore":
                    MyCommands.ReloadComp(6, "comboBox_106_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(7, "comboBox_106_0"); //Atualiza combobox legenda
                    break;
                case "Granito":
                    MyCommands.ReloadComp(6, "comboBox_107_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(7, "comboBox_107_0"); //Atualiza combobox legenda
                    break;
                case "Madeira":
                    MyCommands.ReloadComp(6, "comboBox_108_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(7, "comboBox_108_0"); //Atualiza combobox legenda
                    break;
                case "Pintura":
                    MyCommands.ReloadComp(6, "comboBox_109_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(7, "comboBox_109_0"); //Atualiza combobox legenda
                    break;
                case "Revestimento":
                    MyCommands.ReloadComp(6, "comboBox_110_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(7, "comboBox_110_0"); //Atualiza combobox legenda
                    break;
                case "PapelParede":
                    MyCommands.ReloadComp(6, "comboBox_111_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(7, "comboBox_111_0"); //Atualiza combobox legenda
                    break;
                case "Espelho":
                    MyCommands.ReloadComp(6, "comboBox_112_0"); //Atualiza lista legenda
                    MyCommands.ReloadComp(7, "comboBox_112_0"); //Atualiza combobox legenda
                    break;



                case "Altura":
                    MyCommands.ReloadComp(4, "comboBox_61_3"); //Atualiza lista
                    MyCommands.ReloadComp(5, "comboBox_61_3"); //Atualiza combobox
                    break;
                case "Acabamento":
                    MyCommands.ReloadComp(3, "comboBox_47_4"); //Atualiza lista parede
                    MyCommands.ReloadComp(4, "comboBox_47_4"); //Atualiza lista teto
                    MyCommands.ReloadComp(4, "comboBox_47_4"); //Atualiza combobox parede
                    MyCommands.ReloadComp(5, "comboBox_61_5"); //Atualiza combobox teto
                    MyCommands.ReloadComp(6, "comboBox_75_4"); //Atualiza combobox esquadria
                    break;
                case "Dimensão":
                    MyCommands.ReloadComp(2, "comboBox_5_3");  //Atualiza lista piso
                    MyCommands.ReloadComp(3, "comboBox_5_3"); //Atualiza lista parede
                    MyCommands.ReloadComp(4, "comboBox_5_3"); //Atualiza lista teto
                    MyCommands.ReloadComp(3, "comboBox_5_3");  //Atualiza combobox piso
                    MyCommands.ReloadComp(4, "comboBox_47_3"); //Atualiza combobox parede
                    MyCommands.ReloadComp(5, "comboBox_61_4"); //Atualiza combobox teto
                    break;
            }
        }
    }
}