namespace FallingFruits
{
    partial class ScoresTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoresTable));
            this.label1 = new System.Windows.Forms.Label();
            this.scoreTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score Table";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreTable
            // 
            this.scoreTable.AllowUserToAddRows = false;
            this.scoreTable.AllowUserToDeleteRows = false;
            this.scoreTable.AllowUserToOrderColumns = true;
            this.scoreTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.scoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.scoreTable.GridColor = System.Drawing.Color.MistyRose;
            this.scoreTable.Location = new System.Drawing.Point(159, 80);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.ReadOnly = true;
            this.scoreTable.RowHeadersWidth = 51;
            this.scoreTable.RowTemplate.Height = 24;
            this.scoreTable.Size = new System.Drawing.Size(457, 358);
            this.scoreTable.TabIndex = 3;
            // 
            // ScoresTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreTable);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScoresTable";
            this.Text = "ScoresTable";
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView scoreTable;
    }
}