using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ECTF_Editor
{
    public partial class Form1 : Form
    {
        string textAreaContent;
        string changedTAC;
        char[] charText;
        int turn = 0;
        int num1 = 0;
        int num2 = 0;
        private void CompileText(string text)
        {
            changedTAC = "";
            byte[] byteValues = Encoding.UTF8.GetBytes(text);

            foreach (byte letter in byteValues)
            {
                int myInt = (int)letter;

                if (letter == 32)
                {
                    myInt = 0;
                }

                turn++;

                /*if (turn == 0)
                {
                    num1 = letter;
                    turn++;
                }
                else if (turn == 1)
                {
                    num2 = letter;
                    turn++;
                }
                else
                {
                    changedTAC += " ";
                    turn = 0;
                }*/
                changedTAC += "." + myInt;
            }

            textAreaContent = changedTAC;

        }

        private string DeCompileText(string text)
        {
            string[] byteStrings = text.Split('.');
            byte[] bytes = new byte[byteStrings.Length];

            StringBuilder decompiledText = new StringBuilder();

            for (int i = 0; i < byteStrings.Length; i++)
            {
                if (!string.IsNullOrEmpty(byteStrings[i]))
                {
                    bytes[i] = Convert.ToByte(byteStrings[i]);

                    if (bytes[i] == 0)
                    {
                        decompiledText.Append(" "); // Add a space when the byte value is 0
                    }
                    else
                    {
                        decompiledText.Append(Encoding.UTF8.GetString(new byte[] { bytes[i] }));
                    }
                }
            }

            return decompiledText.ToString();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
  

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "Editable Compressed Text Format(*.ectf)|*.ectf|All files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textArea.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }

            this.Text = ofd.FileName;

            textAreaContent = textArea.Text.ToString();

            textArea.Text = DeCompileText(textAreaContent);
        }

        private void avToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textAreaContent = textArea.Text.ToString();

            CompileText(textAreaContent);
            textArea.Text = "";
            textArea.Text = textAreaContent;
            textAreaContent = "";

            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Title = "Save";
            ofd.Filter = "Editable Compressed Text Format (*.ectf)|*.ectf|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textArea.SaveFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }

            this.Text = ofd.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Redo();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();

            if (fnt.ShowDialog() == DialogResult.OK)
            {
                textArea.Font = fnt.Font;
            }
        }

        private void foregroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();

            if (fnt.ShowDialog() == DialogResult.OK)
            {
                textArea.ForeColor = fnt.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();

            if (fnt.ShowDialog() == DialogResult.OK)
            {
                textArea.BackColor = fnt.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void eCTFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toECTFToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void fromECTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textAreaContent = textArea.Text.ToString();

            textArea.Text = DeCompileText(textAreaContent);
        }
    }
}
