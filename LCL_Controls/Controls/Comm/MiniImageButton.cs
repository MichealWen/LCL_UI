﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Comm
{
    public partial class MiniImageButton : UserControl
    {
        [Browsable(true)]
        public MiniImageButtonColor MiniImageButtonColor { get; set; } = new MiniImageButtonColor();

        private MiniImageButtonImage MiniImageButtonImage { get; set; } = new MiniImageButtonImage();

        [Bindable(true)]
        [Browsable(true)]
        [Localizable(true)]
        public Image Image { get { return BackgroundImage; } set { BackgroundImage = value; ComputingImage(); } }

        private bool isMouseDown = false;
        private bool isInSide = false;



        public MiniImageButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算出按钮所需的所有图像
        /// </summary>
        private void ComputingImage()
        {
            Bitmap bitmap = (Bitmap)Image;
            MiniImageButtonImage.MouseMoveImage = ChangeBitmapColor(bitmap, MiniImageButtonColor.MouseMoveForegroundColor, MiniImageButtonColor.MouseMoveBackgroundColor);
            MiniImageButtonImage.MouseDownImage = ChangeBitmapColor(bitmap, MiniImageButtonColor.MouseDownForegroundColor, MiniImageButtonColor.MouseDownBackgroundColor);
            MiniImageButtonImage.MouseLeaveImage = ChangeBitmapColor(bitmap, MiniImageButtonColor.MouseLeaveForegroundColor, MiniImageButtonColor.MouseLeaveBackgroundColor);
            MiniImageButtonImage.LostFocusImage = ChangeBitmapColor(bitmap, MiniImageButtonColor.LostFocusForegroundColor, MiniImageButtonColor.LostFocusBackgroundColor);
        }

        

        public Bitmap ChangeBitmapColor(Bitmap bmp, Color foregroundColor, Color backgroundColor)
        {
            // 获取长宽，创建一个新的Bitmap副本
            int w = bmp.Width;
            int h = bmp.Height;
            Bitmap newBmp = new Bitmap(w, h);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    // 透明的地方全是背景色，非透明的地方全是前景色
                    newBmp.SetPixel(x, y, (bmp.GetPixel(x, y).A == 0) ? backgroundColor : foregroundColor);
                }
            }
            return newBmp;
        }

        private void MiniImageButton_Load(object sender, EventArgs e)
        {
            BackgroundImage = MiniImageButtonImage.MouseLeaveImage;
        }

        private void MiniImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            BackgroundImage = MiniImageButtonImage.MouseDownImage;
        }

        private void MiniImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (isInSide)
            {
                BackgroundImage = MiniImageButtonImage.MouseMoveImage;
            }
            else
            {
                BackgroundImage = MiniImageButtonImage.MouseLeaveImage;
            }
        }

        private void MiniImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isInSide)
            {
                BackgroundImage = MiniImageButtonImage.MouseMoveImage;
            }
            isInSide = true;
        }

        private void MiniImageButton_MouseLeave(object sender, EventArgs e)
        {
            isInSide = false;
            BackgroundImage = MiniImageButtonImage.MouseLeaveImage;
        }
    }

    public class MiniImageButtonColor
    {
        [Browsable(true)]
        public Color MouseMoveForegroundColor { get; set; } = Color.White;
        [Browsable(true)]
        public Color MouseMoveBackgroundColor { get; set; } = Color.FromArgb(82, 176, 239);
        [Browsable(true)]
        public Color MouseLeaveForegroundColor { get; set; } = Color.White;
        [Browsable(true)]
        public Color MouseLeaveBackgroundColor { get; set; } = Color.FromArgb(0,122,204);
        [Browsable(true)]
        public Color MouseDownForegroundColor { get; set; } = Color.White;
        [Browsable(true)]
        public Color MouseDownBackgroundColor { get; set; } = Color.FromArgb(14,97,152);
        [Browsable(true)]
        public Color LostFocusForegroundColor { get; set; } = Color.FromArgb(30, 30, 30);
        [Browsable(true)]
        public Color LostFocusBackgroundColor { get; set; } = Color.FromArgb(251, 251, 251);
    }

    class MiniImageButtonImage
    {
        public Image MouseMoveImage { get; set; }
        public Image MouseLeaveImage { get; set; }
        public Image MouseDownImage { get; set; }
        public Image LostFocusImage { get; set; }
    }
}
