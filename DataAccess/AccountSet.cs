//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountSet()
        {
            this.FriendList = new HashSet<FriendList>();
            this.FriendList1 = new HashSet<FriendList>();
            this.UserSet = new HashSet<UserSet>();
            this.BlueTeamSet = new HashSet<BlueTeamSet>();
            this.RedTeamSet = new HashSet<RedTeamSet>();
        }
    
        public string Nickname { get; set; }
        public string Email { get; set; }
        public bool EmailVerify { get; set; }
        public string Password { get; set; }
        public int FriendRequest_FriendRequestId { get; set; }
        public int FriendRequest1_FriendRequestId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FriendList> FriendList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FriendList> FriendList1 { get; set; }
        public virtual FriendRequestSet FriendRequestSet { get; set; }
        public virtual FriendRequestSet FriendRequestSet1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSet> UserSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlueTeamSet> BlueTeamSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RedTeamSet> RedTeamSet { get; set; }
    }
}