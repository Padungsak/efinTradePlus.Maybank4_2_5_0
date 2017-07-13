using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000180 RID: 384
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ReloadSETIndexInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001142 RID: 4418 RVA: 0x000F8134 File Offset: 0x000F6534
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ReloadSETIndexInfoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x000F8160 File Offset: 0x000F6560
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

		// Token: 0x040009A1 RID: 2465
		private object[] results;
	}
}
