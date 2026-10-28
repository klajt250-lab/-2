using System.IO;
using System.Windows.Forms;

namespace Блокнот
{
    public partial class Form1 : Form
    {
        public string program;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                program = saveFileDialog1.FileName;
            string text = textBox1.Text;
            StreamWriter writer = new StreamWriter(program);
            writer.Write(text);
            writer.Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                program = openFileDialog1.FileName;
            StreamReader reader = new StreamReader(program);
            string text = reader.ReadToEnd();
            reader.Close();
            textBox1.Text = text;
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Copy();
                }
            }
        }


        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Paste();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Cut();
                }
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                fontDialog1.ShowDialog();
                textBox1.Font = fontDialog1.Font;
            }

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                program = saveFileDialog1.FileName;
            string text = textBox1.Text;
            StreamWriter writer = new StreamWriter(program);
            writer.Write(text);
            writer.Close();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}








