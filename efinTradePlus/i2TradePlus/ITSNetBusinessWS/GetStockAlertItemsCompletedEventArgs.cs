using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000161 RID: 353
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class GetStockAlertItemsCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010E4 RID: 4324 RVA: 0x000F7B58 File Offset: 0x000F5F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetStockAlertItemsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x000F7B84 File Offset: 0x000F5F84
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

		// Token: 0x04000992 RID: 2450
		private object[] results;
	}
}
