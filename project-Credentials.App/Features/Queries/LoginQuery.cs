using MediatR;
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

        public async Task<string> Handle(LoginQuery query,CancellationToken cancellationToken)
        {
            Debug.WriteLine(query.email);
            return query.email;
        }
    }
}
