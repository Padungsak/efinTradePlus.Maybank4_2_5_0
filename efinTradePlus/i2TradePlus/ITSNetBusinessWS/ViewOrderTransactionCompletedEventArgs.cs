using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001C8 RID: 456
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class ViewOrderTransactionCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600121A RID: 4634 RVA: 0x000F8F44 File Offset: 0x000F7344
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderTransactionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x000F8F70 File Offset: 0x000F7370
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

		// Token: 0x040009C5 RID: 2501
		private object[] results;
	}
}
