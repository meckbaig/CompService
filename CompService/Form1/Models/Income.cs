//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Income
    {
        public int IdOrder { get; set; }
        public string FullName { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
    }
}