namespace MyRestaurantApp;

partial class FrmPayment
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
        lbTotal = new Label();
        txtCash = new TextBox();
        label1 = new Label();
        label2 = new Label();
        txtCC = new TextBox();
        btnMakeThePayment = new Button();
        label3 = new Label();
        txtCCOwner = new TextBox();
        label4 = new Label();
        txtCCNumber1 = new TextBox();
        txtCCNumber2 = new TextBox();
        txtCCNumber3 = new TextBox();
        txtCCNumber4 = new TextBox();
        label5 = new Label();
        txtExpireMonth = new TextBox();
        txtExpireYear = new TextBox();
        label6 = new Label();
        txtCVC = new TextBox();
        gbCC = new GroupBox();
        cbCC = new CheckBox();
        gbCC.SuspendLayout();
        SuspendLayout();
        // 
        // lbTotal
        // 
        lbTotal.BackColor = Color.IndianRed;
        lbTotal.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
        lbTotal.ForeColor = Color.White;
        lbTotal.Location = new Point(18, 9);
        lbTotal.Name = "lbTotal";
        lbTotal.Size = new Size(353, 63);
        lbTotal.TabIndex = 2;
        lbTotal.Text = "100,00₺";
        lbTotal.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtCash
        // 
        txtCash.Location = new Point(18, 128);
        txtCash.Name = "txtCash";
        txtCash.Size = new Size(353, 32);
        txtCash.TabIndex = 3;
        txtCash.Text = "0";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(24, 91);
        label1.Name = "label1";
        label1.Size = new Size(56, 23);
        label1.TabIndex = 4;
        label1.Text = "Nakit";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(15, 270);
        label2.Name = "label2";
        label2.Size = new Size(54, 23);
        label2.TabIndex = 5;
        label2.Text = "Tutar";
        // 
        // txtCC
        // 
        txtCC.Location = new Point(15, 296);
        txtCC.Name = "txtCC";
        txtCC.Size = new Size(325, 32);
        txtCC.TabIndex = 6;
        txtCC.Text = "0";
        // 
        // btnMakeThePayment
        // 
        btnMakeThePayment.Location = new Point(12, 194);
        btnMakeThePayment.Name = "btnMakeThePayment";
        btnMakeThePayment.Size = new Size(353, 44);
        btnMakeThePayment.TabIndex = 7;
        btnMakeThePayment.Text = "Ödeme yap";
        btnMakeThePayment.UseVisualStyleBackColor = true;
        btnMakeThePayment.Click += btnMakeThePayment_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 42);
        label3.Name = "label3";
        label3.Size = new Size(138, 23);
        label3.TabIndex = 8;
        label3.Text = "Kart Sahibi Adı";
        // 
        // txtCCOwner
        // 
        txtCCOwner.Location = new Point(15, 68);
        txtCCOwner.Name = "txtCCOwner";
        txtCCOwner.Size = new Size(338, 32);
        txtCCOwner.TabIndex = 9;
        txtCCOwner.Text = "John Doe";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 102);
        label4.Name = "label4";
        label4.Size = new Size(133, 23);
        label4.TabIndex = 10;
        label4.Text = "Kart Numarası";
        // 
        // txtCCNumber1
        // 
        txtCCNumber1.Location = new Point(15, 128);
        txtCCNumber1.Name = "txtCCNumber1";
        txtCCNumber1.Size = new Size(82, 32);
        txtCCNumber1.TabIndex = 11;
        txtCCNumber1.Text = "5528";
        // 
        // txtCCNumber2
        // 
        txtCCNumber2.Location = new Point(103, 128);
        txtCCNumber2.Name = "txtCCNumber2";
        txtCCNumber2.Size = new Size(81, 32);
        txtCCNumber2.TabIndex = 12;
        txtCCNumber2.Text = "7900";
        // 
        // txtCCNumber3
        // 
        txtCCNumber3.Location = new Point(190, 128);
        txtCCNumber3.Name = "txtCCNumber3";
        txtCCNumber3.Size = new Size(77, 32);
        txtCCNumber3.TabIndex = 13;
        txtCCNumber3.Text = "0000";
        // 
        // txtCCNumber4
        // 
        txtCCNumber4.Location = new Point(273, 128);
        txtCCNumber4.Name = "txtCCNumber4";
        txtCCNumber4.Size = new Size(80, 32);
        txtCCNumber4.TabIndex = 14;
        txtCCNumber4.Text = "0008";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(6, 181);
        label5.Name = "label5";
        label5.Size = new Size(138, 23);
        label5.TabIndex = 15;
        label5.Text = "Son Kul. Tarihi";
        // 
        // txtExpireMonth
        // 
        txtExpireMonth.Location = new Point(15, 207);
        txtExpireMonth.Name = "txtExpireMonth";
        txtExpireMonth.Size = new Size(55, 32);
        txtExpireMonth.TabIndex = 16;
        txtExpireMonth.Text = "12";
        // 
        // txtExpireYear
        // 
        txtExpireYear.Location = new Point(76, 207);
        txtExpireYear.Name = "txtExpireYear";
        txtExpireYear.Size = new Size(55, 32);
        txtExpireYear.TabIndex = 17;
        txtExpireYear.Text = "2030";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(197, 181);
        label6.Name = "label6";
        label6.Size = new Size(53, 23);
        label6.TabIndex = 18;
        label6.Text = "CCV";
        // 
        // txtCVC
        // 
        txtCVC.Location = new Point(197, 207);
        txtCVC.Name = "txtCVC";
        txtCVC.Size = new Size(55, 32);
        txtCVC.TabIndex = 19;
        txtCVC.Text = "123";
        // 
        // gbCC
        // 
        gbCC.Controls.Add(label3);
        gbCC.Controls.Add(label6);
        gbCC.Controls.Add(txtCVC);
        gbCC.Controls.Add(label4);
        gbCC.Controls.Add(txtCC);
        gbCC.Controls.Add(label5);
        gbCC.Controls.Add(txtCCOwner);
        gbCC.Controls.Add(txtCCNumber4);
        gbCC.Controls.Add(label2);
        gbCC.Controls.Add(txtExpireMonth);
        gbCC.Controls.Add(txtExpireYear);
        gbCC.Controls.Add(txtCCNumber3);
        gbCC.Controls.Add(txtCCNumber2);
        gbCC.Controls.Add(txtCCNumber1);
        gbCC.Location = new Point(12, 244);
        gbCC.Name = "gbCC";
        gbCC.Size = new Size(359, 350);
        gbCC.TabIndex = 20;
        gbCC.TabStop = false;
        gbCC.Text = "Kredi Kartı";
        gbCC.Visible = false;
        // 
        // cbCC
        // 
        cbCC.AutoSize = true;
        cbCC.Location = new Point(18, 166);
        cbCC.Name = "cbCC";
        cbCC.Size = new Size(154, 27);
        cbCC.TabIndex = 21;
        cbCC.Text = "K.K İle Ödeme";
        cbCC.UseVisualStyleBackColor = true;
        cbCC.CheckedChanged += cbCC_CheckedChanged;
        // 
        // FrmPayment
        // 
        AutoScaleDimensions = new SizeF(12F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(393, 634);
        Controls.Add(cbCC);
        Controls.Add(btnMakeThePayment);
        Controls.Add(label1);
        Controls.Add(txtCash);
        Controls.Add(lbTotal);
        Controls.Add(gbCC);
        Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5);
        Name = "FrmPayment";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmPayment";
        gbCC.ResumeLayout(false);
        gbCC.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbTotal;
    private TextBox txtCash;
    private Label label1;
    private Label label2;
    private TextBox txtCC;
    private Button btnMakeThePayment;
    private Label label3;
    private TextBox txtCCOwner;
    private Label label4;
    private TextBox txtCCNumber1;
    private TextBox txtCCNumber2;
    private TextBox txtCCNumber3;
    private TextBox txtCCNumber4;
    private Label label5;
    private TextBox txtExpireMonth;
    private TextBox txtExpireYear;
    private Label label6;
    private TextBox txtCVC;
    private GroupBox gbCC;
    private CheckBox cbCC;
}