﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landriesnidis.LCL_Controls.Controls.Comm
{
    public class StateColorSet
    {
        [Browsable(true)]
        public Color MouseMoveForegroundColor { get; set; } = Color.White;
        [Browsable(true)]
        public Color MouseMoveBackgroundColor { get; set; } = Color.FromArgb(82, 176, 239);
        [Browsable(true)]
        public Color MouseLeaveForegroundColor { get; set; } = Color.White;
        [Browsable(true)]
        public Color MouseLeaveBackgroundColor { get; set; } = Color.FromArgb(0, 122, 204);
        [Browsable(true)]
        public Color MouseDownForegroundColor { get; set; } = Color.White;
        [Browsable(true)]
        public Color MouseDownBackgroundColor { get; set; } = Color.FromArgb(14, 97, 152);
        [Browsable(true)]
        public Color LostFocusForegroundColor { get; set; } = Color.FromArgb(30, 30, 30);
        [Browsable(true)]
        public Color LostFocusBackgroundColor { get; set; } = Color.FromArgb(251, 251, 251);
    }
}
