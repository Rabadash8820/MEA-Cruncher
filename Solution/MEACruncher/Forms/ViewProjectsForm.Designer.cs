﻿namespace MEACruncher.Forms {
    partial class ViewProjectsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProjectsForm));
            this.MainTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EntitiesDGV = new System.Windows.Forms.DataGridView();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStartedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EntityBS)).BeginInit();
            this.MainTblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntitiesDGV)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTblLayout
            // 
            this.MainTblLayout.ColumnCount = 1;
            this.MainTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTblLayout.Controls.Add(this.EntitiesDGV, 0, 0);
            this.MainTblLayout.Controls.Add(this.BottomPanel, 0, 1);
            this.MainTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTblLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTblLayout.Name = "MainTblLayout";
            this.MainTblLayout.RowCount = 2;
            this.MainTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTblLayout.Size = new System.Drawing.Size(499, 264);
            this.MainTblLayout.TabIndex = 0;
            // 
            // EntitiesDGV
            // 
            this.EntitiesDGV.AllowUserToAddRows = false;
            this.EntitiesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntitiesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleCol,
            this.DateStartedCol,
            this.CommentsCol});
            this.EntitiesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntitiesDGV.Location = new System.Drawing.Point(3, 3);
            this.EntitiesDGV.Name = "EntitiesDGV";
            this.EntitiesDGV.Size = new System.Drawing.Size(493, 223);
            this.EntitiesDGV.TabIndex = 0;
            this.EntitiesDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.EntitiesDGV_CellFormatting);
            this.EntitiesDGV.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.EntitiesDGV_CellValidating);
            this.EntitiesDGV.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.EntitiesDGV_RowValidated);
            this.EntitiesDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.EntitiesDGV_RowValidating);
            this.EntitiesDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.EntitiesDGV_DataError);
            this.EntitiesDGV.CellDoubleClick += EntitiesDGV_CellDoubleClick;
            // 
            // TitleCol
            // 
            this.TitleCol.HeaderText = "Title";
            this.TitleCol.Name = "TitleCol";
            // 
            // DateStartedCol
            // 
            this.DateStartedCol.HeaderText = "Date Started";
            this.DateStartedCol.Name = "DateStartedCol";
            // 
            // CommentsCol
            // 
            this.CommentsCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CommentsCol.HeaderText = "Comments";
            this.CommentsCol.Name = "CommentsCol";
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DeleteBtn);
            this.BottomPanel.Controls.Add(this.CloseBtn);
            this.BottomPanel.Controls.Add(this.EditBtn);
            this.BottomPanel.Controls.Add(this.NewBtn);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(3, 232);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(493, 29);
            this.BottomPanel.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(165, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(415, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(84, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(3, 3);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // ViewProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(499, 264);
            this.Controls.Add(this.MainTblLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 150);
            this.Name = "ViewProjectsForm";
            this.ShowInTaskbar = false;
            this.Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)(this.EntityBS)).EndInit();
            this.MainTblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EntitiesDGV)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTblLayout;
        private System.Windows.Forms.DataGridView EntitiesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStartedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsCol;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}