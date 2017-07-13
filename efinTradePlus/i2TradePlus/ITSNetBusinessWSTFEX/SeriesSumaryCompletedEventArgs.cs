using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000294 RID: 660
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class SeriesSumaryCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600178A RID: 6026 RVA: 0x00144460 File Offset: 0x00142860
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SeriesSumaryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x0014448C File Offset: 0x0014288C
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

		// Token: 0x04000BF0 RID: 3056
		private object[] results;
	}
}
