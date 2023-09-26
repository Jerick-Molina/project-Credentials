

using NSubstitute;
using project_Credentials.App.Features.Queries;
using project_Credentials.App.Interfaces;
using project_Credentials.Repository.Repositories;

namespace project_Credentials.Testing;

public class UnitTest1
{
    public readonly LoginQueryHandler _query;

    public readonly IUserRepository _userRepo = Substitute.For<IUserRepository>();
    public UnitTest1 ()
    {
        _query = new LoginQueryHandler(_userRepo);
    }
    [Fact]
    public void GetUserByEmail ()
    {
        //testing
    }
}