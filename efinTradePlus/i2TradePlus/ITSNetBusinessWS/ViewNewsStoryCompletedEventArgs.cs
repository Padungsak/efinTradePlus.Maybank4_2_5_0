using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001D2 RID: 466
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class ViewNewsStoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001238 RID: 4664 RVA: 0x000F9138 File Offset: 0x000F7538
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewNewsStoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000F9164 File Offset: 0x000F7564
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

		// Token: 0x040009CA RID: 2506
		private object[] results;
	}
}
