using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000278 RID: 632
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class TopBBOTFEXadCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x00143EE8 File Offset: 0x001422E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopBBOTFEXadCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00143F14 File Offset: 0x00142314
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

		// Token: 0x04000BE2 RID: 3042
		private object[] results;
	}
}
