using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001B6 RID: 438
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class SaveUserConfigForDumpCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011E4 RID: 4580 RVA: 0x000F8BC0 File Offset: 0x000F6FC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveUserConfigForDumpCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000F8BEC File Offset: 0x000F6FEC
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

		// Token: 0x040009BC RID: 2492
		private object[] results;
	}
}
