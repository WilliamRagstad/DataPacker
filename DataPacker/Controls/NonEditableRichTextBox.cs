﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPacker.Controls
{
    class NonEditableRichTextBox : RichTextBox
    {
        public NonEditableRichTextBox()
        {
            Selectable = true;
        }
        const int WM_SETFOCUS = 0x0007;
        const int WM_KILLFOCUS = 0x0008;

        ///<summary>
        /// Enables or disables selection highlight. 
        /// If you set `Selectable` to `false` then the selection highlight
        /// will be disabled.
        /// It's enabled by default.
        ///</summary>
        [DefaultValue(true)]
        public bool Selectable { get; set; }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SETFOCUS && !Selectable)
                m.Msg = WM_KILLFOCUS;

            base.WndProc(ref m);
        }
    }
}
