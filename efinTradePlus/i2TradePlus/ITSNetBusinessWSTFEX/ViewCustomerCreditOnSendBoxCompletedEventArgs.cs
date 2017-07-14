using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x020002A4 RID: 676
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class ViewCustomerCreditOnSendBoxCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017BA RID: 6074 RVA: 0x00144780 File Offset: 0x00142B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomerCreditOnSendBoxCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x001447AC File Offset: 0x00142BAC
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

		// Token: 0x04000BF8 RID: 3064
		private object[] results;
	}
}
