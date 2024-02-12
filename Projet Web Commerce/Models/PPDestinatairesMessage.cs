﻿using Projet_Web_Commerce.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_Web_Commerce.Models
{
    public class PPDestinatairesMessage
    {
        [Key]
        public int DestinataireId { get; set; }

        public int NoMessage { get; set; }

        public string Destinataire { get; set; }

        [ForeignKey("NoMessage")]
        [InverseProperty("Destinataires")]
        public virtual PPMessages? Message { get; set; }

        [ForeignKey("Destinataire")]
        public virtual Utilisateur DestinataireUser { get; set; }
    }
}