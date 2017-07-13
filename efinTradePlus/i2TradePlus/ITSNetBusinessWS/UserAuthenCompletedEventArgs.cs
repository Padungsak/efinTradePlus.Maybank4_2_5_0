using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200020C RID: 524
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class UserAuthenCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012E6 RID: 4838 RVA: 0x000F9C8C File Offset: 0x000F808C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal UserAuthenCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x000F9CB8 File Offset: 0x000F80B8
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

		// Token: 0x040009E7 RID: 2535
		private object[] results;
	}
}
