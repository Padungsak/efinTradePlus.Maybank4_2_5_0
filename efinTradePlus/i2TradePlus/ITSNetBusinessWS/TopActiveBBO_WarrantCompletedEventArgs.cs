using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000198 RID: 408
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class TopActiveBBO_WarrantCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x000F85E4 File Offset: 0x000F69E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBO_WarrantCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x000F8610 File Offset: 0x000F6A10
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

		// Token: 0x040009AD RID: 2477
		private object[] results;
	}
}
