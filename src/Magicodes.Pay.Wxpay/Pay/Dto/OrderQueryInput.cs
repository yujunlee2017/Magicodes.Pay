﻿// ======================================================================
//   
//           Copyright (C) 2018-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : OrderQueryInput.cs
//           description :
//   
//           created by 雪雁 at  2018-07-31 9:52
//           Mail: wenqiang.li@xin-lai.com
//           QQ群：85318032（技术交流）
//           Blog：http://www.cnblogs.com/codelove/
//           GitHub：https://github.com/xin-lai
//           Home：http://xin-lai.com
//   
// ======================================================================

using System.Xml.Serialization;

namespace Magicodes.Pay.Wxpay.Pay.Dto
{
    /// <summary>
    ///     订单查询
    /// </summary>
    public class OrderQueryInput
    {
        /// <summary>
        ///     微信支付订单号（二选一）
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        ///     商户系统的订单号，与请求一致（二选一）
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}