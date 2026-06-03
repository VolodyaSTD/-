namespace МенеджнрПаролей
{
    partial class PasswordStorageForm
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
            labelTitle = new Label();
            buttonExit = new Button();
            textSearch = new TextBox();
            buttonAdd = new Button();
            listBoxPasswords = new ListBox();
            labelSite = new Label();
            labelLogin = new Label();
            labelPassword = new Label();
            label1 = new Label();
            progressBar = new ProgressBar();
            labelSafety = new Label();
            textBoxSite = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonShow = new Button();
            buttonCopy = new Button();
            buttonGenerate = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonFieldclear = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BorderStyle = BorderStyle.FixedSingle;
            labelTitle.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(49, 30);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(624, 74);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Менеджер паролей";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.NavajoWhite;
            buttonExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(746, 32);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(210, 75);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(49, 170);
            textSearch.Margin = new Padding(4);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Поиск по сайту или логину...";
            textSearch.Size = new Size(363, 31);
            textSearch.TabIndex = 2;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.NavajoWhite;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(672, 158);
            buttonAdd.Margin = new Padding(4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(284, 58);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "+ Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxPasswords
            // 
            listBoxPasswords.FormattingEnabled = true;
            listBoxPasswords.Location = new Point(49, 259);
            listBoxPasswords.Margin = new Padding(4);
            listBoxPasswords.Name = "listBoxPasswords";
            listBoxPasswords.Size = new Size(363, 504);
            listBoxPasswords.TabIndex = 4;
            listBoxPasswords.SelectedIndexChanged += listBoxPasswords_SelectedIndexChanged;
            // 
            // labelSite
            // 
            labelSite.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSite.Location = new Point(479, 259);
            labelSite.Margin = new Padding(4, 0, 4, 0);
            labelSite.Name = "labelSite";
            labelSite.Size = new Size(109, 45);
            labelSite.TabIndex = 5;
            labelSite.Text = "Сайт:";
            // 
            // labelLogin
            // 
            labelLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(479, 331);
            labelLogin.Margin = new Padding(4, 0, 4, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(109, 45);
            labelLogin.TabIndex = 6;
            labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(479, 406);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 45);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(712, 279);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(479, 521);
            progressBar.Margin = new Padding(4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(475, 36);
            progressBar.TabIndex = 9;
            // 
            // labelSafety
            // 
            labelSafety.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSafety.Location = new Point(479, 479);
            labelSafety.Margin = new Padding(4, 0, 4, 0);
            labelSafety.Name = "labelSafety";
            labelSafety.Size = new Size(176, 39);
            labelSafety.TabIndex = 10;
            labelSafety.Text = "Надежность";
            // 
            // textBoxSite
            // 
            textBoxSite.Location = new Point(618, 259);
            textBoxSite.Margin = new Padding(4);
            textBoxSite.Name = "textBoxSite";
            textBoxSite.Size = new Size(310, 31);
            textBoxSite.TabIndex = 11;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(618, 331);
            textBoxLogin.Margin = new Padding(4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(310, 31);
            textBoxLogin.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(618, 406);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(310, 31);
            textBoxPassword.TabIndex = 13;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = Color.NavajoWhite;
            buttonShow.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonShow.Location = new Point(463, 602);
            buttonShow.Margin = new Padding(4);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(148, 78);
            buttonShow.TabIndex = 14;
            buttonShow.Text = "Показать";
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.BackColor = Color.NavajoWhite;
            buttonCopy.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCopy.Location = new Point(649, 602);
            buttonCopy.Margin = new Padding(4);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(148, 78);
            buttonCopy.TabIndex = 15;
            buttonCopy.Text = "Копировать пароль";
            buttonCopy.UseVisualStyleBackColor = false;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.NavajoWhite;
            buttonGenerate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGenerate.Location = new Point(824, 602);
            buttonGenerate.Margin = new Padding(4);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(181, 78);
            buttonGenerate.TabIndex = 16;
            buttonGenerate.Text = "Сгенерировать";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.NavajoWhite;
            buttonEdit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEdit.Location = new Point(460, 702);
            buttonEdit.Margin = new Padding(4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(254, 61);
            buttonEdit.TabIndex = 17;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.NavajoWhite;
            buttonDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(746, 702);
            buttonDelete.Margin = new Padding(4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(254, 61);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonFieldclear
            // 
            buttonFieldclear.BackColor = Color.NavajoWhite;
            buttonFieldclear.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFieldclear.Location = new Point(476, 158);
            buttonFieldclear.Margin = new Padding(4);
            buttonFieldclear.Name = "buttonFieldclear";
            buttonFieldclear.Size = new Size(181, 58);
            buttonFieldclear.TabIndex = 19;
            buttonFieldclear.Text = "очистисть поля";
            buttonFieldclear.UseVisualStyleBackColor = false;
            buttonFieldclear.Click += buttonFieldclear_Click;
            // 
            // PasswordStorageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1018, 795);
            Controls.Add(buttonFieldclear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonGenerate);
            Controls.Add(buttonCopy);
            Controls.Add(buttonShow);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxSite);
            Controls.Add(labelSafety);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(labelSite);
            Controls.Add(listBoxPasswords);
            Controls.Add(buttonAdd);
            Controls.Add(textSearch);
            Controls.Add(buttonExit);
            Controls.Add(labelTitle);
            Margin = new Padding(4);
            Name = "PasswordStorageForm";
            Text = "PasswordStorageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonExit;
        private TextBox textSearch;
        private Button buttonAdd;
        private ListBox listBoxPasswords;
        private Label labelSite;
        private Label labelLogin;
        private Label labelPassword;
        private Label label1;
        private ProgressBar progressBar;
        private Label labelSafety;
        private TextBox textBoxSite;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonShow;
        private Button buttonCopy;
        private Button buttonGenerate;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonFieldclear;
    }
}