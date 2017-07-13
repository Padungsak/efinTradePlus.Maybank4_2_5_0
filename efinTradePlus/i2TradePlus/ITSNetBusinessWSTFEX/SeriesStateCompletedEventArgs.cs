using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000270 RID: 624
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SeriesStateCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600171E RID: 5918 RVA: 0x00143D58 File Offset: 0x00142158
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SeriesStateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00143D84 File Offset: 0x00142184
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

		// Token: 0x04000BDE RID: 3038
		private object[] results;
	}
}
