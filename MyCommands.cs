using System;
using System.Windows.Forms;
using Autodesk.AutoCAD.Runtime;

namespace APJPaletteSet
{
    public class MyCommands
    {
        private static MyPaletteSet _myPs = null;
        private static MyPaletteList _myPl = null;

        string currentProject = MyProject.CurrentProject();

        [CommandMethod("ProjectDetailsPalette")]
        public void ShowMyPaletteSet()
        {
            bool firstShow = false;

            if (_myPs == null)
            {
                _myPs = new MyPaletteSet();
                firstShow = true;
            }
            _myPs.Visible = true;

            if (firstShow)
            {
                _myPs.Dock = Autodesk.AutoCAD.Windows.DockSides.None;
            }

            if (_myPs != null && currentProject != MyProject.CurrentProject())
            {
                ReloadPaletteSet();
                currentProject = MyProject.CurrentProject();
            }

            if (_myPl == null)
            {
                _myPl = new MyPaletteList();
                _myPl.Visible = false;
            }
        }

        [CommandMethod("ProjectDetailsPaletteClose")]
        public static void HideMyPaletteSet()
        {
            _myPs.Visible = false;
        }

        [CommandMethod("ProjectDetailsPaletteReload")]
        public static void ReloadMyPaletteSet()
        {
            ReloadPaletteSet();
        }

        [CommandMethod("ProjectDetailsListPalette")]
        public void ShowMyPaletteList()
        {
            if (_myPl == null)
            {
                _myPl = new MyPaletteList();
            }
            _myPl.Visible = true;

            if (_myPs == null)
            {
                _myPs = new MyPaletteSet();
                _myPs.Visible = false;
            }
        }

        [CommandMethod("ProjectDetailsListPaletteClose")]
        public void HideMyPaletteList()
        {
            _myPl.Visible = false;
        }
        public static void ReloadPaletteSet(object sender, EventArgs e)
        {
            _myPs._first.FillComponent();
            _myPs._second.FillComponent();
            _myPs._third.FillComponent();
            _myPs._fourth.FillComponent();
            _myPs._fifth.FillComponent();
            _myPs._sixth.FillComponent();
            //_myPs._seventh.FillComponent();
            _myPs._eighth.FillComponent();
            _myPs._ninth.FillComponent();
        }
        public static void ReloadPaletteSet()
        {
            _myPs._first.FillComponent();
            _myPs._second.FillComponent();
            _myPs._third.FillComponent();
            _myPs._fourth.FillComponent();
            _myPs._fifth.FillComponent();
            _myPs._sixth.FillComponent();
            //_myPs._seventh.FillComponent();
            _myPs._eighth.FillComponent();
            _myPs._ninth.FillComponent();
        }
        public static void ShowMyPaletteListLink(int _index)
        {
            if (_myPl == null)
            {
                _myPl = new MyPaletteList();
            }
            _myPl.Visible = true;
            _myPl.Activate(_index);
        }
        public static void ReloadComp(int _palette, string combobox)
        {
            switch (_palette)
            {
                case 1:
                    _myPs._first.FillList(combobox);
                    _myPl._first.FillList(combobox);
                    break;
                case 2:
                    _myPl._second.FillList(combobox);
                    break;
                case 3:
                    _myPs._third.FillList(combobox);
                    _myPl._third.FillList(combobox);
                    break;
                case 4:
                    _myPs._fourth.FillList(combobox);
                    _myPl._fourth.FillList(combobox);
                    break;
                case 5:
                    _myPs._fifth.FillList(combobox);
                    _myPl._fifth.FillList(combobox);
                    break;
                case 6:
                    _myPs._sixth.FillList(combobox);
                    //_myPl._sixth.FillList(combobox);
                    break;
                //case 7:
                //    _myPs._seventh.FillList(combobox);
                //    break;                    
            }
        }
        public static void ReloadCompIndex(ComboBox _control, int _index, string _text, int _palette)
        {
            switch (_palette)
            {                
                case 9:
                    _myPs._ninth.FillList(_control, _index, _text);
                    break;
            }
        }
    }
}