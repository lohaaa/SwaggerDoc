using System.ComponentModel.DataAnnotations;

namespace Sample.Models;

/// <summary>
/// 查询订单详情参数
/// </summary>
public class GetOrderListRequest
{
    /// <summary>
    /// 订单号
    /// </summary>
    [MinLength(1, ErrorMessage = "最小长度为1")]
    [MaxLength(64, ErrorMessage = "最大长度为64")]
    [RegularExpression("^[a-zA-Z0-9-]+$", ErrorMessage = "只允许包含大小写字母、数字和英文中横线")]
    public string OrderNo { get; set; }

    /// <summary>
    /// 订单类型
    /// </summary>
    public OrderType OrderType { get; set; }

    /// <summary>
    /// 订单状态
    /// </summary>
    public OrderStatus OrderStatus { get; set; }
}