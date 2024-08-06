namespace Mustafa_Abdulateef_To_Do_List_Application
{
    partial class UC_Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Display));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pnlPenson = new System.Windows.Forms.Panel();
            this.rjTextBoxDescription = new CustomControls.RJControls.RJTextBox();
            this.rjTextBoxTitle = new CustomControls.RJControls.RJTextBox();
            this.rjButtonDel = new CustomControls.RJControls.RJButton();
            this.pnlPenson.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(302, 11);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.dateTimePicker.TabIndex = 2;
            // 
            // pnlPenson
            // 
            this.pnlPenson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPenson.Controls.Add(this.rjTextBoxDescription);
            this.pnlPenson.Controls.Add(this.dateTimePicker);
            this.pnlPenson.Controls.Add(this.rjTextBoxTitle);
            this.pnlPenson.Location = new System.Drawing.Point(0, 0);
            this.pnlPenson.Name = "pnlPenson";
            this.pnlPenson.Size = new System.Drawing.Size(552, 168);
            this.pnlPenson.TabIndex = 1;
            this.pnlPenson.Click += new System.EventHandler(this.pnlPenson_Click);
            // 
            // rjTextBoxDescription
            // 
            this.rjTextBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.rjTextBoxDescription.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.rjTextBoxDescription.BorderRadius = 15;
            this.rjTextBoxDescription.BorderSize = 3;
            this.rjTextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxDescription.Location = new System.Drawing.Point(4, 65);
            this.rjTextBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxDescription.Multiline = true;
            this.rjTextBoxDescription.Name = "rjTextBoxDescription";
            this.rjTextBoxDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxDescription.PasswordChar = false;
            this.rjTextBoxDescription.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBoxDescription.PlaceholderText = "Description";
            this.rjTextBoxDescription.ShowHorizontalScrollbar = false;
            this.rjTextBoxDescription.ShowVerticalScrollbar = true;
            this.rjTextBoxDescription.Size = new System.Drawing.Size(544, 103);
            this.rjTextBoxDescription.TabIndex = 2;
            this.rjTextBoxDescription.Texts = "";
            this.rjTextBoxDescription.UnderlinedStyle = false;
            this.rjTextBoxDescription.WordWrap = true;
            // 
            // rjTextBoxTitle
            // 
            this.rjTextBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.rjTextBoxTitle.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.rjTextBoxTitle.BorderRadius = 15;
            this.rjTextBoxTitle.BorderSize = 3;
            this.rjTextBoxTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxTitle.Location = new System.Drawing.Point(4, 4);
            this.rjTextBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxTitle.Multiline = true;
            this.rjTextBoxTitle.Name = "rjTextBoxTitle";
            this.rjTextBoxTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxTitle.PasswordChar = false;
            this.rjTextBoxTitle.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBoxTitle.PlaceholderText = "Title"; this.rjTextBoxTitle.PlaceholderText = "Title";
            this.rjTextBoxTitle.ShowHorizontalScrollbar = true;
            this.rjTextBoxTitle.ShowVerticalScrollbar = false;
            this.rjTextBoxTitle.Size = new System.Drawing.Size(259, 57);
            this.rjTextBoxTitle.TabIndex = 3;
            this.rjTextBoxTitle.Texts = "";
            this.rjTextBoxTitle.UnderlinedStyle = false;
            this.rjTextBoxTitle.WordWrap = false;
            // 
            // rjButtonDel
            // 
            this.rjButtonDel.BackColor = System.Drawing.Color.White;
            this.rjButtonDel.BackgroundColor = System.Drawing.Color.White;
            this.rjButtonDel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonDel.BorderRadius = 0;
            this.rjButtonDel.BorderSize = 0;
            this.rjButtonDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjButtonDel.FlatAppearance.BorderSize = 0;
            this.rjButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonDel.ForeColor = System.Drawing.Color.White;
            this.rjButtonDel.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonDel.Image")));
            this.rjButtonDel.Location = new System.Drawing.Point(0, 0);
            this.rjButtonDel.Name = "rjButtonDel";
            this.rjButtonDel.Size = new System.Drawing.Size(142, 168);
            this.rjButtonDel.TabIndex = 0;
            this.rjButtonDel.TextColor = System.Drawing.Color.White;
            this.rjButtonDel.UseVisualStyleBackColor = false;
            this.rjButtonDel.Click += new System.EventHandler(this.rjButtonDel_Click_1);
            // 
            // UC_Display
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlPenson);
            this.Controls.Add(this.rjButtonDel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Display";
            this.Size = new System.Drawing.Size(734, 168);
            this.pnlPenson.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButtonDel;
        public CustomControls.RJControls.RJTextBox rjTextBoxTitle;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.Panel pnlPenson;
        public CustomControls.RJControls.RJTextBox rjTextBoxDescription;
    }
}