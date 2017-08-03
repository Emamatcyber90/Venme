using System.ComponentModel.DataAnnotations.Schema;

namespace Venme.Models
{
    public partial class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int FromUserId { get; set; }

        public int ToUserId { get; set; }

        public int Amount { get; set; }

        public virtual User FromUser { get; set; }
    }
}
