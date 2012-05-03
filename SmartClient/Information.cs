using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Collections.Specialized;
using System.IO;
using MyNameSpace.Screens;

namespace SmartClient
{
	public partial class frmInformation : Form
	{
		private BasicHttpBinding binding = new BasicHttpBinding();
		private NameValueCollection appSettings;
		private EndpointAddress endPointAddress;
		private InformationServiceClient informationServiceClient;
	
		public frmInformation()
		{
			InitializeComponent();
		}

		private void btnServerCall_Click(object sender, EventArgs e)
		{
		informationServiceClient = new InformationServiceClient(binding, endPointAddress);
		UserInformation user = informationServiceClient.GetUserInfo(Convert.ToInt32 (this.cboUserId.Text));

		StringBuilder sb = new StringBuilder();
			if (user !=null) {
				if (user.UserName !=null){
					sb.Append(user.UserName);
						sb.Append(",");
				}
				if (user.Age !=null){
					sb.Append(user.Age);
				}
				this.txtUserInformation.Text = sb.ToString();
			}
			else{
				this.txtUserInformation.Text = "No user information returned.";
			}
		}

		private void frmInformation_Load(object sender, System.EventArgs e){
			//read the configuration settings.There is no ConfigurationManager inbuilt class in CF.
			// Load config file as an XmlDocument
			XmlDocument myXmlDocument = new XmlDocument();
			myXmlDocument.Load(String.Format("{0}.config", System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase));

			appSettings = new NameValueCollection();
			//Read appsettings
			foreach (XmlNode appSettingNode in myXmlDocument.SelectNodes("/configuration/appSettings/add"))
			{
				appSettings.Add(appSettingNode.Attributes[@"key"].Value, appSettingNode.Attributes[@"value"].Value);
			}

			endPointAddress = new EndpointAddress(Path.Combine(appSettings[@"HostWebSite"], appSettings[@"InformationService"]));
		}

	}
}