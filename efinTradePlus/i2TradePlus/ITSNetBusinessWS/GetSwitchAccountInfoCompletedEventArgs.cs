using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001DA RID: 474
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class GetSwitchAccountInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001250 RID: 4688 RVA: 0x000F92C8 File Offset: 0x000F76C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetSwitchAccountInfoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x000F92F4 File Offset: 0x000F76F4
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

		// Token: 0x040009CE RID: 2510
		private object[] results;
	}
}
