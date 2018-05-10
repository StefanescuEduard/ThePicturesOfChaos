using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ThePicturesOfChaos
{
    internal class CustomColorDialog : ColorDialog
    {
        [DllImport("user32.dll")]
        private static extern bool SetWindowText(IntPtr hWnd, string lpString);
        private string _title;
        private bool _titleSet;

        public CustomColorDialog()
        {
            Title = string.Empty;
            _titleSet = false;
        }

        public string Title
        {
            get => _title;
            set
            {
                if (value != null && value != _title)
                {
                    _title = value;
                    _titleSet = false;
                }
            }
        }

        protected override IntPtr HookProc(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam)
        {
            if (!_titleSet)
            {
                SetWindowText(hWnd, _title);
                _titleSet = true;
            }

            return base.HookProc(hWnd, msg, wparam, lparam);
        }
    }
}
