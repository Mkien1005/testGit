namespace testGit
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
            this.btnDay1 = new System.Windows.Forms.Button();
            this.btnDay2 = new System.Windows.Forms.Button();
            this.btnDay3 = new System.Windows.Forms.Button();
            this.btnDay4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grv1 = new System.Windows.Forms.DataGridView();
            this.grv2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDay1
            // 
            this.btnDay1.Location = new System.Drawing.Point(162, 42);
            this.btnDay1.Name = "btnDay1";
            this.btnDay1.Size = new System.Drawing.Size(106, 46);
            this.btnDay1.TabIndex = 0;
            this.btnDay1.Text = "19/12/2022";
            this.btnDay1.UseVisualStyleBackColor = true;
            this.btnDay1.Click += new System.EventHandler(this.btnDay1_Click);
            // 
            // btnDay2
            // 
            this.btnDay2.Location = new System.Drawing.Point(312, 42);
            this.btnDay2.Name = "btnDay2";
            this.btnDay2.Size = new System.Drawing.Size(106, 46);
            this.btnDay2.TabIndex = 0;
            this.btnDay2.Text = "20/12/2022";
            this.btnDay2.UseVisualStyleBackColor = true;
            // 
            // btnDay3
            // 
            this.btnDay3.Location = new System.Drawing.Point(460, 42);
            this.btnDay3.Name = "btnDay3";
            this.btnDay3.Size = new System.Drawing.Size(106, 46);
            this.btnDay3.TabIndex = 0;
            this.btnDay3.Text = "21/12/2022";
            this.btnDay3.UseVisualStyleBackColor = true;
            // 
            // btnDay4
            // 
            this.btnDay4.Location = new System.Drawing.Point(606, 42);
            this.btnDay4.Name = "btnDay4";
            this.btnDay4.Size = new System.Drawing.Size(106, 46);
            this.btnDay4.TabIndex = 0;
            this.btnDay4.Text = "22/12/2022";
            this.btnDay4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày";
            // 
            // grv1
            // 
            this.grv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv1.Location = new System.Drawing.Point(162, 109);
            this.grv1.Name = "grv1";
            this.grv1.RowHeadersWidth = 51;
            this.grv1.RowTemplate.Height = 24;
            this.grv1.Size = new System.Drawing.Size(550, 146);
            this.grv1.TabIndex = 2;
            // 
            // grv2
            // 
            this.grv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv2.Location = new System.Drawing.Point(162, 298);
            this.grv2.Name = "grv2";
            this.grv2.RowHeadersWidth = 51;
            this.grv2.RowTemplate.Height = 24;
            this.grv2.Size = new System.Drawing.Size(550, 146);
            this.grv2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sáng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chiều";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grv2);
            this.Controls.Add(this.grv1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDay4);
            this.Controls.Add(this.btnDay3);
            this.Controls.Add(this.btnDay2);
            this.Controls.Add(this.btnDay1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDay1;
        private System.Windows.Forms.Button btnDay2;
        private System.Windows.Forms.Button btnDay3;
        private System.Windows.Forms.Button btnDay4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grv1;
        private System.Windows.Forms.DataGridView grv2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

