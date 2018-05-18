﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using psycoderDal;
using psycoderEntity;
using Common;

namespace psycoder.Controllers
{
    public class AdminOrderController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: /Notice/
        public ActionResult OrderList(int? page)
        {

            Pager pager = new Pager();
            pager.table = "Orders";
            pager.strwhere = "1=1";
            pager.PageSize = 20;
            pager.PageNo = page ?? 1;
            pager.FieldKey = "Id";
            pager.FiledOrder = "Id desc";

            pager = CommonDal.GetPager(pager);
            IList<Orders> dataList = DataConvertHelper<Orders>.ConvertToModel(pager.EntityDataTable);
            var PageList = new StaticPagedList<Orders>(dataList, pager.PageNo, pager.PageSize, pager.Amount);
            return View(PageList);

        }

        public ActionResult PsyOrderList(int? page)
        {
            Pager pager = new Pager();
            pager.table = "PsyOrders";
            pager.strwhere = "1=1";
            pager.PageSize = 20;
            pager.PageNo = page ?? 1;
            pager.FieldKey = "Id";
            pager.FiledOrder = "Id desc";

            pager = CommonDal.GetPager(pager);
            IList<PsyOrders> dataList = DataConvertHelper<PsyOrders>.ConvertToModel(pager.EntityDataTable);
            var PageList = new StaticPagedList<PsyOrders>(dataList, pager.PageNo, pager.PageSize, pager.Amount);
            return View(PageList);
        }
	}
}