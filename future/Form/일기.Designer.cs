
namespace future
{
    partial class 일기
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
            this.컨텐츠관리자 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.내용table = new System.Windows.Forms.TableLayoutPanel();
            this.txb일기내용 = new System.Windows.Forms.TextBox();
            this.하단table = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Maintable.SuspendLayout();
            this.컨텐츠관리자.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.내용table.SuspendLayout();
            this.하단table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Maintable
            // 
            this.Maintable.ColumnCount = 2;
            this.Maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.Maintable.Controls.Add(this.컨텐츠관리자, 0, 0);
            this.Maintable.Controls.Add(this.treeView1, 0, 0);
            this.Maintable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maintable.Location = new System.Drawing.Point(0, 0);
            this.Maintable.Name = "Maintable";
            this.Maintable.RowCount = 1;
            this.Maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Maintable.Size = new System.Drawing.Size(802, 448);
            this.Maintable.TabIndex = 0;
            // 
            // 컨텐츠관리자
            // 
            this.컨텐츠관리자.Controls.Add(this.tabPage);
            this.컨텐츠관리자.Dock = System.Windows.Forms.DockStyle.Fill;
            this.컨텐츠관리자.Location = new System.Drawing.Point(283, 3);
            this.컨텐츠관리자.Name = "컨텐츠관리자";
            this.컨텐츠관리자.SelectedIndex = 0;
            this.컨텐츠관리자.Size = new System.Drawing.Size(516, 442);
            this.컨텐츠관리자.TabIndex = 4;
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.Color.Transparent;
            this.tabPage.Controls.Add(this.내용table);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage.Size = new System.Drawing.Size(508, 416);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "MainHome";
            // 
            // 내용table
            // 
            this.내용table.ColumnCount = 1;
            this.내용table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.내용table.Controls.Add(this.txb일기내용, 0, 0);
            this.내용table.Controls.Add(this.하단table, 0, 1);
            this.내용table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.내용table.Location = new System.Drawing.Point(3, 3);
            this.내용table.Name = "내용table";
            this.내용table.RowCount = 2;
            this.내용table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.내용table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.내용table.Size = new System.Drawing.Size(502, 410);
            this.내용table.TabIndex = 0;
            // 
            // txb일기내용
            // 
            this.txb일기내용.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb일기내용.Location = new System.Drawing.Point(3, 3);
            this.txb일기내용.Multiline = true;
            this.txb일기내용.Name = "txb일기내용";
            this.txb일기내용.Size = new System.Drawing.Size(496, 363);
            this.txb일기내용.TabIndex = 1;
            // 
            // 하단table
            // 
            this.하단table.ColumnCount = 3;
            this.하단table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.하단table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.하단table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.하단table.Controls.Add(this.textBox2, 0, 0);
            this.하단table.Controls.Add(this.btndelete, 2, 0);
            this.하단table.Controls.Add(this.btnsave, 1, 0);
            this.하단table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.하단table.Location = new System.Drawing.Point(3, 372);
            this.하단table.Name = "하단table";
            this.하단table.RowCount = 1;
            this.하단table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.하단table.Size = new System.Drawing.Size(496, 35);
            this.하단table.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(3, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 21);
            this.textBox2.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndelete.Location = new System.Drawing.Point(399, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 29);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsave.Location = new System.Drawing.Point(300, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 29);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(280, 448);
            this.treeView1.TabIndex = 2;
            // 
            // 일기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 448);
            this.Controls.Add(this.Maintable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "일기";
            this.Text = "Maintable";
            this.Maintable.ResumeLayout(false);
            this.컨텐츠관리자.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.내용table.ResumeLayout(false);
            this.내용table.PerformLayout();
            this.하단table.ResumeLayout(false);
            this.하단table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Maintable;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl 컨텐츠관리자;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TableLayoutPanel 내용table;
        private System.Windows.Forms.TextBox txb일기내용;
        private System.Windows.Forms.TableLayoutPanel 하단table;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
    }
}