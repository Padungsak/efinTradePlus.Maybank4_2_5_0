using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001CC RID: 460
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewOrdersForDumpCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001226 RID: 4646 RVA: 0x000F900C File Offset: 0x000F740C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrdersForDumpCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x000F9038 File Offset: 0x000F7438
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

		// Token: 0x040009C7 RID: 2503
		private object[] results;
	}
}
