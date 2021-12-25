using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.BLL.Helpers
{
    public class MessageBuilder
    {
        protected string ControllerName { get; set; }
        protected string ActionName { get; set; }
        public MessageBuilder()
        {
            this.ControllerName = String.Empty;
            this.ActionName = String.Empty;
        }
        public MessageBuilder(string controllerName)
        {
            this.ControllerName = controllerName;
            this.ActionName = String.Empty;
        }
        public MessageBuilder(string controllerName, string actionName)
        {
            this.ControllerName = controllerName;
            this.ActionName = actionName;
        }

        public string CreatedOrUpdated(int reqId, int respId)
        {
            return $"{ControllerName} {(reqId == respId ? Constants.Messages.UpdatedSuccessfully : Constants.Messages.CreatedSuccessfully)}";
        }

        public string NotCreatedOrUpdated(int reqId)
        {
            return $"{ControllerName} {(reqId == 0 ? Constants.Messages.NotCreated : Constants.Messages.NotUpdated)}";
        }
        public string Deleted(bool isDeleted)
        {
            return $"{ControllerName} {(isDeleted ? Constants.Messages.DeletedSuccessfully : Constants.Messages.NotDeleted)}";
        }
    }
}
