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
            this.label_test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Location = new System.Drawing.Point(139, 146);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(49, 13);
            this.label_test.TabIndex = 0;
            this.label_test.Text = "Loaded: ";
            // 
            // UC_DataPackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_test);
            this.Name = "UC_DataPackView";
            this.Size = new System.Drawing.Size(662, 453);
            this.Load += new System.EventHandler(this.UC_DataPackView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_test;
    }
}
