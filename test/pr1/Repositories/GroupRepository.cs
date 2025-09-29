using pr1.Interfaces;
using pr1.Models;

namespace pr1.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private List<Group> _groups = new List<Group>();

        public void AddGroup(Group group)
        {
            _groups.Add(group);
        }

        public void DeleteGroupById(int id)
        {
            var group = _groups.FirstOrDefault(g => g.Id == id);

            if (group != null)
            {
                _groups.Remove(group);
            }
        }

        public List<Group> GetAll(Group group)
        {
            return _groups;
        }

        public Group GetGroupById(int id)
        {
            return _groups.FirstOrDefault(g => g.Id == id);
        }

        public void Update(Group group)
        {
            var existing = _groups.FirstOrDefault(g => g.Id == group.Id);
            
            if (existing != null)
            {
                existing.GroupName = group.GroupName;
            }
        }

        public void DeleteAll()
        {
            _groups.Clear();
        }
    }
}