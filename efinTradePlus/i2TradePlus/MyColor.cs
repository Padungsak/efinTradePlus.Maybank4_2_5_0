using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;
using STIControl;

namespace i2TradePlus
{
	// Token: 0x02000029 RID: 41
	public class MyColor
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00016CD8 File Offset: 0x000150D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetStyle(bool isSoftStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (isSoftStyle)
			{
				MyColor.UpColor = Color.FromArgb(0, 240, 50);
				MyColor.DownColor = Color.FromArgb(255, 55, 46);
				MyColor.BuyColor = Color.FromArgb(255, 175, 0);
				MyColor.SellColor = Color.FromArgb(216, 100, 216);
				MyColor.UnChgColor = Color.FromArgb(255, 255, 80);
				MyColor.OpenColor = Color.White;
				MyColor.CeilingColor = Color.FromArgb(78, 232, 230);
				MyColor.FloorColor = Color.FromArgb(187, 44, 189);
			}
			else
			{
				MyColor.UpColor = Color.Lime;
				MyColor.DownColor = Color.Red;
				MyColor.BuyColor = Color.Lime;
				MyColor.SellColor = Color.Red;
				MyColor.UnChgColor = Color.Yellow;
				MyColor.OpenColor = Color.Yellow;
				MyColor.CeilingColor = Color.Cyan;
				MyColor.FloorColor = Color.Magenta;
			}
			MySetting.UpColor = MyColor.UpColor;
			MySetting.DownColor = MyColor.DownColor;
			MySetting.BuyColor = MyColor.BuyColor;
			MySetting.SellColor = MyColor.SellColor;
			MySetting.UnchgColor = MyColor.UnChgColor;
			MySetting.OpenColor = MyColor.OpenColor;
			MySetting.CeilingColor = MyColor.CeilingColor;
			MySetting.FloorColor = MyColor.FloorColor;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00016E4C File Offset: 0x0001524C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MyColor() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00016E68 File Offset: 0x00015268
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MyColor()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			MyColor.UpColor = Color.FromArgb(0, 255, 124);
			MyColor.DownColor = Color.FromArgb(255, 80, 75);
			MyColor.BuyColor = Color.FromArgb(255, 175, 0);
			MyColor.SellColor = Color.FromArgb(174, 126, 213);
			MyColor.UnChgColor = Color.FromArgb(255, 244, 80);
			MyColor.CeilingColor = Color.FromArgb(78, 232, 230);
			MyColor.FloorColor = Color.FromArgb(187, 44, 189);
			MyColor.OpenColor = Color.White;
		}

		// Token: 0x040000C2 RID: 194
		public static Color UpColor;

		// Token: 0x040000C3 RID: 195
		public static Color DownColor;

		// Token: 0x040000C4 RID: 196
		public static Color BuyColor;

		// Token: 0x040000C5 RID: 197
		public static Color SellColor;

		// Token: 0x040000C6 RID: 198
		public static Color UnChgColor;

		// Token: 0x040000C7 RID: 199
		public static Color CeilingColor;

		// Token: 0x040000C8 RID: 200
		public static Color FloorColor;

		// Token: 0x040000C9 RID: 201
		public static Color OpenColor;
	}
}
