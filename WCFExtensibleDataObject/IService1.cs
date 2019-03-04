using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFExtensibleDataObject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        void CreateCustomer(Customer cust);
       
    }

    public class Customer : IExtensibleDataObject
    {

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return _extensionData;
            }
            set
            {
                _extensionData = value;
            }
        }
        private ExtensionDataObject _extensionData;
        
    }
}
