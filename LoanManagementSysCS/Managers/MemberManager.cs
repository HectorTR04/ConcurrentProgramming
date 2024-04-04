using LoanManagementSys.SystemItems;

namespace LoanManagementSys.Managers
{
    /// <summary>
    /// Manager which reads a list of member data from a file and adds each entry as a member object in a member list.
    /// </summary>
    public class MemberManager : BaseManager<Member>
    {
        private readonly string[] _memberNames; //String array to hold member entries from a text file as strings

        public MemberManager()
        {
            var path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            _memberNames = File.ReadAllLines(newPath + "\\Member.txt"); //Reads text file containing member entries    
        }

        //Method which adds testmembers to the member list, which numeric id that increments each time
        public void AddTestMember()
        {
            foreach (string name in _memberNames)
            {
                AddNewTestMember(_lastID++, name);
            }          
        }
        
        //Method which creates a new test member to add to the member list
        public Member AddNewTestMember(int id, string name)
        {
            Member member = new Member(id, name); 
            member.ID = id;
            member.Name = name;
            _systemItems.Add(member);
            return member;
        }
    }
}
