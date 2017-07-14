using System;
using System.Runtime.CompilerServices;
using System.Web.Services.Protocols;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus
{
	// Token: 0x02000245 RID: 581
	internal class WebServiceFactory
	{
		// Token: 0x060015EB RID: 5611 RVA: 0x00126A3C File Offset: 0x00124E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SoapHttpClientProtocol Create(ITSNetWS ITSNetWS)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			SoapHttpClientProtocol result;
			try
			{
				SoapHttpClientProtocol soapHttpClientProtocol;
				if (ITSNetWS == ITSNetWS.TfexService || ITSNetWS == ITSNetWS.MainTfexService)
				{
					soapHttpClientProtocol = new BusinessServiceFactory().CreateTFEX(ITSNetWS);
				}
				else
				{
					soapHttpClientProtocol = new BusinessServiceFactory().CreateSET(ITSNetWS);
				}
				result = soapHttpClientProtocol;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00126AB0 File Offset: 0x00124EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebServiceFactory() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
		}
	}
}
