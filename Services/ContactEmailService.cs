using System;
using System.Collections.Generic;
using System.Text;
using Portfolio.Models;
using Resend;

namespace Portfolio.Services
{
    public class ContactEmailService
    {
        private readonly IResend _resend;
        public ContactEmailService(IResend resend)
        {
            _resend = resend;
        }


        public async Task SendAsync(ContactMessage contactMessage)
        {
            var email = new EmailMessage
            {
                From = "Portfolio <onboarding@resend.dev>",
                Subject = $"Contact Portfolio - Nouveau message de {contactMessage.Name}",
                HtmlBody = $"""
                    <h2> Nouveau message de contact depuis le Portfolio</h2>
                    <p><strong>Nom:</strong> {contactMessage.Name}</p>
                    <p><strong>Email:</strong> {contactMessage.Email}</p>
                    <h3>Message reçu:</h3>
                    <p>{contactMessage.Message}</p>

                    <hr />

                    <h3>Réponse type à copier/coller</h3>

                    <p>Bonjour {contactMessage.Name},</p>

                    <p>
                        Merci pour votre message : .
                    </p>
                {contactMessage.Message}

                    <p>dont je viens de prendre connaissance. Je vous remercie pour votre intérêt.</p>

                    <p>
                        Je reviens vers vous rapidement avec une réponse plus détaillée.
                    </p>

                    <p>
                        Cordialement,<br />
                        Fabien Canehan
                    </p>


                """
            };

            email.To.Add("fcanehan.jobs@gmail.com");
            await _resend.EmailSendAsync(email);

            #region copie_envoyeur
            /// version réponse automatique si le site le permet un jour via hébergement

            //var copyEmail = new EmailMessage
            //{
            //    From = "Portfolio < onboarding@resend.dev > ",
            //    Subject = "Copie de votre message envoyé",
            //    HtmlBody = $"""
            //        <h2>Merci pour votre message ❤️</h2>

            //        <p>Votre message a bien été transmis.</p>

            //        <h3>Copie du message</h3>

            //        <p>{contactMessage.Message}</p>
            //    """

            //};

            //copyEmail.To.Add(contactMessage.Email);
            //await _resend.EmailSendAsync(copyEmail);

            #endregion copie_envoyeur
        }
    }
}