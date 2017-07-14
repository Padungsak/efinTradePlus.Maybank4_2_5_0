using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using ITSNet.Common.BIZ;

// Token: 0x0200001A RID: 26
public class ucVolumeAtPrice : UserControl
{
	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060000D9 RID: 217 RVA: 0x00010E48 File Offset: 0x0000F248
	// (remove) Token: 0x060000DA RID: 218 RVA: 0x00010E70 File Offset: 0x0000F270
	public event ucVolumeAtPrice.ActivatedEventHandler Activated
	{
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Activated = (ucVolumeAtPrice.ActivatedEventHandler)Delegate.Combine(this.Activated, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Activated = (ucVolumeAtPrice.ActivatedEventHandler)Delegate.Remove(this.Activated, value);
		}
	}

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060000DB RID: 219 RVA: 0x00010E98 File Offset: 0x0000F298
	// (remove) Token: 0x060000DC RID: 220 RVA: 0x00010EC0 File Offset: 0x0000F2C0
	public event ucVolumeAtPrice.DragEventHandler Drag
	{
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Drag = (ucVolumeAtPrice.DragEventHandler)Delegate.Combine(this.Drag, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Drag = (ucVolumeAtPrice.DragEventHandler)Delegate.Remove(this.Drag, value);
		}
	}

