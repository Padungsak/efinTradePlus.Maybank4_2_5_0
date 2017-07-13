using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200029E RID: 670
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class ViewCustomersInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017A8 RID: 6056 RVA: 0x00144654 File Offset: 0x00142A54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomersInfoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00144680 File Offset: 0x00142A80
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

		// Token: 0x04000BF5 RID: 3061
		private object[] results;
	}
}
