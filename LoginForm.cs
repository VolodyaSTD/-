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
            if(!File.Exists(filepath))
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


        public void LoginButton_Click(object sender, EventArgs e)
        {
            string login = loginTxtBox.Text.Trim();
            string password = passwordTxtBox.Text.Trim();  

            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните пожалуйста все поля");
                return;
            }
            List<User> users = LoadUsers();

            User foundUser = null;

            User existingUser = users.FirstOrDefault(u => u.Login == login);
            if (existingUser != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }
            User newUser = new User();
            {
                Login = login,
                Password = password
            };
            users.Add(newUser);
            SaveUsers(users);

            MessageBox.Show("Пользователь зарегистрирован!");
        }

    }
}
