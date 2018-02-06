using EduxV2.Data;
using EduxV2.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduxV2.Service
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public UserProfile GetUserProfile(string id)
        {
            return userProfileRepository.Get(id);
        }
    }
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(string id);
    }
}
