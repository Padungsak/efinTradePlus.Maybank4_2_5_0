using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.MyDataSet;
using i2TradePlus.Templates;

namespace i2TradePlus
{
	// Token: 0x02000083 RID: 131
	internal class HotKeyManager
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0006CB2C File Offset: 0x0006AF2C
		public static Keys[] FunctionKeys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return HotKeyManager.functionKeys;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0006CB54 File Offset: 0x0006AF54
		public static Keys[] ModifierKeys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return HotKeyManager.modifierKeys;
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0006CB7C File Offset: 0x0006AF7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HotKeyManager()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			HotKeyManager.functionKeys = new Keys[]
			{
				Keys.None,
				Keys.A,
				Keys.B,
				Keys.C,
				Keys.E,
				Keys.F,
				Keys.G,
				Keys.H,
				Keys.I,
				Keys.J,
				Keys.K,
				Keys.L,
				Keys.M,
				Keys.N,
				Keys.O,
				Keys.P,
				Keys.Q,
				Keys.R,
				Keys.S,
				Keys.T,
				Keys.U,
				Keys.V,
				Keys.W,
				Keys.X,
				Keys.Y,
				Keys.Z,
				Keys.F1,
				Keys.F2,
				Keys.F3,
				Keys.F4,
				Keys.F5,
				Keys.F6,
				Keys.F7,
				Keys.F8,
				Keys.F9,
				Keys.F10,
				Keys.F11,
				Keys.F12,
				Keys.NumLock,
				Keys.Subtract,
				Keys.Multiply,
				Keys.Divide
			};
			HotKeyManager.modifierKeys = new Keys[]
			{
				Keys.None,
				Keys.Control,
				Keys.Alt,
				Keys.Shift
			};
			HotKeyManager.systemHotKeys = null;
			HotKeyManager.templatesHotKey = null;
			try
			{
				HotKeyManager.systemHotKeys = new Dictionary<Keys, HotKeyFor>();
				HotKeyManager.templatesHotKey = new Dictionary<Keys, HotKeyManager.HotkeyProperty>();
				HotKeyManager.LoadSystemHotkey();
			}
			catch
			{
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0006CD08 File Offset: 0x0006B108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearTemplateHotkey()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (HotKeyManager.templatesHotKey == null)
			{
				HotKeyManager.templatesHotKey = new Dictionary<Keys, HotKeyManager.HotkeyProperty>();
			}
			else
			{
				HotKeyManager.templatesHotKey.Clear();
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0006CD50 File Offset: 0x0006B150
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Dictionary<Keys, HotKeyFor> ConvertToHashtable(StringCollection config)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Dictionary<Keys, HotKeyFor> dictionary = new Dictionary<Keys, HotKeyFor>();
			foreach (string current in config)
			{
				string[] array = current.Split(new char[]
				{
					'|'
				});
				dictionary.Add((Keys)int.Parse(array[0]), (HotKeyFor)int.Parse(array[1]));
			}
			return dictionary;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0006CE08 File Offset: 0x0006B208
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsValidHotKey(Keys hotKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keys = hotKey & Keys.KeyCode;
			Keys keys2 = hotKey & Keys.Modifiers;
			bool result;
			if (hotKey == Keys.None)
			{
				result = false;
			}
			else
			{
				Keys keys3 = keys;
				if (keys3 <= Keys.Insert)
				{
					if (keys3 != Keys.Pause && keys3 != Keys.Insert)
					{
						goto IL_8F;
					}
				}
				else if (keys3 != Keys.Multiply)
				{
					switch (keys3)
					{
					case Keys.Subtract:
					case Keys.Divide:
						break;
					case Keys.Decimal:
						goto IL_8F;
					default:
						if (keys3 != Keys.NumLock)
						{
							goto IL_8F;
						}
						break;
					}
				}
				result = true;
				return result;
				IL_8F:
				if (keys < Keys.F1 || keys > Keys.F24)
				{
					if (keys == Keys.None || keys2 == Keys.None)
					{
						result = false;
						return result;
					}
					switch (keys)
					{
					case Keys.ShiftKey:
					case Keys.ControlKey:
					case Keys.Menu:
						result = false;
						return result;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0006CF18 File Offset: 0x0006B318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsHotKeyDefined(Keys hotKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return HotKeyManager.templatesHotKey.ContainsKey(hotKey) || HotKeyManager.systemHotKeys.ContainsKey(hotKey);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0006CF5C File Offset: 0x0006B35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsReservKey(Keys hotKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (hotKey <= (Keys)131154)
			{
				if (hotKey != Keys.Pause && hotKey != Keys.Insert && hotKey != (Keys)131154)
				{
					goto IL_6B;
				}
			}
			else if (hotKey != (Keys)131162 && hotKey != (Keys)262227 && hotKey != (Keys)262259)
			{
				goto IL_6B;
			}
			bool result = true;
			return result;
			IL_6B:
			result = false;
			return result;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0006CFE4 File Offset: 0x0006B3E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckHotkey(Keys functionKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!HotKeyManager.IsValidHotKey(functionKey))
			{
				throw new Exception("This key is invalid key for system, cannot defind for your HotKey!");
			}
			if (HotKeyManager.IsReservKey(functionKey))
			{
				throw new Exception("This key is Reserv key for system, cannot defind for your HotKey!");
			}
			if (HotKeyManager.IsHotKeyDefined(functionKey))
			{
				throw new Exception("This key is definded, cannot defind for your HotKey!");
			}
			return true;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0006D058 File Offset: 0x0006B458
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void AddSystemHotkey(int keyID, Keys functionKey, bool isRestoreDefault)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!isRestoreDefault)
				{
					HotKeyManager.CheckHotkey(functionKey);
				}
				HotKeyManager.systemHotKeys.Add(functionKey, (HotKeyFor)keyID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0006D0B0 File Offset: 0x0006B4B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AddTemplateHotkey(string templateName, string templateGroup, Keys functionKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			try
			{
				if (functionKey != Keys.None)
				{
					if (!HotKeyManager.templatesHotKey.ContainsKey(functionKey))
					{
						HotKeyManager.templatesHotKey.Add(functionKey, new HotKeyManager.HotkeyProperty(templateName, templateGroup));
					}
					else
					{
						HotKeyManager.templatesHotKey[functionKey] = new HotKeyManager.HotkeyProperty(templateName, templateGroup);
					}
					result = true;
					return result;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			result = false;
			return result;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0006D144 File Offset: 0x0006B544
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RemoveHotkey_ByTemplateName(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keys = Keys.None;
			try
			{
				foreach (KeyValuePair<Keys, HotKeyManager.HotkeyProperty> current in HotKeyManager.templatesHotKey)
				{
					if (current.Value.TemplateName == templateName)
					{
						keys = current.Key;
						break;
					}
				}
				if (keys != Keys.None)
				{
					HotKeyManager.templatesHotKey.Remove(keys);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0006D210 File Offset: 0x0006B610
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RemoveHotkey_ByKey(Keys pressedKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (HotKeyManager.systemHotKeys.ContainsKey(pressedKey))
				{
					HotKeyManager.systemHotKeys.Remove(pressedKey);
				}
				if (HotKeyManager.templatesHotKey.ContainsKey(pressedKey))
				{
					HotKeyManager.templatesHotKey.Remove(pressedKey);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0006D28C File Offset: 0x0006B68C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static HotKeyManager.HotkeyProperty GetTemplateHotKey(Keys pressedKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			HotKeyManager.HotkeyProperty result;
			if (HotKeyManager.templatesHotKey.ContainsKey(pressedKey))
			{
				result = HotKeyManager.templatesHotKey[pressedKey];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0006D2D8 File Offset: 0x0006B6D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Keys GetKeyFromTemplateHotKey(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys result;
			foreach (KeyValuePair<Keys, HotKeyManager.HotkeyProperty> current in HotKeyManager.templatesHotKey)
			{
				if (templateName == current.Value.TemplateName)
				{
					result = current.Key;
					return result;
				}
			}
			result = Keys.None;
			return result;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0006D374 File Offset: 0x0006B774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static HotKeyFor GetSystemHotKey(Keys pressedKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			HotKeyFor result;
			if (HotKeyManager.systemHotKeys.ContainsKey(pressedKey))
			{
				result = HotKeyManager.systemHotKeys[pressedKey];
			}
			else
			{
				result = HotKeyFor.NoAction;
			}
			return result;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0006D3C0 File Offset: 0x0006B7C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Keys GetSystemHotKey(HotKeyFor keyFor)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys result;
			if (HotKeyManager.systemHotKeys.ContainsValue(keyFor))
			{
				foreach (KeyValuePair<Keys, HotKeyFor> current in HotKeyManager.systemHotKeys)
				{
					if (keyFor == current.Value)
					{
						result = current.Key;
						return result;
					}
				}
			}
			result = Keys.None;
			return result;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0006D46C File Offset: 0x0006B86C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadSystemHotkey()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				HotKeyManager.systemHotKeys.Clear();
				HotKeyManager.AddSystemHotkey(0, (Keys)262259, true);
				HotKeyManager.AddSystemHotkey(1, Keys.Pause, true);
				HotKeyManager.AddSystemHotkey(2, (Keys)131162, true);
				HotKeyManager.AddSystemHotkey(4, (Keys)262227, true);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0006D4E0 File Offset: 0x0006B8E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Initial()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				TemplateManager.Instance.DefaultTemplateName = string.Empty;
				TemplateManager.Instance.DefaultTemplateGroup = string.Empty;
				HotKeyManager.ClearTemplateHotkey();
				UserWorkingProfileDS userWorkingProfileDS = new UserWorkingProfileDS();
				string templatePathByUser = ApplicationInfo.GetTemplatePathByUser();
				string text = templatePathByUser + "\\UserProfile.xml";
				if (File.Exists(text))
				{
					userWorkingProfileDS.ReadXml(text);
				}
				HotKeyManager.InputHotkey("Fixed", userWorkingProfileDS);
				HotKeyManager.InputHotkey("Order", userWorkingProfileDS);
				userWorkingProfileDS.Clear();
				userWorkingProfileDS.Dispose();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0006D598 File Offset: 0x0006B998
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void InputHotkey(string groupName, UserWorkingProfileDS tdsUserProfile)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				List<MainFixedTemplate.TemplateProperty> list = null;
				if (groupName == "Fixed")
				{
					list = MainFixedTemplate.GetFixedTemplateName();
				}
				else if (groupName == "Order")
				{
					list = MainFixedTemplate.GetOrderTemplateName();
				}
				UserWorkingProfileDS.TemplateItemRow[] array = (UserWorkingProfileDS.TemplateItemRow[])tdsUserProfile.TemplateItem.Select("RootTemplateName='" + groupName + "'", tdsUserProfile.TemplateItem.ListIndexColumn.ColumnName);
				string text = string.Empty;
				if (array.Length > 0)
				{
					UserWorkingProfileDS.TemplateItemRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						UserWorkingProfileDS.TemplateItemRow templateItemRow = array2[i];
						if (templateItemRow != null)
						{
							foreach (MainFixedTemplate.TemplateProperty current in list)
							{
								if (current.TempateName == templateItemRow.ItemName)
								{
									current.Hotkey = templateItemRow.HotKey;
									break;
								}
							}
							if (templateItemRow.IsDefalutTemplate)
							{
								text = templateItemRow.ItemName;
							}
						}
					}
				}
				foreach (MainFixedTemplate.TemplateProperty current2 in list)
				{
					HotKeyManager.AddTemplateHotkey(current2.TempateName, groupName, (Keys)current2.Hotkey);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0006D7B0 File Offset: 0x0006BBB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HotKeyManager() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
		}

		// Token: 0x040003D5 RID: 981
		private static readonly Keys[] functionKeys;

		// Token: 0x040003D6 RID: 982
		private static readonly Keys[] modifierKeys;

		// Token: 0x040003D7 RID: 983
		private static Dictionary<Keys, HotKeyFor> systemHotKeys;

		// Token: 0x040003D8 RID: 984
		private static Dictionary<Keys, HotKeyManager.HotkeyProperty> templatesHotKey;

		// Token: 0x02000084 RID: 132
		public class HotkeyProperty
		{
			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x0600063F RID: 1599 RVA: 0x0006D7CC File Offset: 0x0006BBCC
			// (set) Token: 0x06000640 RID: 1600 RVA: 0x0006D7F8 File Offset: 0x0006BBF8
			public string TemplateName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.templateName;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.templateName = value;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000641 RID: 1601 RVA: 0x0006D810 File Offset: 0x0006BC10
			// (set) Token: 0x06000642 RID: 1602 RVA: 0x0006D83C File Offset: 0x0006BC3C
			public string TemplateGroup
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.templateGroup;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.templateGroup = value;
				}
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x0006D854 File Offset: 0x0006BC54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public HotkeyProperty(string templateName, string templateGroup) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.templateName = string.Empty;
				this.templateGroup = string.Empty;
				
				this.templateName = templateName;
				this.templateGroup = templateGroup;
			}

			// Token: 0x06000644 RID: 1604 RVA: 0x0006D8A4 File Offset: 0x0006BCA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public string Pack()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.templateName + "</>" + this.templateGroup;
			}

			// Token: 0x040003D9 RID: 985
			private string templateName;

			// Token: 0x040003DA RID: 986
			private string templateGroup;
		}
	}
}
