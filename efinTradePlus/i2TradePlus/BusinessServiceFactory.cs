using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.ITSNetBusinessWSTFEX;
using Microsoft.Win32;

namespace i2TradePlus
{
	// Token: 0x02000231 RID: 561
	internal class BusinessServiceFactory
	{
		// Token: 0x06001554 RID: 5460 RVA: 0x0011AACC File Offset: 0x00118ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public i2TradePlus.ITSNetBusinessWS.Service CreateSET(ITSNetWS ITSNetWS)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			i2TradePlus.ITSNetBusinessWS.Service result;
			try
			{
				i2TradePlus.ITSNetBusinessWS.Service service = new BusinessService();
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.RemoteCertificateValidationCallBack);
				if (ITSNetWS == ITSNetWS.EquityService)
				{
					service.Url = ApplicationInfo.WebUrl;
				}
				else if (ITSNetWS == ITSNetWS.MainService)
				{
					service.Url = ApplicationInfo.WebMainUrl;
				}
				else if (ITSNetWS == ITSNetWS.OrderService)
				{
					service.Url = ApplicationInfo.WebOrderUrl;
				}
				else if (ITSNetWS == ITSNetWS.AlertService)
				{
					service.Url = ApplicationInfo.WebAlertUrl;
				}
				result = service;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0011AB98 File Offset: 0x00118F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public i2TradePlus.ITSNetBusinessWSTFEX.Service CreateTFEX(ITSNetWS ITSNetWS)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			i2TradePlus.ITSNetBusinessWSTFEX.Service result;
			try
			{
				i2TradePlus.ITSNetBusinessWSTFEX.Service service = new BusinessTfexService();
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.RemoteCertificateValidationCallBack);
				if (ITSNetWS == ITSNetWS.MainTfexService)
				{
					service.Url = ApplicationInfo.WebMainTfexUrl;
				}
				else
				{
					service.Url = ApplicationInfo.WebTfexUrl;
				}
				result = service;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0011AC18 File Offset: 0x00119018
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetRegistryStringValue(RegistryKey baseKey, string strSubKey, string strValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object obj = null;
			string text = string.Empty;
			string result;
			try
			{
				RegistryKey registryKey = baseKey.OpenSubKey(strSubKey);
				if (registryKey == null)
				{
					result = null;
					return result;
				}
				obj = registryKey.GetValue(strValue);
				if (obj == null)
				{
					result = null;
					return result;
				}
				registryKey.Close();
				baseKey.Close();
			}
			catch (Exception ex)
			{
				text = ex.Message;
				result = null;
				return result;
			}
			result = obj.ToString();
			return result;
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0011ACD8 File Offset: 0x001190D8
		public static bool IsSSLEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return !string.IsNullOrEmpty(ConfigurationManager.AppSettings["WebEnableSSL"]) && ConfigurationManager.AppSettings["WebEnableSSL"] == "1";
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0011AD34 File Offset: 0x00119134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RemoteCertificateValidationCallBack(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["SSLAcceptAnyCert"]))
			{
				result = true;
			}
			else if (ConfigurationManager.AppSettings["SSLAcceptAnyCert"] == "0")
			{
				result = true;
			}
			else
			{
				List<string> list = new List<string>();
				list.AddRange(certificate.Issuer.Split(new char[]
				{
					','
				}));
				string text = ConfigurationManager.AppSettings["SSLCertSerialNumber"];
				string text2 = ConfigurationManager.AppSettings["SSLCertSubject"];
				if (!string.IsNullOrEmpty(text) && list.Contains(text))
				{
					if (!string.IsNullOrEmpty(text2) && text2 == certificate.Subject)
					{
						result = true;
						return result;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0011AE50 File Offset: 0x00119250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BusinessServiceFactory() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor();
		}
	}
}
