using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caculator;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double numberA = 0;
            double numberB = 0;
            numberA = Double.Parse(this.textBox_operandA.Text);
            numberB = Double.Parse(this.textBox_operandB.Text);
            Operation oper;
            int selected = this.listBox_operator.SelectedIndex;
            if (selected == -1)
            {
                MessageBox.Show("未选择运算类型！");
                return;
            }

            try
            {
                oper = OperationFactory.createOperate((OperatorType)selected);
                oper.NumberA = numberA;
                oper.NumberB = numberB;
                double result = oper.getResult();
                this.label_result.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
 



        }
    }
}
