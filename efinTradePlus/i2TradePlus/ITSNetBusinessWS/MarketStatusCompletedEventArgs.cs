using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001BE RID: 446
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class MarketStatusCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011FC RID: 4604 RVA: 0x000F8D50 File Offset: 0x000F7150
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal MarketStatusCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x000F8D7C File Offset: 0x000F717C
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

		// Token: 0x040009C0 RID: 2496
		private object[] results;
	}
}
