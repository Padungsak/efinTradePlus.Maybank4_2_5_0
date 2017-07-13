using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200017A RID: 378
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class LoadAllInformationCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001130 RID: 4400 RVA: 0x000F8008 File Offset: 0x000F6408
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadAllInformationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x000F8034 File Offset: 0x000F6434
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

		// Token: 0x0400099E RID: 2462
		private object[] results;
	}
}
