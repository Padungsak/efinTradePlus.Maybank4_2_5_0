using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000276 RID: 630
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopBBOTFEXCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x00143E84 File Offset: 0x00142284
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopBBOTFEXCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.results = results;
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00143EB0 File Offset: 0x001422B0
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

		// Token: 0x04000BE1 RID: 3041
		private object[] results;
	}
}
