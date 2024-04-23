using System;

namespace CashCash.Models
{
    public class Intervention
    {
     
        public int NumIntervention { get; set; }
        public DateTime DateIntervention { get; set; }
        public int NumEmploye { get; set; }
        public DateTime HeureIntervention { get; set; }
        public int NumClient { get; set; }
    }
}