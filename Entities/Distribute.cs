using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Start_Up_Group.Entities
{
    public class Distribute
    {
        [Key]
        public int DistributeId { get; set; }
        public DateTime Distribute_On { get; set; }

        [ForeignKey("BranchProduct")]
        public int BranchProductId { get; set; }
        public virtual ICollection<BranchProduct> BranchProducts { get; set; }

    }
}
