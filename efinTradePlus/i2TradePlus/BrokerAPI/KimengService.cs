using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.WebProxy;

namespace i2TradePlus.BrokerAPI
{
	// Token: 0x020000F4 RID: 244
	public class KimengService
	{
		// Token: 0x06000B68 RID: 2920 RVA: 0x000CFD64 File Offset: 0x000CE164
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KimengService() : base()
		{
            //while (false)
            //{
            //    //////object arg_0A_0 = null[0];
            //}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._keServer = string.Empty;
	
			try
			{
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000CFDB4 File Offset: 0x000CE1B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KimengWSResult GetCustomerGrade(string userID, string session, string productName)
		{
            //while (false)
            //{
            //    //////object arg_0A_0 = null[0];
            //}
			KimengWSResult kimengWSResult = default(KimengWSResult);
			KimengWSResult result;
			try
			{
				this.kimengAPI = new Https();
				string grade_Server = ApplicationInfo.Grade_Server;
				string xml = this.kimengAPI.Get(string.Concat(new string[]
				{
					grade_Server,
					"/keapi/get_cust_grade.asp?Userid=",
					userID,
					"&Sid=",
					session,
					"&Product=",
					productName
				}));
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				kimengWSResult.Code = xmlDocument.GetElementsByTagName("res_code").Item(0).InnerText.ToString();
				if (kimengWSResult.Code == "0")
				{
					kimengWSResult.AccountNO = xmlDocument.GetElementsByTagName("Inv_no").Item(0).InnerText;
					kimengWSResult.CustomerGrade = xmlDocument.GetElementsByTagName("user_grade").Item(0).InnerText;
					kimengWSResult.Description = "Successed";
				}
				else
				{
					kimengWSResult.Description = xmlDocument.GetElementsByTagName("res_msg").Item(0).InnerText;
				}
				result = kimengWSResult;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x04000778 RID: 1912
		private Https kimengAPI;

		// Token: 0x04000779 RID: 1913
		public string _keServer;
	}
}
