using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x020002AD RID: 685
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class GetGoldSpotCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x00144910 File Offset: 0x00142D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetGoldSpotCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0014493C File Offset: 0x00142D3C
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

		// Token: 0x04000BFC RID: 3068
		private object[] results;
	}
}
