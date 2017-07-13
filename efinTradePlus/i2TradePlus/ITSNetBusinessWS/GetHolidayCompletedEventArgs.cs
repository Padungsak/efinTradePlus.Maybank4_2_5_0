using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000153 RID: 339
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetHolidayCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x000F789C File Offset: 0x000F5C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetHolidayCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000F78C8 File Offset: 0x000F5CC8
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

		// Token: 0x0400098B RID: 2443
		private object[] results;
	}
}
