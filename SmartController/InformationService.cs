using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace MyNameSpace
{
	[ServiceContract(Namespace ="http://schemas.a-t-g.com/2010/08/web/services", ConfigurationName="InformationScreenService")] 
	[AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Required)] 
	public class InformationService
	{
		[OperationContract]
		public  UserInformation GetUserInfo(int userId){
			UserInformation user;
			switch (userId) {
				case 1:
					user = new UserInformation("Akshata", "Shanbhag", 28);
					break;
				case 2:
					user = new UserInformation("Sam", "Khawase", 29);
					break;
				default:
					return null;
			}
			return user;
		}
	}
}
