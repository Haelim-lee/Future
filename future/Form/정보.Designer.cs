
namespace future
{
    partial class 정보
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Maintable = new System.Windows.Forms.TableLayoutPanel();
            this.datatable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.생년월일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주소 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전화번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.성별 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.직업 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.분류 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.키 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.몸무게 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.혈액형 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.특이사항 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검색table = new System.Windows.Forms.TableLayoutPanel();
            this.LB메인검색 = new System.Windows.Forms.Label();
            this.LB이름 = new System.Windows.Forms.Label();
            this.TXB이름 = new System.Windows.Forms.TextBox();
            this.TXB전화번호 = new System.Windows.Forms.TextBox();
            this.LB전화번호 = new System.Windows.Forms.Label();
            this.sextable = new System.Windows.Forms.TableLayoutPanel();
            this.LB성별 = new System.Windows.Forms.Label();
            this.RBO여 = new System.Windows.Forms.RadioButton();
            this.RBO남 = new System.Windows.Forms.RadioButton();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn검색 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.분류table = new System.Windows.Forms.TableLayoutPanel();
            this.LB분류 = new System.Windows.Forms.Label();
            this.cbo분류 = new System.Windows.Forms.ComboBox();
            this.Maintable.SuspendLayout();
            this.datatable.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.검색table.SuspendLayout();
            this.sextable.SuspendLayout();
            this.분류table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Maintable
            // 
            this.Maintable.ColumnCount = 2;
            this.Maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.Maintable.Controls.Add(this.datatable, 1, 0);
            this.Maintable.Controls.Add(this.검색table, 0, 0);
            this.Maintable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maintable.Location = new System.Drawing.Point(0, 0);
            this.Maintable.Margin = new System.Windows.Forms.Padding(0);
            this.Maintable.Name = "Maintable";
            this.Maintable.RowCount = 1;
            this.Maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Maintable.Size = new System.Drawing.Size(868, 541);
            this.Maintable.TabIndex = 0;
            // 
            // datatable
            // 
            this.datatable.ColumnCount = 1;
            this.datatable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datatable.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.datatable.Controls.Add(this.dataGridView1, 0, 0);
            this.datatable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datatable.Location = new System.Drawing.Point(305, 2);
            this.datatable.Margin = new System.Windows.Forms.Padding(2);
            this.datatable.Name = "datatable";
            this.datatable.RowCount = 2;
            this.datatable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.datatable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.datatable.Size = new System.Drawing.Size(561, 537);
            this.datatable.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 483);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 54);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(341, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(341, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "저장";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.이름,
            this.생년월일,
            this.주소,
            this.전화번호,
            this.성별,
            this.직업,
            this.분류,
            this.키,
            this.몸무게,
            this.혈액형,
            this.특이사항});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(557, 479);
            this.dataGridView1.TabIndex = 1;
            // 
            // 이름
            // 
            this.이름.DataPropertyName = "이름";
            this.이름.HeaderText = "이름";
            this.이름.Name = "이름";
            // 
            // 생년월일
            // 
            this.생년월일.DataPropertyName = "생년월일";
            this.생년월일.HeaderText = "생년월일";
            this.생년월일.Name = "생년월일";
            // 
            // 주소
            // 
            this.주소.DataPropertyName = "주소";
            this.주소.HeaderText = "주소";
            this.주소.Name = "주소";
            // 
            // 전화번호
            // 
            this.전화번호.DataPropertyName = "전화번호";
            this.전화번호.HeaderText = "전화번호";
            this.전화번호.Name = "전화번호";
            // 
            // 성별
            // 
            this.성별.DataPropertyName = "성별";
            this.성별.HeaderText = "성별";
            this.성별.Name = "성별";
            // 
            // 직업
            // 
            this.직업.DataPropertyName = "직업";
            this.직업.HeaderText = "직업";
            this.직업.Name = "직업";
            // 
            // 분류
            // 
            this.분류.DataPropertyName = "분류";
            this.분류.HeaderText = "분류";
            this.분류.Name = "분류";
            // 
            // 키
            // 
            this.키.DataPropertyName = "키";
            this.키.HeaderText = "키";
            this.키.Name = "키";
            // 
            // 몸무게
            // 
            this.몸무게.DataPropertyName = "몸무게";
            this.몸무게.HeaderText = "몸무게";
            this.몸무게.Name = "몸무게";
            // 
            // 혈액형
            // 
            this.혈액형.DataPropertyName = "혈액형";
            this.혈액형.HeaderText = "혈액형";
            this.혈액형.Name = "혈액형";
            // 
            // 특이사항
            // 
            this.특이사항.DataPropertyName = "특이사항";
            this.특이사항.HeaderText = "특이사항";
            this.특이사항.Name = "특이사항";
            // 
            // 검색table
            // 
            this.검색table.BackColor = System.Drawing.Color.White;
            this.검색table.ColumnCount = 2;
            this.검색table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.검색table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.검색table.Controls.Add(this.LB메인검색, 0, 0);
            this.검색table.Controls.Add(this.LB이름, 0, 1);
            this.검색table.Controls.Add(this.TXB이름, 1, 1);
            this.검색table.Controls.Add(this.TXB전화번호, 1, 2);
            this.검색table.Controls.Add(this.LB전화번호, 0, 2);
            this.검색table.Controls.Add(this.sextable, 1, 3);
            this.검색table.Controls.Add(this.btn초기화, 0, 5);
            this.검색table.Controls.Add(this.btn검색, 1, 5);
            this.검색table.Controls.Add(this.treeView1, 0, 4);
            this.검색table.Controls.Add(this.분류table, 0, 3);
            this.검색table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.검색table.Location = new System.Drawing.Point(0, 0);
            this.검색table.Margin = new System.Windows.Forms.Padding(0);
            this.검색table.Name = "검색table";
            this.검색table.RowCount = 6;
            this.검색table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.검색table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.검색table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.검색table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.검색table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.검색table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.검색table.Size = new System.Drawing.Size(303, 541);
            this.검색table.TabIndex = 1;
            // 
            // LB메인검색
            // 
            this.LB메인검색.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB메인검색.AutoSize = true;
            this.검색table.SetColumnSpan(this.LB메인검색, 2);
            this.LB메인검색.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB메인검색.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LB메인검색.Location = new System.Drawing.Point(119, 14);
            this.LB메인검색.Name = "LB메인검색";
            this.LB메인검색.Size = new System.Drawing.Size(65, 25);
            this.LB메인검색.TabIndex = 0;
            this.LB메인검색.Text = "검색 ! ";
            // 
            // LB이름
            // 
            this.LB이름.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LB이름.AutoSize = true;
            this.LB이름.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB이름.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LB이름.Location = new System.Drawing.Point(50, 60);
            this.LB이름.Name = "LB이름";
            this.LB이름.Size = new System.Drawing.Size(37, 15);
            this.LB이름.TabIndex = 1;
            this.LB이름.Text = "이름 :";
            // 
            // TXB이름
            // 
            this.TXB이름.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXB이름.Location = new System.Drawing.Point(148, 57);
            this.TXB이름.Margin = new System.Windows.Forms.Padding(0);
            this.TXB이름.Name = "TXB이름";
            this.TXB이름.Size = new System.Drawing.Size(97, 21);
            this.TXB이름.TabIndex = 2;
            // 
            // TXB전화번호
            // 
            this.TXB전화번호.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXB전화번호.Location = new System.Drawing.Point(147, 84);
            this.TXB전화번호.Name = "TXB전화번호";
            this.TXB전화번호.Size = new System.Drawing.Size(98, 21);
            this.TXB전화번호.TabIndex = 3;
            // 
            // LB전화번호
            // 
            this.LB전화번호.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LB전화번호.AutoSize = true;
            this.LB전화번호.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB전화번호.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LB전화번호.Location = new System.Drawing.Point(26, 87);
            this.LB전화번호.Name = "LB전화번호";
            this.LB전화번호.Size = new System.Drawing.Size(61, 15);
            this.LB전화번호.TabIndex = 4;
            this.LB전화번호.Text = "전화번호 :";
            // 
            // sextable
            // 
            this.sextable.ColumnCount = 2;
            this.sextable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sextable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sextable.Controls.Add(this.LB성별, 0, 0);
            this.sextable.Controls.Add(this.RBO여, 0, 1);
            this.sextable.Controls.Add(this.RBO남, 1, 1);
            this.sextable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sextable.Location = new System.Drawing.Point(90, 108);
            this.sextable.Margin = new System.Windows.Forms.Padding(0);
            this.sextable.Name = "sextable";
            this.sextable.RowCount = 2;
            this.sextable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sextable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sextable.Size = new System.Drawing.Size(213, 54);
            this.sextable.TabIndex = 6;
            // 
            // LB성별
            // 
            this.LB성별.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB성별.AutoSize = true;
            this.sextable.SetColumnSpan(this.LB성별, 2);
            this.LB성별.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB성별.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LB성별.Location = new System.Drawing.Point(91, 6);
            this.LB성별.Name = "LB성별";
            this.LB성별.Size = new System.Drawing.Size(31, 15);
            this.LB성별.TabIndex = 5;
            this.LB성별.Text = "성별";
            // 
            // RBO여
            // 
            this.RBO여.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBO여.AutoSize = true;
            this.RBO여.ForeColor = System.Drawing.Color.LightCoral;
            this.RBO여.Location = new System.Drawing.Point(35, 32);
            this.RBO여.Margin = new System.Windows.Forms.Padding(0);
            this.RBO여.Name = "RBO여";
            this.RBO여.Size = new System.Drawing.Size(35, 16);
            this.RBO여.TabIndex = 6;
            this.RBO여.TabStop = true;
            this.RBO여.Text = "여";
            this.RBO여.UseVisualStyleBackColor = true;
            // 
            // RBO남
            // 
            this.RBO남.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBO남.AutoSize = true;
            this.RBO남.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RBO남.Location = new System.Drawing.Point(142, 32);
            this.RBO남.Margin = new System.Windows.Forms.Padding(0);
            this.RBO남.Name = "RBO남";
            this.RBO남.Size = new System.Drawing.Size(35, 16);
            this.RBO남.TabIndex = 7;
            this.RBO남.TabStop = true;
            this.RBO남.Text = "남";
            this.RBO남.UseVisualStyleBackColor = true;
            // 
            // btn초기화
            // 
            this.btn초기화.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn초기화.ForeColor = System.Drawing.Color.Black;
            this.btn초기화.Location = new System.Drawing.Point(0, 459);
            this.btn초기화.Margin = new System.Windows.Forms.Padding(0);
            this.btn초기화.Name = "btn초기화";
            this.btn초기화.Size = new System.Drawing.Size(90, 82);
            this.btn초기화.TabIndex = 8;
            this.btn초기화.Text = "초기화";
            this.btn초기화.UseVisualStyleBackColor = true;
            // 
            // btn검색
            // 
            this.btn검색.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn검색.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn검색.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn검색.Location = new System.Drawing.Point(90, 459);
            this.btn검색.Margin = new System.Windows.Forms.Padding(0);
            this.btn검색.Name = "btn검색";
            this.btn검색.Size = new System.Drawing.Size(213, 82);
            this.btn검색.TabIndex = 9;
            this.btn검색.Text = "검색 !";
            this.btn검색.UseVisualStyleBackColor = false;
            // 
            // treeView1
            // 
            this.검색table.SetColumnSpan(this.treeView1, 2);
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(2, 164);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(299, 293);
            this.treeView1.TabIndex = 1;
            // 
            // 분류table
            // 
            this.분류table.ColumnCount = 1;
            this.분류table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.분류table.Controls.Add(this.LB분류, 0, 0);
            this.분류table.Controls.Add(this.cbo분류, 0, 1);
            this.분류table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.분류table.Location = new System.Drawing.Point(0, 108);
            this.분류table.Margin = new System.Windows.Forms.Padding(0);
            this.분류table.Name = "분류table";
            this.분류table.RowCount = 2;
            this.분류table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.분류table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.분류table.Size = new System.Drawing.Size(90, 54);
            this.분류table.TabIndex = 10;
            // 
            // LB분류
            // 
            this.LB분류.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB분류.AutoSize = true;
            this.LB분류.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LB분류.Location = new System.Drawing.Point(30, 7);
            this.LB분류.Name = "LB분류";
            this.LB분류.Size = new System.Drawing.Size(29, 12);
            this.LB분류.TabIndex = 0;
            this.LB분류.Text = "분류";
            // 
            // cbo분류
            // 
            this.cbo분류.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo분류.FormattingEnabled = true;
            this.cbo분류.Items.AddRange(new object[] {
            "고등학교",
            "중학교",
            "대학교",
            "사회",
            "가족"});
            this.cbo분류.Location = new System.Drawing.Point(3, 30);
            this.cbo분류.Name = "cbo분류";
            this.cbo분류.Size = new System.Drawing.Size(84, 20);
            this.cbo분류.TabIndex = 1;
            // 
            // 정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 541);
            this.ControlBox = false;
            this.Controls.Add(this.Maintable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "정보";
            this.Text = "정보";
            this.Maintable.ResumeLayout(false);
            this.datatable.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.검색table.ResumeLayout(false);
            this.검색table.PerformLayout();
            this.sextable.ResumeLayout(false);
            this.sextable.PerformLayout();
            this.분류table.ResumeLayout(false);
            this.분류table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Maintable;
        private System.Windows.Forms.TableLayoutPanel datatable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel 검색table;
        private System.Windows.Forms.Label LB메인검색;
        private System.Windows.Forms.Label LB이름;
        private System.Windows.Forms.TextBox TXB이름;
        private System.Windows.Forms.TextBox TXB전화번호;
        private System.Windows.Forms.Label LB전화번호;
        private System.Windows.Forms.Label LB성별;
        private System.Windows.Forms.TableLayoutPanel sextable;
        private System.Windows.Forms.RadioButton RBO여;
        private System.Windows.Forms.RadioButton RBO남;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn검색;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel 분류table;
        private System.Windows.Forms.Label LB분류;
        private System.Windows.Forms.ComboBox cbo분류;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생년월일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주소;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전화번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 성별;
        private System.Windows.Forms.DataGridViewTextBoxColumn 직업;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류;
        private System.Windows.Forms.DataGridViewTextBoxColumn 키;
        private System.Windows.Forms.DataGridViewTextBoxColumn 몸무게;
        private System.Windows.Forms.DataGridViewTextBoxColumn 혈액형;
        private System.Windows.Forms.DataGridViewTextBoxColumn 특이사항;
    }
}