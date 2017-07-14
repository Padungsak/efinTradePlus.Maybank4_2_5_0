using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.Templates
{
	// Token: 0x020002BA RID: 698
	internal class FormProperties
	{
		// Token: 0x060018A5 RID: 6309 RVA: 0x0014E49C File Offset: 0x0014C89C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FormProperties(object form) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.form = null;
			
			this.form = form;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0014E4C8 File Offset: 0x0014C8C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, object> GetFormProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this.form);
			string[] array = FormProperties.serializablePropertyNames;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				PropertyDescriptor propertyDescriptor = properties.Find(text, false);
				if (propertyDescriptor != null)
				{
					object value = propertyDescriptor.GetValue(this.form);
					dictionary.Add(text, value);
				}
				else if (text == "Type")
				{
					dictionary.Add("Type", this.form.GetType());
				}
			}
			return dictionary;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0014E594 File Offset: 0x0014C994
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FormProperties()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			FormProperties.serializablePropertyNames = new string[]
			{
				"Name",
				"Type",
				"Text"
			};
		}

		// Token: 0x04000C76 RID: 3190
		public static readonly string[] serializablePropertyNames;

		// Token: 0x04000C77 RID: 3191
		private object form;
	}
}
