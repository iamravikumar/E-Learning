//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Learning.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Content_Type()
        {
            this.Course_Chapter_Content = new HashSet<Course_Chapter_Content>();
        }
    
        public int id { get; set; }
        public string content_type1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Chapter_Content> Course_Chapter_Content { get; set; }
    }
}
