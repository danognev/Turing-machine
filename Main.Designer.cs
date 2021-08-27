
namespace Turing
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
      this.condTable = new System.Windows.Forms.DataGridView();
      this.symbolCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.alphabetText = new System.Windows.Forms.TextBox();
      this.addCond = new System.Windows.Forms.Button();
      this.deleteCond = new System.Windows.Forms.Button();
      this.tableTape = new System.Windows.Forms.DataGridView();
      this.stepBttn = new System.Windows.Forms.Button();
      this.startBttn = new System.Windows.Forms.Button();
      this.resetBttn = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.cursorToRight = new System.Windows.Forms.Button();
      this.cursorToLeft = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      ((System.ComponentModel.ISupportInitialize)(this.condTable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableTape)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // condTable
      // 
      this.condTable.AllowUserToAddRows = false;
      this.condTable.AllowUserToDeleteRows = false;
      this.condTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
      this.condTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.condTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolCol,
            this.Column1});
      this.condTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.condTable.Location = new System.Drawing.Point(93, 233);
      this.condTable.MultiSelect = false;
      this.condTable.Name = "condTable";
      this.condTable.Size = new System.Drawing.Size(377, 160);
      this.condTable.TabIndex = 0;
      // 
      // symbolCol
      // 
      this.symbolCol.HeaderText = "Q0";
      this.symbolCol.Name = "symbolCol";
      this.symbolCol.ReadOnly = true;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Q1";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      // 
      // alphabetText
      // 
      this.alphabetText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.alphabetText.Location = new System.Drawing.Point(3, 16);
      this.alphabetText.Name = "alphabetText";
      this.alphabetText.Size = new System.Drawing.Size(461, 20);
      this.alphabetText.TabIndex = 1;
      this.alphabetText.TextChanged += new System.EventHandler(this.alphabetText_TextChanged);
      // 
      // addCond
      // 
      this.addCond.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addCond.Location = new System.Drawing.Point(3, 3);
      this.addCond.Name = "addCond";
      this.addCond.Size = new System.Drawing.Size(78, 74);
      this.addCond.TabIndex = 3;
      this.addCond.Text = "Добавить";
      this.addCond.UseVisualStyleBackColor = true;
      this.addCond.Click += new System.EventHandler(this.addCond_Click);
      // 
      // deleteCond
      // 
      this.deleteCond.Dock = System.Windows.Forms.DockStyle.Fill;
      this.deleteCond.Location = new System.Drawing.Point(3, 83);
      this.deleteCond.Name = "deleteCond";
      this.deleteCond.Size = new System.Drawing.Size(78, 74);
      this.deleteCond.TabIndex = 4;
      this.deleteCond.Text = "Удалить";
      this.deleteCond.UseVisualStyleBackColor = true;
      this.deleteCond.Click += new System.EventHandler(this.deleteCond_Click);
      // 
      // tableTape
      // 
      this.tableTape.AllowUserToAddRows = false;
      this.tableTape.AllowUserToDeleteRows = false;
      this.tableTape.AllowUserToResizeColumns = false;
      this.tableTape.AllowUserToResizeRows = false;
      this.tableTape.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
      this.tableTape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.tableTape.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableTape.Location = new System.Drawing.Point(93, 153);
      this.tableTape.MultiSelect = false;
      this.tableTape.Name = "tableTape";
      this.tableTape.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.tableTape.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
      this.tableTape.Size = new System.Drawing.Size(377, 74);
      this.tableTape.TabIndex = 10;
      this.tableTape.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableTape_CellContentClick);
      // 
      // stepBttn
      // 
      this.stepBttn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.stepBttn.Location = new System.Drawing.Point(3, 56);
      this.stepBttn.Name = "stepBttn";
      this.stepBttn.Size = new System.Drawing.Size(78, 47);
      this.stepBttn.TabIndex = 11;
      this.stepBttn.Text = "Шаг";
      this.stepBttn.UseVisualStyleBackColor = true;
      this.stepBttn.Click += new System.EventHandler(this.stepBttn_Click);
      // 
      // startBttn
      // 
      this.startBttn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.startBttn.Location = new System.Drawing.Point(3, 3);
      this.startBttn.Name = "startBttn";
      this.startBttn.Size = new System.Drawing.Size(78, 47);
      this.startBttn.TabIndex = 12;
      this.startBttn.Text = "Пуск";
      this.startBttn.UseVisualStyleBackColor = true;
      this.startBttn.Click += new System.EventHandler(this.startBttn_Click);
      // 
      // resetBttn
      // 
      this.resetBttn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.resetBttn.Location = new System.Drawing.Point(3, 109);
      this.resetBttn.Name = "resetBttn";
      this.resetBttn.Size = new System.Drawing.Size(78, 48);
      this.resetBttn.TabIndex = 13;
      this.resetBttn.Text = "Сброс";
      this.resetBttn.UseVisualStyleBackColor = true;
      this.resetBttn.Click += new System.EventHandler(this.resetBttn_Click);
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(3, 16);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(461, 75);
      this.textBox1.TabIndex = 14;
      // 
      // cursorToRight
      // 
      this.cursorToRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.cursorToRight.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cursorToRight.Location = new System.Drawing.Point(476, 153);
      this.cursorToRight.Name = "cursorToRight";
      this.cursorToRight.Size = new System.Drawing.Size(84, 74);
      this.cursorToRight.TabIndex = 8;
      this.cursorToRight.Text = ">";
      this.cursorToRight.UseVisualStyleBackColor = true;
      this.cursorToRight.Click += new System.EventHandler(this.cursorToRight_Click);
      // 
      // cursorToLeft
      // 
      this.cursorToLeft.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cursorToLeft.Location = new System.Drawing.Point(3, 153);
      this.cursorToLeft.Name = "cursorToLeft";
      this.cursorToLeft.Size = new System.Drawing.Size(84, 74);
      this.cursorToLeft.TabIndex = 7;
      this.cursorToLeft.Text = "<";
      this.cursorToLeft.UseVisualStyleBackColor = true;
      this.cursorToLeft.Click += new System.EventHandler(this.cursorToLeft_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.cursorToLeft, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.tableTape, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.cursorToRight, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.condTable, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 396);
      this.tableLayoutPanel1.TabIndex = 15;
      // 
      // groupBox1
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(467, 94);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Условие задачи";
      // 
      // groupBox2
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
      this.groupBox2.Controls.Add(this.alphabetText);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(3, 103);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(467, 44);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Алфавит";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.addCond, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.deleteCond, 0, 1);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 233);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(84, 160);
      this.tableLayoutPanel2.TabIndex = 11;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.startBttn, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.resetBttn, 0, 2);
      this.tableLayoutPanel3.Controls.Add(this.stepBttn, 0, 1);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(476, 233);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 3;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(84, 160);
      this.tableLayoutPanel3.TabIndex = 12;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(563, 396);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(700, 592);
      this.MinimumSize = new System.Drawing.Size(400, 400);
      this.Name = "Main";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Машина Тьюринга";
      ((System.ComponentModel.ISupportInitialize)(this.condTable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableTape)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView condTable;
        private System.Windows.Forms.TextBox alphabetText;
        private System.Windows.Forms.Button addCond;
        private System.Windows.Forms.Button deleteCond;
        private System.Windows.Forms.Button cursorToLeft;
        private System.Windows.Forms.Button cursorToRight;
        private System.Windows.Forms.DataGridView tableTape;
        private System.Windows.Forms.Button stepBttn;
        private System.Windows.Forms.Button startBttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button resetBttn;
        private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
  }
}

