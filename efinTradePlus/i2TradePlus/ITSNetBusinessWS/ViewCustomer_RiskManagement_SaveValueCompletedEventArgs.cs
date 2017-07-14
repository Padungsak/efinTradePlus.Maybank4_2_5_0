using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001EA RID: 490
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_RiskManagement_SaveValueCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001280 RID: 4736 RVA: 0x000F95E8 File Offset: 0x000F79E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_RiskManagement_SaveValueCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000F9614 File Offset: 0x000F7A14
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

		// Token: 0x040009D6 RID: 2518
		private object[] results;
	}
}
