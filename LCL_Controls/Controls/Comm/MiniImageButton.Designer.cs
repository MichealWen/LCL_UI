﻿namespace Landriesnidis.LCL_Controls.Controls.Comm
{
    partial class MiniImageButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MiniImageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Close;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Name = "MiniImageButton";
            this.Size = new System.Drawing.Size(25, 25);
            this.Load += new System.EventHandler(this.MiniImageButton_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MiniImageButton_MouseDown);
            this.MouseLeave += new System.EventHandler(this.MiniImageButton_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MiniImageButton_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MiniImageButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
