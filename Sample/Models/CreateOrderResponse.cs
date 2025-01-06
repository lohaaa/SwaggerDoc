using System.ComponentModel.DataAnnotations;

namespace Sample.Models;

/// <summary>
/// 创建订单返回
/// </summary>
public class CreateOrderResponse
{
    /// <summary>
    /// 订单号
    /// </summary>
    [MinLength(1, ErrorMessage = "最小长度为1")]
    [MaxLength(64, ErrorMessage = "最大长度为64")]
    [RegularExpression("^[a-zA-Z0-9-]+$", ErrorMessage = "只允许包含大小写字母、数字和英文中横线")]
    public string OrderNo { get; set; }

    /// <summary>
    /// 支付链接
    /// </summary>
    public string PayUrl { get; set; }

    /// <summary>
    /// 支付二维码
    /// </summary>
    public string PayQrCode { get; set; }
}
