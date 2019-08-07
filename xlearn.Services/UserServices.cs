using Microsoft.Extensions.Configuration;

using xlearn.Models;
using xlearn.Repository;
using Xlearn.Repository;

namespace xlearn.Services {
    public class UserServices : RepositoryBase<User> {
        public UserServices(IConfiguration configuration) : base(configuration) { }

    }
}