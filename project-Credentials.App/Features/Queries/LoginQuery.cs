using MediatR;
using project_Credentials.App.Interfaces;
using project_Credentials.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Credentials.App.Features.Queries
{

    public record LoginQuery(string email) : IRequest<string>;
    public class LoginQueryHandler : IRequestHandler<LoginQuery,string>
    {
        private readonly IUserRepository _user;
        private readonly IJwtUtil _jwt;
        private readonly IHasher _hasher;
        private readonly INumberGenerator _numberGenerator;

        public LoginQueryHandler(IUserRepository user)
        {
            _user = user;
        }
        public async Task<string> Handle(LoginQuery query,CancellationToken cancellationToken)
        {
            Debug.WriteLine(query.email);
            return query.email;
        }
    }
}
