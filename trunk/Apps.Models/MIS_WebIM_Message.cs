//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MIS_WebIM_Message
    {
        public MIS_WebIM_Message()
        {
            this.MIS_WebIM_Message_Rec = new HashSet<MIS_WebIM_Message_Rec>();
        }
    
        public string Id { get; set; }
        public string Message { get; set; }
        public string Sender { get; set; }
        public string receiver { get; set; }
        public bool State { get; set; }
        public Nullable<System.DateTime> SendDt { get; set; }
        public string receiverTitle { get; set; }
    
        public virtual ICollection<MIS_WebIM_Message_Rec> MIS_WebIM_Message_Rec { get; set; }
    }
}
