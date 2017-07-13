using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000268 RID: 616
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class LoadSETindexCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001706 RID: 5894 RVA: 0x00143BC8 File Offset: 0x00141FC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadSETindexCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00143BF4 File Offset: 0x00141FF4
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

		// Token: 0x04000BDA RID: 3034
		private object[] results;
	}
}
