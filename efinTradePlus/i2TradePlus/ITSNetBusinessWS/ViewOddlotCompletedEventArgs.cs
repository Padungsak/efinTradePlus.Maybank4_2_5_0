using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001C4 RID: 452
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewOddlotCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600120E RID: 4622 RVA: 0x000F8E7C File Offset: 0x000F727C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOddlotCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000F8EA8 File Offset: 0x000F72A8
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

		// Token: 0x040009C3 RID: 2499
		private object[] results;
	}
}
