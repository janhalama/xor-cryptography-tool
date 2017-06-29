using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValeoInterviewChallenge.CryptographyService;
using ValeoInterviewChallenge.CryptographyService.Interface;

namespace ValeoInterviewChallenge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //This is application root, in more complex case of application I would use IOC container here to compose the app dependencies, in this case I just instanciate the cryptography sevice
            ICryptographyService cryptographyService = new XorCryptographyService();
            Application.Run(new F_Main(cryptographyService));
        }
    }
}
