﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace psycoderEntity
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "用户ID")]
        public int Customer { get; set; }

        [Display(Name = "商家ID")]
        public int Seller { get; set; }

        [Display(Name = "产品ID")]
        public int Product { get; set; }

        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }

        [Display(Name = "有效期截止时间")]
        public DateTime ExpiryTime { get; set; }

        [Display(Name = "订单备注")]
        public string Beizhu { get; set; }

        [Display(Name = "订单状态")]
        public string Status { get; set; }

    }

    public class PsyOrders
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "用户ID")]
        public int Customer { get; set; }

        [Display(Name = "商家ID")]
        public int Seller { get; set; }

        [Display(Name = "产品ID")]
        public int Product { get; set; }

        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }

        [Display(Name = "有效期截止时间")]
        public DateTime ExpiryTime { get; set; }

        [Display(Name = "订单备注")]
        public string Beizhu { get; set; }

        [Display(Name = "订单状态")]
        public string Status { get; set; }

    }

    public enum OrderStatus
    {
        未付款,
        已付款,
        已过期,
        已禁用,
    
    }
}
