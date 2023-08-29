namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            BT_GetData = new Button();
            DG_Result = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bodyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postBindingSource = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DG_Result).BeginInit();
            ((System.ComponentModel.ISupportInitialize)postBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BT_GetData
            // 
            BT_GetData.Location = new Point(27, 25);
            BT_GetData.Name = "BT_GetData";
            BT_GetData.Size = new Size(112, 34);
            BT_GetData.TabIndex = 0;
            BT_GetData.Text = "GetData";
            BT_GetData.UseVisualStyleBackColor = true;
            BT_GetData.Click += BT_GetData_Click;
            // 
            // DG_Result
            // 
            DG_Result.AutoGenerateColumns = false;
            DG_Result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Result.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, bodyDataGridViewTextBoxColumn });
            DG_Result.DataSource = postBindingSource;
            DG_Result.Location = new Point(27, 137);
            DG_Result.Name = "DG_Result";
            DG_Result.RowHeadersWidth = 62;
            DG_Result.RowTemplate.Height = 33;
            DG_Result.Size = new Size(605, 238);
            DG_Result.TabIndex = 1;
            DG_Result.ColumnHeaderMouseClick += DG_Result_ColumnHeaderMouseClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            bodyDataGridViewTextBoxColumn.MinimumWidth = 8;
            bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            bodyDataGridViewTextBoxColumn.Width = 150;
            // 
            // postBindingSource
            // 
            postBindingSource.DataSource = typeof(Model.Post);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 109);
            label1.Name = "label1";
            label1.Size = new Size(452, 25);
            label1.TabIndex = 2;
            label1.Text = "Beim Klick auf die Header, wird die Sortierung geändert.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(DG_Result);
            Controls.Add(BT_GetData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DG_Result).EndInit();
            ((System.ComponentModel.ISupportInitialize)postBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_GetData;
        private DataGridView DG_Result;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private BindingSource postBindingSource;
        private Label label1;
    }
}