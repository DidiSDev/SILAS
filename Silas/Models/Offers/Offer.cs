﻿namespace Silas.Models.Offers
{
    public class Offer
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string requiriments { get; set; }
        public DateTime date { get; set; }
        public string location { get; set; }
        public int id_company { get; set; }

        //CURSO Y ACRONIMO PARA LA VISTA DE OFERTA EN DETALLE
        public string course_name { get; set; }
        public string course_acronim { get; set; }
    }
}
