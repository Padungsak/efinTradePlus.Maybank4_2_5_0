using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000163 RID: 355
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetPortAlertItemsCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010EA RID: 4330 RVA: 0x000F7BBC File Offset: 0x000F5FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetPortAlertItemsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x000F7BE8 File Offset: 0x000F5FE8
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

		// Token: 0x04000993 RID: 2451
		private object[] results;
	}
}
