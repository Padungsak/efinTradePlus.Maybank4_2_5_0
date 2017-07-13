using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200026E RID: 622
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class LoadTFEXInformationCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001718 RID: 5912 RVA: 0x00143CF4 File Offset: 0x001420F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadTFEXInformationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x00143D20 File Offset: 0x00142120
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

		// Token: 0x04000BDD RID: 3037
		private object[] results;
	}
}
