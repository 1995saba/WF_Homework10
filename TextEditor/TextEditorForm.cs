using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class TextEditorForm : Form
    {
        string fileName;
        public TextEditorForm()
        {
            InitializeComponent();
        }

        private void OpenFileToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialog.FileName;
            string fileText = File.ReadAllText(fileName);
            richTextBox.Enabled = true;
            richTextBox.Text = fileText;
            this.Text = fileName;
        }

        private void SaveFileToolStripButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, richTextBox.Text);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = saveFileDialog.FileName;
            File.WriteAllText(fileName, richTextBox.Text);
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox.SelectedText);
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void UndoToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void FontToolStripButton_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            this.Font = fontDialog.Font;
            richTextBox.Font = fontDialog.Font;
            toolStrip.Font = fontDialog.Font;
        }

        private void ForeColorToolStripButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.ForeColor = colorDialog.Color;
            richTextBox.ForeColor = colorDialog.Color;
        }

        private void SellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            fileName = "text.txt";
            this.Text = fileName;
            richTextBox.Enabled = true;
        }
    }
}
