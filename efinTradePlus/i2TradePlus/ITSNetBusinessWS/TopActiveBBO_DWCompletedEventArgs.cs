using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001A0 RID: 416
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopActiveBBO_DWCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011A2 RID: 4514 RVA: 0x000F8774 File Offset: 0x000F6B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBO_DWCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000F87A0 File Offset: 0x000F6BA0
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

		// Token: 0x040009B1 RID: 2481
		private object[] results;
	}
}
