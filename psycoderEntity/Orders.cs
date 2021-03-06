﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace psycoderEntity
{
    public class FensiOrders
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "用户ID")]
        public int Customer { get; set; }

        [Display(Name = "商家ID")]
        public int Seller { get; set; }

        [Display(Name = "产品ID")]
        public int Product { get; set; }
        [Display(Name = "产品价格")]
        public float ProductPrice { get; set; }

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
        [Display(Name = "产品价格")]
        public float ProductPrice { get; set; }

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
        未付款=1,
        已付款=2,
        已过期=3,
        已禁用=0,
    
    }

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "产品名称")]
        [Required]
        public string ProductName { get; set; }

        [Display(Name = "产品价格")]
        [Required(ErrorMessage="请输入价格")]
        public float ProductPrice { get; set; }

        [Display(Name = "商家ID")]
        public int Zixunshi { get; set; }
 
    }
}
