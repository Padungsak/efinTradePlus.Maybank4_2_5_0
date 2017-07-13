using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000196 RID: 406
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopActiveBBO_BenefitCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001184 RID: 4484 RVA: 0x000F8580 File Offset: 0x000F6980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBO_BenefitCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x000F85AC File Offset: 0x000F69AC
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

		// Token: 0x040009AC RID: 2476
		private object[] results;
	}
}
