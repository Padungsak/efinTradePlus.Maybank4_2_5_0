using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001F2 RID: 498
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_ConfirmCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001298 RID: 4760 RVA: 0x000F9778 File Offset: 0x000F7B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_ConfirmCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000F97A4 File Offset: 0x000F7BA4
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

		// Token: 0x040009DA RID: 2522
		private object[] results;
	}
}
