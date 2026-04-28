namespace МенеджнрПаролей
{
    partial class LoginForm
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
            label1 = new Label();
            loginwindow = new TextBox();
            passwordwindow = new TextBox();
            LoginButton = new Button();
            EnterBotton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.NavajoWhite;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Lucida Console", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(44, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 82);
            label1.TabIndex = 0;
            label1.Text = "Зарегестрируйтесь или войдите";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginwindow
            // 
            loginwindow.Location = new Point(91, 151);
            loginwindow.Margin = new Padding(2);
            loginwindow.Name = "loginwindow";
            loginwindow.PlaceholderText = "Логин";
            loginwindow.Size = new Size(215, 31);
            loginwindow.TabIndex = 1;
            loginwindow.TextChanged += loginwindow_TextChanged;
            // 
            // passwordwindow
            // 
            passwordwindow.Location = new Point(91, 236);
            passwordwindow.Margin = new Padding(2);
            passwordwindow.Name = "passwordwindow";
            passwordwindow.PlaceholderText = "Пароль";
            passwordwindow.Size = new Size(215, 31);
            passwordwindow.TabIndex = 2;
            passwordwindow.UseSystemPasswordChar = true;
            passwordwindow.TextChanged += passwordwindow_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.PapayaWhip;
            LoginButton.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(115, 308);
            LoginButton.Margin = new Padding(2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(160, 72);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Регистрация";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // EnterBotton
            // 
            EnterBotton.BackColor = Color.PapayaWhip;
            EnterBotton.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnterBotton.Location = new Point(91, 425);
            EnterBotton.Margin = new Padding(2);
            EnterBotton.Name = "EnterBotton";
            EnterBotton.Size = new Size(215, 68);
            EnterBotton.TabIndex = 4;
            EnterBotton.Text = "Вход";
            EnterBotton.UseVisualStyleBackColor = false;
            EnterBotton.Click += EnterBotton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(384, 562);
            Controls.Add(EnterBotton);
            Controls.Add(LoginButton);
            Controls.Add(passwordwindow);
            Controls.Add(loginwindow);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginwindow;
        private TextBox passwordwindow;
        private Button LoginButton;
        private Button EnterBotton;
    }
}
