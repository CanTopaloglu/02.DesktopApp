namespace MyRestaurantApp;

partial class frmProductVariants
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lstMenu = new ListBox();
        SuspendLayout();
        // 
        // lstMenu
        // 
        lstMenu.FormattingEnabled = true;
        lstMenu.ItemHeight = 30;
        lstMenu.Location = new Point(12, 21);
        lstMenu.Name = "lstMenu";
        lstMenu.Size = new Size(305, 334);
        lstMenu.TabIndex = 0;
        lstMenu.MouseDoubleClick += lstMenu_MouseDoubleClick;
        // 
        // frmProductVariants
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(325, 365);
        Controls.Add(lstMenu);
        Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5, 6, 5, 6);
        Name = "frmProductVariants";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ürün Varyantları";
        FormClosed += frmProductVariants_FormClosed;
        ResumeLayout(false);
    }

    #endregion

    private ListBox lstMenu;
}