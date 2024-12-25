using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOtomation
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title)
        {
            Text = title;
            Size = new Size(400, 200);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = ColorTranslator.FromHtml("#222831");
            FormBorderStyle = FormBorderStyle.None;

            Label lblMessage = new Label
            {
                Text = message,
                Size = new Size(300, 50),
                Font = new Font("Outfit", 13),
                ForeColor = ColorTranslator.FromHtml("#FFD369"),
                TextAlign = ContentAlignment.MiddleCenter
            };


            // Kapanma butonu
            Button btnOk = new Button
            {
                Text = "Tamam",
                Size = new Size(100, 30),
                Font = new Font("Outfit", 10),
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#FFD369"),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };

            btnOk.Click += (sender, e) => Close();

            int totalHeight = Size.Height; // Formun toplam yüksekliği
            int messageHeight = lblMessage.Height;  // Mesajın yüksekliği
            int buttonHeight = btnOk.Height; // Butonun yüksekliği
            int verticalPadding = (totalHeight - (messageHeight + buttonHeight) ) / 3;

            lblMessage.Location = new Point(
                (ClientSize.Width - lblMessage.Width) / 2,  // Ortalamak için X koordinatı
                verticalPadding
            );

            // Butonun konumunu hesaplayalım
            btnOk.Location = new Point(
                (ClientSize.Width - btnOk.Width) / 2,  // Ortalamak için X koordinatı
                lblMessage.Bottom + verticalPadding
            );

            // Form'a label ve butonu ekle
            Controls.Add(lblMessage);
            Controls.Add(btnOk);
        }

        public void Animation()
        {
            // Fade-In animasyonu
            Opacity = 0; // Başlangıçta form tamamen şeffaf
            Timer fadeTimer = new Timer{ Interval = 30 }; // Her 30ms'de bir güncellenir

            fadeTimer.Tick += (sender, e) =>
            {
                if (Opacity < 1)
                {
                    Opacity += 0.05; // Her animasyon adımında opaklığı arttır
                }
                else
                {
                    fadeTimer.Stop(); // Opaklık %100 olduğunda animasyonu durdur
                }
            };

            fadeTimer.Start();
        }
        public static void Show(string message, string title)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message, title);
            Application.Run(customMessageBox);
            customMessageBox.Animation();
        }
    }
}
