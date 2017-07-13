using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000218 RID: 536
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class StockThresholdInformationCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600130C RID: 4876 RVA: 0x000F9E80 File Offset: 0x000F8280
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StockThresholdInformationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x000F9EAC File Offset: 0x000F82AC
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

		// Token: 0x040009EC RID: 2540
		private object[] results;
	}
}
