namespace WindowsFormsApplication8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txBx = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txBxDescription = new System.Windows.Forms.TextBox();
            this.txBxPrice = new System.Windows.Forms.TextBox();
            this.txBxAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBxBrand = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(24, 31);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Просмотр";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // txBx
            // 
            this.txBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txBx.Location = new System.Drawing.Point(91, 70);
            this.txBx.Multiline = true;
            this.txBx.Name = "txBx";
            this.txBx.Size = new System.Drawing.Size(232, 20);
            this.txBx.TabIndex = 2;
            this.txBx.Text = "Зеркало заднего вида";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(154, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кол-во";
            // 
            // txBxDescription
            // 
            this.txBxDescription.Location = new System.Drawing.Point(91, 107);
            this.txBxDescription.Multiline = true;
            this.txBxDescription.Name = "txBxDescription";
            this.txBxDescription.Size = new System.Drawing.Size(232, 20);
            this.txBxDescription.TabIndex = 7;
            // 
            // txBxPrice
            // 
            this.txBxPrice.Location = new System.Drawing.Point(91, 178);
            this.txBxPrice.Name = "txBxPrice";
            this.txBxPrice.Size = new System.Drawing.Size(232, 20);
            this.txBxPrice.TabIndex = 8;
            // 
            // txBxAmount
            // 
            this.txBxAmount.Location = new System.Drawing.Point(91, 211);
            this.txBxAmount.Name = "txBxAmount";
            this.txBxAmount.Size = new System.Drawing.Size(232, 20);
            this.txBxAmount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Марка";
            // 
            // cmbBxBrand
            // 
            this.cmbBxBrand.FormattingEnabled = true;
            this.cmbBxBrand.Items.AddRange(new object[] {
            "BMW",
            "Lanos"});
            this.cmbBxBrand.Location = new System.Drawing.Point(91, 138);
            this.cmbBxBrand.Name = "cmbBxBrand";
            this.cmbBxBrand.Size = new System.Drawing.Size(232, 21);
            this.cmbBxBrand.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 294);
            this.Controls.Add(this.cmbBxBrand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txBxAmount);
            this.Controls.Add(this.txBxPrice);
            this.Controls.Add(this.txBxDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txBx;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txBxDescription;
        private System.Windows.Forms.TextBox txBxPrice;
        private System.Windows.Forms.TextBox txBxAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBxBrand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

