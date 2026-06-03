using System.IO;
using System.Linq;
using System.Text.Json;

namespace МенеджнрПаролей
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void loginwindow_TextChanged(object sender, EventArgs e) { }
        private void passwordwindow_TextChanged(object sender, EventArgs e) { }

        public void LoginButton_Click(object sender, EventArgs e)
        {
            string login = loginwindow.Text.Trim();
            string password = passwordwindow.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните пожалуйста все поля");
                return;
            }
            List<User> users = UserStorage.LoadUsers();

            foreach (User u in users)
            {
                if(u.Login == login)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                    return;
                }
            }
            string salt = SecurityHelper.GenerateSalt();
            string hash = SecurityHelper.HashPassword(password, salt);

            User newUser = new User();
            newUser.Login = login;
            newUser.Salt = salt;
            newUser.PasswordHash = hash;

            users.Add(newUser);
            UserStorage.SaveUsers(users);

            MessageBox.Show("Пользователь зарегестрирован!");
        }

        private void EnterBotton_Click(object sender, EventArgs e)
        {
            string login = loginwindow.Text.Trim();
            string password = passwordwindow.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            List<User> users = UserStorage.LoadUsers();

            User foundUser = null;
            foreach(User u in users)
            {
                if (u.Login == login && SecurityHelper.VerifyPassword(password, u.Salt, u.PasswordHash))
                {
                    foundUser = u;
                    break;
                }
            }
            if (foundUser == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            //MessageBox.Show("Вход выполнен успешно!");

            PasswordStorageForm storageForm = new PasswordStorageForm(foundUser, password);
            //..проблема висящего процесса
            storageForm.FormClosed += (s, args) =>
            {
                this.Close();
            };

            this.Hide();
            storageForm.Show();
        }

    }
}