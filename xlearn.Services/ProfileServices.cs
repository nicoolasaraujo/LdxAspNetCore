using Microsoft.Extensions.Configuration;
using xlearn.Models;
using xlearn.Repository;
using Xlearn.Repository;

namespace Xlearn.Services {
    public class ProfileServices : RepositoryBase<Profile> {
        public ProfileServices(IConfiguration configuration) : base(configuration) { }

    }
}