namespace MyRepeatDesktop;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnUpdate = new Button();
        btnSave = new Button();
        txtWork = new TextBox();
        lstTodos = new ListBox();
        label1 = new Label();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(12, 83);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(249, 41);
        btnUpdate.TabIndex = 0;
        btnUpdate.Text = "Güncelle";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(12, 83);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(249, 41);
        btnSave.TabIndex = 1;
        btnSave.Text = "Kaydet";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // txtWork
        // 
        txtWork.Location = new Point(12, 54);
        txtWork.Name = "txtWork";
        txtWork.Size = new Size(249, 23);
        txtWork.TabIndex = 2;
        // 
        // lstTodos
        // 
        lstTodos.FormattingEnabled = true;
        lstTodos.ItemHeight = 15;
        lstTodos.Location = new Point(12, 175);
        lstTodos.Name = "lstTodos";
        lstTodos.Size = new Size(249, 199);
        lstTodos.TabIndex = 3;
        lstTodos.MouseClick += lstTodos_MouseClick;
        lstTodos.MouseDoubleClick += lstTodos_MouseDoubleClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(96, 36);
        label1.Name = "label1";
        label1.Size = new Size(65, 15);
        label1.TabIndex = 4;
        label1.Text = "TO DO LIST";
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(12, 130);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(249, 39);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Vazgeç";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(273, 406);
        Controls.Add(btnCancel);
        Controls.Add(label1);
        Controls.Add(lstTodos);
        Controls.Add(txtWork);
        Controls.Add(btnSave);
        Controls.Add(btnUpdate);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnUpdate;
    private Button btnSave;
    private TextBox txtWork;
    private ListBox lstTodos;
    private Label label1;
    private Button btnCancel;
}
