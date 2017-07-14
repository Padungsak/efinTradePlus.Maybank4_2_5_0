using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001F8 RID: 504
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class ViewOrderInfo_AfterCloseFwCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012AA RID: 4778 RVA: 0x000F98A4 File Offset: 0x000F7CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderInfo_AfterCloseFwCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x000F98D0 File Offset: 0x000F7CD0
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

		// Token: 0x040009DD RID: 2525
		private object[] results;
	}
}
