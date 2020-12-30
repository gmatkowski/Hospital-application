using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalApp.Views;
using Hospital.DB;
using Hospital.Repositories;
using Hospital.Abstracts;

namespace HospitalApp
{
    static class Program
    {
        public static User AuthenticatedUser = null;
        public static bool IsAuthenticated()
        {
            return AuthenticatedUser != null;
        }

        public static void Logout()
        {
            AuthenticatedUser = null;
        }
       
        [STAThread]
        static void Main()
        {
            Start program = new Start();
            program.StartApplication();
        }

    }

    class Start
    {
        public void StartApplication()
        {
            HospitalContext context = new HospitalContext("HospitalDbContext");

            DatabaseBootstrapper bs = new DatabaseBootstrapper();
            bs.Configure(context);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserRepository repository = new UserRepository(context);
            if (repository.HasAdmins())
            {
                Application.Run(new Login());
                return;
            }

            Application.Run(new AdminRegister());
        }
    }
}
