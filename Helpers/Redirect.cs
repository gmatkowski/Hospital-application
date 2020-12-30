using HospitalApp.Views;
using System.Windows.Forms;

namespace HospitalApp.Helpers
{
    public static class Redirect
    {
        public static void GoToLogin(Form form)
        {
            form.Hide();

            Login dialog = new Login();
            dialog.Location = form.Location;
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.ShowDialog();

            form.Close();
        }

        public static void GoToDashboard(Form form)
        {
            form.Hide();

            Dashboard dialog = new Dashboard();
            dialog.Location = form.Location;
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.ShowDialog();

            form.Close();
        }
    }
}
