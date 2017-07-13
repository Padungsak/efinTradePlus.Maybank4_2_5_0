using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000210 RID: 528
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class GetUrlClientCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012F2 RID: 4850 RVA: 0x000F9D54 File Offset: 0x000F8154
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetUrlClientCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000F9D80 File Offset: 0x000F8180
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

		// Token: 0x040009E9 RID: 2537
		private object[] results;
	}
}
