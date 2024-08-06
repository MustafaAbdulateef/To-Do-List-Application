namespace Mustafa_Abdulateef_To_Do_List_Application
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.rjButtonUndo = new CustomControls.RJControls.RJButton();
            this.rjButtonRedo = new CustomControls.RJControls.RJButton();
            this.rjButtonCalendar = new CustomControls.RJControls.RJButton();
            this.rjButtonAddNew = new CustomControls.RJControls.RJButton();
            this.rjButtonClearAll = new CustomControls.RJControls.RJButton();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.rjTextBoxSearch = new CustomControls.RJControls.RJTextBox();
            this.rjButtonSave = new CustomControls.RJControls.RJButton();
            this.tableLayoutPanelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDisplay
            // 
            this.tableLayoutPanelDisplay.AutoScroll = true;
            this.tableLayoutPanelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelDisplay.ColumnCount = 8;
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDisplay.Controls.Add(this.rjButtonUndo, 1, 0);
            this.tableLayoutPanelDisplay.Controls.Add(this.rjButtonRedo, 2, 0);
            this.tableLayoutPanelDisplay.Controls.Add(this.rjButtonCalendar, 3, 0);
            this.tableLayoutPanelDisplay.Controls.Add(this.rjButtonAddNew, 4, 0);
            this.tableLayoutPanelDisplay.Controls.Add(this.rjButtonClearAll, 5, 0);
            this.tableLayoutPanelDisplay.Controls.Add(this.FLP, 1, 2);
            this.tableLayoutPanelDisplay.Controls.Add(this.rjTextBoxSearch, 4, 1);
            this.tableLayoutPanelDisplay.Controls.Add(this.rjButtonSave, 5, 6);
            this.tableLayoutPanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDisplay.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDisplay.Name = "tableLayoutPanelDisplay";
            this.tableLayoutPanelDisplay.RowCount = 9;
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDisplay.Size = new System.Drawing.Size(1038, 785);
            this.tableLayoutPanelDisplay.TabIndex = 0;
            // 
            // rjButtonUndo
            // 
            this.rjButtonUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(178)))));
            this.rjButtonUndo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(178)))));
            this.rjButtonUndo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonUndo.BorderRadius = 10;
            this.rjButtonUndo.BorderSize = 0;
            this.rjButtonUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButtonUndo.FlatAppearance.BorderSize = 0;
            this.rjButtonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonUndo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonUndo.ForeColor = System.Drawing.Color.White;
            this.rjButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonUndo.Image")));
            this.rjButtonUndo.Location = new System.Drawing.Point(151, 3);
            this.rjButtonUndo.Name = "rjButtonUndo";
            this.rjButtonUndo.Size = new System.Drawing.Size(142, 109);
            this.rjButtonUndo.TabIndex = 11;
            this.rjButtonUndo.TextColor = System.Drawing.Color.White;
            this.rjButtonUndo.UseVisualStyleBackColor = false;
            this.rjButtonUndo.Click += new System.EventHandler(this.rjButtonUndo_Click);
            // 
            // rjButtonRedo
            // 
            this.rjButtonRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(178)))));
            this.rjButtonRedo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(178)))));
            this.rjButtonRedo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonRedo.BorderRadius = 10;
            this.rjButtonRedo.BorderSize = 0;
            this.rjButtonRedo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButtonRedo.FlatAppearance.BorderSize = 0;
            this.rjButtonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonRedo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonRedo.ForeColor = System.Drawing.Color.White;
            this.rjButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonRedo.Image")));
            this.rjButtonRedo.Location = new System.Drawing.Point(299, 3);
            this.rjButtonRedo.Name = "rjButtonRedo";
            this.rjButtonRedo.Size = new System.Drawing.Size(142, 109);
            this.rjButtonRedo.TabIndex = 12;
            this.rjButtonRedo.TextColor = System.Drawing.Color.White;
            this.rjButtonRedo.UseVisualStyleBackColor = false;
            this.rjButtonRedo.Click += new System.EventHandler(this.rjButtonRedo_Click);
            // 
            // rjButtonCalendar
            // 
            this.rjButtonCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(178)))));
            this.rjButtonCalendar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(178)))));
            this.rjButtonCalendar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonCalendar.BorderRadius = 10;
            this.rjButtonCalendar.BorderSize = 0;
            this.rjButtonCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButtonCalendar.FlatAppearance.BorderSize = 0;
            this.rjButtonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonCalendar.ForeColor = System.Drawing.Color.White;
            this.rjButtonCalendar.Location = new System.Drawing.Point(447, 3);
            this.rjButtonCalendar.Name = "rjButtonCalendar";
            this.rjButtonCalendar.Size = new System.Drawing.Size(142, 109);
            this.rjButtonCalendar.TabIndex = 13;
            this.rjButtonCalendar.Text = "Calendar";
            this.rjButtonCalendar.TextColor = System.Drawing.Color.White;
            this.rjButtonCalendar.UseVisualStyleBackColor = false;
            this.rjButtonCalendar.Click += new System.EventHandler(this.rjButtonCalendar_Click);
            // 
            // rjButtonAddNew
            // 
            this.rjButtonAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.rjButtonAddNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.rjButtonAddNew.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonAddNew.BorderRadius = 10;
            this.rjButtonAddNew.BorderSize = 0;
            this.rjButtonAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButtonAddNew.FlatAppearance.BorderSize = 0;
            this.rjButtonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAddNew.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonAddNew.ForeColor = System.Drawing.Color.White;
            this.rjButtonAddNew.Location = new System.Drawing.Point(595, 3);
            this.rjButtonAddNew.Name = "rjButtonAddNew";
            this.rjButtonAddNew.Size = new System.Drawing.Size(142, 109);
            this.rjButtonAddNew.TabIndex = 14;
            this.rjButtonAddNew.Text = "Add New";
            this.rjButtonAddNew.TextColor = System.Drawing.Color.White;
            this.rjButtonAddNew.UseVisualStyleBackColor = false;
            // 
            // rjButtonClearAll
            // 
            this.rjButtonClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.rjButtonClearAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.rjButtonClearAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonClearAll.BorderRadius = 10;
            this.rjButtonClearAll.BorderSize = 0;
            this.rjButtonClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButtonClearAll.FlatAppearance.BorderSize = 0;
            this.rjButtonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClearAll.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonClearAll.ForeColor = System.Drawing.Color.White;
            this.rjButtonClearAll.Location = new System.Drawing.Point(743, 3);
            this.rjButtonClearAll.Name = "rjButtonClearAll";
            this.rjButtonClearAll.Size = new System.Drawing.Size(142, 109);
            this.rjButtonClearAll.TabIndex = 15;
            this.rjButtonClearAll.Text = "Clear All";
            this.rjButtonClearAll.TextColor = System.Drawing.Color.White;
            this.rjButtonClearAll.UseVisualStyleBackColor = false;
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelDisplay.SetColumnSpan(this.FLP, 5);
            this.FLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLP.Location = new System.Drawing.Point(148, 155);
            this.FLP.Margin = new System.Windows.Forms.Padding(0);
            this.FLP.Name = "FLP";
            this.FLP.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanelDisplay.SetRowSpan(this.FLP, 4);
            this.FLP.Size = new System.Drawing.Size(740, 460);
            this.FLP.TabIndex = 10;
            this.FLP.WrapContents = false;
            // 
            // rjTextBoxSearch
            // 
            this.rjTextBoxSearch.BackColor = System.Drawing.Color.White;
            this.rjTextBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.rjTextBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.rjTextBoxSearch.BorderRadius = 15;
            this.rjTextBoxSearch.BorderSize = 3;
            this.tableLayoutPanelDisplay.SetColumnSpan(this.rjTextBoxSearch, 2);
            this.rjTextBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxSearch.Location = new System.Drawing.Point(596, 119);
            this.rjTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxSearch.Multiline = false;
            this.rjTextBoxSearch.Name = "rjTextBoxSearch";
            this.rjTextBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxSearch.PasswordChar = false;
            this.rjTextBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxSearch.PlaceholderText = "⌕ Search";
            this.rjTextBoxSearch.ShowHorizontalScrollbar = false;
            this.rjTextBoxSearch.ShowVerticalScrollbar = false;
            this.rjTextBoxSearch.Size = new System.Drawing.Size(288, 32);
            this.rjTextBoxSearch.TabIndex = 9;
            this.rjTextBoxSearch.Texts = "";
            this.rjTextBoxSearch.UnderlinedStyle = false;
            this.rjTextBoxSearch.WordWrap = true;
            // 
            // rjButtonSave
            // 
            this.rjButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.rjButtonSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.rjButtonSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonSave.BorderRadius = 10;
            this.rjButtonSave.BorderSize = 0;
            this.rjButtonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButtonSave.FlatAppearance.BorderSize = 0;
            this.rjButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonSave.ForeColor = System.Drawing.Color.White;
            this.rjButtonSave.Location = new System.Drawing.Point(743, 618);
            this.rjButtonSave.Name = "rjButtonSave";
            this.rjButtonSave.Size = new System.Drawing.Size(142, 44);
            this.rjButtonSave.TabIndex = 16;
            this.rjButtonSave.Text = "Save";
            this.rjButtonSave.TextColor = System.Drawing.Color.White;
            this.rjButtonSave.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 785);
            this.Controls.Add(this.tableLayoutPanelDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1054, 824);
            this.Name = "MainForm";
            this.Text = "To-Do List";
            this.tableLayoutPanelDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDisplay;
        private CustomControls.RJControls.RJTextBox rjTextBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private CustomControls.RJControls.RJButton rjButtonUndo;
        private CustomControls.RJControls.RJButton rjButtonRedo;
        private CustomControls.RJControls.RJButton rjButtonCalendar;
        private CustomControls.RJControls.RJButton rjButtonAddNew;
        private CustomControls.RJControls.RJButton rjButtonClearAll;
        private CustomControls.RJControls.RJButton rjButtonSave;
    }
}