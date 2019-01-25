using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotepad.MenuStripForms
{
    class MenuItem
    {
        private MainForm _parent;

        public MenuItem(MainForm mainForm)
        {
            this._parent = mainForm;
        }

        protected MainForm MainForm
        {
            get { return _parent; }
            private set { MainForm = _parent; }
        }
                
    }
}
