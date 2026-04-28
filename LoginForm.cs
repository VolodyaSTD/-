using System.IO;
using System.Linq;
using System.Text.Json;

namespace МенеджнрПаролей
{
    public partial class LoginForm : Form
    {
        private string filepath = "users.json";


        public LoginForm()
        {
            InitializeComponent();
        }

        private List<User> LoadUsers()
        {
            if (!File.Exists(filepath))
            {
                return new List<User>();
            }
            string json = File.ReadAllText(filepath);
            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<User>();
            }
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        private void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filepath, json);
        }

        private void loginwindow_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordwindow_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoginButton_Click(object sender, EventArgs e)
        {
            string login = loginwindow.Text.Trim();
            string password = passwordwindow.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните пожалуйста все поля");
                return;
            }
            List<User> users = LoadUsers();

            User foundUser = null;

            User existingUser = null;
            foreach(User oneuser in users)
            {
                if (oneuser.Login == login)
                {
                    existingUser = oneuser;
                    break;
                }
            }

            if (existingUser != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }

            User newUser = new User();
            newUser.Login = login;
            newUser.Password = password;

            users.Add(newUser);
            SaveUsers(users);

            MessageBox.Show("Пользователь зарегистрирован!");
        }

        private void EnterBotton_Click(object sender, EventArgs e)
        {
            string login = loginwindow.Text.Trim();
            string password = passwordwindow.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("ВВедите логин и пароль");
                return;
            }
            List<User> users = LoadUsers();

            User foundUser = null;
            foreach(User oneuser in users)
            {
                if(oneuser.Login == login && oneuser.Password == password)
                {
                    foundUser = oneuser;
                    break;
               
                }
            }
            if (foundUser == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            //MessageBox.Show("Вход выполнен успешно!");


            PasswordStorageForm storageForm = new PasswordStorageForm();
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
