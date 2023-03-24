using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_api.Entities
{
    [Table("users")]
    public class User
    {
        /// <summary>
        /// 使用者id
        /// </summary>
        [JsonRequired]
        [Column("user_id")]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// 使用者名稱
        /// </summary>
        [JsonRequired]
        [Column("user_name", TypeName = "varchar(50)")]
        public string UserName
        {
            get; set;
        }
    }
}
