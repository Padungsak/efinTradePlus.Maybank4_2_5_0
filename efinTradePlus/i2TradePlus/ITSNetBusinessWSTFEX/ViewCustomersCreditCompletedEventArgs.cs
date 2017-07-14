using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200029C RID: 668
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ViewCustomersCreditCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017A2 RID: 6050 RVA: 0x001445F0 File Offset: 0x001429F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomersCreditCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x0014461C File Offset: 0x00142A1C
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

		// Token: 0x04000BF4 RID: 3060
		private object[] results;
	}
}
