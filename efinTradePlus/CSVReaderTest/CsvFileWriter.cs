using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Abv9LVGLme6DnuTi2C;

namespace CSVReaderTest
{
	// Token: 0x020000F2 RID: 242
	public class CsvFileWriter : StreamWriter
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x000CF9B8 File Offset: 0x000CDDB8
		[MethodImpl(MethodImplOptions.NoInlining)]
        public CsvFileWriter(Stream stream)
            : base(stream)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000CF9D8 File Offset: 0x000CDDD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CsvFileWriter(string filename) : base(filename)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x000CF9F8 File Offset: 0x000CDDF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteRow(CsvRow row)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			foreach (string current in row)
			{
				if (!flag)
				{
					stringBuilder.Append(',');
				}
				if (current.IndexOfAny(new char[]
				{
					'"',
					','
				}) != -1)
				{
					stringBuilder.AppendFormat("\"{0}\"", current.Replace("\"", "\"\""));
				}
				else
				{
					stringBuilder.Append(current);
				}
				flag = false;
			}
			row.LineText = stringBuilder.ToString();
			this.WriteLine(row.LineText);
		}
	}
}
