//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunctionalTests.ProductivityApi.TemplateModels.CsMonsterModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiscontinuedProductMm : ProductMm
    {
        public System.DateTime Discontinued { get; set; }
        public Nullable<int> ReplacementProductId { get; set; }
    
        public virtual ProductMm ReplacedBy { get; set; }
    }
}
