using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.MyDataSet;
using i2TradePlus.Templates;

namespace i2TradePlus
{
	// Token: 0x02000085 RID: 133
	public class TemplateTreeMenus : UserControl
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0006D8E0 File Offset: 0x0006BCE0
		public string HeaderText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return "Templates";
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000646 RID: 1606 RVA: 0x0006D908 File Offset: 0x0006BD08
		// (remove) Token: 0x06000647 RID: 1607 RVA: 0x0006D930 File Offset: 0x0006BD30
		public event TemplateTreeMenus.OnOpenTemplateHandler OnOpenTemplate
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnOpenTemplate = (TemplateTreeMenus.OnOpenTemplateHandler)Delegate.Combine(this.OnOpenTemplate, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnOpenTemplate = (TemplateTreeMenus.OnOpenTemplateHandler)Delegate.Remove(this.OnOpenTemplate, value);
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0006D958 File Offset: 0x0006BD58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenTemplate(string templateName, string templateGroup)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.OnOpenTemplate != null)
			{
				this.OnOpenTemplate(templateName, templateGroup);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0006D994 File Offset: 0x0006BD94
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0006D9C0 File Offset: 0x0006BDC0
		[DefaultValue(true)]
		public bool ShowContextMenu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.showContextMenu;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.showContextMenu != value)
				{
					this.showContextMenu = value;
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0006D9F8 File Offset: 0x0006BDF8
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x0006DA28 File Offset: 0x0006BE28
		[DefaultValue(true)]
		public bool ToolbarVisible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.panelToolbarContainer.Visible;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.panelToolbarContainer.Visible = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0006DA48 File Offset: 0x0006BE48
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0006DA78 File Offset: 0x0006BE78
		[DefaultValue(true)]
		public bool ToolbarEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.panelToolbarContainer.Enabled;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.panelToolbarContainer.Enabled = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0006DA98 File Offset: 0x0006BE98
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x0006DAC8 File Offset: 0x0006BEC8
		[DefaultValue(DockStyle.Right)]
		public DockStyle ToolbarDocking
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.panelToolbarContainer.Dock;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.panelToolbarContainer.Dock != value && value != DockStyle.None && value != DockStyle.Fill)
				{
					if (value == DockStyle.Top || value == DockStyle.Bottom)
					{
						this.panelToolbarContainer.Height = 25;
						this.tsTempateEditor.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
					}
					else
					{
						this.tsTempateEditor.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
					}
					this.panelToolbarContainer.Dock = value;
					this.panelToolbarContainer.SendToBack();
					this.panelDefaultTemplateInfo.BringToFront();
					this.panelTemplateListContainer.BringToFront();
				}
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0006DB8C File Offset: 0x0006BF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateTreeMenus() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.showContextMenu = true;
			this.components = null;
			
