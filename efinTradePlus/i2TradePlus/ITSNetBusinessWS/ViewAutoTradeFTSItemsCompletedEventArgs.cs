using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000151 RID: 337
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ViewAutoTradeFTSItemsCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010B4 RID: 4276 RVA: 0x000F7838 File Offset: 0x000F5C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewAutoTradeFTSItemsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x000F7864 File Offset: 0x000F5C64
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

		// Token: 0x0400098A RID: 2442
		private object[] results;
	}
}
