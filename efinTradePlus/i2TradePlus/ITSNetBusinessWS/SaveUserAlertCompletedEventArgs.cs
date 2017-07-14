using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000155 RID: 341
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class SaveUserAlertCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010C0 RID: 4288 RVA: 0x000F7900 File Offset: 0x000F5D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveUserAlertCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x000F792C File Offset: 0x000F5D2C
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

		// Token: 0x0400098C RID: 2444
		private object[] results;
	}
}
