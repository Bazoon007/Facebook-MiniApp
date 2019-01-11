namespace Ex03.Services
{
    public abstract class FacebookFeature
    {
        protected readonly string r_UserId;

        public string UserId
        {
            get
            {
                return r_UserId;
            }
        }

        public FacebookFeature(UserFacade i_User)
        {
            r_UserId = i_User.Id;
        }
    }
}
