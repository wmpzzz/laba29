using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba29
{
    public partial class Laba29 : Form
    {
        public Laba29()
        {
            InitializeComponent();

        }


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                openFileDialog.ShowDialog();
                string filename = openFileDialog.FileName;
                string fileText = System.IO.File.ReadAllText(filename);
                FileTextRichTextBox.Text = fileText;

            }
        }

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                saveFileDialog1.ShowDialog();
                string filename = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(filename, FileTextRichTextBox.Text);
            }

        }

        private void ColorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            FileTextRichTextBox.SelectionColor = colorDialog.Color;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            FileTextRichTextBox.SelectionFont = fontDialog.Font;
        }

        private void DefaultFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

        }
    }
}
