using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x020002A6 RID: 678
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class ViewCustomer_RiskManagementCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017C0 RID: 6080 RVA: 0x001447E4 File Offset: 0x00142BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_RiskManagementCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00144810 File Offset: 0x00142C10
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

		// Token: 0x04000BF9 RID: 3065
		private object[] results;
	}
}
