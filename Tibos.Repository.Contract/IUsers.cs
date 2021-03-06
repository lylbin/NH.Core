﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tibos.Domain;
using System.Linq.Expressions;
using Tibos.Common;

namespace Tibos.Repository.Contract
{
	/// <summary>
	/// 接口层D_Users
	/// </summary>
	public interface IUsers
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(object id);

		/// <summary>
		/// 增加一条数据
		/// </summary>
		object  Save(Users model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Users model);
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(Users model);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Users Get(object id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Users> LoadAll();

        /// <summary>
        /// 条件查询
        /// </summary>
        IList<Users> GetList(List<SearchTemplate> st, List<SortOrder> order);

        /// <summary>
        /// 获取总条数
        /// </summary>
        int GetCount(List<SearchTemplate> st);
        

		#endregion  成员方法
	} 
}