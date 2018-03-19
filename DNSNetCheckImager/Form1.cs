using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNSNetCheckImager
{
    public partial class DNSNetCheck : Form
    {
       public static string path = "C:\\Users\\Nick Coyle\\Desktop\\";
      

        public void addControls()
        {        
            storeNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        public DNSNetCheck()
        {
            InitializeComponent();
            addControls();
            
        }

        public void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                validateInput();
            }
        }
        private void goBtn_Click(object sender, EventArgs e)
        {
            validateInput();
        }

        private void validateInput()
        {
            string input = storeNumberInput.Text;
            if (input.Length > 1)
            {
                int storeNumber = 0;
               if (  Int32.TryParse(input, out storeNumber) )
                {
                    pingStore(storeNumber);
                }
                else
                {
                    blinkControl(storeNumberInput);  
                }
            }
        }

        private void blinkControl(Control userControl)
        {
            for (int i = 0; i < 3; i++)
            {
                userControl.Hide();
                System.Threading.Thread.Sleep(200);
                userControl.Show();
                System.Threading.Thread.Sleep(200);
            }

        }      

        private void pingStore(int storeNumber)
        {
            MessageBox.Show("Gonna ping that store #" + storeNumber);
        }

        private void screenShotBtn_Click(object sender, EventArgs e)
        {
            makeScreenShot();
        }

        private void makeScreenShot()
        {
            Rectangle bounds = this.Bounds;
                        
             using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))            
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    Size s = this.Size;
                    s.Width = s.Width - 15;
                    s.Height = s.Height - 11;
                     g.CopyFromScreen(new Point(bounds.Left + 7, bounds.Top + 3), Point.Empty, s);                    
                }
                bitmap.Save(path + "test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }     
    }
}
