using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001AE RID: 430
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SectorStatCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011CC RID: 4556 RVA: 0x000F8A30 File Offset: 0x000F6E30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SectorStatCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x000F8A5C File Offset: 0x000F6E5C
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

		// Token: 0x040009B8 RID: 2488
		private object[] results;
	}
}
