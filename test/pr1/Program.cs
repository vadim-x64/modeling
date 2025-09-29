using pr1.Interfaces;
using pr1.Models;
using pr1.Repositories;

namespace pr1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Group group1 = new Group(1, "ПД-31");

            IGroupRepository groupRepository = new GroupRepository();
            groupRepository.AddGroup(group1);
            groupRepository.GetGroupById(1);

            Console.WriteLine(group1.GroupName);
        }
    }
}