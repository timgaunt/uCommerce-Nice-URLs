//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uCommerceNiceUrls.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class NiceUrl_Product : NiceUrl_Url
    {
        public NiceUrl_Product()
        {
            this.Variants = new HashSet<NiceUrl_Product>();
            this.NiceUrl_Categories = new HashSet<NiceUrl_Category>();
        }
    
        public int uCommerceProductID { get; set; }
        public int CategoryID { get; set; }
        public Nullable<int> ProductFamilyID { get; set; }
    
        public virtual ICollection<NiceUrl_Product> Variants { get; set; }
        public virtual NiceUrl_Product ParentProduct { get; set; }
        public virtual uCommerce_Product uCommerce_Product { get; set; }
        public virtual ICollection<NiceUrl_Category> NiceUrl_Categories { get; set; }
    }
}