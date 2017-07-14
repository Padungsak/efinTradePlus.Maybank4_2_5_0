using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200015B RID: 347
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class GetAlertLogByGroupCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010D2 RID: 4306 RVA: 0x000F7A2C File Offset: 0x000F5E2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetAlertLogByGroupCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x000F7A58 File Offset: 0x000F5E58
		public string Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (string)this.results[0];
			}
		}

		// Token: 0x0400098F RID: 2447
		private object[] results;
	}
}
