using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x020002AA RID: 682
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SendTFEXCancelOrderCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017CC RID: 6092 RVA: 0x001448AC File Offset: 0x00142CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendTFEXCancelOrderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x001448D8 File Offset: 0x00142CD8
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

		// Token: 0x04000BFB RID: 3067
		private object[] results;
	}
}
