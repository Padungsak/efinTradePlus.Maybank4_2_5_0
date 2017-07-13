using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200019C RID: 412
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class TopActiveBBO_MyPortCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001196 RID: 4502 RVA: 0x000F86AC File Offset: 0x000F6AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBO_MyPortCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x000F86D8 File Offset: 0x000F6AD8
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

		// Token: 0x040009AF RID: 2479
		private object[] results;
	}
}
