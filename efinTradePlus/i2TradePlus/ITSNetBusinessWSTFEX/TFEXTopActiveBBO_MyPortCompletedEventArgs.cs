using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200027C RID: 636
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TFEXTopActiveBBO_MyPortCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001742 RID: 5954 RVA: 0x00143FB0 File Offset: 0x001423B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TFEXTopActiveBBO_MyPortCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00143FDC File Offset: 0x001423DC
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

		// Token: 0x04000BE4 RID: 3044
		private object[] results;
	}
}
