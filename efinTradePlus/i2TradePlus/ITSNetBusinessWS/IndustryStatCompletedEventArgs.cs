using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000190 RID: 400
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class IndustryStatCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001172 RID: 4466 RVA: 0x000F8454 File Offset: 0x000F6854
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IndustryStatCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x000F8480 File Offset: 0x000F6880
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

		// Token: 0x040009A9 RID: 2473
		private object[] results;
	}
}
