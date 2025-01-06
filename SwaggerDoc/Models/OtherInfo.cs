using System.Text.Json.Serialization;

namespace SwaggerDoc.Models
{
    /// <summary>
    /// 其他信息
    /// </summary>
    public class OtherInfo
    {
        /// <summary>
        /// 最小长度
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? 最小长度 { get; set; }
        /// <summary>
        /// 最大长度
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? 最大长度 { get; set; }
        /// <summary>
        /// 最小值
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? 最小值 { get; set; }
        /// <summary>
        /// 最大值
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? 最大值 { get; set; }
        /// <summary>
        /// 格式校验
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string 格式校验 { get; set; }
    }
}
