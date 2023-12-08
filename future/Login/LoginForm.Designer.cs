
namespace future
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Maintable = new System.Windows.Forms.TableLayoutPanel();
            this.로그인table = new System.Windows.Forms.TableLayoutPanel();
            this.LB로그인 = new System.Windows.Forms.Label();
            this.회원가입table = new System.Windows.Forms.TableLayoutPanel();
            this.btnJoin = new System.Windows.Forms.Button();
            this.LB회원가입 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.로그인메뉴table = new System.Windows.Forms.TableLayoutPanel();
            this.LB로고 = new System.Windows.Forms.Label();
            this.메인로그table = new System.Windows.Forms.TableLayoutPanel();
            this.Maintable.SuspendLayout();
            this.로그인table.SuspendLayout();
            this.회원가입table.SuspendLayout();
            this.로그인메뉴table.SuspendLayout();
            this.메인로그table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Maintable
            // 
            this.Maintable.ColumnCount = 2;
            this.Maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Maintable.Controls.Add(this.로그인메뉴table, 1, 0);
            this.Maintable.Controls.Add(this.메인로그table, 0, 0);
            this.Maintable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maintable.Location = new System.Drawing.Point(0, 0);
            this.Maintable.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Maintable.Name = "Maintable";
            this.Maintable.RowCount = 1;
            this.Maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Maintable.Size = new System.Drawing.Size(557, 355);
            this.Maintable.TabIndex = 2;
            // 
            // 로그인table
            // 
            this.로그인table.ColumnCount = 3;
            this.로그인table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.로그인table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.로그인table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.로그인table.Controls.Add(this.txtLoginID, 1, 1);
            this.로그인table.Controls.Add(this.txtPassword, 1, 3);
            this.로그인table.Controls.Add(this.btnLogin, 1, 5);
            this.로그인table.Controls.Add(this.회원가입table, 1, 6);
            this.로그인table.Controls.Add(this.LB로그인, 1, 0);
            this.로그인table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.로그인table.Location = new System.Drawing.Point(0, 35);
            this.로그인table.Margin = new System.Windows.Forms.Padding(0);
            this.로그인table.Name = "로그인table";
            this.로그인table.RowCount = 7;
            this.로그인table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.7798F));
            this.로그인table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.4841F));
            this.로그인table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.17798F));
            this.로그인table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.7798F));
            this.로그인table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.17798F));
            this.로그인table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.7798F));
            this.로그인table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.820555F));
            this.로그인table.Size = new System.Drawing.Size(335, 284);
            this.로그인table.TabIndex = 0;
            // 
            // LB로그인
            // 
            this.LB로그인.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB로그인.AutoSize = true;
            this.LB로그인.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LB로그인.Location = new System.Drawing.Point(103, 24);
            this.LB로그인.Name = "LB로그인";
            this.LB로그인.Size = new System.Drawing.Size(127, 12);
            this.LB로그인.TabIndex = 4;
            this.LB로그인.Text = "USER ID & PASSWORD";
            // 
            // 회원가입table
            // 
            this.회원가입table.ColumnCount = 3;
            this.회원가입table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.회원가입table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.회원가입table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.회원가입table.Controls.Add(this.LB회원가입, 1, 0);
            this.회원가입table.Controls.Add(this.btnJoin, 0, 0);
            this.회원가입table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.회원가입table.Location = new System.Drawing.Point(16, 258);
            this.회원가입table.Margin = new System.Windows.Forms.Padding(0);
            this.회원가입table.Name = "회원가입table";
            this.회원가입table.RowCount = 1;
            this.회원가입table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.회원가입table.Size = new System.Drawing.Size(301, 26);
            this.회원가입table.TabIndex = 3;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.LightGray;
            this.btnJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJoin.Location = new System.Drawing.Point(0, 0);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(0);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(121, 26);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Click";
            this.btnJoin.UseVisualStyleBackColor = false;
            // 
            // LB회원가입
            // 
            this.LB회원가입.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LB회원가입.AutoSize = true;
            this.LB회원가입.BackColor = System.Drawing.SystemColors.Control;
            this.LB회원가입.Location = new System.Drawing.Point(124, 7);
            this.LB회원가입.Name = "LB회원가입";
            this.LB회원가입.Size = new System.Drawing.Size(53, 12);
            this.LB회원가입.TabIndex = 0;
            this.LB회원가입.Text = "회원가입";
            this.LB회원가입.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Location = new System.Drawing.Point(16, 197);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(301, 61);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(16, 150);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(301, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtLoginID
            // 
            this.txtLoginID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginID.Location = new System.Drawing.Point(16, 82);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(0);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(301, 21);
            this.txtLoginID.TabIndex = 0;
            // 
            // 로그인메뉴table
            // 
            this.로그인메뉴table.BackColor = System.Drawing.Color.WhiteSmoke;
            this.로그인메뉴table.ColumnCount = 1;
            this.로그인메뉴table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.로그인메뉴table.Controls.Add(this.로그인table, 0, 1);
            this.로그인메뉴table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.로그인메뉴table.Location = new System.Drawing.Point(222, 0);
            this.로그인메뉴table.Margin = new System.Windows.Forms.Padding(0);
            this.로그인메뉴table.Name = "로그인메뉴table";
            this.로그인메뉴table.RowCount = 3;
            this.로그인메뉴table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.로그인메뉴table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.로그인메뉴table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.로그인메뉴table.Size = new System.Drawing.Size(335, 355);
            this.로그인메뉴table.TabIndex = 1;
            // 
            // LB로고
            // 
            this.LB로고.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB로고.AutoSize = true;
            this.LB로고.BackColor = System.Drawing.Color.Transparent;
            this.LB로고.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LB로고.Location = new System.Drawing.Point(88, 168);
            this.LB로고.Name = "LB로고";
            this.LB로고.Size = new System.Drawing.Size(40, 12);
            this.LB로고.TabIndex = 0;
            this.LB로고.Text = "Future";
            // 
            // 메인로그table
            // 
            this.메인로그table.BackColor = System.Drawing.Color.LightSteelBlue;
            this.메인로그table.ColumnCount = 1;
            this.메인로그table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.메인로그table.Controls.Add(this.LB로고, 0, 1);
            this.메인로그table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.메인로그table.Location = new System.Drawing.Point(3, 3);
            this.메인로그table.Name = "메인로그table";
            this.메인로그table.RowCount = 3;
            this.메인로그table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.메인로그table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.메인로그table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.메인로그table.Size = new System.Drawing.Size(216, 349);
            this.메인로그table.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 355);
            this.Controls.Add(this.Maintable);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Maintable.ResumeLayout(false);
            this.로그인table.ResumeLayout(false);
            this.로그인table.PerformLayout();
            this.회원가입table.ResumeLayout(false);
            this.회원가입table.PerformLayout();
            this.로그인메뉴table.ResumeLayout(false);
            this.메인로그table.ResumeLayout(false);
            this.메인로그table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Maintable;
        private System.Windows.Forms.TableLayoutPanel 로그인메뉴table;
        private System.Windows.Forms.TableLayoutPanel 로그인table;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel 회원가입table;
        private System.Windows.Forms.Label LB회원가입;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label LB로그인;
        private System.Windows.Forms.TableLayoutPanel 메인로그table;
        private System.Windows.Forms.Label LB로고;
    }
}

