using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000298 RID: 664
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class ViewOrderTransactionCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001796 RID: 6038 RVA: 0x00144528 File Offset: 0x00142928
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderTransactionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00144554 File Offset: 0x00142954
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

		// Token: 0x04000BF2 RID: 3058
		private object[] results;
	}
}
