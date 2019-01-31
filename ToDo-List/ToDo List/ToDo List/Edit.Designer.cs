namespace ToDo_List
{
    partial class Edit
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
            this.editItemTxt = new System.Windows.Forms.TextBox();
            this.editLineLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editItemTxt
            // 
            this.editItemTxt.Location = new System.Drawing.Point(13, 36);
            this.editItemTxt.Name = "editItemTxt";
            this.editItemTxt.Size = new System.Drawing.Size(281, 20);
            this.editItemTxt.TabIndex = 0;
            this.editItemTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editItemTxt_KeyDown);
            // 
            // editLineLbl
            // 
            this.editLineLbl.AutoSize = true;
            this.editLineLbl.Location = new System.Drawing.Point(13, 13);
            this.editLineLbl.Name = "editLineLbl";
            this.editLineLbl.Size = new System.Drawing.Size(144, 13);
            this.editLineLbl.TabIndex = 1;
            this.editLineLbl.Text = "Edit the item then press enter";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 80);
            this.Controls.Add(this.editLineLbl);
            this.Controls.Add(this.editItemTxt);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editItemTxt;
        private System.Windows.Forms.Label editLineLbl;
    }
}