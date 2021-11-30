
namespace Read_File
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_text = new System.Windows.Forms.Button();
            this.richTextBox_Path = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(41, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(923, 410);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button_text
            // 
            this.button_text.Location = new System.Drawing.Point(796, 53);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(168, 41);
            this.button_text.TabIndex = 1;
            this.button_text.Text = "Read file";
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox_Path
            // 
            this.richTextBox_Path.Location = new System.Drawing.Point(41, 53);
            this.richTextBox_Path.Name = "richTextBox_Path";
            this.richTextBox_Path.Size = new System.Drawing.Size(721, 41);
            this.richTextBox_Path.TabIndex = 2;
            this.richTextBox_Path.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(923, 410);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox_Path);
            this.Controls.Add(this.button_text);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_text;
        private System.Windows.Forms.RichTextBox richTextBox_Path;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

