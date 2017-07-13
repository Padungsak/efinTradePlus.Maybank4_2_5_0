using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200027E RID: 638
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class BestProjected_TFEXCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001748 RID: 5960 RVA: 0x00144014 File Offset: 0x00142414
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BestProjected_TFEXCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x00144040 File Offset: 0x00142440
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

		// Token: 0x04000BE5 RID: 3045
		private object[] results;
	}
}
