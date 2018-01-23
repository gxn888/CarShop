﻿using Abp.Runtime.Validation;
using YT.Dto;

namespace YT.Dashboard.Areas.Dtos
{
	/// <summary>
    /// 区域管理查询Dto
    /// </summary>
    public class GetAreaInput : PagedAndSortedInputDto, IShouldNormalize
    {
        //DOTO:在这里增加查询参数

		/// <summary>
	    /// 模糊查询参数
		/// </summary>
		public string FilterText { get; set; }

		/// <summary>
	    /// 用于排序的默认值
		/// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
			
		
                Sorting = "Id";
            }
        }
    }
}
