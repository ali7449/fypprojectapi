//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fypprojectapi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DRESSINFO
    {
        public DRESSINFO()
        {
            this.DRESSIMAGEs = new HashSet<DRESSIMAGE>();
            this.OWNERFAVORITEs = new HashSet<OWNERFAVORITE>();
            this.RENTs = new HashSet<RENT>();
            this.WHISHLISTs = new HashSet<WHISHLIST>();
        }
    
        public Nullable<int> uid { get; set; }
        public int did { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public Nullable<int> cost { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public string descriptin { get; set; }
        public string geneder { get; set; }
        public string quality { get; set; }
        public Nullable<double> rating { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<DRESSIMAGE> DRESSIMAGEs { get; set; }
        public virtual USERINFO USERINFO { get; set; }
        public virtual ICollection<OWNERFAVORITE> OWNERFAVORITEs { get; set; }
        public virtual ICollection<RENT> RENTs { get; set; }
        public virtual ICollection<WHISHLIST> WHISHLISTs { get; set; }
    }
}