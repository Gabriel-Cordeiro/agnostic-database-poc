using Core.Enums;

namespace Api.Models
{
    public class AccessToken
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DatabaseProvider Provider { get; set; }
        public required string ConnectionName { get; set; }
    }
}
