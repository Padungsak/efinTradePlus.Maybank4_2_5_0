using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200027A RID: 634
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class TFEXTopActiveBBOCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600173C RID: 5948 RVA: 0x00143F4C File Offset: 0x0014234C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TFEXTopActiveBBOCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00143F78 File Offset: 0x00142378
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

		// Token: 0x04000BE3 RID: 3043
		private object[] results;
	}
}
