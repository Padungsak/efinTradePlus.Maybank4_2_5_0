using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200020E RID: 526
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ClearEfinSessionCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012EC RID: 4844 RVA: 0x000F9CF0 File Offset: 0x000F80F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ClearEfinSessionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x000F9D1C File Offset: 0x000F811C
		public bool Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (bool)this.results[0];
			}
		}

		// Token: 0x040009E8 RID: 2536
		private object[] results;
	}
}
