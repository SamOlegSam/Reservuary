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
    
    public partial class InventoryM
    {
        public int ID { get; set; }
        public Nullable<int> IDRez { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Massa { get; set; }
        public Nullable<decimal> Vol { get; set; }
        public string UserDC { get; set; }
        public Nullable<decimal> Plotnost { get; set; }
        public Nullable<decimal> Temper { get; set; }
        public Nullable<decimal> V20 { get; set; }
        public Nullable<decimal> Uroven { get; set; }
        public Nullable<int> LocID { get; set; }
        public Nullable<decimal> UrovH2O { get; set; }
        public Nullable<decimal> VH2O { get; set; }
    
        public virtual tanks tanks { get; set; }
    }
}