			this.InitializeComponent();
			this.tvTemplatesList.BorderStyle = BorderStyle.None;
			this.tvTemplatesList.ExpandAll();
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0006DBE4 File Offset: 0x0006BFE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initial()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				TemplateManager.Instance.DefaultTemplateName = string.Empty;
				TemplateManager.Instance.DefaultTemplateGroup = string.Empty;
				this.tvTemplatesList.Nodes.Clear();
				this.tvTemplatesList.Nodes.Add("Fixed", "Investor Menu");
				if (ApplicationInfo.UserLoginMode != "I")
				{
					this.tvTemplatesList.Nodes.Add("Order", "Order Menu");
				}
				this.DefaultEnalbedToolbarItem();
				this.LoadUserTemplate();
				this.DisplayFixedTemplatesToControl("Fixed", false);
				this.DisplayFixedTemplatesToControl("Order", false);
				this.DisplayDefaultTemplateName();
				this.tvTemplatesList.ExpandAll();
			}
			catch (Exception ex)
			{
				this.ShowError("TemplateMenu.Initial", ex);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0006DCE8 File Offset: 0x0006C0E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaveUserProfileFromTreeView()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string templatePathByUser = ApplicationInfo.GetTemplatePathByUser();
			string fileName = templatePathByUser + "\\UserProfile.xml";
			if (this.tdsUserProfile == null)
			{
				this.tdsUserProfile = new UserWorkingProfileDS();
			}
			else
			{
				this.tdsUserProfile.Clear();
			}
			for (int i = 0; i < this.tvTemplatesList.Nodes.Count; i++)
			{
				UserWorkingProfileDS.TemplateRootsRow templateRootsRow = this.tdsUserProfile.TemplateRoots.NewTemplateRootsRow();
				templateRootsRow.TemplateName = this.tvTemplatesList.Nodes[i].Name;
				templateRootsRow.ListIndex = i;
				this.tdsUserProfile.TemplateRoots.AddTemplateRootsRow(templateRootsRow);
				for (int j = 0; j < this.tvTemplatesList.Nodes[i].Nodes.Count; j++)
				{
					UserWorkingProfileDS.TemplateItemRow templateItemRow = this.tdsUserProfile.TemplateItem.NewTemplateItemRow();
					templateItemRow.ItemName = this.tvTemplatesList.Nodes[i].Nodes[j].Name.Trim();
					templateItemRow.ListIndex = j;
					templateItemRow.IsDefalutTemplate = (this.tvTemplatesList.Nodes[i].Nodes[j].ImageKey == "ItemDefault");
					templateItemRow.RootTemplateName = templateRootsRow.TemplateName;
					if (this.tvTemplatesList.Nodes[i].Nodes[j].Tag != null)
					{
						int hotKey = 0;
						int.TryParse(this.tvTemplatesList.Nodes[i].Nodes[j].Tag.ToString(), out hotKey);
						templateItemRow.HotKey = hotKey;
					}
					else
					{
						templateItemRow.HotKey = 0;
					}
					this.tdsUserProfile.TemplateItem.AddTemplateItemRow(templateItemRow);
				}
			}
			if (!Directory.Exists(templatePathByUser))
			{
				Directory.CreateDirectory(templatePathByUser);
			}
			this.tdsUserProfile.WriteXml(fileName);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0006DF30 File Offset: 0x0006C330
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TreeNode GetNodeByName(string groupName, string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TreeNode result = null;
			if (this.tvTemplatesList.Nodes[groupName].Nodes.ContainsKey(templateName))
			{
				for (int i = 0; i < this.tvTemplatesList.Nodes[groupName].Nodes.Count; i++)
				{
					if (this.tvTemplatesList.Nodes[groupName].Nodes[i].Name == templateName)
					{
						result = this.tvTemplatesList.Nodes[groupName].Nodes[i];
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0006E004 File Offset: 0x0006C404
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditHotkeyAtTreeControl(string groupName, string templateName, int hotKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TreeNode nodeByName = this.GetNodeByName(groupName, templateName);
			if (nodeByName != null)
			{
				nodeByName.Tag = hotKey;
				string text = templateName;
				if (hotKey > 0)
				{
					text = "[" + this.DisplayKeyFormat((Keys)hotKey) + "] - " + text;
				}
				nodeByName.Text = text;
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0006E078 File Offset: 0x0006C478
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tvTemplatesList_MouseDown(object sender, MouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tvTemplatesList.SelectedNode = this.tvTemplatesList.GetNodeAt(e.X, e.Y);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0006E0AC File Offset: 0x0006C4AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tvTemplatesList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.Node.Level > 0)
			{
				if (this.tvTemplatesList.SelectedNode != this.tvTemplatesList.Nodes["Fixed"] && this.tvTemplatesList.SelectedNode != this.tvTemplatesList.Nodes["Order"])
				{
					if (e.Node.Parent == this.tvTemplatesList.Nodes["Fixed"])
					{
						this.OpenTemplate(e.Node.Name, "Fixed");
					}
					else if (e.Node.Parent == this.tvTemplatesList.Nodes["Order"])
					{
						this.OpenTemplate(e.Node.Name, "Order");
					}
				}
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0006E1C4 File Offset: 0x0006C5C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tvTemplatesList_AfterSelect(object sender, TreeViewEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.DefaultEnalbedToolbarItem();
			if (e.Node.Level > 0)
			{
				this.tsbtnView.Enabled = true;
				this.tsbtnHotkey.Enabled = (e.Node.Parent == this.tvTemplatesList.Nodes["Fixed"] || e.Node.Parent == this.tvTemplatesList.Nodes["Order"]);
				if (e.Node.ImageKey != "ItemDefault" && !(e.Node.Name == "Buy Order") && !(e.Node.Name == "Sell Order") && !(e.Node.Name == "Cover Buy Order") && !(e.Node.Name == "Short Sell Order"))
				{
					this.tsbtnUseDefault.Enabled = true;
				}
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0006E304 File Offset: 0x0006C704
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tvTemplatesList_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tvTemplatesList.SelectedNode != null)
			{
				if (this.tvTemplatesList.SelectedNode.Level > 0)
				{
					if (e.Control && !e.Shift && !e.Alt)
					{
						if (e.KeyCode != Keys.C)
						{
							if (e.KeyCode == Keys.Up)
							{
								this.MoveCurrentNodeUp();
							}
							else if (e.KeyCode == Keys.Down)
							{
								this.MoveCurrentNodeDown();
							}
						}
					}
					else if (e.KeyCode != Keys.F2)
					{
						if (e.KeyCode != Keys.Delete)
						{
							if (e.KeyCode == Keys.Return)
							{
								this.ViewTemplateAtSelectedNode();
							}
						}
					}
				}
				Keys keyCode = e.KeyCode;
				if (keyCode == Keys.Escape)
				{
					base.Hide();
				}
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0006E458 File Offset: 0x0006C858
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnNew_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0006E46C File Offset: 0x0006C86C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnOpen_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0006E480 File Offset: 0x0006C880
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSave_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0006E494 File Offset: 0x0006C894
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSaveAll_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0006E4A8 File Offset: 0x0006C8A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSaveAs_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0006E4BC File Offset: 0x0006C8BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnView_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewTemplateAtSelectedNode();
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0006E4D4 File Offset: 0x0006C8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnRename_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.RenameTemplateAtSelectedNode();
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0006E4EC File Offset: 0x0006C8EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnDelete_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0006E500 File Offset: 0x0006C900
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnRefresh_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0006E514 File Offset: 0x0006C914
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnNodeMoveUp_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.MoveCurrentNodeUp();
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0006E52C File Offset: 0x0006C92C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnNodeMoveDown_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.MoveCurrentNodeDown();
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0006E544 File Offset: 0x0006C944
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnUseDefault_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string name = this.tvTemplatesList.SelectedNode.Name;
			if (name != null)
			{
				if (name == "Buy Order" || name == "Sell Order" || name == "Short Sell Order" || name == "Cover Buy Order")
				{
					return;
				}
			}
			this.SetDefalutTemplate(this.tvTemplatesList.SelectedNode.Parent.Name, this.tvTemplatesList.SelectedNode.Name);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0006E5F4 File Offset: 0x0006C9F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnClearDefault_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ClearDefaultTemplate();
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0006E60C File Offset: 0x0006CA0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadStandardTemplates()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0006E620 File Offset: 0x0006CA20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadMyFavorites()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0006E634 File Offset: 0x0006CA34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadMyHistory()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0006E648 File Offset: 0x0006CA48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadUserTemplate()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tdsUserProfile = new UserWorkingProfileDS();
				string templatePathByUser = ApplicationInfo.GetTemplatePathByUser();
				string text = templatePathByUser + "\\UserProfile.xml";
				if (File.Exists(text))
				{
					this.tdsUserProfile.ReadXml(text);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoadUserTemplate", ex);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0006E6CC File Offset: 0x0006CACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string DisplayKeyFormat(Keys key)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string[] array = key.ToString().Split(new char[]
			{
				','
			});
			string text;
			if (array.Length > 1)
			{
				text = array[1].Trim().ToLower();
				if (text != null)
				{
					if (text == "control")
					{
						array[1] = "Ctrl";
					}
				}
			}
			string text2 = (array.Length > 1) ? string.Format("{0}+{1}", array[1], array[0]) : array[0];
			text = text2;
			if (text != null)
			{
				if (!(text == "Subtract"))
				{
					if (!(text == "Divide"))
					{
						if (text == "Multiply")
						{
							text2 = "*";
						}
					}
					else
					{
						text2 = "/";
					}
				}
				else
				{
					text2 = "-";
				}
			}
			return text2.Trim();
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0006E7E8 File Offset: 0x0006CBE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisplayFixedTemplatesToControl(string groupName, bool isAddHotkey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tvTemplatesList.Nodes[groupName].Nodes.Clear();
				List<MainFixedTemplate.TemplateProperty> list = null;
				if (groupName == "Fixed")
				{
					list = MainFixedTemplate.GetFixedTemplateName();
				}
				else if (groupName == "Order")
				{
					list = MainFixedTemplate.GetOrderTemplateName();
				}
				UserWorkingProfileDS.TemplateItemRow[] array = (UserWorkingProfileDS.TemplateItemRow[])this.tdsUserProfile.TemplateItem.Select("RootTemplateName='" + groupName + "'", this.tdsUserProfile.TemplateItem.ListIndexColumn.ColumnName);
				string b = string.Empty;
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
								b = templateItemRow.ItemName;
							}
						}
					}
				}
				foreach (MainFixedTemplate.TemplateProperty current2 in list)
				{
					bool isDefault = false;
					if (current2.TempateName == b)
					{
						isDefault = true;
					}
					this.SetDisplayNameOfTreeView(current2.TempateName, groupName, current2.Hotkey, isDefault, isAddHotkey);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("DisplayFixedTemplatesToControl", ex);
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0006EA5C File Offset: 0x0006CE5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TreeNode SetDisplayNameOfTreeView(string templateName, string templateGroup, int hotKey, bool isDefault, bool isAddHotKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TreeNode treeNode = this.tvTemplatesList.Nodes[templateGroup].Nodes[templateName];
			if (treeNode == null)
			{
				treeNode = this.tvTemplatesList.Nodes[templateGroup].Nodes.Add(templateName, templateName);
			}
			if (isDefault)
			{
				treeNode.ImageKey = "ItemDefault";
				treeNode.SelectedImageKey = "ItemDefault";
				TemplateManager.Instance.DefaultTemplateName = templateName;
				TemplateManager.Instance.DefaultTemplateGroup = templateGroup;
			}
			else
			{
				treeNode.ImageKey = "Item";
				treeNode.SelectedImageKey = "Item";
			}
			if (hotKey >= 0)
			{
				string text = templateName;
				if (hotKey > 0)
				{
					text = "[" + this.DisplayKeyFormat((Keys)hotKey) + "] - " + text;
				}
				treeNode.Text = text;
				treeNode.Tag = hotKey;
				try
				{
					if (isAddHotKey)
					{
						if (!HotKeyManager.IsHotKeyDefined((Keys)hotKey))
						{
							HotKeyManager.AddTemplateHotkey(templateName, templateGroup, (Keys)hotKey);
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SetDisplayNameOfTreeView", ex);
				}
			}
			return treeNode;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0006EBD4 File Offset: 0x0006CFD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DefaultEnalbedToolbarItem()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tsbtnView.Enabled = false;
			this.tsbtnUseDefault.Enabled = false;
			this.tsbtnClearDefault.Enabled = true;
			this.tsbtnHotkey.Enabled = false;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0006EC24 File Offset: 0x0006D024
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewTemplateAtSelectedNode()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tvTemplatesList.SelectedNode != null && this.tvTemplatesList.SelectedNode.Level > 0)
			{
				this.OpenTemplate(this.tvTemplatesList.SelectedNode.Name, this.tvTemplatesList.SelectedNode.Parent.Name);
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0006ECA4 File Offset: 0x0006D0A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RenameTemplateAtSelectedNode()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tvTemplatesList.SelectedNode != null && this.tvTemplatesList.SelectedNode.Level > 0)
			{
				this.tvTemplatesList.LabelEdit = true;
				this.tvTemplatesList.SelectedNode.BeginEdit();
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0006ED14 File Offset: 0x0006D114
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteTempateAtSelectedNode()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0006ED28 File Offset: 0x0006D128
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDefalutTemplate(string groupName, string nodeName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TreeNode nodeByName = this.GetNodeByName(groupName, nodeName);
			if (nodeByName != null)
			{
				this.ClearDefaultTemplateTreeNode();
				nodeByName.ImageKey = "ItemDefault";
				nodeByName.SelectedImageKey = "ItemDefault";
				TemplateManager.Instance.DefaultTemplateName = nodeByName.Text;
				TemplateManager.Instance.DefaultTemplateGroup = nodeByName.Parent.Name;
				this.DisplayDefaultTemplateName();
				this.SaveUserProfileFromTreeView();
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0006EDB0 File Offset: 0x0006D1B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearDefaultTemplate()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ClearDefaultTemplateTreeNode();
			TemplateManager.Instance.DefaultTemplateName = string.Empty;
			TemplateManager.Instance.DefaultTemplateGroup = string.Empty;
			this.DisplayDefaultTemplateName();
			this.SaveUserProfileFromTreeView();
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0006EE04 File Offset: 0x0006D204
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearDefaultTemplateTreeNode()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			foreach (TreeNode treeNode in this.tvTemplatesList.Nodes)
			{
				foreach (TreeNode treeNode2 in treeNode.Nodes)
				{
					if (treeNode2.ImageKey == "ItemDefault")
					{
						treeNode2.ImageKey = "Item";
						treeNode2.SelectedImageKey = "Item";
					}
				}
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0006EF20 File Offset: 0x0006D320
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetToolStripItemDisplayStyle(ToolStripItemDisplayStyle style)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			foreach (ToolStripItem toolStripItem in this.tsTempateEditor.Items)
			{
				if (toolStripItem.GetType() != typeof(ToolStripSeparator))
				{
					toolStripItem.DisplayStyle = style;
				}
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0006EFC0 File Offset: 0x0006D3C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisplayDefaultTemplateName()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!string.IsNullOrEmpty(TemplateManager.Instance.DefaultTemplateName))
			{
				this.lblDefaultTemplateName.Text = TemplateManager.Instance.DefaultTemplateName;
			}
			else
			{
				this.lblDefaultTemplateName.Text = "Blank";
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0006F020 File Offset: 0x0006D420
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveCurrentNodeUp()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tvTemplatesList.SelectedNode != null && this.tvTemplatesList.SelectedNode.Level > 0)
			{
				TreeNode selectedNode = this.tvTemplatesList.SelectedNode;
				TreeNode parent = this.tvTemplatesList.SelectedNode.Parent;
				int index = this.tvTemplatesList.SelectedNode.Index - 1;
				parent.Nodes.Remove(this.tvTemplatesList.SelectedNode);
				parent.Nodes.Insert(index, selectedNode);
				this.tvTemplatesList.SelectedNode = selectedNode;
				this.SaveUserProfileFromTreeView();
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0006F0DC File Offset: 0x0006D4DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveCurrentNodeDown()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tvTemplatesList.SelectedNode != null && this.tvTemplatesList.SelectedNode.Level > 0)
			{
				TreeNode selectedNode = this.tvTemplatesList.SelectedNode;
				TreeNode parent = this.tvTemplatesList.SelectedNode.Parent;
				int index = this.tvTemplatesList.SelectedNode.Index + 1;
				parent.Nodes.Remove(this.tvTemplatesList.SelectedNode);
				parent.Nodes.Insert(index, selectedNode);
				this.tvTemplatesList.SelectedNode = selectedNode;
				this.SaveUserProfileFromTreeView();
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0006F198 File Offset: 0x0006D598
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmRefresh_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tmRefresh.Enabled = false;
				if (this.tvTemplatesList.SelectedNode.Parent == null)
				{
					this.tvTemplatesList.Refresh();
				}
			}
			finally
			{
				this.tvTemplatesList.Refresh();
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0006F218 File Offset: 0x0006D618
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiHotkey_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			frmTemplateInfo frmTemplateInfo = new frmTemplateInfo(frmTemplateInfo.ShowMode.Hotkeys, this.tvTemplatesList.SelectedNode.Name, TemplateManager.Instance.IsDefaultTemplate(this.tvTemplatesList.SelectedNode.Name));
			if (frmTemplateInfo.ShowDialog(this) == DialogResult.OK)
			{
				string templateGroupName = this.GetTemplateGroupName(frmTemplateInfo.TemplateName);
				this.EditHotkeyAtTreeControl(templateGroupName, frmTemplateInfo.TemplateName, frmTemplateInfo.TempalteHotkey);
				HotKeyManager.AddTemplateHotkey(frmTemplateInfo.TemplateName, templateGroupName, (Keys)frmTemplateInfo.TempalteHotkey);
				this.SaveUserProfileFromTreeView();
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0006F2B8 File Offset: 0x0006D6B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetTemplateGroupName(string tempateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			TreeNode[] array = this.tvTemplatesList.Nodes.Find(tempateName, true);
			if (array.Length > 0)
			{
				result = array[0].Parent.Name;
			}
			return result;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0006F314 File Offset: 0x0006D714
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0006F348 File Offset: 0x0006D748
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Hide();
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0006F360 File Offset: 0x0006D760
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Dispose(bool disposing)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0006F3B0 File Offset: 0x0006D7B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			TreeNode treeNode = new TreeNode("Fixed Templates");
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TemplateTreeMenus));
			this.tvTemplatesList = new TreeView();
			this.ImageList = new ImageList(this.components);
			this.panelToolbarContainer = new Panel();
			this.tsTempateEditor = new ToolStrip();
			this.tsbtnView = new ToolStripButton();
			this.tssepNodeMoveDownUseDefault = new ToolStripSeparator();
			this.tsbtnHotkey = new ToolStripButton();
			this.tsbtnUseDefault = new ToolStripButton();
			this.tsbtnClearDefault = new ToolStripButton();
			this.tssepLast = new ToolStripSeparator();
			this.panelTemplateListContainer = new Panel();
			this.panelDefaultTemplateInfo = new Panel();
			this.lbDefault = new Label();
			this.lblDefaultTemplateName = new Label();
			this.tmRefresh = new Timer(this.components);
			this.tdsUserProfile = new UserWorkingProfileDS();
			this.panelToolbarContainer.SuspendLayout();
			this.tsTempateEditor.SuspendLayout();
			this.panelTemplateListContainer.SuspendLayout();
			this.panelDefaultTemplateInfo.SuspendLayout();
			((ISupportInitialize)this.tdsUserProfile).BeginInit();
			base.SuspendLayout();
			this.tvTemplatesList.Dock = DockStyle.Fill;
			this.tvTemplatesList.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tvTemplatesList.ImageIndex = 4;
			this.tvTemplatesList.ImageList = this.ImageList;
			this.tvTemplatesList.Location = new Point(0, 0);
			this.tvTemplatesList.Margin = new Padding(4);
			this.tvTemplatesList.Name = "tvTemplatesList";
			treeNode.Name = "treeNodeFixedTemplates";
			treeNode.Text = "Fixed Templates";
			this.tvTemplatesList.Nodes.AddRange(new TreeNode[]
			{
				treeNode
			});
			this.tvTemplatesList.SelectedImageIndex = 4;
			this.tvTemplatesList.ShowRootLines = false;
			this.tvTemplatesList.Size = new Size(209, 312);
			this.tvTemplatesList.TabIndex = 0;
			this.tvTemplatesList.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.tvTemplatesList_NodeMouseDoubleClick);
			this.tvTemplatesList.AfterSelect += new TreeViewEventHandler(this.tvTemplatesList_AfterSelect);
			this.tvTemplatesList.MouseDown += new MouseEventHandler(this.tvTemplatesList_MouseDown);
			this.tvTemplatesList.KeyDown += new KeyEventHandler(this.tvTemplatesList_KeyDown);
			this.ImageList.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList.ImageStream");
			this.ImageList.TransparentColor = Color.Transparent;
			this.ImageList.Images.SetKeyName(0, "Drafts.bmp");
			this.ImageList.Images.SetKeyName(1, "Outbox.bmp");
			this.ImageList.Images.SetKeyName(2, "Recycle.bmp");
			this.ImageList.Images.SetKeyName(3, "Send.bmp");
			this.ImageList.Images.SetKeyName(4, "Collapsed");
			this.ImageList.Images.SetKeyName(5, "Expanded");
			this.ImageList.Images.SetKeyName(6, "Item");
			this.ImageList.Images.SetKeyName(7, "ItemDefault");
			this.ImageList.Images.SetKeyName(8, "ItemWarning");
			this.panelToolbarContainer.BackColor = SystemColors.Info;
			this.panelToolbarContainer.BorderStyle = BorderStyle.FixedSingle;
			this.panelToolbarContainer.Controls.Add(this.tsTempateEditor);
			this.panelToolbarContainer.Dock = DockStyle.Left;
			this.panelToolbarContainer.Location = new Point(0, 0);
			this.panelToolbarContainer.Margin = new Padding(4);
			this.panelToolbarContainer.Name = "panelToolbarContainer";
			this.panelToolbarContainer.Size = new Size(29, 342);
			this.panelToolbarContainer.TabIndex = 9;
			this.tsTempateEditor.BackgroundImageLayout = ImageLayout.None;
			this.tsTempateEditor.Dock = DockStyle.Fill;
			this.tsTempateEditor.Items.AddRange(new ToolStripItem[]
			{
				this.tsbtnView,
				this.tssepNodeMoveDownUseDefault,
				this.tsbtnHotkey,
				this.tsbtnUseDefault,
				this.tsbtnClearDefault,
				this.tssepLast
			});
			this.tsTempateEditor.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.tsTempateEditor.Location = new Point(0, 0);
			this.tsTempateEditor.Name = "tsTempateEditor";
			this.tsTempateEditor.RenderMode = ToolStripRenderMode.System;
			this.tsTempateEditor.Size = new Size(27, 340);
			this.tsTempateEditor.TabIndex = 7;
			this.tsTempateEditor.Text = "toolStrip1";
			this.tsbtnView.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnView.Image = (Image)componentResourceManager.GetObject("tsbtnView.Image");
			this.tsbtnView.ImageAlign = ContentAlignment.MiddleLeft;
			this.tsbtnView.ImageTransparentColor = Color.Magenta;
			this.tsbtnView.Name = "tsbtnView";
			this.tsbtnView.Size = new Size(25, 20);
			this.tsbtnView.Text = "View";
			this.tsbtnView.TextAlign = ContentAlignment.MiddleLeft;
			this.tsbtnView.ToolTipText = "View(Enter)";
			this.tsbtnView.Click += new EventHandler(this.tsbtnView_Click);
			this.tssepNodeMoveDownUseDefault.Name = "tssepNodeMoveDownUseDefault";
			this.tssepNodeMoveDownUseDefault.Size = new Size(25, 6);
			this.tsbtnHotkey.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnHotkey.Image = (Image)componentResourceManager.GetObject("tsbtnHotkey.Image");
			this.tsbtnHotkey.ImageAlign = ContentAlignment.MiddleLeft;
			this.tsbtnHotkey.ImageTransparentColor = Color.Magenta;
			this.tsbtnHotkey.Name = "tsbtnHotkey";
			this.tsbtnHotkey.Size = new Size(25, 20);
			this.tsbtnHotkey.Text = "Hotkey";
			this.tsbtnHotkey.TextAlign = ContentAlignment.MiddleLeft;
			this.tsbtnHotkey.Click += new EventHandler(this.tsmiHotkey_Click);
			this.tsbtnUseDefault.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnUseDefault.Image = (Image)componentResourceManager.GetObject("tsbtnUseDefault.Image");
			this.tsbtnUseDefault.ImageAlign = ContentAlignment.MiddleLeft;
			this.tsbtnUseDefault.ImageTransparentColor = Color.Magenta;
			this.tsbtnUseDefault.Name = "tsbtnUseDefault";
			this.tsbtnUseDefault.Size = new Size(25, 20);
			this.tsbtnUseDefault.Text = "Set Default";
			this.tsbtnUseDefault.TextAlign = ContentAlignment.MiddleLeft;
			this.tsbtnUseDefault.Click += new EventHandler(this.tsbtnUseDefault_Click);
			this.tsbtnClearDefault.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnClearDefault.Image = (Image)componentResourceManager.GetObject("tsbtnClearDefault.Image");
			this.tsbtnClearDefault.ImageAlign = ContentAlignment.MiddleLeft;
			this.tsbtnClearDefault.ImageTransparentColor = Color.Magenta;
			this.tsbtnClearDefault.Name = "tsbtnClearDefault";
			this.tsbtnClearDefault.Size = new Size(25, 20);
			this.tsbtnClearDefault.Text = "Clear Default";
			this.tsbtnClearDefault.TextAlign = ContentAlignment.MiddleLeft;
			this.tsbtnClearDefault.Click += new EventHandler(this.tsbtnClearDefault_Click);
			this.tssepLast.Name = "tssepLast";
			this.tssepLast.Size = new Size(25, 6);
			this.panelTemplateListContainer.BorderStyle = BorderStyle.FixedSingle;
			this.panelTemplateListContainer.Controls.Add(this.tvTemplatesList);
			this.panelTemplateListContainer.Dock = DockStyle.Fill;
			this.panelTemplateListContainer.Location = new Point(29, 0);
			this.panelTemplateListContainer.Margin = new Padding(4);
			this.panelTemplateListContainer.Name = "panelTemplateListContainer";
			this.panelTemplateListContainer.Size = new Size(211, 314);
			this.panelTemplateListContainer.TabIndex = 10;
			this.panelDefaultTemplateInfo.BorderStyle = BorderStyle.FixedSingle;
			this.panelDefaultTemplateInfo.Controls.Add(this.lbDefault);
			this.panelDefaultTemplateInfo.Controls.Add(this.lblDefaultTemplateName);
			this.panelDefaultTemplateInfo.Dock = DockStyle.Bottom;
			this.panelDefaultTemplateInfo.Location = new Point(29, 314);
			this.panelDefaultTemplateInfo.Margin = new Padding(4);
			this.panelDefaultTemplateInfo.Name = "panelDefaultTemplateInfo";
			this.panelDefaultTemplateInfo.Size = new Size(211, 28);
			this.panelDefaultTemplateInfo.TabIndex = 11;
			this.lbDefault.AutoSize = true;
			this.lbDefault.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 222);
			this.lbDefault.Location = new Point(4, 2);
			this.lbDefault.Margin = new Padding(4, 0, 4, 0);
			this.lbDefault.Name = "lbDefault";
			this.lbDefault.Size = new Size(52, 13);
			this.lbDefault.TabIndex = 1;
			this.lbDefault.Text = "Default:";
			this.lblDefaultTemplateName.AutoSize = true;
			this.lblDefaultTemplateName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lblDefaultTemplateName.Location = new Point(81, 2);
			this.lblDefaultTemplateName.Margin = new Padding(4, 0, 4, 0);
			this.lblDefaultTemplateName.Name = "lblDefaultTemplateName";
			this.lblDefaultTemplateName.Size = new Size(34, 13);
			this.lblDefaultTemplateName.TabIndex = 0;
			this.lblDefaultTemplateName.Text = "Blank";
			this.tmRefresh.Tick += new EventHandler(this.tmRefresh_Tick);
			this.tdsUserProfile.DataSetName = "UserProfileDS";
			this.tdsUserProfile.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.panelTemplateListContainer);
			base.Controls.Add(this.panelDefaultTemplateInfo);
			base.Controls.Add(this.panelToolbarContainer);
			this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.Margin = new Padding(4);
			base.Name = "TemplateTreeMenus";
			base.Size = new Size(240, 342);
			this.panelToolbarContainer.ResumeLayout(false);
			this.panelToolbarContainer.PerformLayout();
			this.tsTempateEditor.ResumeLayout(false);
			this.tsTempateEditor.PerformLayout();
			this.panelTemplateListContainer.ResumeLayout(false);
			this.panelDefaultTemplateInfo.ResumeLayout(false);
			this.panelDefaultTemplateInfo.PerformLayout();
			((ISupportInitialize)this.tdsUserProfile).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040003DC RID: 988
		private bool showContextMenu;

		// Token: 0x040003DD RID: 989
		private IContainer components;

		// Token: 0x040003DE RID: 990
		private TreeView tvTemplatesList;

		// Token: 0x040003DF RID: 991
		private ImageList ImageList;

		// Token: 0x040003E0 RID: 992
		private Panel panelToolbarContainer;

		// Token: 0x040003E1 RID: 993
		private ToolStrip tsTempateEditor;

		// Token: 0x040003E2 RID: 994
		private ToolStripButton tsbtnClearDefault;

		// Token: 0x040003E3 RID: 995
		private ToolStripButton tsbtnUseDefault;

		// Token: 0x040003E4 RID: 996
		private ToolStripSeparator tssepLast;

		// Token: 0x040003E5 RID: 997
		private Panel panelTemplateListContainer;

		// Token: 0x040003E6 RID: 998
		private Panel panelDefaultTemplateInfo;

		// Token: 0x040003E7 RID: 999
		private Label lblDefaultTemplateName;

		// Token: 0x040003E8 RID: 1000
		private Label lbDefault;

		// Token: 0x040003E9 RID: 1001
		private ToolStripButton tsbtnView;

		// Token: 0x040003EA RID: 1002
		private ToolStripSeparator tssepNodeMoveDownUseDefault;

		// Token: 0x040003EB RID: 1003
		private Timer tmRefresh;

		// Token: 0x040003EC RID: 1004
		private ToolStripButton tsbtnHotkey;

		// Token: 0x040003ED RID: 1005
		public UserWorkingProfileDS tdsUserProfile;

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000681 RID: 1665
		public delegate void OnOpenTemplateHandler(string templateName, string templateGroup);
	}
}
