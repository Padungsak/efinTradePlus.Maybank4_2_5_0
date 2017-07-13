using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;

namespace CSVReaderTest
{
	// Token: 0x020000F0 RID: 240
	internal class CSVReadWrite
	{
		// Token: 0x06000B5A RID: 2906 RVA: 0x000CF508 File Offset: 0x000CD908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void exportToCSV(DataTable dt)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Application.ExecutablePath.ToString();
			saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				CSVReadWrite.CreateCSVfile(dt, saveFileDialog.FileName.ToString());
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000CF580 File Offset: 0x000CD980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void exportToCSV(DataSet ds)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Application.ExecutablePath.ToString();
			saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				CSVReadWrite.CreateCSVfile(ds, saveFileDialog.FileName.ToString());
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000CF5F8 File Offset: 0x000CD9F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreateCSVfile(DataTable dtable, string strFilePath)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			if (dtable.Rows.Count > 0)
			{
				StreamWriter streamWriter = new StreamWriter(strFilePath, false);
				int count = dtable.Columns.Count;
				foreach (DataRow dataRow in dtable.Rows)
				{
					for (int i = 0; i < count; i++)
					{
						if (!Convert.IsDBNull(dataRow[i]))
						{
							streamWriter.Write(dataRow[i].ToString());
						}
						if (i < count - 1)
						{
							streamWriter.Write(",");
						}
					}
					streamWriter.Write(streamWriter.NewLine);
				}
				streamWriter.Close();
				Process.Start("rundll32.exe", "shell32.dll, OpenAs_RunDLL " + strFilePath);
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000CF73C File Offset: 0x000CDB3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreateCSVfile(DataSet ds, string strFilePath)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			if (ds.Tables.Count > 0)
			{
				StreamWriter streamWriter = new StreamWriter(strFilePath, false);
				foreach (DataTable dataTable in ds.Tables)
				{
					if (dataTable.Rows.Count > 0)
					{
						int count = dataTable.Columns.Count;
						foreach (DataRow dataRow in dataTable.Rows)
						{
							for (int i = 0; i < count; i++)
							{
								if (!Convert.IsDBNull(dataRow[i]))
								{
									streamWriter.Write(dataRow[i].ToString());
								}
								if (i < count - 1)
								{
									streamWriter.Write(",");
								}
							}
							streamWriter.Write(streamWriter.NewLine);
						}
					}
					streamWriter.Write(streamWriter.NewLine);
					streamWriter.Write(streamWriter.NewLine);
				}
				streamWriter.Close();
				Process.Start("rundll32.exe", "shell32.dll, OpenAs_RunDLL " + strFilePath);
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000CF93C File Offset: 0x000CDD3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CSVReadWrite() : base()
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
		}
	}
}
