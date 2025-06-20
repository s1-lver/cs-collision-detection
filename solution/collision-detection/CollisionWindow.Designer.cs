﻿namespace collision_detection;

partial class CollisionWindow
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Collision Detection";
        KeyDown += CollisionWindow_KeyDown;
        KeyUp += CollisionWindow_KeyUp;

        this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.UserPaint |
                      ControlStyles.AllPaintingInWmPaint, 
                      true);
        this.UpdateStyles();
    }
}
