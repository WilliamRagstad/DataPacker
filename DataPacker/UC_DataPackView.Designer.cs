namespace DataPacker
{
    partial class UC_DataPackView
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
            this.pictureBox_thumbnail = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.richTextBox_description = new DataPacker.Controls.NonEditableRichTextBox();
            this.label_author = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_install = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_thumbnail
            // 
            this.pictureBox_thumbnail.BackgroundImage = global::DataPacker.Properties.Resources.missing_thumbnail;
            this.pictureBox_thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_thumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_thumbnail.Location = new System.Drawing.Point(3, 0);
            this.pictureBox_thumbnail.Name = "pictureBox_thumbnail";
            this.pictureBox_thumbnail.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_thumbnail.TabIndex = 2;
            this.pictureBox_thumbnail.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(99, 3);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(82, 29);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "[Title]";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_description.BackColor = System.Drawing.Color.OldLace;
            this.richTextBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_description.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_description.Location = new System.Drawing.Point(104, 51);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.ReadOnly = true;
            this.richTextBox_description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_description.Selectable = false;
            this.richTextBox_description.Size = new System.Drawing.Size(281, 58);
            this.richTextBox_description.TabIndex = 5;
            this.richTextBox_description.Text = "[Description]";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label_author.Location = new System.Drawing.Point(104, 32);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(70, 13);
            this.label_author.TabIndex = 6;
            this.label_author.Text = "By [Author]";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_version.Location = new System.Drawing.Point(0, 93);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(86, 13);
            this.label_version.TabIndex = 7;
            this.label_version.Text = "Version [Version]";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(6, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 3);
            this.panel1.TabIndex = 8;
            // 
            // button_install
            // 
            this.button_install.Location = new System.Drawing.Point(21, 133);
            this.button_install.Name = "button_install";
            this.button_install.Size = new System.Drawing.Size(113, 27);
            this.button_install.TabIndex = 9;
            this.button_install.Text = "Install";
            this.button_install.UseVisualStyleBackColor = true;
            // 
            // UC_DataPackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_install);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.pictureBox_thumbnail);
            this.Controls.Add(this.label_author);
            this.Name = "UC_DataPackView";
            this.Size = new System.Drawing.Size(398, 252);
            this.Load += new System.EventHandler(this.UC_DataPackView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_thumbnail;
        private System.Windows.Forms.Label label_title;
        private Controls.NonEditableRichTextBox richTextBox_description;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_install;
    }
}
