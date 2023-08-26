using System;
using Autodesk.AutoCAD.Windows;

namespace APJPaletteSet
{
    public class MyPaletteSet : PaletteSet
    {
        internal PropriedadePalette _first = null;
        internal ObraPalette _second = null;
        internal MatPisoPalette _third = null;
        internal MatParedePalette _fourth = null;
        internal MatTetoPalette _fifth = null;
        internal MatEsquadriasPalette _sixth = null;
        //internal MatLegendaPalette _seventh = null;
        internal FornecedoresPalette _eighth = null;
        internal ComplementaresPalette _ninth = null;
        public MyPaletteSet() : base("Project Details", "ProjectDetailsPalette", new Guid("00000000-0000-0000-0000-000000000017"))
        {
            MinimumSize = new System.Drawing.Size(330, 300);
            Style = PaletteSetStyles.ShowCloseButton |
                    PaletteSetStyles.ShowAutoHideButton |
                    PaletteSetStyles.ShowPropertiesMenu |
                    PaletteSetStyles.ShowTabForSingle;
            KeepFocus = true;

            _first = new PropriedadePalette();
            _second = new ObraPalette();
            _third = new MatPisoPalette();
            _fourth = new MatParedePalette();
            _fifth = new MatTetoPalette();
            _sixth = new MatEsquadriasPalette();
            //_seventh = new MatLegendaPalette();
            _eighth = new FornecedoresPalette();
            _ninth = new ComplementaresPalette();

            Add("Projeto", _first);
            Add("Obra", _second);
            Add("Mat. Piso", _third);
            Add("Mat. Parede", _fourth);
            Add("Mat. Teto", _fifth);
            Add("Esquadrias", _sixth);
            //Add("Legendas", _seventh);
            Add("Fornecedores", _eighth);
            Add("Complementares", _ninth);
        }
    }
    public class MyPaletteList : PaletteSet
    {
        internal ListasProjetoPalette _first = null;
        internal ListasPisoPalette _second = null;
        internal ListasParedePalette _third = null;
        internal ListasTetoPalette _fourth = null;
        internal ListasEsquadriasPalette _fifth = null;
        //internal ListasLegendaPalette _sixth = null;
        public MyPaletteList() : base("Project Details List", "ProjectDetailsListPalette", new Guid("00000000-0000-0000-0000-000000000717"))
        {
            MinimumSize = new System.Drawing.Size(330, 300);
            Style = PaletteSetStyles.ShowCloseButton |
                    PaletteSetStyles.ShowAutoHideButton |
                    PaletteSetStyles.ShowPropertiesMenu |
                    PaletteSetStyles.ShowTabForSingle;
            KeepFocus = true;

            _first = new ListasProjetoPalette();
            _second = new ListasPisoPalette();
            _third = new ListasParedePalette();
            _fourth = new ListasTetoPalette();
            _fifth = new ListasEsquadriasPalette();
            //_sixth = new ListasLegendaPalette();

            Add("Projeto", _first);
            Add("Piso", _second);
            Add("Parede", _third);
            Add("Teto", _fourth);
            Add("Esquadrias", _fifth);
            //Add("Legenda", _sixth);
        }
    }
}