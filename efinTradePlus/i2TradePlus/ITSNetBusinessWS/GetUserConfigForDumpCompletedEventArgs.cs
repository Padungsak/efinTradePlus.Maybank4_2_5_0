using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001B4 RID: 436
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class GetUserConfigForDumpCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011DE RID: 4574 RVA: 0x000F8B5C File Offset: 0x000F6F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetUserConfigForDumpCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x000F8B88 File Offset: 0x000F6F88
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

		// Token: 0x040009BB RID: 2491
		private object[] results;
	}
}