	// Token: 0x1400000B RID: 11
	// (add) Token: 0x060000DD RID: 221 RVA: 0x00010EE8 File Offset: 0x0000F2E8
	// (remove) Token: 0x060000DE RID: 222 RVA: 0x00010F10 File Offset: 0x0000F310
	public event ucVolumeAtPrice.SendErrorMsgEventHandler SendErrorMsg
	{
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendErrorMsg = (ucVolumeAtPrice.SendErrorMsgEventHandler)Delegate.Combine(this.SendErrorMsg, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendErrorMsg = (ucVolumeAtPrice.SendErrorMsgEventHandler)Delegate.Remove(this.SendErrorMsg, value);
		}
	}

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x060000DF RID: 223 RVA: 0x00010F38 File Offset: 0x0000F338
	// (remove) Token: 0x060000E0 RID: 224 RVA: 0x00010F60 File Offset: 0x0000F360
	public event ucVolumeAtPrice.OpenWithEventHandler OpenWith
	{
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.OpenWith = (ucVolumeAtPrice.OpenWithEventHandler)Delegate.Combine(this.OpenWith, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.OpenWith = (ucVolumeAtPrice.OpenWithEventHandler)Delegate.Remove(this.OpenWith, value);
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x060000E1 RID: 225 RVA: 0x00010F88 File Offset: 0x0000F388
	// (set) Token: 0x060000E2 RID: 226 RVA: 0x00010FB4 File Offset: 0x0000F3B4
	public int Mode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this._mode;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._mode = value;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x060000E3 RID: 227 RVA: 0x00010FCC File Offset: 0x0000F3CC
	// (set) Token: 0x060000E4 RID: 228 RVA: 0x00010FF8 File Offset: 0x0000F3F8
	public Color TextBoxBgColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.m_TextBoxBgColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.m_TextBoxBgColor != value)
			{
				this.m_TextBoxBgColor = value;
			}
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x060000E5 RID: 229 RVA: 0x00011034 File Offset: 0x0000F434
	// (set) Token: 0x060000E6 RID: 230 RVA: 0x00011060 File Offset: 0x0000F460
	public Color TextBoxForeColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.m_TextBoxForeColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.m_TextBoxForeColor != value)
			{
				this.m_TextBoxForeColor = value;
			}
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x060000E7 RID: 231 RVA: 0x0001109C File Offset: 0x0000F49C
	// (set) Token: 0x060000E8 RID: 232 RVA: 0x000110CC File Offset: 0x0000F4CC
	public clsPermission ActiveTFEX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.oActiveTFEX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.oGraphPanel.oActiveTFEX = value;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000E9 RID: 233 RVA: 0x000110EC File Offset: 0x0000F4EC
	// (set) Token: 0x060000EA RID: 234 RVA: 0x0001111C File Offset: 0x0000F51C
	public clsPermission ActiveSET
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.oActiveSET;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.oGraphPanel.oActiveSET = value;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000EB RID: 235 RVA: 0x0001113C File Offset: 0x0000F53C
	// (set) Token: 0x060000EC RID: 236 RVA: 0x0001116C File Offset: 0x0000F56C
	public Dictionary<string, float> dictIPO
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.dictIPO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.oGraphPanel.dictIPO = value;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060000ED RID: 237 RVA: 0x0001118C File Offset: 0x0000F58C
	// (set) Token: 0x060000EE RID: 238 RVA: 0x000111B8 File Offset: 0x0000F5B8
	public string CurDate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.strCurDate;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.strCurDate != value)
			{
				this.strCurDate = value;
			}
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000EF RID: 239 RVA: 0x000111F4 File Offset: 0x0000F5F4
	// (set) Token: 0x060000F0 RID: 240 RVA: 0x00011220 File Offset: 0x0000F620
	public enumMode TypeMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.eTypeMode;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.eTypeMode = value;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000F1 RID: 241 RVA: 0x00011238 File Offset: 0x0000F638
	// (set) Token: 0x060000F2 RID: 242 RVA: 0x00011268 File Offset: 0x0000F668
	public enumType SymbolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.oSymbolType;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.oGraphPanel.oSymbolType = value;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000F3 RID: 243 RVA: 0x00011288 File Offset: 0x0000F688
	// (set) Token: 0x060000F4 RID: 244 RVA: 0x000112B8 File Offset: 0x0000F6B8
	public Color ColorCeiling
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_CeilingColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.oGraphPanel.m_CeilingColor != value)
			{
				this.oGraphPanel.m_CeilingColor = value;
				if (this.bLoaded)
				{
					this.PictureBox1.Invalidate();
				}
			}
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060000F5 RID: 245 RVA: 0x0001131C File Offset: 0x0000F71C
	// (set) Token: 0x060000F6 RID: 246 RVA: 0x0001134C File Offset: 0x0000F74C
	public Color ColorFloor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_FloorColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.oGraphPanel.m_FloorColor != value)
			{
				this.oGraphPanel.m_FloorColor = value;
				if (this.bLoaded)
				{
					this.PictureBox1.Invalidate();
				}
			}
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060000F7 RID: 247 RVA: 0x000113B0 File Offset: 0x0000F7B0
	// (set) Token: 0x060000F8 RID: 248 RVA: 0x000113E0 File Offset: 0x0000F7E0
	public string FontName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_FontName;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.m_FontName)
			{
				this.oGraphPanel.m_FontName = value;
				if (this.bLoaded)
				{
					this.PictureBox1.Invalidate();
				}
			}
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x00011444 File Offset: 0x0000F844
	// (set) Token: 0x060000FA RID: 250 RVA: 0x00011474 File Offset: 0x0000F874
	public float FontSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_FontSize;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.m_FontSize)
			{
				this.oGraphPanel.m_FontSize = value;
				if (this.bLoaded)
				{
					this.PictureBox1.Invalidate();
				}
			}
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000FB RID: 251 RVA: 0x000114D0 File Offset: 0x0000F8D0
	// (set) Token: 0x060000FC RID: 252 RVA: 0x00011500 File Offset: 0x0000F900
	public Color ColorGrid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_GridColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.oGraphPanel.m_GridColor != value)
			{
				this.oGraphPanel.m_GridColor = value;
				if (this.bLoaded)
				{
					this.PictureBox1.Invalidate();
				}
			}
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000FD RID: 253 RVA: 0x00011564 File Offset: 0x0000F964
	// (set) Token: 0x060000FE RID: 254 RVA: 0x00011594 File Offset: 0x0000F994
	public Color ColorBg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_BgColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.oGraphPanel.m_BgColor != value)
			{
				this.oGraphPanel.m_BgColor = value;
				this.SetBgColor();
				this.PictureBox1.Invalidate();
			}
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000FF RID: 255 RVA: 0x000115EC File Offset: 0x0000F9EC
	// (set) Token: 0x06000100 RID: 256 RVA: 0x0001161C File Offset: 0x0000FA1C
	public Color ColorVolume
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_VolumeColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.m_VolumeColor)
			{
				this.oGraphPanel.m_VolumeColor = value;
				this.PictureBox1.Invalidate();
			}
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000101 RID: 257 RVA: 0x00011670 File Offset: 0x0000FA70
	// (set) Token: 0x06000102 RID: 258 RVA: 0x000116A0 File Offset: 0x0000FAA0
	public Color ColorUp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_UpColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.m_UpColor)
			{
				this.oGraphPanel.m_UpColor = value;
				this.PictureBox1.Invalidate();
			}
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000103 RID: 259 RVA: 0x000116F4 File Offset: 0x0000FAF4
	// (set) Token: 0x06000104 RID: 260 RVA: 0x00011724 File Offset: 0x0000FB24
	public Color ColorDown
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_DownColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.m_DownColor)
			{
				this.oGraphPanel.m_DownColor = value;
				this.PictureBox1.Invalidate();
			}
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000105 RID: 261 RVA: 0x00011778 File Offset: 0x0000FB78
	// (set) Token: 0x06000106 RID: 262 RVA: 0x000117A8 File Offset: 0x0000FBA8
	public Color ColorNoChg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_NoChgColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.m_NoChgColor)
			{
				this.oGraphPanel.m_NoChgColor = value;
				this.PictureBox1.Invalidate();
			}
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000107 RID: 263 RVA: 0x000117FC File Offset: 0x0000FBFC
	// (set) Token: 0x06000108 RID: 264 RVA: 0x0001182C File Offset: 0x0000FC2C
	public Color ColorBuy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.BuyColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.BuyColor)
			{
				this.oGraphPanel.BuyColor = value;
				this.PictureBox1.Invalidate();
			}
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000109 RID: 265 RVA: 0x00011880 File Offset: 0x0000FC80
	// (set) Token: 0x0600010A RID: 266 RVA: 0x000118B0 File Offset: 0x0000FCB0
	public Color ColorSell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.SellColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.SellColor)
			{
				this.oGraphPanel.SellColor = value;
				this.PictureBox1.Invalidate();
			}
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600010B RID: 267 RVA: 0x00011904 File Offset: 0x0000FD04
	// (set) Token: 0x0600010C RID: 268 RVA: 0x00011934 File Offset: 0x0000FD34
	public Color ColorValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.m_ValueColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (value != this.oGraphPanel.m_ValueColor)
			{
				this.oGraphPanel.m_ValueColor = value;
				this.PictureBox1.Invalidate();
			}
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600010D RID: 269 RVA: 0x00011988 File Offset: 0x0000FD88
	// (set) Token: 0x0600010E RID: 270 RVA: 0x000119B8 File Offset: 0x0000FDB8
	public string SymbolList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.oGraphPanel.strSymbolList;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.oGraphPanel.strSymbolList != value)
			{
				if (!this.bLoaded)
				{
					this.oGraphPanel.SymbolList = value;
					this.SetSymbolType();
				}
			}
		}
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00011A14 File Offset: 0x0000FE14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSymbolTypeSpecial(enumType enumSymbolType)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			this.SymbolType = enumSymbolType;
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub SetSymbolTypeSpecial ", ex.Message);
			}
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00011A84 File Offset: 0x0000FE84
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSymbolType()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			if (!string.IsNullOrEmpty(this.oGraphPanel.strSymbolList) && this.SymbolListSet.Contains(this.oGraphPanel.strSymbolList))
			{
				this.SymbolType = enumType.eSet;
			}
			else if (!string.IsNullOrEmpty(this.oGraphPanel.strSymbolList) && this.SymbolListTfex.Contains(this.oGraphPanel.strSymbolList))
			{
				this.SymbolType = enumType.eTfex;
			}
			if (this.eOldSymbolType != this.SymbolType)
			{
				this.eOldSymbolType = this.SymbolType;
			}
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub SetSymbolType ", ex.Message);
			}
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00011B9C File Offset: 0x0000FF9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetGraphHeightWidth()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			this.oGraphPanel.Width = this.PictureBox1.Width;
			this.oGraphPanel.Height = this.PictureBox1.Height;
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub SetStartGraphWidth ", ex.Message);
			}
		}
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00011C30 File Offset: 0x00010030
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsBetweenCurrentDay()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		bool result = false;
		try
		{
			if (!string.IsNullOrEmpty(this.SymbolList))
			{
				if (this.TypeMode == enumMode.Between)
				{
					if (FormatUtil.Isdatetime(this.strCurDate) && FormatUtil.Isdatetime(this.strEndDate))
					{
						if (Convert.ToDateTime(this.strEndDate) >= Convert.ToDateTime(this.strCurDate))
						{
							result = true;
						}
					}
				}
				else
				{
					result = true;
				}
			}
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Function IsBetweenCurrentDay ", ex.Message);
			}
		}
		return result;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00011D28 File Offset: 0x00010128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadControl()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			if (!this.bLoaded)
			{
				this.SetGraphHeightWidth();
				this.SetBgColor();
				this.PictureBox1.Invalidate();
			}
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub wcVolumeAtPrice_Load ", ex.Message);
			}
		}
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00011DB8 File Offset: 0x000101B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBgColor()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			this.PictureBox1.BackColor = this.oGraphPanel.m_BgColor;
			this.BackColor = this.oGraphPanel.m_BgColor;
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub SetBgColor", ex.Message);
			}
		}
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00011E48 File Offset: 0x00010248
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CanUseThisPermission()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		bool flag = false;
		try
		{
			if (this.oGraphPanel != null)
			{
				if (this.TypeMode == enumMode.Previous)
				{
					flag = true;
				}
				else if (this.oGraphPanel.ActiveType.Permission == enumPermission.Usable)
				{
					flag = true;
				}
			}
			if (this.bLoaded && !flag)
			{
				this.PictureBox1.Invalidate();
			}
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub CanUseThisPermission ", ex.Message);
			}
		}
		return flag;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00011F30 File Offset: 0x00010330
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wcVolumeAtPrice_Load(object sender, EventArgs e)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		this.LoadControl();
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00011F48 File Offset: 0x00010348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitData(string Symbol, double Prior, double LastPrice, double Ceiling, double Floor)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			this.oGraphPanel.Clear();
			this.oGraphPanel.SymbolList = Symbol;
			this.oGraphPanel.Prior = Prior;
			this.oGraphPanel.Last = LastPrice;
			this.oGraphPanel.Ceiling = Ceiling;
			this.oGraphPanel.Floor = Floor;
			this.bLoaded = true;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00011FD8 File Offset: 0x000103D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitData()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			this.oGraphPanel.Clear();
			this.oGraphPanel.SymbolList = string.Empty;
			this.oGraphPanel.Prior = 0.0;
			this.oGraphPanel.Last = 0.0;
			this.oGraphPanel.Ceiling = 0.0;
			this.oGraphPanel.Floor = 0.0;
			this.bLoaded = true;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00012088 File Offset: 0x00010488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InputData(double Price, long AccVolume, long BuyVolume, long SellVolume)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		this.oGraphPanel.Add(Price, AccVolume, BuyVolume, SellVolume);
	}

	// Token: 0x0600011A RID: 282 RVA: 0x000120AC File Offset: 0x000104AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InputData(string stock, double value, double profit)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		this.oGraphPanel.Add(stock, value, profit);
	}

	// Token: 0x0600011B RID: 283 RVA: 0x000120CC File Offset: 0x000104CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateData(double Price, long AccVolume, long BuyVolume, long SellVolume)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		this.oGraphPanel.Update(Price, AccVolume, BuyVolume, SellVolume);
		this.PictureBox1.Invalidate();
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000120FC File Offset: 0x000104FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndUpdate()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		this.PictureBox1.Invalidate();
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0001211C File Offset: 0x0001051C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Sort()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		this.oGraphPanel.Sort();
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0001213C File Offset: 0x0001053C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PictureBox1_Paint(object sender, PaintEventArgs e)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			if (this.bLoaded && this.oGraphPanel != null)
			{
				if (this._mode == 0)
				{
					this.oGraphPanel.Draw(e.Graphics);
				}
				else
				{
					this.oGraphPanel.DrawByStock(e.Graphics);
				}
			}
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub PictureBox1_Paint ", ex.Message);
			}
		}
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00012200 File Offset: 0x00010600
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PictureBox1_Resize(object sender, EventArgs e)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			this.oGraphPanel.Width = this.PictureBox1.Width;
			this.oGraphPanel.Height = this.PictureBox1.Height;
			if (this.bLoaded)
			{
				this.PictureBox1.Invalidate();
			}
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub PictureBox1_Resize ", ex.Message);
			}
		}
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000122B4 File Offset: 0x000106B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		try
		{
			if (this.Activated != null)
			{
				this.Activated();
			}
			if (this.bLoaded)
			{
				if (e.Button == MouseButtons.Right)
				{
					if (!string.IsNullOrEmpty(this.oGraphPanel.strSymbolList))
					{
						if (this.OpenWith != null)
						{
							this.OpenWith(this.oGraphPanel.strSymbolList);
						}
					}
					else if (this.OpenWith != null)
					{
						this.OpenWith("");
					}
				}
				if (e.Button == MouseButtons.Left)
				{
					if (!string.IsNullOrEmpty(this.oGraphPanel.strSymbolList))
					{
						Color color = default(Color);
						color = this.oGraphPanel.GetCompareColor(this.oGraphPanel.Prior, this.oGraphPanel.Last);
						if (this.Drag != null)
						{
							this.Drag(this.oGraphPanel.strSymbolList, color);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub PictureBox1_MouseDown ", ex.Message);
			}
		}
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00012460 File Offset: 0x00010860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ucVolumeAtPrice() : base()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
		this.oGraphPanel = new clsGraphPanel();
		this.strEndDate = string.Empty;
		this.eTypeMode = enumMode.Previous;
		
		base.Load += new EventHandler(this.wcVolumeAtPrice_Load);
		try
		{
			this.InitializeComponent();
		}
		catch (Exception ex)
		{
			if (this.SendErrorMsg != null)
			{
				this.SendErrorMsg("Sub New ", ex.Message);
			}
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0001250C File Offset: 0x0001090C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
		while (false)
		{
			//object arg_0A_0 = null[0];
		}
		this.PictureBox1 = new PictureBox();
		((ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.PictureBox1.Dock = DockStyle.Fill;
		this.PictureBox1.Location = new Point(0, 0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new Size(150, 150);
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.PictureBox1.Resize += new EventHandler(this.PictureBox1_Resize);
		this.PictureBox1.MouseDown += new MouseEventHandler(this.PictureBox1_MouseDown);
		this.PictureBox1.Paint += new PaintEventHandler(this.PictureBox1_Paint);
		base.Controls.Add(this.PictureBox1);
		base.Name = "ucVolumeAtPrice";
		((ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000086 RID: 134
	private PictureBox PictureBox1;

	// Token: 0x04000087 RID: 135
	private bool bLoaded;

	// Token: 0x04000088 RID: 136
	private clsGraphPanel oGraphPanel;

	// Token: 0x04000089 RID: 137
	public List<string> SymbolListTfex;

	// Token: 0x0400008A RID: 138
	public List<string> SymbolListSet;

	// Token: 0x0400008B RID: 139
	private string strEndDate;

	// Token: 0x0400008C RID: 140
	private enumMode eTypeMode;

	// Token: 0x0400008D RID: 141
	private enumType eOldSymbolType;

	// Token: 0x0400008E RID: 142
	private string strCurDate;

	// Token: 0x0400008F RID: 143
	private Color m_TextBoxBgColor;

	// Token: 0x04000090 RID: 144
	private Color m_TextBoxForeColor;

	// Token: 0x04000095 RID: 149
	private int _mode;

	// Token: 0x0200001B RID: 27
	// (Invoke) Token: 0x06000124 RID: 292
	public delegate void ActivatedEventHandler();

	// Token: 0x0200001C RID: 28
	// (Invoke) Token: 0x06000128 RID: 296
	public delegate void DragEventHandler(string Symbol, Color Color);

	// Token: 0x0200001D RID: 29
	// (Invoke) Token: 0x0600012C RID: 300
	public delegate void ItemChangeEventHandler(string strSymbol, string strTypeMode, string strInterval, string strStartDate, string strEndDate);

	// Token: 0x0200001E RID: 30
	// (Invoke) Token: 0x06000130 RID: 304
	public delegate void StartGetWsEventHandler(string Symbol, string TypeSymbol);

	// Token: 0x0200001F RID: 31
	// (Invoke) Token: 0x06000134 RID: 308
	public delegate void LoadCompleteEventHandler(string Symbol, string TypeSymbol);

	// Token: 0x02000020 RID: 32
	// (Invoke) Token: 0x06000138 RID: 312
	public delegate void SendErrorMsgEventHandler(string SubName, string ErrorMsg);

	// Token: 0x02000021 RID: 33
	// (Invoke) Token: 0x0600013C RID: 316
	public delegate void OpenWithEventHandler(string Symbol);

	// Token: 0x02000022 RID: 34
	// (Invoke) Token: 0x06000140 RID: 320
	public delegate void EnableLoadingEventHandler();

	// Token: 0x02000023 RID: 35
	// (Invoke) Token: 0x06000144 RID: 324
	public delegate void DisableloadingEventHandler();
}
