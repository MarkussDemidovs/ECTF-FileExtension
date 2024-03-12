namespace ECTF_Editor
{
    public partial class Form1 : Form
    {
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
        }

        private void avToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            String str = textArea.Text;
            Char cha = 'a';
            var i = str.IndexOf(char);
            // i will be the index of the first occurrence of 'p' in str, or -1 if not found.

            if (i == -1)
            {
                // not found
            }
            else
            {
                do
                {
                    // do something with index i, which is != -1
                    i = str.IndexOf(c, i + 1);
                } while (i != -1);
            }
        }
    }
}
