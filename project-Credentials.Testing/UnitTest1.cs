

using NSubstitute;
using project_Credentials.App.Interfaces;
using project_Credentials.Repository.Repositories;

namespace project_Credentials.Testing;

public class UnitTest1
{
    public readonly UserRepository _sus;

    public readonly ISqlDataContext _userRepo = Substitute.For<ISqlDataContext>();
    public UnitTest1 ()
    {
        _sus = new UserRepository(_userRepo);
    }
    [Fact]
    public void Test1()
    {
        //testing
    }
}