using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200026C RID: 620
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TFEXInformationCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001712 RID: 5906 RVA: 0x00143C90 File Offset: 0x00142090
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TFEXInformationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00143CBC File Offset: 0x001420BC
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

		// Token: 0x04000BDC RID: 3036
		private object[] results;
	}
}
