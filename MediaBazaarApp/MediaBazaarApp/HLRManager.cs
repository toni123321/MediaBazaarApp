using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public class HLRManager
    {
        private List<HolidayLeaveRequest> hlrs = new List<HolidayLeaveRequest>();

        public HLRManager()
        {
            hlrs = new List<HolidayLeaveRequest>();
        }

        public void SendEmailToNotifyEmployee(string firstname, string email, DateTime requestDate, bool isRequestAccepted)
        {
            MailAddress to = new MailAddress(email);
            MailAddress from = new MailAddress("758b1e48c8-dc8967@inbox.mailtrap.io");

            MailMessage message = new MailMessage(from, to);
            string AcceptedRequestSubject = "Request for edit account details accepted";
            string DeclinedRequestSubject = "Request for edit account details declined";

            message.Subject = isRequestAccepted ? AcceptedRequestSubject : DeclinedRequestSubject;
            message.IsBodyHtml = true;

            string DeclinedRequestBody =
                $@"
                <p><span style='font-family: Verdana, Geneva, sans-serif;font-size:25px;'>Hello {firstname}</span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'>On <strong>{requestDate}</strong> you submitted a request for a holiday leave starting from {HLR_sd} until {HLR_et}.</span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'>We would like to let you know that the HR team has reviewed and <strong>declined&nbsp;</strong>your request.</span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'>If you believe that your request was wrongfully declined, feel free to contact the HR team by phone or email.</span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'><em><span style='font-size: 12px;'>This is an automated email; therefore, replying to it is not possible and if you do so, your email will not be received by us.</span></em></span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'>Kind regards,<br>Media Bazaar&apos;s team</span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'><img src='data:image/png;base64,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'></span><br></p>
                ";
            string AcceptedRequestBody =
                $@"
                <p><span style='font-family: Verdana, Geneva, sans-serif;font-size:25px;'>Hello {firstname}</span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'>On <strong>{requestDate}</strong> you submitted a request for a holiday leave starting from {HLR_sd} until {HLR_et}.</span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'>We would like to let you know that the HR team has reviewed and <strong>accepted&nbsp;</strong>your request.</span></p>
                <p><a href='http://localhost/s2-prj-cb03-1-webiste/HTML-PHP/accountPage.php'><span style='font-family: Verdana, Geneva, sans-serif;'>Click here to view your account with the applied changes (logging in might be needed).</span></a></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'><em><span style='font-size: 12px;'>This is an automated email; therefore, replying to it is not possible and if you do so, your email will not be received by us.</span></em></span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'>Kind regards,<br>Media Bazaar&apos;s team</span></p>
                <p><span style='font-family: Verdana, Geneva, sans-serif;'><img src='data:image/png;base64,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'></span><br></p>
                ";
            message.Body = isRequestAccepted ? AcceptedRequestBody : DeclinedRequestBody;

            SmtpClient client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("f6ba1fe10a5e88", "e05fd608218765"),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AcceptHLR(HolidayLeaveRequest request)
        {
            // Accept - call update from db control
            // Load requests
            // Send email - proper msg
        }

        public void DeclineHLR(HolidayLeaveRequest request)
        {
            // Decline - call update from db control
            // Load requests
            // Send email - proper msg
        }



    }
}
