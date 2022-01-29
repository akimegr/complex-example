
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textX = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textZ = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.xym = new System.Windows.Forms.RadioButton();
            this.xyl = new System.Windows.Forms.RadioButton();
            this.xx = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yy = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.anss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(74, 54);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(100, 22);
            this.textX.TabIndex = 0;
            this.textX.Text = "5";
            this.textX.TextChanged += new System.EventHandler(this.textX_TextChanged);
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(74, 107);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(100, 22);
            this.textY.TabIndex = 1;
            this.textY.Text = "5";
            // 
            // textZ
            // 
            this.textZ.Location = new System.Drawing.Point(74, 163);
            this.textZ.Name = "textZ";
            this.textZ.Size = new System.Drawing.Size(100, 22);
            this.textZ.TabIndex = 2;
            this.textZ.Text = "5";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(13, 58);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 17);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(13, 107);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(21, 17);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y:";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(16, 163);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(21, 17);
            this.labelZ.TabIndex = 5;
            this.labelZ.Text = "Z:";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(89, 255);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(370, 22);
            this.textResult.TabIndex = 6;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // xym
            // 
            this.xym.AutoSize = true;
            this.xym.Location = new System.Drawing.Point(48, 19);
            this.xym.Name = "xym";
            this.xym.Size = new System.Drawing.Size(62, 21);
            this.xym.TabIndex = 7;
            this.xym.TabStop = true;
            this.xym.Text = "x/y>0";
            this.xym.UseVisualStyleBackColor = true;
            // 
            // xyl
            // 
            this.xyl.AutoSize = true;
            this.xyl.Location = new System.Drawing.Point(48, 72);
            this.xyl.Name = "xyl";
            this.xyl.Size = new System.Drawing.Size(62, 21);
            this.xyl.TabIndex = 8;
            this.xyl.TabStop = true;
            this.xyl.Text = "x/y<0";
            this.xyl.UseVisualStyleBackColor = true;
            // 
            // xx
            // 
            this.xx.AutoSize = true;
            this.xx.Location = new System.Drawing.Point(48, 114);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(51, 21);
            this.xx.TabIndex = 9;
            this.xx.TabStop = true;
            this.xx.Text = "x=0";
            this.xx.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yy);
            this.groupBox1.Controls.Add(this.xx);
            this.groupBox1.Controls.Add(this.xyl);
            this.groupBox1.Controls.Add(this.xym);
            this.groupBox1.Location = new System.Drawing.Point(331, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 185);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "U(x)";
            // 
            // yy
            // 
            this.yy.AutoSize = true;
            this.yy.Location = new System.Drawing.Point(48, 158);
            this.yy.Name = "yy";
            this.yy.Size = new System.Drawing.Size(52, 21);
            this.yy.TabIndex = 10;
            this.yy.TabStop = true;
            this.yy.Text = "y=0";
            this.yy.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(192, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Умножить на 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // anss
            // 
            this.anss.Location = new System.Drawing.Point(103, 206);
            this.anss.Multiline = true;
            this.anss.Name = "anss";
            this.anss.Size = new System.Drawing.Size(222, 22);
            this.anss.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Уравнение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anss);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textZ);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textZ;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.RadioButton xym;
        private System.Windows.Forms.RadioButton xyl;
        private System.Windows.Forms.RadioButton xx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton yy;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox anss;
        private System.Windows.Forms.Label label1;
    }
}

