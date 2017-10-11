namespace TextEditor
{
    partial class TextEditorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.createToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.boldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.foreColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripButton,
            this.saveFileToolStripButton,
            this.createToolStripButton,
            this.toolStripSeparator1,
            this.copyToolStripButton,
            this.cutToolStripButton,
            this.pasteToolStripButton,
            this.undoToolStripButton,
            this.toolStripSeparator2,
            this.fontToolStripButton,
            this.boldToolStripButton,
            this.italicsToolStripButton,
            this.foreColorToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(351, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // openFileToolStripButton
            // 
            this.openFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileToolStripButton.Image = global::TextEditor.Properties.Resources.folderIcon;
            this.openFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileToolStripButton.Name = "openFileToolStripButton";
            this.openFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openFileToolStripButton.Text = "Открыть файл";
            this.openFileToolStripButton.ToolTipText = "Открыть файл";
            this.openFileToolStripButton.Click += new System.EventHandler(this.OpenFileToolStripButton_Click);
            // 
            // saveFileToolStripButton
            // 
            this.saveFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFileToolStripButton.Image = global::TextEditor.Properties.Resources.saveIcon;
            this.saveFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileToolStripButton.Name = "saveFileToolStripButton";
            this.saveFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveFileToolStripButton.Text = "Сохранить";
            this.saveFileToolStripButton.Click += new System.EventHandler(this.SaveFileToolStripButton_Click);
            // 
            // createToolStripButton
            // 
            this.createToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createToolStripButton.Image = global::TextEditor.Properties.Resources.addFileIcon;
            this.createToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createToolStripButton.Name = "createToolStripButton";
            this.createToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.createToolStripButton.Text = "Создать новый";
            this.createToolStripButton.Click += new System.EventHandler(this.CreateToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = global::TextEditor.Properties.Resources.copyIcon;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "Копировать";
            this.copyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = global::TextEditor.Properties.Resources.cutIcon;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "Вырезать";
            this.cutToolStripButton.Click += new System.EventHandler(this.CutToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = global::TextEditor.Properties.Resources.pasteIcon;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "Вставить";
            this.pasteToolStripButton.Click += new System.EventHandler(this.PasteToolStripButton_Click);
            // 
            // undoToolStripButton
            // 
            this.undoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolStripButton.Image = global::TextEditor.Properties.Resources.undoIcon;
            this.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton.Name = "undoToolStripButton";
            this.undoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.undoToolStripButton.Text = "Отменить";
            this.undoToolStripButton.Click += new System.EventHandler(this.UndoToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fontToolStripButton
            // 
            this.fontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontToolStripButton.Image = global::TextEditor.Properties.Resources.fontIcon;
            this.fontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontToolStripButton.Name = "fontToolStripButton";
            this.fontToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fontToolStripButton.Text = "Шрифт";
            this.fontToolStripButton.Click += new System.EventHandler(this.FontToolStripButton_Click);
            // 
            // boldToolStripButton
            // 
            this.boldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolStripButton.Image = global::TextEditor.Properties.Resources.boldIcon;
            this.boldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolStripButton.Name = "boldToolStripButton";
            this.boldToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.boldToolStripButton.Text = "Жирный";
            // 
            // italicsToolStripButton
            // 
            this.italicsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicsToolStripButton.Image = global::TextEditor.Properties.Resources.italicIcon;
            this.italicsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicsToolStripButton.Name = "italicsToolStripButton";
            this.italicsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.italicsToolStripButton.Text = "Курсив";
            // 
            // foreColorToolStripButton
            // 
            this.foreColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.foreColorToolStripButton.Image = global::TextEditor.Properties.Resources.textColorIcon;
            this.foreColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.foreColorToolStripButton.Name = "foreColorToolStripButton";
            this.foreColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.foreColorToolStripButton.Text = "Цвет Текста";
            this.foreColorToolStripButton.Click += new System.EventHandler(this.ForeColorToolStripButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(351, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // sellectAllToolStripMenuItem
            // 
            this.sellectAllToolStripMenuItem.Name = "sellectAllToolStripMenuItem";
            this.sellectAllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.sellectAllToolStripMenuItem.Text = "Выделить всё";
            this.sellectAllToolStripMenuItem.Click += new System.EventHandler(this.SellectAllToolStripMenuItem_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Enabled = false;
            this.richTextBox.Location = new System.Drawing.Point(0, 49);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(351, 382);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовый файл|*.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Текстовые файлы|*.txt";
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 431);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TextEditorForm";
            this.Text = "Текстовый редактор";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openFileToolStripButton;
        private System.Windows.Forms.ToolStripButton saveFileToolStripButton;
        private System.Windows.Forms.ToolStripButton createToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton undoToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellectAllToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripButton fontToolStripButton;
        private System.Windows.Forms.ToolStripButton boldToolStripButton;
        private System.Windows.Forms.ToolStripButton italicsToolStripButton;
        private System.Windows.Forms.ToolStripButton foreColorToolStripButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

