namespace Atividade_Extra_AFD
{
    partial class AFD
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
            this.groupAluno = new System.Windows.Forms.GroupBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataInput = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReduce = new System.Windows.Forms.Button();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.dataOutput = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupAluno.SuspendLayout();
            this.groupInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInput)).BeginInit();
            this.groupOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAluno
            // 
            this.groupAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAluno.Controls.Add(this.lblAluno);
            this.groupAluno.Location = new System.Drawing.Point(12, 12);
            this.groupAluno.Name = "groupAluno";
            this.groupAluno.Size = new System.Drawing.Size(473, 80);
            this.groupAluno.TabIndex = 0;
            this.groupAluno.TabStop = false;
            this.groupAluno.Text = "Aluno";
            // 
            // lblAluno
            // 
            this.lblAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAluno.Location = new System.Drawing.Point(3, 16);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(467, 61);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Tiago Grossi Hasuda\r\n\r\nRA 1694324";
            this.lblAluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupInput
            // 
            this.groupInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInput.Controls.Add(this.btnReduce);
            this.groupInput.Controls.Add(this.dataInput);
            this.groupInput.Controls.Add(this.label1);
            this.groupInput.Location = new System.Drawing.Point(12, 98);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(473, 300);
            this.groupInput.TabIndex = 1;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o AFD na tabela abaixo (o primeiro estado será tido como o estado inicial)" +
    "";
            // 
            // dataInput
            // 
            this.dataInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataInput.Location = new System.Drawing.Point(6, 32);
            this.dataInput.Name = "dataInput";
            this.dataInput.Size = new System.Drawing.Size(461, 234);
            this.dataInput.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estados";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "a";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "b";
            this.Column3.Name = "Column3";
            // 
            // btnReduce
            // 
            this.btnReduce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReduce.Location = new System.Drawing.Point(355, 272);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(112, 22);
            this.btnReduce.TabIndex = 2;
            this.btnReduce.Text = "Reduzir AFD";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // groupOutput
            // 
            this.groupOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOutput.Controls.Add(this.dataOutput);
            this.groupOutput.Location = new System.Drawing.Point(12, 404);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(473, 221);
            this.groupOutput.TabIndex = 2;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Saída";
            // 
            // dataOutput
            // 
            this.dataOutput.AllowUserToAddRows = false;
            this.dataOutput.AllowUserToDeleteRows = false;
            this.dataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column5});
            this.dataOutput.Location = new System.Drawing.Point(6, 19);
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.ReadOnly = true;
            this.dataOutput.Size = new System.Drawing.Size(461, 196);
            this.dataOutput.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Estados";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "a";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "b";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado aceitador";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado aceitador";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 637);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.groupAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade extra AFD - Teoria da computação - Tiago Grossi Hasuda";
            this.groupAluno.ResumeLayout(false);
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInput)).EndInit();
            this.groupOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.DataGridView dataInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.DataGridView dataOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}

