using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000157 RID: 343
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SaveUserAlert2CompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010C6 RID: 4294 RVA: 0x000F7964 File Offset: 0x000F5D64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveUserAlert2CompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000F7990 File Offset: 0x000F5D90
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

		// Token: 0x0400098D RID: 2445
		private object[] results;
	}
}
