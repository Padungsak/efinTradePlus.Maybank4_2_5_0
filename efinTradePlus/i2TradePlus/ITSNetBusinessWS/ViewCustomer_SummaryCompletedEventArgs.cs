using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001EE RID: 494
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_SummaryCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600128C RID: 4748 RVA: 0x000F96B0 File Offset: 0x000F7AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_SummaryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000F96DC File Offset: 0x000F7ADC
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

		// Token: 0x040009D8 RID: 2520
		private object[] results;
	}
}
