using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void bt_read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                txt_view.Text = sr.ReadToEnd();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Đọc File Thất Bại!");
            }
        }

        private void br_write_Click(object sender, EventArgs e)
        {
            try
            {
                string[] expressions = txt_view.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string value = "";
                double result = 0;
                foreach (string expression in expressions)
                {
                    result = Math.Round(evaluate(expression),2);
                    value += expression + " = " + result.ToString() + Environment.NewLine;
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(value);
                sw.Flush();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Ghi File Thất Bại!");
            }
        }
        public static int precedence(char op)
        {
            if (op == '+' || op == '-')
                return 1;
            if (op == '*' || op == '/')
                return 2;
            return 0;
        }
        public static double applyOp(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
            }
            return 0;
        }

        public static double evaluate(string tokens)
        {
            int i;

            Stack<double> values = new Stack<double>();

            Stack<char> ops = new Stack<char>();

            for (i = 0; i < tokens.Length; i++)
            {

                if (tokens[i] == ' ')
                    continue;

                else if (tokens[i] == '(')
                {
                    ops.Push(tokens[i]);
                }
                else if (Char.IsDigit(tokens[i]))
                {
                    int val = 0;

                    while (i < tokens.Length && Char.IsDigit(tokens[i]))
                    {
                        val = (val * 10) + (tokens[i] - '0');
                        i++;
                    }

                    values.Push(val);
                    i--;    
                }
                else if (tokens[i] == ')')
                {
                    while (ops.Count != 0 && values.Count >= 2 && ops.Peek() != '(')
                    {
                        double val2 = values.Pop();
                        double val1 = values.Pop();
                        char op = ops.Pop();
                        values.Push(applyOp(val1, val2, op));
                    }
                    if (ops.Count != 0 && ops.Peek() == '(')
                        ops.Pop();
                    else
                        throw new Exception("Thiếu dấu mở ngoặc");
                }
                else
                {
                    while (ops.Count != 0 && values.Count >= 2 && precedence(ops.Peek()) >= precedence(tokens[i]))
                    {
                        double val2 = values.Pop();
                        double val1 = values.Pop();
                        char op = ops.Pop();
                        values.Push(applyOp(val1, val2, op));
                    }
                    ops.Push(tokens[i]);
                }
            }
            while (ops.Count != 0 && values.Count >= 2)
            {
                double val2 = values.Pop();
                double val1 = values.Pop();
                char op = ops.Pop();
                values.Push(applyOp(val1, val2, op));
            }

            if (values.Count != 1)
                throw new Exception("Biểu thức không hợp lệ");
            else
                return values.Pop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
