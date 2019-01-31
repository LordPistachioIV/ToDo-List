namespace ToDo_List
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainTitleLbl = new System.Windows.Forms.Label();
            this.exitProgBtn = new System.Windows.Forms.Button();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.addItemTxtb = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.todoItemListChkBx = new System.Windows.Forms.CheckedListBox();
            this.itemTotalLbl = new System.Windows.Forms.Label();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.counterTimer = new System.Windows.Forms.Timer(this.components);
            this.filterDisplayLbl = new System.Windows.Forms.Label();
            this.selectAllChkB = new System.Windows.Forms.CheckBox();
            this.filterAllBtn = new System.Windows.Forms.Button();
            this.filterActiveBtn = new System.Windows.Forms.Button();
            this.filterCompletedBtn = new System.Windows.Forms.Button();
            this.setCompletedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTitleLbl
            // 
            this.mainTitleLbl.AutoSize = true;
            this.mainTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLbl.Location = new System.Drawing.Point(213, 24);
            this.mainTitleLbl.Name = "mainTitleLbl";
            this.mainTitleLbl.Size = new System.Drawing.Size(110, 25);
            this.mainTitleLbl.TabIndex = 0;
            this.mainTitleLbl.Text = "Todo List";
            // 
            // exitProgBtn
            // 
            this.exitProgBtn.Location = new System.Drawing.Point(499, 396);
            this.exitProgBtn.Name = "exitProgBtn";
            this.exitProgBtn.Size = new System.Drawing.Size(75, 23);
            this.exitProgBtn.TabIndex = 1;
            this.exitProgBtn.Text = "Exit ";
            this.exitProgBtn.UseVisualStyleBackColor = true;
            this.exitProgBtn.Click += new System.EventHandler(this.exitProgBtn_Click);
            // 
            // addItemLbl
            // 
            this.addItemLbl.AutoSize = true;
            this.addItemLbl.Location = new System.Drawing.Point(19, 64);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(51, 13);
            this.addItemLbl.TabIndex = 2;
            this.addItemLbl.Text = "Add item:";
            // 
            // addItemTxtb
            // 
            this.addItemTxtb.AcceptsReturn = true;
            this.addItemTxtb.Location = new System.Drawing.Point(77, 61);
            this.addItemTxtb.Name = "addItemTxtb";
            this.addItemTxtb.Size = new System.Drawing.Size(412, 20);
            this.addItemTxtb.TabIndex = 3;
            this.addItemTxtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addItemTxtb_KeyDown);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(495, 59);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 4;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // todoItemListChkBx
            // 
            this.todoItemListChkBx.CheckOnClick = true;
            this.todoItemListChkBx.FormattingEnabled = true;
            this.todoItemListChkBx.HorizontalScrollbar = true;
            this.todoItemListChkBx.Location = new System.Drawing.Point(25, 116);
            this.todoItemListChkBx.Name = "todoItemListChkBx";
            this.todoItemListChkBx.Size = new System.Drawing.Size(412, 274);
            this.todoItemListChkBx.TabIndex = 5;
            this.todoItemListChkBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.todoItemListChkBx_KeyDown);
            this.todoItemListChkBx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.todoItemListChkBx_MouseDoubleClick);
            // 
            // itemTotalLbl
            // 
            this.itemTotalLbl.AutoSize = true;
            this.itemTotalLbl.Location = new System.Drawing.Point(447, 116);
            this.itemTotalLbl.Name = "itemTotalLbl";
            this.itemTotalLbl.Size = new System.Drawing.Size(64, 13);
            this.itemTotalLbl.TabIndex = 6;
            this.itemTotalLbl.Text = "Total items: ";
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Location = new System.Drawing.Point(362, 396);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(75, 23);
            this.removeItemBtn.TabIndex = 7;
            this.removeItemBtn.Text = "Remove";
            this.removeItemBtn.UseVisualStyleBackColor = true;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // counterTimer
            // 
            this.counterTimer.Interval = 1000;
            this.counterTimer.Tick += new System.EventHandler(this.counterTimer_Tick);
            // 
            // filterDisplayLbl
            // 
            this.filterDisplayLbl.AutoSize = true;
            this.filterDisplayLbl.Location = new System.Drawing.Point(178, 100);
            this.filterDisplayLbl.Name = "filterDisplayLbl";
            this.filterDisplayLbl.Size = new System.Drawing.Size(62, 13);
            this.filterDisplayLbl.TabIndex = 8;
            this.filterDisplayLbl.Text = "Showing All";
            // 
            // selectAllChkB
            // 
            this.selectAllChkB.AutoSize = true;
            this.selectAllChkB.Location = new System.Drawing.Point(28, 96);
            this.selectAllChkB.Name = "selectAllChkB";
            this.selectAllChkB.Size = new System.Drawing.Size(69, 17);
            this.selectAllChkB.TabIndex = 9;
            this.selectAllChkB.Text = "Select all";
            this.selectAllChkB.UseVisualStyleBackColor = true;
            this.selectAllChkB.CheckedChanged += new System.EventHandler(this.selectAllChkB_CheckedChanged);
            // 
            // filterAllBtn
            // 
            this.filterAllBtn.Location = new System.Drawing.Point(450, 204);
            this.filterAllBtn.Name = "filterAllBtn";
            this.filterAllBtn.Size = new System.Drawing.Size(96, 23);
            this.filterAllBtn.TabIndex = 10;
            this.filterAllBtn.Text = "Show All";
            this.filterAllBtn.UseVisualStyleBackColor = true;
            this.filterAllBtn.Click += new System.EventHandler(this.filterAllBtn_Click);
            // 
            // filterActiveBtn
            // 
            this.filterActiveBtn.Location = new System.Drawing.Point(450, 145);
            this.filterActiveBtn.Name = "filterActiveBtn";
            this.filterActiveBtn.Size = new System.Drawing.Size(96, 23);
            this.filterActiveBtn.TabIndex = 11;
            this.filterActiveBtn.Text = "Show Active";
            this.filterActiveBtn.UseVisualStyleBackColor = true;
            this.filterActiveBtn.Click += new System.EventHandler(this.filterActiveBtn_Click);
            // 
            // filterCompletedBtn
            // 
            this.filterCompletedBtn.Location = new System.Drawing.Point(450, 175);
            this.filterCompletedBtn.Name = "filterCompletedBtn";
            this.filterCompletedBtn.Size = new System.Drawing.Size(96, 23);
            this.filterCompletedBtn.TabIndex = 12;
            this.filterCompletedBtn.Text = "Show Completed";
            this.filterCompletedBtn.UseVisualStyleBackColor = true;
            this.filterCompletedBtn.Click += new System.EventHandler(this.filterCompletedBtn_Click);
            // 
            // setCompletedBtn
            // 
            this.setCompletedBtn.Location = new System.Drawing.Point(25, 396);
            this.setCompletedBtn.Name = "setCompletedBtn";
            this.setCompletedBtn.Size = new System.Drawing.Size(75, 23);
            this.setCompletedBtn.TabIndex = 13;
            this.setCompletedBtn.Text = "Complete";
            this.setCompletedBtn.UseVisualStyleBackColor = true;
            this.setCompletedBtn.Click += new System.EventHandler(this.setCompletedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 431);
            this.Controls.Add(this.setCompletedBtn);
            this.Controls.Add(this.filterCompletedBtn);
            this.Controls.Add(this.filterActiveBtn);
            this.Controls.Add(this.filterAllBtn);
            this.Controls.Add(this.selectAllChkB);
            this.Controls.Add(this.filterDisplayLbl);
            this.Controls.Add(this.removeItemBtn);
            this.Controls.Add(this.itemTotalLbl);
            this.Controls.Add(this.todoItemListChkBx);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.addItemTxtb);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.exitProgBtn);
            this.Controls.Add(this.mainTitleLbl);
            this.Name = "Form1";
            this.Text = "Todo List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitleLbl;
        private System.Windows.Forms.Button exitProgBtn;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.TextBox addItemTxtb;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.CheckedListBox todoItemListChkBx;
        private System.Windows.Forms.Label itemTotalLbl;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.Timer counterTimer;
        private System.Windows.Forms.Label filterDisplayLbl;
        private System.Windows.Forms.CheckBox selectAllChkB;
        private System.Windows.Forms.Button filterAllBtn;
        private System.Windows.Forms.Button filterActiveBtn;
        private System.Windows.Forms.Button filterCompletedBtn;
        private System.Windows.Forms.Button setCompletedBtn;
    }
}

