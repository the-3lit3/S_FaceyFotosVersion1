//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S_FaceyFotosVersion1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_shootTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_shootTime()
        {
            this.tb_bookingInfo = new HashSet<tb_bookingInfo>();
        }
    
        public int Id { get; set; }
        public string Shoot_Time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_bookingInfo> tb_bookingInfo { get; set; }
    }
}
