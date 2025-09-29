using pr1.Models;

namespace pr1.Interfaces
{
    public interface IGroupRepository
    {
        void AddGroup(Group group);
        List<Group> GetAll(Group group);
        Group GetGroupById(int id);
        void Update(Group group);
        void DeleteGroupById(int id);
        void DeleteAll();
    }
}