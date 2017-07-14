using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000216 RID: 534
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class ChangeTraderPasswordCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001306 RID: 4870 RVA: 0x000F9E1C File Offset: 0x000F821C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ChangeTraderPasswordCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x000F9E48 File Offset: 0x000F8248
		public bool Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (bool)this.results[0];
			}
		}

		// Token: 0x040009EB RID: 2539
		private object[] results;
	}
}
