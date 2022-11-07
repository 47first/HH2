namespace Bebra
{
    partial class Form1
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
            this.gameDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb3 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gamesPage = new System.Windows.Forms.TabPage();
            this.companiesPage = new System.Windows.Forms.TabPage();
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.genresPage = new System.Windows.Forms.TabPage();
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.lauchersPage = new System.Windows.Forms.TabPage();
            this.launcherDataGridView = new System.Windows.Forms.DataGridView();
            this.showgroundsPage = new System.Windows.Forms.TabPage();
            this.showgroundDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.gamesPage.SuspendLayout();
            this.companiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            this.genresPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            this.lauchersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.launcherDataGridView)).BeginInit();
            this.showgroundsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showgroundDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDataGridView
            // 
            this.gameDataGridView.AllowUserToAddRows = false;
            this.gameDataGridView.AllowUserToDeleteRows = false;
            this.gameDataGridView.AllowUserToOrderColumns = true;
            this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gameDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.gameDataGridView.MultiSelect = false;
            this.gameDataGridView.Name = "gameDataGridView";
            this.gameDataGridView.ReadOnly = true;
            this.gameDataGridView.RowHeadersWidth = 51;
            this.gameDataGridView.RowTemplate.Height = 24;
            this.gameDataGridView.Size = new System.Drawing.Size(567, 472);
            this.gameDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(590, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // idTb
            // 
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTb.Location = new System.Drawing.Point(590, 62);
            this.idTb.Margin = new System.Windows.Forms.Padding(2);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(317, 32);
            this.idTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(590, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(590, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название:";
            // 
            // Tb1
            // 
            this.Tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb1.Location = new System.Drawing.Point(590, 124);
            this.Tb1.Margin = new System.Windows.Forms.Padding(2);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(317, 32);
            this.Tb1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(590, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Владелец:";
            // 
            // Tb2
            // 
            this.Tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb2.Location = new System.Drawing.Point(590, 186);
            this.Tb2.Margin = new System.Windows.Forms.Padding(2);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(317, 32);
            this.Tb2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(590, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(590, 416);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Обновить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(590, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Цена:";
            // 
            // Tb3
            // 
            this.Tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb3.Location = new System.Drawing.Point(590, 248);
            this.Tb3.Margin = new System.Windows.Forms.Padding(2);
            this.Tb3.Name = "Tb3";
            this.Tb3.Size = new System.Drawing.Size(317, 32);
            this.Tb3.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gamesPage);
            this.tabControl1.Controls.Add(this.companiesPage);
            this.tabControl1.Controls.Add(this.genresPage);
            this.tabControl1.Controls.Add(this.lauchersPage);
            this.tabControl1.Controls.Add(this.showgroundsPage);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 500);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // gamesPage
            // 
            this.gamesPage.Controls.Add(this.gameDataGridView);
            this.gamesPage.Location = new System.Drawing.Point(4, 24);
            this.gamesPage.Name = "gamesPage";
            this.gamesPage.Size = new System.Drawing.Size(567, 472);
            this.gamesPage.TabIndex = 0;
            this.gamesPage.Text = "Игры";
            this.gamesPage.UseVisualStyleBackColor = true;
            // 
            // companiesPage
            // 
            this.companiesPage.Controls.Add(this.companyDataGridView);
            this.companiesPage.Location = new System.Drawing.Point(4, 24);
            this.companiesPage.Name = "companiesPage";
            this.companiesPage.Size = new System.Drawing.Size(567, 472);
            this.companiesPage.TabIndex = 1;
            this.companiesPage.Text = "Компании";
            this.companiesPage.UseVisualStyleBackColor = true;
            // 
            // companyDataGridView
            // 
            this.companyDataGridView.AllowUserToAddRows = false;
            this.companyDataGridView.AllowUserToDeleteRows = false;
            this.companyDataGridView.AllowUserToOrderColumns = true;
            this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.companyDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.companyDataGridView.MultiSelect = false;
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.ReadOnly = true;
            this.companyDataGridView.RowHeadersWidth = 51;
            this.companyDataGridView.RowTemplate.Height = 24;
            this.companyDataGridView.Size = new System.Drawing.Size(567, 472);
            this.companyDataGridView.TabIndex = 1;
            // 
            // genresPage
            // 
            this.genresPage.Controls.Add(this.genreDataGridView);
            this.genresPage.Location = new System.Drawing.Point(4, 24);
            this.genresPage.Name = "genresPage";
            this.genresPage.Size = new System.Drawing.Size(567, 472);
            this.genresPage.TabIndex = 2;
            this.genresPage.Text = "Жанры";
            this.genresPage.UseVisualStyleBackColor = true;
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.AllowUserToAddRows = false;
            this.genreDataGridView.AllowUserToDeleteRows = false;
            this.genreDataGridView.AllowUserToOrderColumns = true;
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreDataGridView.Location = new System.Drawing.Point(0, 0);
            this.genreDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.genreDataGridView.MultiSelect = false;
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.ReadOnly = true;
            this.genreDataGridView.RowHeadersWidth = 51;
            this.genreDataGridView.RowTemplate.Height = 24;
            this.genreDataGridView.Size = new System.Drawing.Size(567, 472);
            this.genreDataGridView.TabIndex = 1;
            // 
            // lauchersPage
            // 
            this.lauchersPage.Controls.Add(this.launcherDataGridView);
            this.lauchersPage.Location = new System.Drawing.Point(4, 24);
            this.lauchersPage.Name = "lauchersPage";
            this.lauchersPage.Size = new System.Drawing.Size(567, 472);
            this.lauchersPage.TabIndex = 3;
            this.lauchersPage.Text = "Лаунчеры";
            this.lauchersPage.UseVisualStyleBackColor = true;
            // 
            // launcherDataGridView
            // 
            this.launcherDataGridView.AllowUserToAddRows = false;
            this.launcherDataGridView.AllowUserToDeleteRows = false;
            this.launcherDataGridView.AllowUserToOrderColumns = true;
            this.launcherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.launcherDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launcherDataGridView.Location = new System.Drawing.Point(0, 0);
            this.launcherDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.launcherDataGridView.MultiSelect = false;
            this.launcherDataGridView.Name = "launcherDataGridView";
            this.launcherDataGridView.ReadOnly = true;
            this.launcherDataGridView.RowHeadersWidth = 51;
            this.launcherDataGridView.RowTemplate.Height = 24;
            this.launcherDataGridView.Size = new System.Drawing.Size(567, 472);
            this.launcherDataGridView.TabIndex = 1;
            // 
            // showgroundsPage
            // 
            this.showgroundsPage.Controls.Add(this.showgroundDataGridView);
            this.showgroundsPage.Location = new System.Drawing.Point(4, 24);
            this.showgroundsPage.Name = "showgroundsPage";
            this.showgroundsPage.Size = new System.Drawing.Size(567, 472);
            this.showgroundsPage.TabIndex = 4;
            this.showgroundsPage.Text = "Площадки";
            this.showgroundsPage.UseVisualStyleBackColor = true;
            // 
            // showgroundDataGridView
            // 
            this.showgroundDataGridView.AllowUserToAddRows = false;
            this.showgroundDataGridView.AllowUserToDeleteRows = false;
            this.showgroundDataGridView.AllowUserToOrderColumns = true;
            this.showgroundDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showgroundDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showgroundDataGridView.Location = new System.Drawing.Point(0, 0);
            this.showgroundDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.showgroundDataGridView.MultiSelect = false;
            this.showgroundDataGridView.Name = "showgroundDataGridView";
            this.showgroundDataGridView.ReadOnly = true;
            this.showgroundDataGridView.RowHeadersWidth = 51;
            this.showgroundDataGridView.RowTemplate.Height = 24;
            this.showgroundDataGridView.Size = new System.Drawing.Size(567, 472);
            this.showgroundDataGridView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(934, 559);
            this.MinimumSize = new System.Drawing.Size(934, 559);
            this.Name = "Form1";
            this.Text = "Nyo-ho";
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.gamesPage.ResumeLayout(false);
            this.companiesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            this.genresPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            this.lauchersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.launcherDataGridView)).EndInit();
            this.showgroundsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showgroundDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gameDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Label label4;
        private TextBox Tb3;
        private TabControl tabControl1;
        private TabPage gamesPage;
        private TabPage companiesPage;
        private TabPage genresPage;
        private TabPage lauchersPage;
        private TabPage showgroundsPage;
        private DataGridView companyDataGridView;
        private DataGridView genreDataGridView;
        private DataGridView launcherDataGridView;
        private DataGridView showgroundDataGridView;
    }
}

