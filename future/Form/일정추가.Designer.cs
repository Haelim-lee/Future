
namespace future
{
    partial class 일정추가
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
            this.Maintable = new System.Windows.Forms.TableLayoutPanel();
            this.LB년도 = new System.Windows.Forms.Label();
            this.LB일정메모 = new System.Windows.Forms.Label();
            this.TBNsave = new System.Windows.Forms.Button();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNesc = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TXB일정 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Maintable.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Maintable
            // 
            this.Maintable.ColumnCount = 2;
            this.Maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Maintable.Controls.Add(this.LB년도, 1, 0);
            this.Maintable.Controls.Add(this.LB일정메모, 0, 1);
            this.Maintable.Controls.Add(this.TBNsave, 0, 2);
            this.Maintable.Controls.Add(this.BTNdelete, 0, 3);
            this.Maintable.Controls.Add(this.BTNesc, 0, 4);
            this.Maintable.Controls.Add(this.tabControl1, 1, 1);
            this.Maintable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maintable.Location = new System.Drawing.Point(0, 0);
            this.Maintable.Margin = new System.Windows.Forms.Padding(0);
            this.Maintable.Name = "Maintable";
            this.Maintable.RowCount = 5;
            this.Maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Maintable.Size = new System.Drawing.Size(423, 247);
            this.Maintable.TabIndex = 0;
            // 
            // LB년도
            // 
            this.LB년도.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LB년도.AutoSize = true;
            this.LB년도.Location = new System.Drawing.Point(391, 6);
            this.LB년도.Name = "LB년도";
            this.LB년도.Size = new System.Drawing.Size(29, 12);
            this.LB년도.TabIndex = 0;
            this.LB년도.Text = "년도";
            // 
            // LB일정메모
            // 
            this.LB일정메모.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB일정메모.AutoSize = true;
            this.LB일정메모.Location = new System.Drawing.Point(15, 45);
            this.LB일정메모.Name = "LB일정메모";
            this.LB일정메모.Size = new System.Drawing.Size(53, 12);
            this.LB일정메모.TabIndex = 1;
            this.LB일정메모.Text = "일정메모";
            // 
            // TBNsave
            // 
            this.TBNsave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBNsave.Location = new System.Drawing.Point(0, 79);
            this.TBNsave.Margin = new System.Windows.Forms.Padding(0);
            this.TBNsave.Name = "TBNsave";
            this.TBNsave.Size = new System.Drawing.Size(84, 55);
            this.TBNsave.TabIndex = 2;
            this.TBNsave.Text = "SAVE";
            this.TBNsave.UseVisualStyleBackColor = true;
            this.TBNsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNdelete
            // 
            this.BTNdelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNdelete.Location = new System.Drawing.Point(0, 134);
            this.BTNdelete.Margin = new System.Windows.Forms.Padding(0);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(84, 55);
            this.BTNdelete.TabIndex = 3;
            this.BTNdelete.Text = "DELETE";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNesc
            // 
            this.BTNesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNesc.Location = new System.Drawing.Point(0, 189);
            this.BTNesc.Margin = new System.Windows.Forms.Padding(0);
            this.BTNesc.Name = "BTNesc";
            this.BTNesc.Size = new System.Drawing.Size(84, 58);
            this.BTNesc.TabIndex = 4;
            this.BTNesc.Text = "ESC";
            this.BTNesc.UseVisualStyleBackColor = true;
            this.BTNesc.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(84, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.Maintable.SetRowSpan(this.tabControl1, 4);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 223);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TXB일정);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "일정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TXB일정
            // 
            this.TXB일정.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXB일정.Location = new System.Drawing.Point(3, 3);
            this.TXB일정.Multiline = true;
            this.TXB일정.Name = "TXB일정";
            this.TXB일정.Size = new System.Drawing.Size(325, 191);
            this.TXB일정.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "일정2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 173);
            this.textBox2.TabIndex = 0;
            // 
            // 일정추가
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 247);
            this.Controls.Add(this.Maintable);
            this.Name = "일정추가";
            this.Text = "일정추가";
            this.Maintable.ResumeLayout(false);
            this.Maintable.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Maintable;
        private System.Windows.Forms.Label LB년도;
        private System.Windows.Forms.Label LB일정메모;
        private System.Windows.Forms.Button TBNsave;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Button BTNesc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TXB일정;
        private System.Windows.Forms.TextBox textBox2;
    }
}