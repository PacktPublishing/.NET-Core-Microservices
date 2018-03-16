namespace Actio.Common.Events
{
    public class AuthenticateUserRejected : IRejectedEvent
    {
        public string Email { get; }
        public string Code { get; }
        public string Reason { get; }

        protected AuthenticateUserRejected()
        {
        }

        public AuthenticateUserRejected(string email,
            string code, string reason)
        {
            Email = email;
            Code = code;
            Reason = reason;
        }         
    }
}