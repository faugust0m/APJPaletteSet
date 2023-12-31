﻿namespace APJPaletteSet
{
    internal class MyTooltips
    {
        internal static string ComboBox(string txt) { return "Determine ou selecione " + txt + " a partir da lista"; }
        internal static string ComboBoxList(string txt) { return "Determine ou selecione a partir da lista " + txt + " relacionado ao índice destacado"; }
        internal static string ComboBoxLista(string txt) { return "Determine ou selecione a partir da lista " + txt + " relacionada ao índice destacado"; }
        internal static string TextBox(string txt) { return "Determine " + txt; }
        internal static string TextBoxLimite(string txt) { return "Determine " + txt + " em relação ao limite selecionado"; }
        internal static string Link(string txt) { return "Clique no link para editar a lista " + txt; }
        internal static string Radio() { return "Selecione o índice de referência para as informações do grupo"; }
        internal static string EdLista() { return "Clique no link 'Editar lista' para modificá-la;\n"; }
        internal static string Tag()
        {
            return "(Informação utilizada no preenchimento automático de rótulos e tabelas)";
        }
        internal static string Selos()
        {
            return "(Informação utilizada no preenchimento automático dos selos)";
        }
        internal static string SelosAp()
        {
            return "(Informação utilizada no preenchimento automático dos selos de aprovação)";
        }
    }
}
