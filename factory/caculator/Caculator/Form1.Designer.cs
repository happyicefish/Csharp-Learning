
namespace Caculator
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCaculate = new System.Windows.Forms.Button();
            this.textBox_operandA = new System.Windows.Forms.TextBox();
            this.textBox_operandB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_operator = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaculate
            // 
            this.btnCaculate.Location = new System.Drawing.Point(108, 311);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(115, 42);
            this.btnCaculate.TabIndex = 0;
            this.btnCaculate.Text = "计算";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // textBox_operandA
            // 
            this.textBox_operandA.Location = new System.Drawing.Point(123, 40);
            this.textBox_operandA.Name = "textBox_operandA";
            this.textBox_operandA.Size = new System.Drawing.Size(100, 25);
            this.textBox_operandA.TabIndex = 1;
            this.textBox_operandA.Text = "0";
            // 
            // textBox_operandB
            // 
            this.textBox_operandB.Location = new System.Drawing.Point(123, 104);
            this.textBox_operandB.Name = "textBox_operandB";
            this.textBox_operandB.Size = new System.Drawing.Size(100, 25);
            this.textBox_operandB.TabIndex = 2;
            this.textBox_operandB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "操作数A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "操作数B";
            // 
            // listBox_operator
            // 
            this.listBox_operator.FormattingEnabled = true;
            this.listBox_operator.ItemHeight = 15;
            this.listBox_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "×",
            "÷",
            "sqrt",
            "平方",
            "立方"});
            this.listBox_operator.Location = new System.Drawing.Point(123, 168);
            this.listBox_operator.Name = "listBox_operator";
            this.listBox_operator.Size = new System.Drawing.Size(100, 124);
            this.listBox_operator.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "运算";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(316, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "运算结果：";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result.Location = new System.Drawing.Point(494, 135);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(41, 43);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 383);
            this.Controls.Add(this.listBox_operator);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_operandB);
            this.Controls.Add(this.textBox_operandA);
            this.Controls.Add(this.btnCaculate);
            this.Name = "Form1";
            this.Text = "计算器（设计模式-简单工厂）";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaculate;
        private System.Windows.Forms.TextBox textBox_operandA;
        private System.Windows.Forms.TextBox textBox_operandB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_operator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_result;
    }
}

