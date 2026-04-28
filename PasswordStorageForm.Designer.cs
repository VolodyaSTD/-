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
            titlelable = new Label();
            logoutbotton = new Button();
            searchTextBox = new TextBox();
            addbutton = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            siteLable = new Label();
            loginLable = new Label();
            passwordLable = new Label();
            siteTextBox = new TextBox();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            showPasswordButton = new Button();
            copyPasswordButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            generatePasswordButton = new Button();
            strengthLabel = new Label();
            passwordStrengthProgressBar = new ProgressBar();
            strengthTextLabel = new Label();
            SuspendLayout();
            // 
            // titlelable
            // 
            titlelable.BackColor = Color.AntiqueWhite;
            titlelable.BorderStyle = BorderStyle.FixedSingle;
            titlelable.Font = new Font("Lucida Console", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titlelable.Location = new Point(13, 9);
            titlelable.Margin = new Padding(4, 0, 4, 0);
            titlelable.Name = "titlelable";
            titlelable.Size = new Size(300, 63);
            titlelable.TabIndex = 0;
            titlelable.Text = "Менеджер Паролей";
            titlelable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutbotton
            // 
            logoutbotton.BackColor = Color.NavajoWhite;
            logoutbotton.BackgroundImageLayout = ImageLayout.Stretch;
            logoutbotton.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logoutbotton.Location = new Point(362, 9);
            logoutbotton.Margin = new Padding(4);
            logoutbotton.Name = "logoutbotton";
            logoutbotton.Size = new Size(197, 64);
            logoutbotton.TabIndex = 1;
            logoutbotton.Text = "Выйти";
            logoutbotton.UseVisualStyleBackColor = false;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.BlanchedAlmond;
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(13, 106);
            searchTextBox.Margin = new Padding(4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(300, 31);
            searchTextBox.TabIndex = 2;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.NavajoWhite;
            addbutton.BackgroundImageLayout = ImageLayout.Stretch;
            addbutton.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addbutton.Location = new Point(362, 106);
            addbutton.Margin = new Padding(4);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(197, 34);
            addbutton.TabIndex = 3;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(13, 163);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(546, 154);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 394);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            // 
            // siteLable
            // 
            siteLable.BackColor = Color.AntiqueWhite;
            siteLable.BorderStyle = BorderStyle.FixedSingle;
            siteLable.Font = new Font("Lucida Console", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            siteLable.Location = new Point(13, 356);
            siteLable.Margin = new Padding(4, 0, 4, 0);
            siteLable.Name = "siteLable";
            siteLable.Size = new Size(89, 47);
            siteLable.TabIndex = 6;
            siteLable.Text = "Сайт";
            siteLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // loginLable
            // 
            loginLable.BackColor = Color.AntiqueWhite;
            loginLable.BorderStyle = BorderStyle.FixedSingle;
            loginLable.Font = new Font("Lucida Console", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLable.Location = new Point(13, 430);
            loginLable.Margin = new Padding(4, 0, 4, 0);
            loginLable.Name = "loginLable";
            loginLable.Size = new Size(89, 47);
            loginLable.TabIndex = 7;
            loginLable.Text = "Логин";
            loginLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordLable
            // 
            passwordLable.BackColor = Color.AntiqueWhite;
            passwordLable.BorderStyle = BorderStyle.FixedSingle;
            passwordLable.Font = new Font("Lucida Console", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordLable.Location = new Point(12, 503);
            passwordLable.Margin = new Padding(4, 0, 4, 0);
            passwordLable.Name = "passwordLable";
            passwordLable.Size = new Size(90, 47);
            passwordLable.TabIndex = 8;
            passwordLable.Text = "Пароль";
            passwordLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siteTextBox
            // 
            siteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siteTextBox.BackColor = Color.BlanchedAlmond;
            siteTextBox.BorderStyle = BorderStyle.FixedSingle;
            siteTextBox.Location = new Point(139, 356);
            siteTextBox.Margin = new Padding(4);
            siteTextBox.Name = "siteTextBox";
            siteTextBox.Size = new Size(420, 31);
            siteTextBox.TabIndex = 9;
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            loginTextBox.BackColor = Color.BlanchedAlmond;
            loginTextBox.BorderStyle = BorderStyle.FixedSingle;
            loginTextBox.Location = new Point(139, 430);
            loginTextBox.Margin = new Padding(4);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(420, 31);
            loginTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            passwordTextBox.BackColor = Color.BlanchedAlmond;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(139, 503);
            passwordTextBox.Margin = new Padding(4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(420, 31);
            passwordTextBox.TabIndex = 11;
            // 
            // showPasswordButton
            // 
            showPasswordButton.BackColor = Color.NavajoWhite;
            showPasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            showPasswordButton.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            showPasswordButton.Location = new Point(13, 690);
            showPasswordButton.Margin = new Padding(4);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(133, 64);
            showPasswordButton.TabIndex = 12;
            showPasswordButton.Text = "Показать";
            showPasswordButton.UseVisualStyleBackColor = false;
            // 
            // copyPasswordButton
            // 
            copyPasswordButton.BackColor = Color.NavajoWhite;
            copyPasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            copyPasswordButton.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            copyPasswordButton.Location = new Point(154, 690);
            copyPasswordButton.Margin = new Padding(4);
            copyPasswordButton.Name = "copyPasswordButton";
            copyPasswordButton.Size = new Size(159, 64);
            copyPasswordButton.TabIndex = 13;
            copyPasswordButton.Text = "Копировать";
            copyPasswordButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.BackColor = Color.NavajoWhite;
            editButton.BackgroundImageLayout = ImageLayout.Stretch;
            editButton.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editButton.Location = new Point(313, 690);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(125, 64);
            editButton.TabIndex = 14;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.NavajoWhite;
            deleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            deleteButton.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(441, 690);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(119, 64);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += button4_Click;
            // 
            // generatePasswordButton
            // 
            generatePasswordButton.BackColor = Color.NavajoWhite;
            generatePasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            generatePasswordButton.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            generatePasswordButton.Location = new Point(13, 773);
            generatePasswordButton.Margin = new Padding(4);
            generatePasswordButton.Name = "generatePasswordButton";
            generatePasswordButton.Size = new Size(547, 48);
            generatePasswordButton.TabIndex = 16;
            generatePasswordButton.Text = "Сгенерировать надежный пароль";
            generatePasswordButton.UseVisualStyleBackColor = false;
            // 
            // strengthLabel
            // 
            strengthLabel.BackColor = Color.AntiqueWhite;
            strengthLabel.BorderStyle = BorderStyle.FixedSingle;
            strengthLabel.Font = new Font("Lucida Console", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            strengthLabel.Location = new Point(12, 581);
            strengthLabel.Margin = new Padding(4, 0, 4, 0);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(264, 89);
            strengthLabel.TabIndex = 17;
            strengthLabel.Text = "Надежность пароля";
            strengthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordStrengthProgressBar
            // 
            passwordStrengthProgressBar.Location = new Point(313, 636);
            passwordStrengthProgressBar.Name = "passwordStrengthProgressBar";
            passwordStrengthProgressBar.Size = new Size(247, 34);
            passwordStrengthProgressBar.TabIndex = 18;
            // 
            // strengthTextLabel
            // 
            strengthTextLabel.BackColor = Color.AntiqueWhite;
            strengthTextLabel.BorderStyle = BorderStyle.FixedSingle;
            strengthTextLabel.Font = new Font("Lucida Console", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            strengthTextLabel.Location = new Point(313, 581);
            strengthTextLabel.Margin = new Padding(4, 0, 4, 0);
            strengthTextLabel.Name = "strengthTextLabel";
            strengthTextLabel.Size = new Size(246, 37);
            strengthTextLabel.TabIndex = 19;
            strengthTextLabel.Text = "Значение";
            strengthTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordStorageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(589, 851);
            Controls.Add(strengthTextLabel);
            Controls.Add(passwordStrengthProgressBar);
            Controls.Add(strengthLabel);
            Controls.Add(generatePasswordButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(copyPasswordButton);
            Controls.Add(showPasswordButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(siteTextBox);
            Controls.Add(passwordLable);
            Controls.Add(loginLable);
            Controls.Add(siteLable);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(addbutton);
            Controls.Add(searchTextBox);
            Controls.Add(logoutbotton);
            Controls.Add(titlelable);
            Margin = new Padding(4);
            Name = "PasswordStorageForm";
            Text = "PasswordStorageForm";
            Load += PasswordStorageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlelable;
        private Button logoutbotton;
        private TextBox searchTextBox;
        private Button addbutton;
        private ListBox listBox1;
        private Label label1;
        private Label siteLable;
        private Label loginLable;
        private Label passwordLable;
        private TextBox siteTextBox;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button showPasswordButton;
        private Button copyPasswordButton;
        private Button editButton;
        private Button deleteButton;
        private Button generatePasswordButton;
        private Label strengthLabel;
        private ProgressBar passwordStrengthProgressBar;
        private Label strengthTextLabel;
    }
}