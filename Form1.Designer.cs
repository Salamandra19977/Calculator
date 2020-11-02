namespace Сalculator
{
    partial class Index
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.numberOneBtn = new System.Windows.Forms.Button();
            this.numberTwoBtn = new System.Windows.Forms.Button();
            this.numberThreeBtn = new System.Windows.Forms.Button();
            this.numberSixBtn = new System.Windows.Forms.Button();
            this.numberFiveBtn = new System.Windows.Forms.Button();
            this.numberFourBtn = new System.Windows.Forms.Button();
            this.numberNineBtn = new System.Windows.Forms.Button();
            this.numberEightBtn = new System.Windows.Forms.Button();
            this.numberSevenBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.nuberNilBtn = new System.Windows.Forms.Button();
            this.separatorBtn = new System.Windows.Forms.Button();
            this.equallyBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.splitBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.prewNumber = new System.Windows.Forms.Label();
            this.arithmeticBlock = new System.Windows.Forms.Panel();
            this.arithmeticBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(13, 38);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(274, 29);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // numberOneBtn
            // 
            this.numberOneBtn.Location = new System.Drawing.Point(13, 129);
            this.numberOneBtn.Name = "numberOneBtn";
            this.numberOneBtn.Size = new System.Drawing.Size(50, 50);
            this.numberOneBtn.TabIndex = 1;
            this.numberOneBtn.Text = "1";
            this.numberOneBtn.UseVisualStyleBackColor = true;
            this.numberOneBtn.Click += new System.EventHandler(this.NumberOneBtn_Click);
            // 
            // numberTwoBtn
            // 
            this.numberTwoBtn.Location = new System.Drawing.Point(69, 129);
            this.numberTwoBtn.Name = "numberTwoBtn";
            this.numberTwoBtn.Size = new System.Drawing.Size(50, 50);
            this.numberTwoBtn.TabIndex = 2;
            this.numberTwoBtn.Text = "2";
            this.numberTwoBtn.UseVisualStyleBackColor = true;
            this.numberTwoBtn.Click += new System.EventHandler(this.NumberTwoBtn_Click);
            // 
            // numberThreeBtn
            // 
            this.numberThreeBtn.Location = new System.Drawing.Point(125, 129);
            this.numberThreeBtn.Name = "numberThreeBtn";
            this.numberThreeBtn.Size = new System.Drawing.Size(50, 50);
            this.numberThreeBtn.TabIndex = 3;
            this.numberThreeBtn.Text = "3";
            this.numberThreeBtn.UseVisualStyleBackColor = true;
            this.numberThreeBtn.Click += new System.EventHandler(this.NumberThreeBtn_Click);
            // 
            // numberSixBtn
            // 
            this.numberSixBtn.Location = new System.Drawing.Point(125, 185);
            this.numberSixBtn.Name = "numberSixBtn";
            this.numberSixBtn.Size = new System.Drawing.Size(50, 50);
            this.numberSixBtn.TabIndex = 6;
            this.numberSixBtn.Text = "6";
            this.numberSixBtn.UseVisualStyleBackColor = true;
            this.numberSixBtn.Click += new System.EventHandler(this.NumberSixBtn_Click);
            // 
            // numberFiveBtn
            // 
            this.numberFiveBtn.Location = new System.Drawing.Point(69, 185);
            this.numberFiveBtn.Name = "numberFiveBtn";
            this.numberFiveBtn.Size = new System.Drawing.Size(50, 50);
            this.numberFiveBtn.TabIndex = 5;
            this.numberFiveBtn.Text = "5";
            this.numberFiveBtn.UseVisualStyleBackColor = true;
            this.numberFiveBtn.Click += new System.EventHandler(this.NumberFiveBtn_Click);
            // 
            // numberFourBtn
            // 
            this.numberFourBtn.Location = new System.Drawing.Point(13, 186);
            this.numberFourBtn.Name = "numberFourBtn";
            this.numberFourBtn.Size = new System.Drawing.Size(50, 50);
            this.numberFourBtn.TabIndex = 4;
            this.numberFourBtn.Text = "4";
            this.numberFourBtn.UseVisualStyleBackColor = true;
            this.numberFourBtn.Click += new System.EventHandler(this.NumberFourBtn_Click);
            // 
            // numberNineBtn
            // 
            this.numberNineBtn.Location = new System.Drawing.Point(125, 241);
            this.numberNineBtn.Name = "numberNineBtn";
            this.numberNineBtn.Size = new System.Drawing.Size(50, 50);
            this.numberNineBtn.TabIndex = 9;
            this.numberNineBtn.Text = "9";
            this.numberNineBtn.UseVisualStyleBackColor = true;
            this.numberNineBtn.Click += new System.EventHandler(this.NumberNineBtn_Click);
            // 
            // numberEightBtn
            // 
            this.numberEightBtn.Location = new System.Drawing.Point(69, 241);
            this.numberEightBtn.Name = "numberEightBtn";
            this.numberEightBtn.Size = new System.Drawing.Size(50, 50);
            this.numberEightBtn.TabIndex = 8;
            this.numberEightBtn.Text = "8";
            this.numberEightBtn.UseVisualStyleBackColor = true;
            this.numberEightBtn.Click += new System.EventHandler(this.NumberEightBtn_Click);
            // 
            // numberSevenBtn
            // 
            this.numberSevenBtn.Location = new System.Drawing.Point(13, 242);
            this.numberSevenBtn.Name = "numberSevenBtn";
            this.numberSevenBtn.Size = new System.Drawing.Size(50, 50);
            this.numberSevenBtn.TabIndex = 7;
            this.numberSevenBtn.Text = "7";
            this.numberSevenBtn.UseVisualStyleBackColor = true;
            this.numberSevenBtn.Click += new System.EventHandler(this.NumberSevenBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Location = new System.Drawing.Point(13, 73);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(106, 50);
            this.clearAllBtn.TabIndex = 12;
            this.clearAllBtn.Text = "CE";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(125, 73);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(50, 50);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "←";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // nuberNilBtn
            // 
            this.nuberNilBtn.Location = new System.Drawing.Point(13, 298);
            this.nuberNilBtn.Name = "nuberNilBtn";
            this.nuberNilBtn.Size = new System.Drawing.Size(106, 50);
            this.nuberNilBtn.TabIndex = 10;
            this.nuberNilBtn.Text = "0";
            this.nuberNilBtn.UseVisualStyleBackColor = true;
            this.nuberNilBtn.Click += new System.EventHandler(this.NuberNilBtn_Click);
            // 
            // separatorBtn
            // 
            this.separatorBtn.Location = new System.Drawing.Point(125, 298);
            this.separatorBtn.Name = "separatorBtn";
            this.separatorBtn.Size = new System.Drawing.Size(50, 50);
            this.separatorBtn.TabIndex = 13;
            this.separatorBtn.Text = ",";
            this.separatorBtn.UseVisualStyleBackColor = true;
            this.separatorBtn.Click += new System.EventHandler(this.SeparatorBtn_Click);
            // 
            // equallyBtn
            // 
            this.equallyBtn.Location = new System.Drawing.Point(0, 116);
            this.equallyBtn.Name = "equallyBtn";
            this.equallyBtn.Size = new System.Drawing.Size(50, 50);
            this.equallyBtn.TabIndex = 18;
            this.equallyBtn.Text = "=";
            this.equallyBtn.UseVisualStyleBackColor = true;
            this.equallyBtn.Click += new System.EventHandler(this.EquallyBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(0, 3);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(104, 50);
            this.plusBtn.TabIndex = 17;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // splitBtn
            // 
            this.splitBtn.Location = new System.Drawing.Point(54, 116);
            this.splitBtn.Name = "splitBtn";
            this.splitBtn.Size = new System.Drawing.Size(50, 50);
            this.splitBtn.TabIndex = 16;
            this.splitBtn.Text = "/";
            this.splitBtn.UseVisualStyleBackColor = true;
            this.splitBtn.Click += new System.EventHandler(this.SplitBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(0, 60);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(104, 50);
            this.multiplyBtn.TabIndex = 15;
            this.multiplyBtn.Text = "*";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(181, 298);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(104, 50);
            this.minusBtn.TabIndex = 14;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Location = new System.Drawing.Point(180, 73);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(107, 50);
            this.historyBtn.TabIndex = 19;
            this.historyBtn.Text = "история";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // prewNumber
            // 
            this.prewNumber.AutoSize = true;
            this.prewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prewNumber.Location = new System.Drawing.Point(12, 9);
            this.prewNumber.Name = "prewNumber";
            this.prewNumber.Size = new System.Drawing.Size(0, 16);
            this.prewNumber.TabIndex = 21;
            // 
            // arithmeticBlock
            // 
            this.arithmeticBlock.Controls.Add(this.multiplyBtn);
            this.arithmeticBlock.Controls.Add(this.splitBtn);
            this.arithmeticBlock.Controls.Add(this.plusBtn);
            this.arithmeticBlock.Controls.Add(this.equallyBtn);
            this.arithmeticBlock.Enabled = false;
            this.arithmeticBlock.Location = new System.Drawing.Point(181, 126);
            this.arithmeticBlock.Name = "arithmeticBlock";
            this.arithmeticBlock.Size = new System.Drawing.Size(107, 175);
            this.arithmeticBlock.TabIndex = 22;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 352);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.arithmeticBlock);
            this.Controls.Add(this.prewNumber);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.separatorBtn);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.nuberNilBtn);
            this.Controls.Add(this.numberNineBtn);
            this.Controls.Add(this.numberEightBtn);
            this.Controls.Add(this.numberSevenBtn);
            this.Controls.Add(this.numberSixBtn);
            this.Controls.Add(this.numberFiveBtn);
            this.Controls.Add(this.numberFourBtn);
            this.Controls.Add(this.numberThreeBtn);
            this.Controls.Add(this.numberTwoBtn);
            this.Controls.Add(this.numberOneBtn);
            this.Controls.Add(this.inputTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Index";
            this.Text = "Калькулятор";
            this.arithmeticBlock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button numberOneBtn;
        private System.Windows.Forms.Button numberTwoBtn;
        private System.Windows.Forms.Button numberThreeBtn;
        private System.Windows.Forms.Button numberSixBtn;
        private System.Windows.Forms.Button numberFiveBtn;
        private System.Windows.Forms.Button numberFourBtn;
        private System.Windows.Forms.Button numberNineBtn;
        private System.Windows.Forms.Button numberEightBtn;
        private System.Windows.Forms.Button numberSevenBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button nuberNilBtn;
        private System.Windows.Forms.Button separatorBtn;
        private System.Windows.Forms.Button equallyBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button splitBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Label prewNumber;
        private System.Windows.Forms.Panel arithmeticBlock;
    }
}

