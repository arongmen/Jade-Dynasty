using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace expeditor
{
    public partial class Form1 : Form
    {
        public string FileName;
        public int zx311 = 7988216;
        public int zx400 = 8811308;
        public int zx420 = 10058720;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog binaryFile = new OpenFileDialog())
            {
                if (binaryFile.ShowDialog() == DialogResult.OK || File.Exists(binaryFile.FileName))
                {
                    FileName = binaryFile.FileName;

                    using (BinaryReader br = new BinaryReader(new FileStream(FileName, FileMode.Open, FileAccess.Read)))
                    {
                        br.BaseStream.Seek(zx311, SeekOrigin.Begin);

                        Single exp = br.ReadSingle();
                        Single item = br.ReadSingle();
                        Single money = br.ReadSingle();
                        Single TaskSp = br.ReadSingle();
                        Single TaskExp = br.ReadSingle();
                        Single TaskMoney = br.ReadSingle();

                        textBox1.Text = exp.ToString();
                        textBox2.Text = item.ToString();
                        textBox3.Text = money.ToString();
                        textBox4.Text = TaskSp.ToString();
                        textBox5.Text = TaskExp.ToString();
                        textBox6.Text = TaskMoney.ToString();

                    }
                    MessageBox.Show("Ваше ядро успешно загружено. Будьте внимательны при сохранении!", "Информация");
                    label8.Text = "3.1.1";
                }
            }
        }

        private void х1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = "1";
            textBox1.Text = a;
            textBox2.Text = a;
            textBox3.Text = a;
            textBox4.Text = a;
            textBox5.Text = a;
            textBox6.Text = a;
        }

        private void х10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = "10";
            textBox1.Text = a;
            textBox2.Text = a;
            textBox3.Text = a;
            textBox4.Text = a;
            textBox5.Text = a;
            textBox6.Text = a;
        }

        private void х100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = "100";
            textBox1.Text = a;
            textBox2.Text = a;
            textBox3.Text = a;
            textBox4.Text = a;
            textBox5.Text = a;
            textBox6.Text = a;
        }

        private void х1000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = "1000";
            textBox1.Text = a;
            textBox2.Text = a;
            textBox3.Text = a;
            textBox4.Text = a;
            textBox5.Text = a;
            textBox6.Text = a;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный редактор ломает ваше ядро на 14,55% , будьте осторожны", "Внимание!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog binaryFile = new OpenFileDialog())
            {
                if (binaryFile.ShowDialog() == DialogResult.OK || File.Exists(binaryFile.FileName))
                {
                    FileName = binaryFile.FileName;

                    using (BinaryReader br = new BinaryReader(new FileStream(FileName, FileMode.Open, FileAccess.Read)))
                    {
                        br.BaseStream.Seek(zx400, SeekOrigin.Begin);

                        Single exp = br.ReadSingle();
                        Single item = br.ReadSingle();
                        Single money = br.ReadSingle();
                        Single TaskSp = br.ReadSingle();
                        Single TaskExp = br.ReadSingle();
                        Single TaskMoney = br.ReadSingle();

                        textBox1.Text = exp.ToString();
                        textBox2.Text = item.ToString();
                        textBox3.Text = money.ToString();
                        textBox4.Text = TaskSp.ToString();
                        textBox5.Text = TaskExp.ToString();
                        textBox6.Text = TaskMoney.ToString();

                    }
                    MessageBox.Show("Ваше ядро успешно загружено. Будьте внимательны при сохранении!", "Информация");
                    label8.Text = "4.0.0";
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog binaryFile = new OpenFileDialog())
            {
                if (binaryFile.ShowDialog() == DialogResult.OK || File.Exists(binaryFile.FileName))
                {
                    FileName = binaryFile.FileName;

                    using (BinaryReader br = new BinaryReader(new FileStream(FileName, FileMode.Open, FileAccess.Read)))
                    {
                        br.BaseStream.Seek(zx420, SeekOrigin.Begin);

                        Single exp = br.ReadSingle();
                        Single item = br.ReadSingle();
                        Single money = br.ReadSingle();
                        Single TaskSp = br.ReadSingle();
                        Single TaskExp = br.ReadSingle();
                        Single TaskMoney = br.ReadSingle();

                        textBox1.Text = exp.ToString();
                        textBox2.Text = item.ToString();
                        textBox3.Text = money.ToString();
                        textBox4.Text = TaskSp.ToString();
                        textBox5.Text = TaskExp.ToString();
                        textBox6.Text = TaskMoney.ToString();

                    }
                    MessageBox.Show("Ваше ядро успешно загружено. Будьте внимательны при сохранении!", "Информация");
                    label8.Text = "4.2.0";
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                using (BinaryWriter bw = new BinaryWriter(stream))
                {

                    bw.BaseStream.Seek(zx311, SeekOrigin.Begin);
                    bw.Write(System.Convert.ToSingle(textBox1.Text));
                    bw.Write(System.Convert.ToSingle(textBox2.Text));
                    bw.Write(System.Convert.ToSingle(textBox3.Text));
                    bw.Write(System.Convert.ToSingle(textBox4.Text));
                    bw.Write(System.Convert.ToSingle(textBox5.Text));
                    bw.Write(System.Convert.ToSingle(textBox6.Text));

                }
                MessageBox.Show("Ваши данные успешно сохранены", "Информация");
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                using (BinaryWriter bw = new BinaryWriter(stream))
                {

                    bw.BaseStream.Seek(zx400, SeekOrigin.Begin);
                    bw.Write(System.Convert.ToSingle(textBox1.Text));
                    bw.Write(System.Convert.ToSingle(textBox2.Text));
                    bw.Write(System.Convert.ToSingle(textBox3.Text));
                    bw.Write(System.Convert.ToSingle(textBox4.Text));
                    bw.Write(System.Convert.ToSingle(textBox5.Text));
                    bw.Write(System.Convert.ToSingle(textBox6.Text));

                }
                MessageBox.Show("Ваши данные успешно сохранены", "Информация");
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                using (BinaryWriter bw = new BinaryWriter(stream))
                {

                    bw.BaseStream.Seek(zx420, SeekOrigin.Begin);
                    bw.Write(System.Convert.ToSingle(textBox1.Text));
                    bw.Write(System.Convert.ToSingle(textBox2.Text));
                    bw.Write(System.Convert.ToSingle(textBox3.Text));
                    bw.Write(System.Convert.ToSingle(textBox4.Text));
                    bw.Write(System.Convert.ToSingle(textBox5.Text));
                    bw.Write(System.Convert.ToSingle(textBox6.Text));

                }
                MessageBox.Show("Ваши данные успешно сохранены", "Информация");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
