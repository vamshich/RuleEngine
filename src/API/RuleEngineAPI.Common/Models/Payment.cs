using System.ComponentModel.DataAnnotations;

namespace RuleEngineAPI.Common.Models
{
    public class Payment
    {
        [Required]
        public string Selection { get; set; }
    }
}
