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
    
    public partial class P_WC_GetResponseContent_Result
    {
        public string Id { get; set; }
        public string OfficalAccountId { get; set; }
        public Nullable<int> MessageRule { get; set; }
        public Nullable<int> Category { get; set; }
        public string MatchKey { get; set; }
        public string TextContent { get; set; }
        public string ImgTextContext { get; set; }
        public string ImgTextUrl { get; set; }
        public string ImgTextLink { get; set; }
        public string MeidaUrl { get; set; }
        public string MeidaLink { get; set; }
        public bool Enable { get; set; }
        public bool IsDefault { get; set; }
        public string Remark { get; set; }
        public int Sort { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime ModifyTime { get; set; }
        public string ModifyBy { get; set; }
    }
}
