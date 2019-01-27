﻿namespace CharRecognizer
{
    partial class CharRecognizer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.charRecognizerGroupBox = new System.Windows.Forms.GroupBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.charPictureBox = new System.Windows.Forms.PictureBox();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.networkComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.generatorGroupBox = new System.Windows.Forms.GroupBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.layersCountLabel = new System.Windows.Forms.Label();
            this.layersCountTextBox = new System.Windows.Forms.TextBox();
            this.newNetworkNameLabel = new System.Windows.Forms.Label();
            this.newNetworkNameTextBox = new System.Windows.Forms.TextBox();
            this.charRecognizerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charPictureBox)).BeginInit();
            this.generalGroupBox.SuspendLayout();
            this.descriptionGroupBox.SuspendLayout();
            this.generatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // charRecognizerGroupBox
            // 
            this.charRecognizerGroupBox.Controls.Add(this.saveImageButton);
            this.charRecognizerGroupBox.Controls.Add(this.clearButton);
            this.charRecognizerGroupBox.Controls.Add(this.charPictureBox);
            this.charRecognizerGroupBox.Controls.Add(this.recognizeButton);
            this.charRecognizerGroupBox.Enabled = false;
            this.charRecognizerGroupBox.Location = new System.Drawing.Point(308, 66);
            this.charRecognizerGroupBox.Name = "charRecognizerGroupBox";
            this.charRecognizerGroupBox.Size = new System.Drawing.Size(294, 354);
            this.charRecognizerGroupBox.TabIndex = 0;
            this.charRecognizerGroupBox.TabStop = false;
            this.charRecognizerGroupBox.Text = "Char Reconizer";
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(122, 19);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(73, 26);
            this.saveImageButton.TabIndex = 8;
            this.saveImageButton.Text = "Save image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(122, 51);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(73, 26);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // charPictureBox
            // 
            this.charPictureBox.BackColor = System.Drawing.Color.White;
            this.charPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.charPictureBox.Location = new System.Drawing.Point(6, 19);
            this.charPictureBox.Name = "charPictureBox";
            this.charPictureBox.Size = new System.Drawing.Size(100, 100);
            this.charPictureBox.TabIndex = 6;
            this.charPictureBox.TabStop = false;
            // 
            // recognizeButton
            // 
            this.recognizeButton.Location = new System.Drawing.Point(122, 93);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(73, 26);
            this.recognizeButton.TabIndex = 5;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.networkComboBox);
            this.generalGroupBox.Location = new System.Drawing.Point(12, 66);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(275, 62);
            this.generalGroupBox.TabIndex = 1;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // networkComboBox
            // 
            this.networkComboBox.FormattingEnabled = true;
            this.networkComboBox.Location = new System.Drawing.Point(6, 23);
            this.networkComboBox.Name = "networkComboBox";
            this.networkComboBox.Size = new System.Drawing.Size(121, 21);
            this.networkComboBox.TabIndex = 0;
            this.networkComboBox.SelectionChangeCommitted += new System.EventHandler(this.networkComboBox_SelectionChangeCommitted);
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Controls.Add(this.descriptionLabel);
            this.descriptionGroupBox.Location = new System.Drawing.Point(18, 13);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(584, 47);
            this.descriptionGroupBox.TabIndex = 2;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Description";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(7, 20);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(163, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Some description //TODO TEXT";
            // 
            // generatorGroupBox
            // 
            this.generatorGroupBox.Controls.Add(this.generateButton);
            this.generatorGroupBox.Controls.Add(this.layersCountLabel);
            this.generatorGroupBox.Controls.Add(this.layersCountTextBox);
            this.generatorGroupBox.Controls.Add(this.newNetworkNameLabel);
            this.generatorGroupBox.Controls.Add(this.newNetworkNameTextBox);
            this.generatorGroupBox.Location = new System.Drawing.Point(12, 184);
            this.generatorGroupBox.Name = "generatorGroupBox";
            this.generatorGroupBox.Size = new System.Drawing.Size(290, 141);
            this.generatorGroupBox.TabIndex = 3;
            this.generatorGroupBox.TabStop = false;
            this.generatorGroupBox.Text = "Generator";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(87, 109);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(111, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // layersCountLabel
            // 
            this.layersCountLabel.AutoSize = true;
            this.layersCountLabel.Location = new System.Drawing.Point(13, 53);
            this.layersCountLabel.Name = "layersCountLabel";
            this.layersCountLabel.Size = new System.Drawing.Size(68, 13);
            this.layersCountLabel.TabIndex = 3;
            this.layersCountLabel.Text = "Count layers:";
            // 
            // layersCountTextBox
            // 
            this.layersCountTextBox.Location = new System.Drawing.Point(87, 50);
            this.layersCountTextBox.Name = "layersCountTextBox";
            this.layersCountTextBox.Size = new System.Drawing.Size(40, 20);
            this.layersCountTextBox.TabIndex = 2;
            // 
            // newNetworkNameLabel
            // 
            this.newNetworkNameLabel.AutoSize = true;
            this.newNetworkNameLabel.Location = new System.Drawing.Point(13, 27);
            this.newNetworkNameLabel.Name = "newNetworkNameLabel";
            this.newNetworkNameLabel.Size = new System.Drawing.Size(38, 13);
            this.newNetworkNameLabel.TabIndex = 1;
            this.newNetworkNameLabel.Text = "Name:";
            // 
            // newNetworkNameTextBox
            // 
            this.newNetworkNameTextBox.Location = new System.Drawing.Point(87, 24);
            this.newNetworkNameTextBox.Name = "newNetworkNameTextBox";
            this.newNetworkNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.newNetworkNameTextBox.TabIndex = 0;
            // 
            // CharRecognizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 446);
            this.Controls.Add(this.generatorGroupBox);
            this.Controls.Add(this.descriptionGroupBox);
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.charRecognizerGroupBox);
            this.Name = "CharRecognizer";
            this.Text = "Char Recognizer";
            this.Load += new System.EventHandler(this.CharRecognizer_Load);
            this.charRecognizerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charPictureBox)).EndInit();
            this.generalGroupBox.ResumeLayout(false);
            this.descriptionGroupBox.ResumeLayout(false);
            this.descriptionGroupBox.PerformLayout();
            this.generatorGroupBox.ResumeLayout(false);
            this.generatorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox charRecognizerGroupBox;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox charPictureBox;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.ComboBox networkComboBox;
        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.GroupBox generatorGroupBox;
        private System.Windows.Forms.Label newNetworkNameLabel;
        private System.Windows.Forms.TextBox newNetworkNameTextBox;
        private System.Windows.Forms.Label layersCountLabel;
        private System.Windows.Forms.TextBox layersCountTextBox;
        private System.Windows.Forms.Button generateButton;
    }
}