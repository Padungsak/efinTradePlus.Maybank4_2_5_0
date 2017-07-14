using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200012D RID: 301
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class LoadStockNicknameExtraCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001048 RID: 4168 RVA: 0x000F7130 File Offset: 0x000F5530
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadStockNicknameExtraCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x000F715C File Offset: 0x000F555C
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

		// Token: 0x04000978 RID: 2424
		private object[] results;
	}
}
