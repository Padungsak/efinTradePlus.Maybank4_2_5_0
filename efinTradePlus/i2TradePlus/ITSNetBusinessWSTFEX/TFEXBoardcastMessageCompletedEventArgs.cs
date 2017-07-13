using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000296 RID: 662
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class TFEXBoardcastMessageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001790 RID: 6032 RVA: 0x001444C4 File Offset: 0x001428C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TFEXBoardcastMessageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x001444F0 File Offset: 0x001428F0
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

		// Token: 0x04000BF1 RID: 3057
		private object[] results;
	}
}
