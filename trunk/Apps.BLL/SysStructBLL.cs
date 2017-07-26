﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2012-12-11 22:12:12 by App
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Apps.Models;
using Apps.Common;
using Apps.BLL.Core;
using Apps.IBLL;
using Apps.IDAL;
using Apps.Models.Sys;
using Apps.Locale;
namespace Apps.BLL
{
    public partial class SysStructBLL
    {

        public List<SysStructModel> GetList(string parentId)
        {
            IQueryable<SysStruct> queryData = null;
            queryData = m_Rep.GetList(a => a.ParentId == parentId).OrderBy(a => a.Sort);
            return CreateModelList(ref queryData);
        }

        public override List<SysStructModel> CreateModelList(ref IQueryable<SysStruct> queryData)
        {

            List<SysStructModel> modelList = (from r in queryData
                                              select new SysStructModel
                                              {
                                                  Id = r.Id,
                                                  Name = r.Name,
                                                  ParentId = r.ParentId,
                                                  Sort = r.Sort,
                                                  Enable = r.Enable,
                                                  CreateTime = r.CreateTime,
                                                  Higher = r.Higher,
                                                  Remark = r.Remark,
                                                  Type = "group"
                                              }).ToList();
            return modelList;
        }
    }
}