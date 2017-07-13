using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000117 RID: 279
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class CountOrderCancelForDumpCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001006 RID: 4102 RVA: 0x000F6CE4 File Offset: 0x000F50E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CountOrderCancelForDumpCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x000F6D10 File Offset: 0x000F5110
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

		// Token: 0x0400096D RID: 2413
		private object[] results;
	}
}
