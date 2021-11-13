namespace Start_Up_Group.Views
{
    partial class FormDistribute
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFirstProduct = new System.Windows.Forms.ComboBox();
            this.cbxSecondProduct = new System.Windows.Forms.ComboBox();
            this.cbxFifthProduct = new System.Windows.Forms.ComboBox();
            this.cbxThirdProduct = new System.Windows.Forms.ComboBox();
            this.cbxFourthProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFPAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSPAmount = new System.Windows.Forms.TextBox();
            this.txtTPAmount = new System.Windows.Forms.TextBox();
            this.txtFoP = new System.Windows.Forms.TextBox();
            this.txtFiP = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 95);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(442, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 38);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a branch ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxFirstProduct
            // 
            this.cbxFirstProduct.Enabled = false;
            this.cbxFirstProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxFirstProduct.FormattingEnabled = true;
            this.cbxFirstProduct.Location = new System.Drawing.Point(194, 146);
            this.cbxFirstProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFirstProduct.Name = "cbxFirstProduct";
            this.cbxFirstProduct.Size = new System.Drawing.Size(423, 38);
            this.cbxFirstProduct.TabIndex = 1;
            this.cbxFirstProduct.SelectedIndexChanged += new System.EventHandler(this.cbxFirstProduct_SelectedIndexChanged);
            // 
            // cbxSecondProduct
            // 
            this.cbxSecondProduct.Enabled = false;
            this.cbxSecondProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxSecondProduct.FormattingEnabled = true;
            this.cbxSecondProduct.Location = new System.Drawing.Point(194, 205);
            this.cbxSecondProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSecondProduct.Name = "cbxSecondProduct";
            this.cbxSecondProduct.Size = new System.Drawing.Size(423, 38);
            this.cbxSecondProduct.TabIndex = 1;
            // 
            // cbxFifthProduct
            // 
            this.cbxFifthProduct.Enabled = false;
            this.cbxFifthProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxFifthProduct.FormattingEnabled = true;
            this.cbxFifthProduct.Location = new System.Drawing.Point(194, 377);
            this.cbxFifthProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFifthProduct.Name = "cbxFifthProduct";
            this.cbxFifthProduct.Size = new System.Drawing.Size(423, 38);
            this.cbxFifthProduct.TabIndex = 1;
            // 
            // cbxThirdProduct
            // 
            this.cbxThirdProduct.Enabled = false;
            this.cbxThirdProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxThirdProduct.FormattingEnabled = true;
            this.cbxThirdProduct.Location = new System.Drawing.Point(194, 264);
            this.cbxThirdProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxThirdProduct.Name = "cbxThirdProduct";
            this.cbxThirdProduct.Size = new System.Drawing.Size(423, 38);
            this.cbxThirdProduct.TabIndex = 1;
            // 
            // cbxFourthProduct
            // 
            this.cbxFourthProduct.Enabled = false;
            this.cbxFourthProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxFourthProduct.FormattingEnabled = true;
            this.cbxFourthProduct.Location = new System.Drawing.Point(194, 322);
            this.cbxFourthProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFourthProduct.Name = "cbxFourthProduct";
            this.cbxFourthProduct.Size = new System.Drawing.Size(423, 38);
            this.cbxFourthProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name :";
            // 
            // txtFPAmount
            // 
            this.txtFPAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFPAmount.Enabled = false;
            this.txtFPAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFPAmount.Location = new System.Drawing.Point(647, 146);
            this.txtFPAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFPAmount.Name = "txtFPAmount";
            this.txtFPAmount.Size = new System.Drawing.Size(109, 35);
            this.txtFPAmount.TabIndex = 3;
            this.txtFPAmount.TextChanged += new System.EventHandler(this.txtFPAmount_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(647, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount :";
            // 
            // txtSPAmount
            // 
            this.txtSPAmount.Enabled = false;
            this.txtSPAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSPAmount.Location = new System.Drawing.Point(647, 205);
            this.txtSPAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSPAmount.Name = "txtSPAmount";
            this.txtSPAmount.Size = new System.Drawing.Size(109, 35);
            this.txtSPAmount.TabIndex = 3;
            // 
            // txtTPAmount
            // 
            this.txtTPAmount.Enabled = false;
            this.txtTPAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTPAmount.Location = new System.Drawing.Point(647, 264);
            this.txtTPAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTPAmount.Name = "txtTPAmount";
            this.txtTPAmount.Size = new System.Drawing.Size(109, 35);
            this.txtTPAmount.TabIndex = 3;
            // 
            // txtFoP
            // 
            this.txtFoP.Enabled = false;
            this.txtFoP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFoP.Location = new System.Drawing.Point(647, 322);
            this.txtFoP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFoP.Name = "txtFoP";
            this.txtFoP.Size = new System.Drawing.Size(109, 35);
            this.txtFoP.TabIndex = 3;
            // 
            // txtFiP
            // 
            this.txtFiP.Enabled = false;
            this.txtFiP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiP.Location = new System.Drawing.Point(647, 377);
            this.txtFiP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiP.Name = "txtFiP";
            this.txtFiP.Size = new System.Drawing.Size(109, 35);
            this.txtFiP.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(108, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSend.Location = new System.Drawing.Point(16, 7);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 31);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send ";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(428, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 53);
            this.panel2.TabIndex = 6;
            // 
            // FormDistribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1077, 344);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFiP);
            this.Controls.Add(this.txtFoP);
            this.Controls.Add(this.txtTPAmount);
            this.Controls.Add(this.txtSPAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFPAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFourthProduct);
            this.Controls.Add(this.cbxThirdProduct);
            this.Controls.Add(this.cbxFifthProduct);
            this.Controls.Add(this.cbxSecondProduct);
            this.Controls.Add(this.cbxFirstProduct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDistribute";
            this.Text = "FormDistribute";
            this.Load += new System.EventHandler(this.FormDistribute_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFirstProduct;
        private System.Windows.Forms.ComboBox cbxSecondProduct;
        private System.Windows.Forms.ComboBox cbxFifthProduct;
        private System.Windows.Forms.ComboBox cbxThirdProduct;
        private System.Windows.Forms.ComboBox cbxFourthProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFPAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSPAmount;
        private System.Windows.Forms.TextBox txtTPAmount;
        private System.Windows.Forms.TextBox txtFoP;
        private System.Windows.Forms.TextBox txtFiP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel2;
    }
}