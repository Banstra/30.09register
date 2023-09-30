using Sport.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sport.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Page
    {/*
        public Registr()
        {
            InitializeComponent();
            connect.modelbd = new Models.magaz();
        }

        private void Registraciya(object sender, RoutedEventArgs e)
        {
            // Получаем данные из полей ввода
            string login = Login.Text;
            string password = Password.Password;
            string confirmPassword = ConfirmPassword.Password;

            // Проверяем, совпадают ли пароль и подтверждение пароля
            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка при регистрации",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Проверяем, существует ли пользователь с таким логином
            var existingUser = connect.modelbd.users.FirstOrDefault(u => u.login == login);
            if (existingUser != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка при регистрации",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Создаем нового пользователя
            var newUser = new Models.users
            {
                login = login,
                password = password,
                id_type = 3 // 3 соответствует роли "Client"
            };

            // Добавляем пользователя в таблицу users
            connect.modelbd.users.Add(newUser);

            try
            {
                // Сохраняем изменения в базе данных
                connect.modelbd.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!", "Успешная регистрация",
                    MessageBoxButton.OK, MessageBoxImage.Information);

                // Очищаем поля ввода
                Login.Clear();
                Password.Clear();
                ConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка при регистрации",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        */
    }

}


