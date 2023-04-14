using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Collections;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;

namespace Lab02
{
    public partial class Bai4 : Form
    {
        private int index = 0;
        public Bai4()
        {
            InitializeComponent();
        }
        [Serializable]
        class Student
        {
            string Name;
            string ID;
            string Phone;
            float course1;
            float course2;
            float course3;
            float avg;
            public string getName()
            {
                return (this.Name);
            }
            public string getID()
            {
               return (this.ID);
            }
            public string getPhone()
            { return (this.Phone); }
            public float getCourse1()
            { return (this.course1); }
            public float getCourse2()
            { return (this.course2); }
            public float getCourse3()
            { return (this.course3); }
            public double computeAVG()
            {
                return Math.Round(((this.course1 + this.course2 + this.course3)/3), 2);
            }
            public bool IsNumber(string str)
            {
                foreach (Char c in str)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
            public Student (string Name, string ID, string Phone, float course1, float course2, float course3)
            {
                this.Name = Name;
                if (!IsNumber(ID)) MessageBox.Show("ID sinh viên phải là số");
                else if (ID.Length != 8) MessageBox.Show("ID sinh viên phải có 8 chữ số");
                else this.ID = ID;
                if (!IsNumber(Phone)) MessageBox.Show("SDT phải là số");
                else if (Phone[0] != '0') MessageBox.Show("SDT phải bắt đầu bởi số 0");
                else if (Phone.Length != 10) MessageBox.Show("SDT phải có 10 số");
                else this.Phone = Phone;
                if (course1 < 0 || course1 > 10) MessageBox.Show("Điểm Course 1 phải là số từ 1 đến 10");
                else this.course1 = course1;
                if (course2 < 0 || course2 > 10) MessageBox.Show("Điểm Course 2 phải là số từ 1 đến 10");
                else this.course2 = course2;
                if (course3 < 0 || course3 > 10) MessageBox.Show("Điểm Course 3 phải là số từ 1 đến 10");
                else this.course3 = course3;
            }
        }
        private List<Student> students = new List<Student>();
        private void bt_write_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                binaryFormatter.Serialize(fs, students);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(txt_view.Text);
                sw.Flush();
                fs.Close();
            }
            catch  
            {
                MessageBox.Show("Ghi File Thất Bại!");
            }  
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_namewrite.Text;
                string ID = txt_idwrite.Text;
                string phone = txt_phonewrite.Text;
                float course1 = float.Parse(txt_c1write.Text);
                float course2 = float.Parse(txt_c2write.Text);
                float course3 = float.Parse(txt_c3write.Text);

                students.Add(new Student(name, ID, phone, course1, course2, course3));
                txt_namewrite.Clear();
                txt_idwrite.Clear();
                txt_phonewrite.Clear();
                txt_c1write.Clear();
                txt_c2write.Clear();
                txt_c3write.Clear();
            }catch
            {
                MessageBox.Show("Thêm Sinh Viên thất bại!");
            }
        }

        private void bt_read_Click(object sender, EventArgs e)
        {
            try 
            { 
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    List<Student> studentList = binaryFormatter.Deserialize(fs) as List<Student>;

                    if (studentList != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (Student data in studentList)
                        {
                            sb.AppendLine($"{data.getName()}{Environment.NewLine}{data.getID()}{Environment.NewLine}{data.getPhone()}{Environment.NewLine}{data.getCourse1()}{Environment.NewLine}{data.getCourse2()}{Environment.NewLine}{data.getCourse3()}{Environment.NewLine}{data.computeAVG()}{Environment.NewLine}");
                        }
                        txt_view.Text = sb.ToString();
                    }
                    txt_nameread.Text = studentList[index].getName();
                    txt_phoneread.Text = studentList[index].getPhone();
                    txt_idread.Text = studentList[index].getID();
                    txt_c1read.Text = studentList[index].getCourse1().ToString();
                    txt_c2read.Text = studentList[index].getCourse2().ToString();
                    txt_c3read.Text = studentList[index].getCourse3().ToString();
                    txt_avg.Text = studentList[index].computeAVG().ToString();
                    fs.Close();
                }
            
            }catch
            {
                MessageBox.Show("Đọc File thất bại!");
            }
        }

        private void bt_prev_Click(object sender, EventArgs e)
        {
            try
            {
                index--;
                txt_nameread.Text = students[index].getName();
                txt_phoneread.Text = students[index].getPhone();
                txt_idread.Text = students[index].getID();
                txt_c1read.Text = students[index].getCourse1().ToString();
                txt_c2read.Text = students[index].getCourse2().ToString();
                txt_c3read.Text = students[index].getCourse3().ToString();
                txt_avg.Text = students[index].computeAVG().ToString();
            }
            catch
            {
                MessageBox.Show("Không thể lùi!");
            }
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            try
            {
                index++;
                txt_nameread.Text = students[index].getName();
                txt_phoneread.Text = students[index].getPhone();
                txt_idread.Text = students[index].getID();
                txt_c1read.Text = students[index].getCourse1().ToString();
                txt_c2read.Text = students[index].getCourse2().ToString();
                txt_c3read.Text = students[index].getCourse3().ToString();
                txt_avg.Text = students[index].computeAVG().ToString();
            }
            catch
            {
                MessageBox.Show("Không thể tiến!");
            }
        }
    }
}
