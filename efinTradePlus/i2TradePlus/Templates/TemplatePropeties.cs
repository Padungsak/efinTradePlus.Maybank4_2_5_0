using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.Templates
{
	// Token: 0x020002B9 RID: 697
	internal class TemplatePropeties
	{
		// Token: 0x060018A2 RID: 6306 RVA: 0x0014E3A0 File Offset: 0x0014C7A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplatePropeties(TemplateView template) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.template = null;
			
			this.template = template;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0014E3CC File Offset: 0x0014C7CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, object> GetTemplateProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this.template);
			string[] array = TemplatePropeties.serializablePropertyNames;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				PropertyDescriptor propertyDescriptor = properties.Find(text, false);
				if (propertyDescriptor != null)
				{
					object value = propertyDescriptor.GetValue(this.template);
					dictionary.Add(text, value);
				}
			}
			return dictionary;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0014E464 File Offset: 0x0014C864
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TemplatePropeties()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			TemplatePropeties.serializablePropertyNames = new string[]
			{
				"IsLock"
			};
		}

		// Token: 0x04000C74 RID: 3188
		public static readonly string[] serializablePropertyNames;

		// Token: 0x04000C75 RID: 3189
		private TemplateView template;
	}
}
