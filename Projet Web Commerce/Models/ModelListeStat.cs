﻿namespace Projet_Web_Commerce.Models
{
    public class ModelListeStat
    {
        public List<PPVendeurs> VendeursList { get; set; }

        public List<PPClients> ClientsList { get; set; }

        public List<PPProduits> ProduitsList { get; set; }

        public List<PPCommandes> CommandesList { get; set; }

        public List<PPVendeursClients> VendeursClientsList { get; set; }

        public List<ModelVisite> VisitesCountData { get; set; }

        public List<ModelMoisAnneVendeur> VendeurDate { get; set; }
        public List<OrderPercentage> OrderPercentages { get; set; }

        public List<ModelordersByClientAndVendeur>? OrdersByClientAndVendeurList { get; set; }

        public List<string> Labels { get; set; }
        public List<decimal> Data { get; set; }
    }
}
