using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloClone.ViewModel
{
    public class CardDetails
    {
        public int Id { get; set; }
        [Required]
        public string Contents { get; set; }
        public string Notes { get; set; }
    }
}
