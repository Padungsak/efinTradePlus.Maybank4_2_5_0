using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.Templates
{
	// Token: 0x020002B8 RID: 696
	internal class TemplateManager
	{
		// Token: 0x06001889 RID: 6281 RVA: 0x0014DBD8 File Offset: 0x0014BFD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateManager() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.mainForm = null;
			this.templateViews = null;
			this.currentActiveTemplateView = null;
			this.defaultTemplateName = string.Empty;
			this.defaultTemplateGroup = string.Empty;
			
			if (this.templateViews == null)
			{
				this.templateViews = new Dictionary<string, TemplateView>();
			}
			else
			{
				this.templateViews.Clear();
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x0014DC5C File Offset: 0x0014C05C
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x0014DCA0 File Offset: 0x0014C0A0
		public static TemplateManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (TemplateManager.instance == null)
				{
					TemplateManager.instance = new TemplateManager();
				}
				return TemplateManager.instance;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateManager.instance = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0014DCB8 File Offset: 0x0014C0B8
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0014DCE4 File Offset: 0x0014C0E4
		public frmMain MainForm
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.mainForm;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.mainForm = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0014DCFC File Offset: 0x0014C0FC
		public Dictionary<string, TemplateView> TemplateViews
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.templateViews;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x0014DD28 File Offset: 0x0014C128
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x0014DD9C File Offset: 0x0014C19C
		public TemplateView CurrentActiveTemplateView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.templateViews.Count > 0 && this.currentActiveTemplateView == null)
				{
					KeyValuePair<string, TemplateView> current = this.templateViews.GetEnumerator().Current;
					this.currentActiveTemplateView = current.Value;
				}
				return this.currentActiveTemplateView;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.currentActiveTemplateView = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x0014DDB4 File Offset: 0x0014C1B4
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x0014DDE0 File Offset: 0x0014C1E0
		public string DefaultTemplateName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.defaultTemplateName;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.defaultTemplateName = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x0014DDF8 File Offset: 0x0014C1F8
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x0014DE24 File Offset: 0x0014C224
		public string DefaultTemplateGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.defaultTemplateGroup;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.defaultTemplateGroup = value;
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0014DE3C File Offset: 0x0014C23C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsDefaultTemplate(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return TemplateManager.Instance.DefaultTemplateName == templateName;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0014DE70 File Offset: 0x0014C270
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateView GetTemplate(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TemplateView result;
			if (this.templateViews.ContainsKey(templateName))
			{
				result = this.templateViews[templateName];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0014DEC0 File Offset: 0x0014C2C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string templateViewName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				TemplateView templateView = null;
				if (this.currentActiveTemplateView != null)
				{
					if (this.currentActiveTemplateView.Name != templateViewName)
					{
						templateView = this.currentActiveTemplateView;
					}
				}
				if (this.templateViews.ContainsKey(templateViewName))
				{
					this.currentActiveTemplateView = this.templateViews[templateViewName];
					this.currentActiveTemplateView.Show();
				}
				if (templateView != null)
				{
					templateView.Hide();
				}
				else
				{
					Console.WriteLine("test");
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0014DF88 File Offset: 0x0014C388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendSymbolLink(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.currentActiveTemplateView != null)
				{
					this.currentActiveTemplateView.SendSymbolLink1(sender, source, newStock);
				}
				if (source == SymbolLinkSource.SmartStock)
				{
					this.mainForm.SetSmartStock(sender, source, newStock);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0014DFFC File Offset: 0x0014C3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteTemplate(string templateViewName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.templateViews.ContainsKey(templateViewName))
				{
					TemplateView templateView = this.templateViews[templateViewName];
					if (templateView != null)
					{
						templateView.CurrentState = TemplateView.ContentState.OpeningOrClosing;
						templateView.Hide();
						if (templateView.FormObj.GetType().BaseType == typeof(ClientBaseForm))
						{
							frmMain.OnMessageReceived -= new frmMain.OnMessageRecievedEventHendler((templateView.FormObj as IRealtimeMessage).ReceiveMessage);
							((ClientBaseForm)templateView.FormObj).FormState = ClientBaseForm.ClientBaseFormState.Closing;
							templateView.FormObj.Dispose();
							templateView.FormObj = null;
						}
						if (this.currentActiveTemplateView == this.templateViews[templateViewName])
						{
							this.currentActiveTemplateView = null;
						}
						this.templateViews.Remove(templateViewName);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0014E114 File Offset: 0x0014C514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, object> GetTemplateProperties(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Dictionary<string, object> result = null;
			if (this.templateViews.ContainsKey(templateName))
			{
				result = new TemplatePropeties(this.templateViews[templateName]).GetTemplateProperties();
			}
			return result;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0014E16C File Offset: 0x0014C56C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Dictionary<string, object>> GetAllFormProperties(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<Dictionary<string, object>> list = null;
			if (this.templateViews.ContainsKey(templateName))
			{
				list = new List<Dictionary<string, object>>();
				list.Add(new FormProperties(this.templateViews[templateName].FormObj).GetFormProperties());
			}
			return list;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0014E1D4 File Offset: 0x0014C5D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, object> GetFormPropertyFields(string templateName, string formName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Dictionary<string, object> result = null;
			if (this.templateViews.ContainsKey(templateName))
			{
				Form formObj = this.templateViews[templateName].FormObj;
				if (formObj != null && formObj.GetType().BaseType == typeof(ClientBaseForm))
				{
					result = (formObj as ClientBaseForm).PackProperties();
				}
			}
			return result;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0014E260 File Offset: 0x0014C660
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsTemplateContains(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.templateViews.ContainsKey(templateName);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0014E290 File Offset: 0x0014C690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateView CreateTemplateView(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TemplateView result;
			if (this.IsTemplateContains(templateName))
			{
				result = null;
			}
			else
			{
				TemplateView templateView = new TemplateView(templateName);
				this.templateViews.Add(templateView.Name, templateView);
				result = templateView;
			}
			return result;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0014E2E8 File Offset: 0x0014C6E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddFormToTemplate(string templateName, Form formClient, int formIndex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.templateViews.ContainsKey(templateName))
			{
				this.templateViews[templateName].FormObj = formClient;
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0014E330 File Offset: 0x0014C730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateView.ContentState GetTemplateState(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TemplateView.ContentState result;
			if (this.templateViews.ContainsKey(templateName))
			{
				result = this.templateViews[templateName].CurrentState;
			}
			else
			{
				result = TemplateView.ContentState.Detached;
			}
			return result;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0014E384 File Offset: 0x0014C784
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TemplateManager()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			TemplateManager.instance = null;
		}

		// Token: 0x04000C6E RID: 3182
		private static TemplateManager instance;

		// Token: 0x04000C6F RID: 3183
		private frmMain mainForm;

		// Token: 0x04000C70 RID: 3184
		private Dictionary<string, TemplateView> templateViews;

		// Token: 0x04000C71 RID: 3185
		private TemplateView currentActiveTemplateView;

		// Token: 0x04000C72 RID: 3186
		private string defaultTemplateName;

		// Token: 0x04000C73 RID: 3187
		private string defaultTemplateGroup;
	}
}
