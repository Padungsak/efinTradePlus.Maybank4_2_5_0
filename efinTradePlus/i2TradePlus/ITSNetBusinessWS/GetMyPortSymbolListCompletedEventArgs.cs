using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200019E RID: 414
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class GetMyPortSymbolListCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600119C RID: 4508 RVA: 0x000F8710 File Offset: 0x000F6B10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetMyPortSymbolListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000F873C File Offset: 0x000F6B3C
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

		// Token: 0x040009B0 RID: 2480
		private object[] results;
	}
}
