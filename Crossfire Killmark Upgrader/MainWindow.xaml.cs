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
using System.IO;

namespace Crossfire_Killmark_Upgrader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click (object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void killMarkLevel1_Click(object sender, RoutedEventArgs e)
        {
            string location = gamePathBox.Text;
            string input = File.ReadAllText(Path.Combine("Scripts", "Upgrade 1.txt"));
            string output = Path.Combine(location, "rez", "UI", "Scripts");

            try
            {
                File.WriteAllText(Path.Combine(output, "GameIn_EX.txt"), input);
                MessageBox.Show("Killmark has been successfully upgraded to Level 1", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void killMarkLevel2_Click(object sender, RoutedEventArgs e)
        {
            string location = gamePathBox.Text;
            string input = File.ReadAllText(Path.Combine("Scripts", "Upgrade 2.txt"));
            string output = Path.Combine(location, "rez", "UI", "Scripts");

            try
            {
                File.WriteAllText(Path.Combine(output, "GameIn_EX.txt"), input);
                MessageBox.Show("Killmark has been successfully upgraded to Level 2", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void killMarkLevel3_Click(object sender, RoutedEventArgs e)
        {
            string location = gamePathBox.Text;
            string input = File.ReadAllText(Path.Combine("Scripts", "Upgrade 3.txt"));
            string output = Path.Combine(location, "rez", "UI", "Scripts");

            try
            {
                File.WriteAllText(Path.Combine(output, "GameIn_EX.txt"), input);
                MessageBox.Show("Killmark has been successfully upgraded to Level 3", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void resetKillmark_Click(object sender, RoutedEventArgs e)
        {
            string location = gamePathBox.Text;
            string output = Path.Combine(location, "rez", "UI", "Scripts");

            try
            {
                if (File.Exists(Path.Combine(output, "GameIn_EX.txt")) == true)
                {
                    File.Delete(Path.Combine(output, "GameIn_Ex.txt"));
                    File.Copy(Path.Combine(output, "GameIn_EX (Backup).txt"), Path.Combine(output, "GameIn_EX.txt"));
                }
                else
                {
                    File.Copy(Path.Combine(output, "GameIn_EX (Backup).txt"), Path.Combine(output, "GameIn_EX.txt"));
                }
                MessageBox.Show("Killmark has been set to default", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void createBackup_Click(object sender, RoutedEventArgs e)
        {
            string location = gamePathBox.Text;
            string output = Path.Combine(location, "rez", "UI", "Scripts");

            try
            {
                File.Copy(Path.Combine(output, "GameIn_EX.txt"), Path.Combine(output, "GameIn_EX (Backup).txt"));
                MessageBox.Show("Backup has been created successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void howToUseHyperLink_Click(object sender, RoutedEventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Show();
        }
    }
}
