using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001A6 RID: 422
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopActiveBBO_SectorCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011B4 RID: 4532 RVA: 0x000F88A0 File Offset: 0x000F6CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBO_SectorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000F88CC File Offset: 0x000F6CCC
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

		// Token: 0x040009B4 RID: 2484
		private object[] results;
	}
}
