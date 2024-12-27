using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOtomation
{
    public static class CommonFunctions
    {

        public static void switchBetweenPagesWithAnimation(Form pageToClose,Form pageToOpen)
        {
            pageToOpen.Opacity = 0;
            pageToOpen.Show();

            //Fade-Out and Fade-In Animation
            Timer timer = new Timer();
            timer.Interval = 1; //Makes tick ​​event run every 1ms.
            timer.Tick += (s, args) => //Function to run when tick event occurs.
            {
                if (pageToClose.Opacity > 0) /*Decrease the opacity of the current form and increase the opacity of the opened form 
                                        until current one is completely invisible.*/
                {
                    pageToClose.Opacity -= 0.05;
                    pageToOpen.Opacity += 0.05;
                }
                else //After it's end stop tick event and hide current form.
                {
                    timer.Stop();
                    pageToClose.Hide();
                }
            };

            timer.Start();
        }

        public static bool IsFieldEmpty(Control control, string name,ref string nullErrorsString) // Checks if input fields empty on forms        
        {
            if (control.Text != "")
            {
                return false;
            }
            else
            {
                nullErrorsString += $"{name} alanı boş olamaz\n";
                return true;
            }
        }

        public static void Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Shut down app when we click to close button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); 
            }
        }

    }
}
