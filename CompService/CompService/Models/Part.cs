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
    
    public partial class Part
    {
        public int IdPart { get; set; }
        public int IdOrder { get; set; }
        public string PartName { get; set; }
        public string SerialNumber { get; set; }
        public decimal Price { get; set; }
    
        public virtual Order Order { get; set; }
    }
}