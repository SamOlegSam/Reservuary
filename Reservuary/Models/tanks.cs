//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reservuary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tanks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tanks()
        {
            this.InventoryM = new HashSet<InventoryM>();
        }
    
        public int location_ID { get; set; }
        public int tank_ID { get; set; }
        public string tank_NAME { get; set; }
        public Nullable<int> inventory_NUM { get; set; }
        public string point { get; set; }
        public string ofice { get; set; }
        public string opc_TAG { get; set; }
        public Nullable<double> value_m3 { get; set; }
        public Nullable<int> tech_min_mm { get; set; }
        public Nullable<int> tech_max_mm { get; set; }
        public string type { get; set; }
        public Nullable<int> dirID_start { get; set; }
        public Nullable<int> dirID_end { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryM> InventoryM { get; set; }
        public virtual location location { get; set; }
    }
}
