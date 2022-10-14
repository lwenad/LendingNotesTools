using System;
using System.Collections.Generic;
using System.Text;

namespace LendingNotesTools
{
    public class ProsperNoteInfo
    {
        public string Rating { get; set; }
        public string NoteId { get; set; }
        public decimal InvestmentAmount { get; set; }
        public string Term { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal PaymentsReceived { get; set; }
        public decimal PrincipalOutstanding {get;set;}
        public string Yield { get; set; }
        public string Status { get; set; }
        public string SubStatus { get; set; }
    }
}
