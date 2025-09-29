
namespace pr1.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string? GroupName { get; set; }

        public Group(int id, string groupName)
        {
            Id = id;
            GroupName = groupName;
        }
    }
}