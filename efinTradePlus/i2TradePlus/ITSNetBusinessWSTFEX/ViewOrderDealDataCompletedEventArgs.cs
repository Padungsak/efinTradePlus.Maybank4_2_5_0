using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x020002A2 RID: 674
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ViewOrderDealDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017B4 RID: 6068 RVA: 0x0014471C File Offset: 0x00142B1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderDealDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00144748 File Offset: 0x00142B48
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

		// Token: 0x04000BF7 RID: 3063
		private object[] results;
	}
}
