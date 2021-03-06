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
    
    public partial class uCommerce_Product
    {
        public uCommerce_Product()
        {
            this.NiceUrl_Product = new HashSet<NiceUrl_Product>();
            this.uCommerce_Product1 = new HashSet<uCommerce_Product>();
        }
    
        public int ProductId { get; set; }
        public Nullable<int> ParentProductId { get; set; }
        public string Sku { get; set; }
        public string VariantSku { get; set; }
        public string Name { get; set; }
        public bool DisplayOnSite { get; set; }
        public string ThumbnailImageMediaId { get; set; }
        public string PrimaryImageMediaId { get; set; }
        public decimal Weight { get; set; }
        public int ProductDefinitionId { get; set; }
        public bool AllowOrdering { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<double> Rating { get; set; }
    
        public virtual ICollection<NiceUrl_Product> NiceUrl_Product { get; set; }
        public virtual ICollection<uCommerce_Product> uCommerce_Product1 { get; set; }
        public virtual uCommerce_Product uCommerce_Product2 { get; set; }
    }
}
