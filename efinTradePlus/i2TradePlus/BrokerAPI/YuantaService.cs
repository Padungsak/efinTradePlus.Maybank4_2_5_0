using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.WebProxy;

namespace i2TradePlus.BrokerAPI
{
	// Token: 0x02000242 RID: 578
	public class YuantaService
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x001268A8 File Offset: 0x00124CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public YuantaWSResult GetCustomerGrade(string userID, string session, string productName)
		{
            //while (false)
            //{
            //    //////object arg_0A_0 = null[0];
            //}
			YuantaWSResult yuantaWSResult = default(YuantaWSResult);
			YuantaWSResult result;
			try
			{
				this.yuantaAPI = new Https();
				string grade_Server = ApplicationInfo.Grade_Server;
				string xml = this.yuantaAPI.Get(string.Concat(new string[]
				{
					grade_Server,
					"/ytapi/get_cust_grade.aspx?Userid=",
					userID,
					"&Sid=",
					session,
					"&Product=",
					productName
				}));
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				yuantaWSResult.Code = xmlDocument.GetElementsByTagName("code").Item(0).InnerText.ToString();
				if (yuantaWSResult.Code == "0")
				{
					yuantaWSResult.AccountNO = xmlDocument.GetElementsByTagName("inv_no").Item(0).InnerText;
					yuantaWSResult.CustomerGrade = xmlDocument.GetElementsByTagName("user_grade").Item(0).InnerText;
					yuantaWSResult.Description = xmlDocument.GetElementsByTagName("msg").Item(0).InnerText;
				}
				else
				{
					yuantaWSResult.Description = xmlDocument.GetElementsByTagName("msg").Item(0).InnerText;
				}
				result = yuantaWSResult;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00126A20 File Offset: 0x00124E20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public YuantaService() :base()
		{
            //while (false)
            //{
            //    //////object arg_0A_0 = null[0];
            //}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			//
		}

		// Token: 0x04000B50 RID: 2896
		private Https yuantaAPI;
	}
}
