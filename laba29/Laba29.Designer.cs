namespace laba29
{
    partial class Laba29
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FilesAndSettingsMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SettingsToolStripMenuItem = new ToolStripMenuItem();
            ColorToolStripMenuItem = new ToolStripMenuItem();
            FontToolStripMenuItem = new ToolStripMenuItem();
            DefaultFolderToolStripMenuItem = new ToolStripMenuItem();
            FileTextRichTextBox = new RichTextBox();
            FilesAndSettingsMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // FilesAndSettingsMenuStrip
            // 
            FilesAndSettingsMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, SettingsToolStripMenuItem });
            FilesAndSettingsMenuStrip.Location = new Point(0, 0);
            FilesAndSettingsMenuStrip.Name = "FilesAndSettingsMenuStrip";
            FilesAndSettingsMenuStrip.Size = new Size(800, 24);
            FilesAndSettingsMenuStrip.TabIndex = 0;
            FilesAndSettingsMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenToolStripMenuItem, SaveToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(48, 20);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(180, 22);
            OpenToolStripMenuItem.Text = "Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(180, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem1_Click;
            // 
            // SettingsToolStripMenuItem
            // 
            SettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ColorToolStripMenuItem, FontToolStripMenuItem, DefaultFolderToolStripMenuItem });
            SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            SettingsToolStripMenuItem.Size = new Size(78, 20);
            SettingsToolStripMenuItem.Text = "Настройка";
            // 
            // ColorToolStripMenuItem
            // 
            ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            ColorToolStripMenuItem.Size = new Size(194, 22);
            ColorToolStripMenuItem.Text = "Цвет";
            ColorToolStripMenuItem.Click += ColorToolStripMenuItem2_Click;
            // 
            // FontToolStripMenuItem
            // 
            FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            FontToolStripMenuItem.Size = new Size(194, 22);
            FontToolStripMenuItem.Text = "Шрифт";
            FontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // DefaultFolderToolStripMenuItem
            // 
            DefaultFolderToolStripMenuItem.Name = "DefaultFolderToolStripMenuItem";
            DefaultFolderToolStripMenuItem.Size = new Size(194, 22);
            DefaultFolderToolStripMenuItem.Text = "Папка по умолчанию";
            DefaultFolderToolStripMenuItem.Click += DefaultFolderToolStripMenuItem_Click;
            // 
            // FileTextRichTextBox
            // 
            FileTextRichTextBox.Dock = DockStyle.Fill;
            FileTextRichTextBox.Location = new Point(0, 24);
            FileTextRichTextBox.Name = "FileTextRichTextBox";
            FileTextRichTextBox.Size = new Size(800, 426);
            FileTextRichTextBox.TabIndex = 1;
            FileTextRichTextBox.Text = "";
            // 
            // Laba29
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FileTextRichTextBox);
            Controls.Add(FilesAndSettingsMenuStrip);
            MainMenuStrip = FilesAndSettingsMenuStrip;
            Name = "Laba29";
            Text = "Лабораторная работа 21";
            FilesAndSettingsMenuStrip.ResumeLayout(false);
            FilesAndSettingsMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip FilesAndSettingsMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private RichTextBox FileTextRichTextBox;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SettingsToolStripMenuItem;
        private ToolStripMenuItem ColorToolStripMenuItem;
        private ToolStripMenuItem FontToolStripMenuItem;
        private ToolStripMenuItem DefaultFolderToolStripMenuItem;
    }
}
