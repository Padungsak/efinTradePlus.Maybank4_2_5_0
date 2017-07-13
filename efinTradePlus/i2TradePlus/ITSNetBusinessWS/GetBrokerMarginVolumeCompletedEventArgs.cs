using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200011B RID: 283
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class GetBrokerMarginVolumeCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001012 RID: 4114 RVA: 0x000F6DAC File Offset: 0x000F51AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetBrokerMarginVolumeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000F6DD8 File Offset: 0x000F51D8
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

		// Token: 0x0400096F RID: 2415
		private object[] results;
	}
}
