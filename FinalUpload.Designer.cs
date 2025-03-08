namespace Classroom_Management_System
{
    partial class FinalUpload
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            commentsPanel = new Custom.PanelDesign();
            fileLabel = new Label();
            descLabel = new Label();
            titleLabel = new Label();
            saveButton = new Custom.FinalCustomButton();
            announcementCheckedBox = new CheckBox();
            announcementButton = new Button();
            fileLists = new ListBox();
            fileDropPanel = new Panel();
            fileButton = new Custom.FinalCustomButton();
            descTextBox = new TextBox();
            titleTextBox = new TextBox();
            uploadLabel = new Label();
            previewPanel = new Custom.PanelDesign();
            previewLabel = new Label();
            finalNoteUpload1 = new FinalNoteUpload();
            commentsPanel.SuspendLayout();
            previewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // commentsPanel
            // 
            commentsPanel.BackColor = Color.White;
            commentsPanel.BorderColor = Color.FromArgb(93, 49, 156);
            commentsPanel.BorderRadius = 3;
            commentsPanel.BorderSize = 2;
            commentsPanel.BottomGradient = Color.FromArgb(141, 142, 196);
            commentsPanel.Controls.Add(fileLabel);
            commentsPanel.Controls.Add(descLabel);
            commentsPanel.Controls.Add(titleLabel);
            commentsPanel.Controls.Add(saveButton);
            commentsPanel.Controls.Add(announcementCheckedBox);
            commentsPanel.Controls.Add(announcementButton);
            commentsPanel.Controls.Add(fileLists);
            commentsPanel.Controls.Add(fileDropPanel);
            commentsPanel.Controls.Add(fileButton);
            commentsPanel.Controls.Add(descTextBox);
            commentsPanel.Controls.Add(titleTextBox);
            commentsPanel.Controls.Add(uploadLabel);
            commentsPanel.ForeColor = Color.White;
            commentsPanel.GradientAngle = 0F;
            commentsPanel.Location = new Point(3, 3);
            commentsPanel.Name = "commentsPanel";
            commentsPanel.Size = new Size(630, 744);
            commentsPanel.TabIndex = 2;
            commentsPanel.TopGradient = Color.FromArgb(141, 142, 196);
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.BackColor = Color.Transparent;
            fileLabel.Location = new Point(301, 347);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(47, 20);
            fileLabel.TabIndex = 12;
            fileLabel.Text = "File/s:";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.BackColor = Color.Transparent;
            descLabel.Location = new Point(279, 116);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(88, 20);
            descLabel.TabIndex = 11;
            descLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Location = new Point(302, 47);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(41, 20);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "Title:";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(198, 68, 70);
            saveButton.BackgroundColor = Color.FromArgb(198, 68, 70);
            saveButton.BorderColor = Color.FromArgb(198, 68, 70);
            saveButton.BorderRadius = 20;
            saveButton.BorderSize = 0;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(270, 698);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(127, 37);
            saveButton.TabIndex = 9;
            saveButton.Text = "SAVE";
            saveButton.TextColor = Color.White;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // announcementCheckedBox
            // 
            announcementCheckedBox.AutoSize = true;
            announcementCheckedBox.BackColor = Color.Transparent;
            announcementCheckedBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announcementCheckedBox.Location = new Point(218, 666);
            announcementCheckedBox.Name = "announcementCheckedBox";
            announcementCheckedBox.Size = new Size(18, 17);
            announcementCheckedBox.TabIndex = 8;
            announcementCheckedBox.TextAlign = ContentAlignment.MiddleCenter;
            announcementCheckedBox.UseVisualStyleBackColor = false;
            // 
            // announcementButton
            // 
            announcementButton.BackColor = Color.Transparent;
            announcementButton.FlatAppearance.BorderSize = 0;
            announcementButton.FlatStyle = FlatStyle.Flat;
            announcementButton.Location = new Point(212, 660);
            announcementButton.Name = "announcementButton";
            announcementButton.Size = new Size(246, 28);
            announcementButton.TabIndex = 7;
            announcementButton.Text = "Make it an announcement post";
            announcementButton.TextAlign = ContentAlignment.MiddleRight;
            announcementButton.UseVisualStyleBackColor = false;
            // 
            // fileLists
            // 
            fileLists.FormattingEnabled = true;
            fileLists.Location = new Point(364, 420);
            fileLists.Name = "fileLists";
            fileLists.Size = new Size(228, 224);
            fileLists.TabIndex = 5;
            // 
            // fileDropPanel
            // 
            fileDropPanel.Location = new Point(19, 377);
            fileDropPanel.Name = "fileDropPanel";
            fileDropPanel.Size = new Size(326, 267);
            fileDropPanel.TabIndex = 4;
            // 
            // fileButton
            // 
            fileButton.BackColor = Color.White;
            fileButton.BackgroundColor = Color.White;
            fileButton.BorderColor = Color.FromArgb(93, 49, 156);
            fileButton.BorderRadius = 20;
            fileButton.BorderSize = 2;
            fileButton.FlatAppearance.BorderSize = 0;
            fileButton.FlatStyle = FlatStyle.Flat;
            fileButton.ForeColor = Color.Black;
            fileButton.Location = new Point(373, 377);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(204, 37);
            fileButton.TabIndex = 3;
            fileButton.Text = "Choose a file...";
            fileButton.TextColor = Color.Black;
            fileButton.UseVisualStyleBackColor = false;
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(129, 139);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(380, 194);
            descTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(129, 71);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(380, 27);
            titleTextBox.TabIndex = 1;
            // 
            // uploadLabel
            // 
            uploadLabel.AutoSize = true;
            uploadLabel.BackColor = Color.Transparent;
            uploadLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uploadLabel.ForeColor = Color.Black;
            uploadLabel.Location = new Point(286, 8);
            uploadLabel.Name = "uploadLabel";
            uploadLabel.Size = new Size(80, 25);
            uploadLabel.TabIndex = 0;
            uploadLabel.Text = "UPLOAD";
            // 
            // previewPanel
            // 
            previewPanel.BackColor = Color.White;
            previewPanel.BorderColor = Color.FromArgb(198, 68, 70);
            previewPanel.BorderRadius = 3;
            previewPanel.BorderSize = 2;
            previewPanel.BottomGradient = Color.White;
            previewPanel.Controls.Add(finalNoteUpload1);
            previewPanel.Controls.Add(previewLabel);
            previewPanel.ForeColor = Color.White;
            previewPanel.GradientAngle = 0F;
            previewPanel.Location = new Point(639, 3);
            previewPanel.Name = "previewPanel";
            previewPanel.Size = new Size(628, 744);
            previewPanel.TabIndex = 3;
            previewPanel.TopGradient = Color.White;
            // 
            // previewLabel
            // 
            previewLabel.AutoSize = true;
            previewLabel.BackColor = Color.Transparent;
            previewLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            previewLabel.ForeColor = Color.Black;
            previewLabel.Location = new Point(294, 8);
            previewLabel.Name = "previewLabel";
            previewLabel.Size = new Size(84, 25);
            previewLabel.TabIndex = 1;
            previewLabel.Text = "PREVIEW";
            // 
            // finalNoteUpload1
            // 
            finalNoteUpload1.BackColor = Color.FromArgb(141, 142, 196);
            finalNoteUpload1.Location = new Point(3, 369);
            finalNoteUpload1.Name = "finalNoteUpload1";
            finalNoteUpload1.Size = new Size(618, 372);
            finalNoteUpload1.TabIndex = 13;
            // 
            // FinalUpload
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(previewPanel);
            Controls.Add(commentsPanel);
            Name = "FinalUpload";
            Size = new Size(1270, 750);
            commentsPanel.ResumeLayout(false);
            commentsPanel.PerformLayout();
            previewPanel.ResumeLayout(false);
            previewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Custom.PanelDesign commentsPanel;
        private TextBox descTextBox;
        private TextBox titleTextBox;
        private Label uploadLabel;
        private Custom.PanelDesign previewPanel;
        private Label previewLabel;
        private Custom.FinalCustomButton fileButton;
        private ListBox fileLists;
        private Panel fileDropPanel;
        private CheckBox announcementCheckedBox;
        private Button announcementButton;
        private Label titleLabel;
        private Custom.FinalCustomButton saveButton;
        private Label descLabel;
        private Label fileLabel;
        private FinalNoteUpload finalNoteUpload1;
    }
}
