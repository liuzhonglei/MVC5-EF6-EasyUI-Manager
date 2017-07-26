//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Models;
using Apps.Common;
using Microsoft.Practices.Unity;
using System.Transactions;
using Apps.BLL.Core;
using Apps.Locale;
using Apps.Flow.IDAL;
using Apps.Models.Flow;
namespace Apps.Flow.BLL
{
	public class Virtual_Flow_FormAttrBLL
	{
        [Dependency]
        public IFlow_FormAttrRepository m_Rep { get; set; }

		public virtual List<Flow_FormAttrModel> GetList(ref GridPager pager, string queryStr)
        {

            IQueryable<Flow_FormAttr> queryData = null;
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = m_Rep.GetList(
								a=>a.Id.Contains(queryStr)
								|| a.Title.Contains(queryStr)
								|| a.Name.Contains(queryStr)
								|| a.AttrType.Contains(queryStr)
								|| a.CheckJS.Contains(queryStr)
								|| a.TypeId.Contains(queryStr)
								
								|| a.OptionList.Contains(queryStr)
								
								);
            }
            else
            {
                queryData = m_Rep.GetList();
            }
            pager.totalRows = queryData.Count();
            //排序
            queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
            return CreateModelList(ref queryData);
        }
        public virtual List<Flow_FormAttrModel> CreateModelList(ref IQueryable<Flow_FormAttr> queryData)
        {

            List<Flow_FormAttrModel> modelList = (from r in queryData
                                              select new Flow_FormAttrModel
                                              {
													Id = r.Id,
													Title = r.Title,
													Name = r.Name,
													AttrType = r.AttrType,
													CheckJS = r.CheckJS,
													TypeId = r.TypeId,
													CreateTime = r.CreateTime,
													OptionList = r.OptionList,
													IsValid = r.IsValid,
          
                                              }).ToList();

            return modelList;
        }

        public virtual bool Create(ref ValidationErrors errors, Flow_FormAttrModel model)
        {
            try
            {
			    Flow_FormAttr entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.Add(Resource.PrimaryRepeat);
                    return false;
                }
                entity = new Flow_FormAttr(); 
				entity.Id = model.Id;
				entity.Title = model.Title;
				entity.Name = model.Name;
				entity.AttrType = model.AttrType;
				entity.CheckJS = model.CheckJS;
				entity.TypeId = model.TypeId;
				entity.CreateTime = model.CreateTime;
				entity.OptionList = model.OptionList;
				entity.IsValid = model.IsValid;
  

                if (m_Rep.Create(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Resource.InsertFail);
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }



         public virtual bool Delete(ref ValidationErrors errors, string id)
        {
            try
            {
                if (m_Rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

        public virtual bool Delete(ref ValidationErrors errors, string[] deleteCollection)
        {
            try
            {
                if (deleteCollection != null)
                {
                    using (TransactionScope transactionScope = new TransactionScope())
                    {
                        if (m_Rep.Delete(deleteCollection) == deleteCollection.Length)
                        {
                            transactionScope.Complete();
                            return true;
                        }
                        else
                        {
                            Transaction.Current.Rollback();
                            return false;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

		
       

        public virtual bool Edit(ref ValidationErrors errors, Flow_FormAttrModel model)
        {
            try
            {
                Flow_FormAttr entity = m_Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.Add(Resource.Disable);
                    return false;
                }
                              				entity.Id = model.Id;
				entity.Title = model.Title;
				entity.Name = model.Name;
				entity.AttrType = model.AttrType;
				entity.CheckJS = model.CheckJS;
				entity.TypeId = model.TypeId;
				entity.CreateTime = model.CreateTime;
				entity.OptionList = model.OptionList;
				entity.IsValid = model.IsValid;
 


                if (m_Rep.Edit(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Resource.NoDataChange);
                    return false;
                }

            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

      

        public virtual Flow_FormAttrModel GetById(string id)
        {
            if (IsExists(id))
            {
                Flow_FormAttr entity = m_Rep.GetById(id);
                Flow_FormAttrModel model = new Flow_FormAttrModel();
                              				model.Id = entity.Id;
				model.Title = entity.Title;
				model.Name = entity.Name;
				model.AttrType = entity.AttrType;
				model.CheckJS = entity.CheckJS;
				model.TypeId = entity.TypeId;
				model.CreateTime = entity.CreateTime;
				model.OptionList = entity.OptionList;
				model.IsValid = entity.IsValid;
 
                return model;
            }
            else
            {
                return null;
            }
        }

        public virtual bool IsExists(string id)
        {
            return m_Rep.IsExist(id);
        }
		  public void Dispose()
        { 
            
        }

	}
}
