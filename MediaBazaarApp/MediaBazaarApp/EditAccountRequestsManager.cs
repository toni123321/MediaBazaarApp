using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class EditAccountRequestsManager
    {
        private IList<EditAccountRequest> editAccountRequests;
        private DBControl storage;

        public EditAccountRequestsManager()
        {
            this.editAccountRequests = new List<EditAccountRequest>();
            this.storage = new DBControl();
            this.LoadDataFromStorage();
        }

        public void LoadDataFromStorage()
        {
            editAccountRequests = this.storage.GetEditAccountRequests();
        }

        public void AcceptRequest(int requestId)
        {
            // Update db with new request status
            this.storage.UpdateEditAccountRequest((EditAccountRequest)
                editAccountRequests.Select(x => x.Id == requestId));
        }

        public void DeclineRequest(int requestId)
        {
            // Update db with new request status
            this.storage.UpdateEditAccountRequest((EditAccountRequest)
                editAccountRequests.Select(x=> x.Id == requestId));
        }

        public IList<EditAccountRequest> GetAllEditAccountRequests()
        {
            return this.editAccountRequests;
        }
    }
}
