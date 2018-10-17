using DIONE.Extensions;

namespace DIONE.Client
{
    public class Client
    {
        private readonly IService _iservice;

        public Client(IService iservice)
        {
           _iservice = iservice; 
        }

        public void ServeMethod()
        {
            this._iservice.Serve();
        }
    }
}