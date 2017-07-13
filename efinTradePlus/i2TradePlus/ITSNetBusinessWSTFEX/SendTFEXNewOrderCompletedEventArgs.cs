using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x020002A8 RID: 680
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SendTFEXNewOrderCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x00144848 File Offset: 0x00142C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendTFEXNewOrderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x00144874 File Offset: 0x00142C74
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

		// Token: 0x04000BFA RID: 3066
		private object[] results;
	}
}
