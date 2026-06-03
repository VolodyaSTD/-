using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace МенеджнрПаролей
{
    public partial class PasswordStorageForm : Form
    {
        private User currentUser;
        private string masterPassword;
        public PasswordStorageForm(User user, string masterPassword)
        {
            InitializeComponent();
            this.currentUser = user;
            this.masterPassword = masterPassword;

            RefreshList();
        }
        private void RefreshList()
        {
            listBoxPasswords.Items.Clear();
            foreach (PasswordEntry entry in currentUser.Passwords)
            {
                listBoxPasswords.Items.Add(entry);
            }
        }
        private PasswordEntry GetSelected()
        {
            return listBoxPasswords.SelectedItem as PasswordEntry;
        }
        private void ClearFields()
        {
            textBoxSite.Text = "";
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            progressBar.Value = 0;
        }

        private void SaveChanges()
        {
            List<User> users = UserStorage.LoadUsers();
            foreach (User u in users)
            {
                if (u.Login == currentUser.Login)
                {
                    u.Passwords = currentUser.Passwords;
                    break;
                }
            }
            UserStorage.SaveUsers(users);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string site = textBoxSite.Text.Trim();
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(site) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните поля Сайт, Логи и Пароль");
                return;
            }

            PasswordEntry entry = new PasswordEntry();
            entry.Site = site;
            entry.Login = login;
            entry.Password = SecurityHelper.Encrypt(password, masterPassword);

            currentUser.Passwords.Add(entry);
            SaveChanges();
            RefreshList();
            ClearFields();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            PasswordEntry entry = GetSelected();
            if (entry == null)
            {
                MessageBox.Show("Выберете запись в списке");
                return;
            }

            string site = textBoxSite.Text.Trim();
            string login = textBoxLogin.Text.Trim();
            if (string.IsNullOrWhiteSpace(site) || string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Заполните сайт и логин");
                return;
            }

            entry.Site = site;
            entry.Login = login;

            if (!string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                entry.Password = SecurityHelper.Encrypt(textBoxPassword.Text, masterPassword);
            }
            SaveChanges();
            RefreshList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            PasswordEntry entry = GetSelected();
            if (entry == null)
            {
                MessageBox.Show("Выюерете запись для ужаления");
                return;
            }
            DialogResult answer = MessageBox.Show(
                "Удалить запись \"" + entry.Site + "\"?",
                "Подтверждение",
                MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes) return;

            currentUser.Passwords.Remove(entry);
            SaveChanges();
            RefreshList();
            ClearFields();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            PasswordEntry entry = GetSelected();
            if (entry == null)
            {
                MessageBox.Show("Выбрете пользователя");
                return;
            }
            textBoxPassword.Text = SecurityHelper.Decrypt(entry.Password, masterPassword);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            PasswordEntry entry = GetSelected();
            if (entry == null)
            {
                MessageBox.Show("Выберете запись");
                return;
            }
            string plain = SecurityHelper.Decrypt(entry.Password, masterPassword);
            if (!string.IsNullOrEmpty(plain))
            {
                Clipboard.SetText(plain);
                MessageBox.Show("Пароль скопирован в буфер оюмена");
            }
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = PasswordGenerator.Generate(12);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listBoxPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {
            PasswordEntry entry = GetSelected();
            if (entry == null) return;

            textBoxSite.Text = entry.Site;
            textBoxLogin.Text = entry.Login;
            textBoxPassword.Text = "";
            progressBar.Value = 0;
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            progressBar.Value = PasswordStrength.Evaluate(textBoxPassword.Text);
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string query = textSearch.Text.Trim().ToLower();

            listBoxPasswords.Items.Clear();
            foreach (PasswordEntry entry in currentUser.Passwords)
            {
                string site = (entry.Site ?? "").ToLower();
                string login = (entry.Login ?? "").ToLower();

                if (query.Length == 0 || site.Contains(query) || login.Contains(query))
                {
                    listBoxPasswords.Items.Add(entry);
                }
            }
        }
    }
}