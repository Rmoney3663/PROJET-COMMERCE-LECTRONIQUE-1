﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.WebUtilities;
using Projet_Web_Commerce.Areas.Identity.Data;

namespace Projet_Web_Commerce.Areas.Identity.Pages.Account
{
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<Utilisateur> _userManager;
        private readonly IEmailSender _emailSender;

        public ForgotPasswordModel(UserManager<Utilisateur> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Le courriel est requis.")]
            [EmailAddress]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null) //|| !(await _userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError(string.Empty, "Cette adresse courriel n'existe pas dans la base de données.");

                    // Don't reveal that the user does not exist or is not confirmed
                    //return RedirectToPage("./ForgotPasswordConfirmation");
                }
                else
                {
                    // For more information on how to enable account confirmation and password reset please
                    // visit https://go.microsoft.com/fwlink/?LinkID=532713
                    var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ResetPassword",
                        pageHandler: null,
                        values: new { area = "Identity", code },
                        protocol: Request.Scheme);

                    await Methodes.envoyerCourriel(
                        "Réinitialiser le mot de passe",
                        $"Veuillez réinitialiser votre mot de passe en <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>cliquant ici</a>.",
                        Input.Email);

                    return RedirectToPage("./ForgotPasswordConfirmation");
                }
            }

            return Page();
        }
    }
}
