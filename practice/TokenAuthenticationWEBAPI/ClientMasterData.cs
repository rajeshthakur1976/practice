using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuthenticationWEBAPI
{
    public class ClientMasterData
    {
        List<ClientMaster> ColClientMaster = new List<ClientMaster>();
        public ClientMasterData()
        {
            ColClientMaster.Add(new ClientMaster() { ClientId = "1", ClientKeyId = 1, ClientName = "Lemontree0", ClientSecret = "llll1", CreatedOn = System.DateTime.Now });
            ColClientMaster.Add(new ClientMaster() { ClientId = "2", ClientKeyId = 2, ClientName = "Lemontree1", ClientSecret = "llll2", CreatedOn = System.DateTime.Now });
            ColClientMaster.Add(new ClientMaster() { ClientId = "3", ClientKeyId = 3, ClientName = "Lemontree2", ClientSecret = "llll3", CreatedOn = System.DateTime.Now });
        }

        public ClientMaster ValidateClient(string ClientID, string ClientSecret)
        {
            return ColClientMaster.FirstOrDefault(user => user.ClientId == ClientID && user.ClientSecret == ClientSecret);
        }
    }

    public class ClientMaster
    {
        public int ClientKeyId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string ClientName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Active { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        public string AllowedOrigin { get; set; }
    }

    public class RefreshToken
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string ClientID { get; set; }
        public DateTime IssuedTime { get; set; }
        public DateTime ExpiredTime { get; set; }
        public string ProtectedTicket { get; set; }

    }
}