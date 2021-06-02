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

        public EditAccountRequest GetEditAccountRequest(int requestId)
        {
            foreach (EditAccountRequest request in editAccountRequests)
            {
                if (request.Id == requestId)
                {
                    return request;
                }
            }

            return null;
        }

        public void AcceptRequest(int requestId, DepartmentManagement departmentManagement)
        {
            // Update db with new request status
            EditAccountRequest editedRequest = GetEditAccountRequest(requestId);
            editedRequest.Status = "Accepted";
            // Update the edit account request
            this.storage.UpdateEditAccountRequest(editedRequest);
            LoadDataFromStorage();

            Employee currEmp = departmentManagement.GetEmployeeById(requestId);
            
            currEmp.Email = editedRequest.Email;
            currEmp.PhoneNumber = editedRequest.PhoneNumber;
            currEmp.Street = editedRequest.Street;
            currEmp.City = editedRequest.City;
            currEmp.Country = editedRequest.Country;
            currEmp.Postcode = editedRequest.Postcode;

            //Emergency contact details
            currEmp.EmConName = editedRequest.EmConName; 
            currEmp.EmConRelation = editedRequest.EmConRelation;
            currEmp.EmConEmail = editedRequest.EmConEmail;
            currEmp.EmConPhoneNum = editedRequest.EmConPhone;
            storage.EditEmployee(currEmp);
            storage.GetEmployees(departmentManagement);

        }

        public void DeclineRequest(int requestId)
        {
            // Update db with new request status
            EditAccountRequest editedRequest = GetEditAccountRequest(requestId);
            editedRequest.Status = "Declined";
            this.storage.UpdateEditAccountRequest(editedRequest);
            LoadDataFromStorage();
        }

        public IList<EditAccountRequest> GetAllEditAccountRequests()
        {
            return this.editAccountRequests;
        }

        public IList<EditAccountRequest> GetAcceptedEditAccountRequests()
        {
            return this.editAccountRequests.Where(x=> x.Status == "Accepted").ToList();
        }

        public IList<EditAccountRequest> GetDeclinedEditAccountRequests()
        {
            return this.editAccountRequests.Where(x => x.Status == "Declined").ToList();
        }

        public IList<EditAccountRequest> GetInProgressEditAccountRequests()
        {
            return this.editAccountRequests.Where(x => x.Status == "InProgress").ToList();
        }
    }
}
