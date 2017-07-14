using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.MyDataSet
{
	// Token: 0x02000068 RID: 104
	[ToolboxItem(true), XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code"), HelpKeyword("vs.data.DataSet"), XmlRoot("TemplateDS"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class TemplateDS : DataSet
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x0005FD40 File Offset: 0x0005E140
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateDS() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0005FDAC File Offset: 0x0005E1AC
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TemplateDS(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
			}
			else
			{
				string s = (string)info.GetValue("XmlSchema", typeof(string));
				if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
				{
					DataSet dataSet = new DataSet();
					dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
					if (dataSet.Tables["TemplateProperty"] != null)
					{
						base.Tables.Add(new TemplateDS.TemplatePropertyDataTable(dataSet.Tables["TemplateProperty"]));
					}
					if (dataSet.Tables["FormInfo"] != null)
					{
						base.Tables.Add(new TemplateDS.FormInfoDataTable(dataSet.Tables["FormInfo"]));
					}
					if (dataSet.Tables["FormProperty"] != null)
					{
						base.Tables.Add(new TemplateDS.FormPropertyDataTable(dataSet.Tables["FormProperty"]));
					}
					if (dataSet.Tables["FormRememberField"] != null)
					{
						base.Tables.Add(new TemplateDS.FormRememberFieldDataTable(dataSet.Tables["FormRememberField"]));
					}
					base.DataSetName = dataSet.DataSetName;
					base.Prefix = dataSet.Prefix;
					base.Namespace = dataSet.Namespace;
					base.Locale = dataSet.Locale;
					base.CaseSensitive = dataSet.CaseSensitive;
					base.EnforceConstraints = dataSet.EnforceConstraints;
					base.Merge(dataSet, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				else
				{
					base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				}
				base.GetSerializationData(info, context);
				CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
				base.Tables.CollectionChanged += value2;
				this.Relations.CollectionChanged += value2;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00060018 File Offset: 0x0005E418
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
		public TemplateDS.TemplatePropertyDataTable TemplateProperty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableTemplateProperty;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00060044 File Offset: 0x0005E444
		[DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public TemplateDS.FormInfoDataTable FormInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableFormInfo;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00060070 File Offset: 0x0005E470
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public TemplateDS.FormPropertyDataTable FormProperty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableFormProperty;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0006009C File Offset: 0x0005E49C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
		public TemplateDS.FormRememberFieldDataTable FormRememberField
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableFormRememberField;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x000600C8 File Offset: 0x0005E4C8
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x000600F4 File Offset: 0x0005E4F4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(true), DebuggerNonUserCode]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._schemaSerializationMode;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0006010C File Offset: 0x0005E50C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Tables;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00060138 File Offset: 0x0005E538
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Relations;
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00060164 File Offset: 0x0005E564
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitializeDerivedDataSet()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0006018C File Offset: 0x0005E58C
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DataSet Clone()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TemplateDS templateDS = (TemplateDS)base.Clone();
			templateDS.InitVars();
			templateDS.SchemaSerializationMode = this.SchemaSerializationMode;
			return templateDS;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000601D0 File Offset: 0x0005E5D0
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool ShouldSerializeTables()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000601F4 File Offset: 0x0005E5F4
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool ShouldSerializeRelations()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00060218 File Offset: 0x0005E618
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["TemplateProperty"] != null)
				{
					base.Tables.Add(new TemplateDS.TemplatePropertyDataTable(dataSet.Tables["TemplateProperty"]));
				}
				if (dataSet.Tables["FormInfo"] != null)
				{
					base.Tables.Add(new TemplateDS.FormInfoDataTable(dataSet.Tables["FormInfo"]));
				}
				if (dataSet.Tables["FormProperty"] != null)
				{
					base.Tables.Add(new TemplateDS.FormPropertyDataTable(dataSet.Tables["FormProperty"]));
				}
				if (dataSet.Tables["FormRememberField"] != null)
				{
					base.Tables.Add(new TemplateDS.FormRememberFieldDataTable(dataSet.Tables["FormRememberField"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXml(reader);
				this.InitVars();
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000603C8 File Offset: 0x0005E7C8
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override XmlSchema GetSchemaSerializable()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00060414 File Offset: 0x0005E814
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InitVars()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.InitVars(true);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00060430 File Offset: 0x0005E830
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InitVars(bool initTable)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tableTemplateProperty = (TemplateDS.TemplatePropertyDataTable)base.Tables["TemplateProperty"];
			if (initTable)
			{
				if (this.tableTemplateProperty != null)
				{
					this.tableTemplateProperty.InitVars();
				}
			}
			this.tableFormInfo = (TemplateDS.FormInfoDataTable)base.Tables["FormInfo"];
			if (initTable)
			{
				if (this.tableFormInfo != null)
				{
					this.tableFormInfo.InitVars();
				}
			}
			this.tableFormProperty = (TemplateDS.FormPropertyDataTable)base.Tables["FormProperty"];
			if (initTable)
			{
				if (this.tableFormProperty != null)
				{
					this.tableFormProperty.InitVars();
				}
			}
			this.tableFormRememberField = (TemplateDS.FormRememberFieldDataTable)base.Tables["FormRememberField"];
			if (initTable)
			{
				if (this.tableFormRememberField != null)
				{
					this.tableFormRememberField.InitVars();
				}
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00060564 File Offset: 0x0005E964
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitClass()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.DataSetName = "TemplateDS";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/TemplateDS.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableTemplateProperty = new TemplateDS.TemplatePropertyDataTable();
			base.Tables.Add(this.tableTemplateProperty);
			this.tableFormInfo = new TemplateDS.FormInfoDataTable();
			base.Tables.Add(this.tableFormInfo);
			this.tableFormProperty = new TemplateDS.FormPropertyDataTable();
			base.Tables.Add(this.tableFormProperty);
			this.tableFormRememberField = new TemplateDS.FormRememberFieldDataTable();
			base.Tables.Add(this.tableFormRememberField);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00060628 File Offset: 0x0005EA28
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeTemplateProperty()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0006064C File Offset: 0x0005EA4C
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeFormInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00060670 File Offset: 0x0005EA70
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeFormProperty()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00060694 File Offset: 0x0005EA94
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeFormRememberField()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000606B8 File Offset: 0x0005EAB8
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000606F0 File Offset: 0x0005EAF0
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TemplateDS templateDS = new TemplateDS();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = templateDS.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = templateDS.GetSchemaSerializable();
			XmlSchemaComplexType result;
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								result = xmlSchemaComplexType;
								return result;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			result = xmlSchemaComplexType;
			return result;
		}

		// Token: 0x040002FA RID: 762
		private TemplateDS.TemplatePropertyDataTable tableTemplateProperty;

		// Token: 0x040002FB RID: 763
		private TemplateDS.FormInfoDataTable tableFormInfo;

		// Token: 0x040002FC RID: 764
		private TemplateDS.FormPropertyDataTable tableFormProperty;

		// Token: 0x040002FD RID: 765
		private TemplateDS.FormRememberFieldDataTable tableFormRememberField;

		// Token: 0x040002FE RID: 766
		private SchemaSerializationMode _schemaSerializationMode;

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060004C5 RID: 1221
		public delegate void TemplatePropertyRowChangeEventHandler(object sender, TemplateDS.TemplatePropertyRowChangeEvent e);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060004C9 RID: 1225
		public delegate void FormInfoRowChangeEventHandler(object sender, TemplateDS.FormInfoRowChangeEvent e);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060004CD RID: 1229
		public delegate void FormPropertyRowChangeEventHandler(object sender, TemplateDS.FormPropertyRowChangeEvent e);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060004D1 RID: 1233
		public delegate void FormRememberFieldRowChangeEventHandler(object sender, TemplateDS.FormRememberFieldRowChangeEvent e);

		// Token: 0x0200006D RID: 109
		[XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[Serializable]
		public class TemplatePropertyDataTable : DataTable, IEnumerable
		{
			// Token: 0x060004D4 RID: 1236 RVA: 0x000608C0 File Offset: 0x0005ECC0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplatePropertyDataTable() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = "TemplateProperty";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00060900 File Offset: 0x0005ED00
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TemplatePropertyDataTable(DataTable table) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060004D6 RID: 1238 RVA: 0x000609E4 File Offset: 0x0005EDE4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected TemplatePropertyDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.InitVars();
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00060A0C File Offset: 0x0005EE0C
			[DebuggerNonUserCode]
			public DataColumn PropertyNameColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnPropertyName;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00060A38 File Offset: 0x0005EE38
			[DebuggerNonUserCode]
			public DataColumn PropertyValueColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnPropertyValue;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00060A64 File Offset: 0x0005EE64
			[DebuggerNonUserCode, Browsable(false)]
			public int Count
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return base.Rows.Count;
				}
			}

			// Token: 0x170000AA RID: 170
			[DebuggerNonUserCode]
			public TemplateDS.TemplatePropertyRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (TemplateDS.TemplatePropertyRow)base.Rows[index];
				}
			}

			// Token: 0x14000015 RID: 21
			// (add) Token: 0x060004DB RID: 1243 RVA: 0x00060AC8 File Offset: 0x0005EEC8
			// (remove) Token: 0x060004DC RID: 1244 RVA: 0x00060AF0 File Offset: 0x0005EEF0
            public TemplateDS.TemplatePropertyRowChangeEventHandler _TemplatePropertyRowChanging;
			public event TemplateDS.TemplatePropertyRowChangeEventHandler TemplatePropertyRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._TemplatePropertyRowChanging += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._TemplatePropertyRowChanging -= value;
				}
			}

			// Token: 0x14000016 RID: 22
			// (add) Token: 0x060004DD RID: 1245 RVA: 0x00060B18 File Offset: 0x0005EF18
			// (remove) Token: 0x060004DE RID: 1246 RVA: 0x00060B40 File Offset: 0x0005EF40
            public TemplateDS.TemplatePropertyRowChangeEventHandler _TemplatePropertyRowChanged;
			public event TemplateDS.TemplatePropertyRowChangeEventHandler TemplatePropertyRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._TemplatePropertyRowChanged += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._TemplatePropertyRowChanged -= value;
				}
			}

			// Token: 0x14000017 RID: 23
			// (add) Token: 0x060004DF RID: 1247 RVA: 0x00060B68 File Offset: 0x0005EF68
			// (remove) Token: 0x060004E0 RID: 1248 RVA: 0x00060B90 File Offset: 0x0005EF90
            public TemplateDS.TemplatePropertyRowChangeEventHandler _TemplatePropertyRowDeleting;
			public event TemplateDS.TemplatePropertyRowChangeEventHandler TemplatePropertyRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					this._TemplatePropertyRowDeleting += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._TemplatePropertyRowDeleting -= value;
				}
			}

			// Token: 0x14000018 RID: 24
			// (add) Token: 0x060004E1 RID: 1249 RVA: 0x00060BB8 File Offset: 0x0005EFB8
			// (remove) Token: 0x060004E2 RID: 1250 RVA: 0x00060BE0 File Offset: 0x0005EFE0
            public TemplateDS.TemplatePropertyRowChangeEventHandler _TemplatePropertyRowDeleted;
			public event TemplateDS.TemplatePropertyRowChangeEventHandler TemplatePropertyRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{

					this._TemplatePropertyRowDeleted += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._TemplatePropertyRowDeleted -= value;
				}
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x00060C08 File Offset: 0x0005F008
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddTemplatePropertyRow(TemplateDS.TemplatePropertyRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x00060C28 File Offset: 0x0005F028
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateDS.TemplatePropertyRow AddTemplatePropertyRow(string PropertyName, string PropertyValue)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateDS.TemplatePropertyRow templatePropertyRow = (TemplateDS.TemplatePropertyRow)base.NewRow();
				object[] itemArray = new object[]
				{
					PropertyName,
					PropertyValue
				};
				templatePropertyRow.ItemArray = itemArray;
				base.Rows.Add(templatePropertyRow);
				return templatePropertyRow;
			}

			// Token: 0x060004E5 RID: 1253 RVA: 0x00060C80 File Offset: 0x0005F080
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual IEnumerator GetEnumerator()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x00060CB0 File Offset: 0x0005F0B0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateDS.TemplatePropertyDataTable templatePropertyDataTable = (TemplateDS.TemplatePropertyDataTable)base.Clone();
				templatePropertyDataTable.InitVars();
				return templatePropertyDataTable;
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x00060CE8 File Offset: 0x0005F0E8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new TemplateDS.TemplatePropertyDataTable();
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x00060D10 File Offset: 0x0005F110
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnPropertyName = base.Columns["PropertyName"];
				this.columnPropertyValue = base.Columns["PropertyValue"];
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x00060D50 File Offset: 0x0005F150
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnPropertyName = new DataColumn("PropertyName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPropertyName);
				this.columnPropertyValue = new DataColumn("PropertyValue", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPropertyValue);
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x00060DC8 File Offset: 0x0005F1C8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateDS.TemplatePropertyRow NewTemplatePropertyRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (TemplateDS.TemplatePropertyRow)base.NewRow();
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x00060DF8 File Offset: 0x0005F1F8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new TemplateDS.TemplatePropertyRow(builder);
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x00060E24 File Offset: 0x0005F224
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(TemplateDS.TemplatePropertyRow);
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x00060E54 File Offset: 0x0005F254
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this._TemplatePropertyRowChanged != null)
				{
					this._TemplatePropertyRowChanged(this, new TemplateDS.TemplatePropertyRowChangeEvent((TemplateDS.TemplatePropertyRow)e.Row, e.Action));
				}
			}

			// Token: 0x060004EE RID: 1262 RVA: 0x00060EB0 File Offset: 0x0005F2B0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this._TemplatePropertyRowChanging != null)
				{
					this._TemplatePropertyRowChanging(this, new TemplateDS.TemplatePropertyRowChangeEvent((TemplateDS.TemplatePropertyRow)e.Row, e.Action));
				}
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x00060F0C File Offset: 0x0005F30C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this._TemplatePropertyRowDeleted != null)
				{
					this._TemplatePropertyRowDeleted(this, new TemplateDS.TemplatePropertyRowChangeEvent((TemplateDS.TemplatePropertyRow)e.Row, e.Action));
				}
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x00060F68 File Offset: 0x0005F368
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this._TemplatePropertyRowDeleting != null)
				{
					this._TemplatePropertyRowDeleting(this, new TemplateDS.TemplatePropertyRowChangeEvent((TemplateDS.TemplatePropertyRow)e.Row, e.Action));
				}
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x00060FC4 File Offset: 0x0005F3C4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveTemplatePropertyRow(TemplateDS.TemplatePropertyRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x00060FE4 File Offset: 0x0005F3E4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				TemplateDS templateDS = new TemplateDS();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = templateDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "TemplatePropertyDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = templateDS.GetSchemaSerializable();
				XmlSchemaComplexType result;
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									result = xmlSchemaComplexType;
									return result;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				result = xmlSchemaComplexType;
				return result;
			}

			// Token: 0x040002FF RID: 767
			private DataColumn columnPropertyName;

			// Token: 0x04000300 RID: 768
			private DataColumn columnPropertyValue;
		}

		// Token: 0x0200006E RID: 110
		[XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[Serializable]
		public class FormInfoDataTable : DataTable, IEnumerable
		{
			// Token: 0x060004F3 RID: 1267 RVA: 0x00061274 File Offset: 0x0005F674
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FormInfoDataTable() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = "FormInfo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060004F4 RID: 1268 RVA: 0x000612B4 File Offset: 0x0005F6B4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal FormInfoDataTable(DataTable table) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060004F5 RID: 1269 RVA: 0x00061398 File Offset: 0x0005F798
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected FormInfoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.InitVars();
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000613C0 File Offset: 0x0005F7C0
			[DebuggerNonUserCode]
			public DataColumn FormIDColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnFormID;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x060004F7 RID: 1271 RVA: 0x000613EC File Offset: 0x0005F7EC
			[DebuggerNonUserCode]
			public DataColumn TypeColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnType;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00061418 File Offset: 0x0005F818
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnName;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00061444 File Offset: 0x0005F844
			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return base.Rows.Count;
				}
			}

			// Token: 0x170000AF RID: 175
			[DebuggerNonUserCode]
			public TemplateDS.FormInfoRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (TemplateDS.FormInfoRow)base.Rows[index];
				}
			}

			// Token: 0x14000019 RID: 25
			// (add) Token: 0x060004FB RID: 1275 RVA: 0x000614A8 File Offset: 0x0005F8A8
			// (remove) Token: 0x060004FC RID: 1276 RVA: 0x000614D0 File Offset: 0x0005F8D0
            public TemplateDS.FormInfoRowChangeEventHandler _FormInfoRowChanging;
			public event TemplateDS.FormInfoRowChangeEventHandler FormInfoRowChanging
			{
                [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
                add
                {
                    this._FormInfoRowChanging += value;
                }

				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormInfoRowChanging -= value;
				}
			}

			// Token: 0x1400001A RID: 26
			// (add) Token: 0x060004FD RID: 1277 RVA: 0x000614F8 File Offset: 0x0005F8F8
			// (remove) Token: 0x060004FE RID: 1278 RVA: 0x00061520 File Offset: 0x0005F920
            public TemplateDS.FormInfoRowChangeEventHandler _FormInfoRowChanged;
			public event TemplateDS.FormInfoRowChangeEventHandler FormInfoRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormInfoRowChanged += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormInfoRowChanged -= value;
				}
			}

			// Token: 0x1400001B RID: 27
			// (add) Token: 0x060004FF RID: 1279 RVA: 0x00061548 File Offset: 0x0005F948
			// (remove) Token: 0x06000500 RID: 1280 RVA: 0x00061570 File Offset: 0x0005F970
            public TemplateDS.FormInfoRowChangeEventHandler _FormInfoRowDeleting;
			public event TemplateDS.FormInfoRowChangeEventHandler FormInfoRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormInfoRowDeleting += value;
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormInfoRowDeleting -= value;
				}
			}

			// Token: 0x1400001C RID: 28
			// (add) Token: 0x06000501 RID: 1281 RVA: 0x00061598 File Offset: 0x0005F998
			// (remove) Token: 0x06000502 RID: 1282 RVA: 0x000615C0 File Offset: 0x0005F9C0
            public TemplateDS.FormInfoRowChangeEventHandler _FormInfoRowDeleted;
			public event TemplateDS.FormInfoRowChangeEventHandler FormInfoRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormInfoRowDeleted += value;
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormInfoRowDeleted -= value;
				}
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x000615E8 File Offset: 0x0005F9E8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddFormInfoRow(TemplateDS.FormInfoRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x00061608 File Offset: 0x0005FA08
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateDS.FormInfoRow AddFormInfoRow(int FormID, string Type, string Name)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateDS.FormInfoRow formInfoRow = (TemplateDS.FormInfoRow)base.NewRow();
				object[] itemArray = new object[]
				{
					FormID,
					Type,
					Name
				};
				formInfoRow.ItemArray = itemArray;
				base.Rows.Add(formInfoRow);
				return formInfoRow;
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x00061668 File Offset: 0x0005FA68
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual IEnumerator GetEnumerator()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000506 RID: 1286 RVA: 0x00061698 File Offset: 0x0005FA98
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateDS.FormInfoDataTable formInfoDataTable = (TemplateDS.FormInfoDataTable)base.Clone();
				formInfoDataTable.InitVars();
				return formInfoDataTable;
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x000616D0 File Offset: 0x0005FAD0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new TemplateDS.FormInfoDataTable();
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x000616F8 File Offset: 0x0005FAF8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnFormID = base.Columns["FormID"];
				this.columnType = base.Columns["Type"];
				this.columnName = base.Columns["Name"];
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x00061758 File Offset: 0x0005FB58
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnFormID = new DataColumn("FormID", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnFormID);
				this.columnType = new DataColumn("Type", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnType);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x00061800 File Offset: 0x0005FC00
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateDS.FormInfoRow NewFormInfoRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (TemplateDS.FormInfoRow)base.NewRow();
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x00061830 File Offset: 0x0005FC30
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new TemplateDS.FormInfoRow(builder);
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x0006185C File Offset: 0x0005FC5C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(TemplateDS.FormInfoRow);
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x0006188C File Offset: 0x0005FC8C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this._FormInfoRowChanged != null)
				{
					this._FormInfoRowChanged(this, new TemplateDS.FormInfoRowChangeEvent((TemplateDS.FormInfoRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x000618E8 File Offset: 0x0005FCE8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this._FormInfoRowChanging != null)
				{
					this._FormInfoRowChanging(this, new TemplateDS.FormInfoRowChangeEvent((TemplateDS.FormInfoRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x00061944 File Offset: 0x0005FD44
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this._FormInfoRowDeleted != null)
				{
					this._FormInfoRowDeleted(this, new TemplateDS.FormInfoRowChangeEvent((TemplateDS.FormInfoRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x000619A0 File Offset: 0x0005FDA0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this._FormInfoRowDeleting != null)
				{
					this._FormInfoRowDeleting(this, new TemplateDS.FormInfoRowChangeEvent((TemplateDS.FormInfoRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x000619FC File Offset: 0x0005FDFC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveFormInfoRow(TemplateDS.FormInfoRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x00061A1C File Offset: 0x0005FE1C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				TemplateDS templateDS = new TemplateDS();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = templateDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "FormInfoDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = templateDS.GetSchemaSerializable();
				XmlSchemaComplexType result;
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									result = xmlSchemaComplexType;
									return result;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				result = xmlSchemaComplexType;
				return result;
			}

			// Token: 0x04000305 RID: 773
			private DataColumn columnFormID;

			// Token: 0x04000306 RID: 774
			private DataColumn columnType;

			// Token: 0x04000307 RID: 775
			private DataColumn columnName;
		}

		// Token: 0x0200006F RID: 111
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class FormPropertyDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000513 RID: 1299 RVA: 0x00061CAC File Offset: 0x000600AC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FormPropertyDataTable() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = "FormProperty";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x00061CEC File Offset: 0x000600EC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal FormPropertyDataTable(DataTable table) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000515 RID: 1301 RVA: 0x00061DD0 File Offset: 0x000601D0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected FormPropertyDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.InitVars();
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000516 RID: 1302 RVA: 0x00061DF8 File Offset: 0x000601F8
			[DebuggerNonUserCode]
			public DataColumn FormIDColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnFormID;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000517 RID: 1303 RVA: 0x00061E24 File Offset: 0x00060224
			[DebuggerNonUserCode]
			public DataColumn PropertyNameColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnPropertyName;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000518 RID: 1304 RVA: 0x00061E50 File Offset: 0x00060250
			[DebuggerNonUserCode]
			public DataColumn PropertyValueColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnPropertyValue;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000519 RID: 1305 RVA: 0x00061E7C File Offset: 0x0006027C
			[DebuggerNonUserCode, Browsable(false)]
			public int Count
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return base.Rows.Count;
				}
			}

			// Token: 0x170000B4 RID: 180
			[DebuggerNonUserCode]
			public TemplateDS.FormPropertyRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (TemplateDS.FormPropertyRow)base.Rows[index];
				}
			}

			// Token: 0x1400001D RID: 29
			// (add) Token: 0x0600051B RID: 1307 RVA: 0x00061EE0 File Offset: 0x000602E0
			// (remove) Token: 0x0600051C RID: 1308 RVA: 0x00061F08 File Offset: 0x00060308
            public TemplateDS.FormPropertyRowChangeEventHandler _FormPropertyRowChanging;
			public event TemplateDS.FormPropertyRowChangeEventHandler FormPropertyRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormPropertyRowChanging += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormPropertyRowChanging -= value;
                }
			}

			// Token: 0x1400001E RID: 30
			// (add) Token: 0x0600051D RID: 1309 RVA: 0x00061F30 File Offset: 0x00060330
			// (remove) Token: 0x0600051E RID: 1310 RVA: 0x00061F58 File Offset: 0x00060358
            public TemplateDS.FormPropertyRowChangeEventHandler _FormPropertyRowChanged;
			public event TemplateDS.FormPropertyRowChangeEventHandler FormPropertyRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormPropertyRowChanged += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormPropertyRowChanged -= value;
				}
			}

			// Token: 0x1400001F RID: 31
			// (add) Token: 0x0600051F RID: 1311 RVA: 0x00061F80 File Offset: 0x00060380
			// (remove) Token: 0x06000520 RID: 1312 RVA: 0x00061FA8 File Offset: 0x000603A8
            public TemplateDS.FormPropertyRowChangeEventHandler _FormPropertyRowDeleting;
			public event TemplateDS.FormPropertyRowChangeEventHandler FormPropertyRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormPropertyRowDeleting += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormPropertyRowDeleting -= value;

                }

			}

			// Token: 0x14000020 RID: 32
			// (add) Token: 0x06000521 RID: 1313 RVA: 0x00061FD0 File Offset: 0x000603D0
			// (remove) Token: 0x06000522 RID: 1314 RVA: 0x00061FF8 File Offset: 0x000603F8
            public TemplateDS.FormPropertyRowChangeEventHandler _FormPropertyRowDeleted;
			public event TemplateDS.FormPropertyRowChangeEventHandler FormPropertyRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormPropertyRowDeleted += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormPropertyRowDeleted -= value;
				}
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x00062020 File Offset: 0x00060420
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddFormPropertyRow(TemplateDS.FormPropertyRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x00062040 File Offset: 0x00060440
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateDS.FormPropertyRow AddFormPropertyRow(int FormID, string PropertyName, string PropertyValue)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateDS.FormPropertyRow formPropertyRow = (TemplateDS.FormPropertyRow)base.NewRow();
				object[] itemArray = new object[]
				{
					FormID,
					PropertyName,
					PropertyValue
				};
				formPropertyRow.ItemArray = itemArray;
				base.Rows.Add(formPropertyRow);
				return formPropertyRow;
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x000620A0 File Offset: 0x000604A0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual IEnumerator GetEnumerator()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x000620D0 File Offset: 0x000604D0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateDS.FormPropertyDataTable formPropertyDataTable = (TemplateDS.FormPropertyDataTable)base.Clone();
				formPropertyDataTable.InitVars();
				return formPropertyDataTable;
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x00062108 File Offset: 0x00060508
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new TemplateDS.FormPropertyDataTable();
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x00062130 File Offset: 0x00060530
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnFormID = base.Columns["FormID"];
				this.columnPropertyName = base.Columns["PropertyName"];
				this.columnPropertyValue = base.Columns["PropertyValue"];
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x00062190 File Offset: 0x00060590
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnFormID = new DataColumn("FormID", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnFormID);
				this.columnPropertyName = new DataColumn("PropertyName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPropertyName);
				this.columnPropertyValue = new DataColumn("PropertyValue", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPropertyValue);
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x00062238 File Offset: 0x00060638
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateDS.FormPropertyRow NewFormPropertyRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (TemplateDS.FormPropertyRow)base.NewRow();
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x00062268 File Offset: 0x00060668
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new TemplateDS.FormPropertyRow(builder);
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x00062294 File Offset: 0x00060694
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(TemplateDS.FormPropertyRow);
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x000622C4 File Offset: 0x000606C4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this._FormPropertyRowChanged != null)
				{
					this._FormPropertyRowChanged(this, new TemplateDS.FormPropertyRowChangeEvent((TemplateDS.FormPropertyRow)e.Row, e.Action));
				}   
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x00062320 File Offset: 0x00060720
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this._FormPropertyRowChanging != null)
				{
					this._FormPropertyRowChanging(this, new TemplateDS.FormPropertyRowChangeEvent((TemplateDS.FormPropertyRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x0006237C File Offset: 0x0006077C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this._FormPropertyRowDeleted != null)
				{
					this._FormPropertyRowDeleted(this, new TemplateDS.FormPropertyRowChangeEvent((TemplateDS.FormPropertyRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x000623D8 File Offset: 0x000607D8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this._FormPropertyRowDeleting != null)
				{
					this._FormPropertyRowDeleting(this, new TemplateDS.FormPropertyRowChangeEvent((TemplateDS.FormPropertyRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x00062434 File Offset: 0x00060834
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveFormPropertyRow(TemplateDS.FormPropertyRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x00062454 File Offset: 0x00060854
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				TemplateDS templateDS = new TemplateDS();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = templateDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "FormPropertyDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = templateDS.GetSchemaSerializable();
				XmlSchemaComplexType result;
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									result = xmlSchemaComplexType;
									return result;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				result = xmlSchemaComplexType;
				return result;
			}

			// Token: 0x0400030C RID: 780
			private DataColumn columnFormID;

			// Token: 0x0400030D RID: 781
			private DataColumn columnPropertyName;

			// Token: 0x0400030E RID: 782
			private DataColumn columnPropertyValue;
		}

		// Token: 0x02000070 RID: 112
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class FormRememberFieldDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000533 RID: 1331 RVA: 0x000626E4 File Offset: 0x00060AE4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FormRememberFieldDataTable() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = "FormRememberField";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x00062724 File Offset: 0x00060B24
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal FormRememberFieldDataTable(DataTable table) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00062808 File Offset: 0x00060C08
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected FormRememberFieldDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.InitVars();
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000536 RID: 1334 RVA: 0x00062830 File Offset: 0x00060C30
			[DebuggerNonUserCode]
			public DataColumn FormIDColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnFormID;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000537 RID: 1335 RVA: 0x0006285C File Offset: 0x00060C5C
			[DebuggerNonUserCode]
			public DataColumn FieldNameColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnFieldName;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000538 RID: 1336 RVA: 0x00062888 File Offset: 0x00060C88
			[DebuggerNonUserCode]
			public DataColumn FieldValueColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnFieldValue;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000539 RID: 1337 RVA: 0x000628B4 File Offset: 0x00060CB4
			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return base.Rows.Count;
				}
			}

			// Token: 0x170000B9 RID: 185
			[DebuggerNonUserCode]
			public TemplateDS.FormRememberFieldRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (TemplateDS.FormRememberFieldRow)base.Rows[index];
				}
			}

			// Token: 0x14000021 RID: 33
			// (add) Token: 0x0600053B RID: 1339 RVA: 0x00062918 File Offset: 0x00060D18
			// (remove) Token: 0x0600053C RID: 1340 RVA: 0x00062940 File Offset: 0x00060D40
            public TemplateDS.FormRememberFieldRowChangeEventHandler _FormRememberFieldRowChanging;
			public event TemplateDS.FormRememberFieldRowChangeEventHandler FormRememberFieldRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormRememberFieldRowChanging += value;
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormRememberFieldRowChanging -= value;
                }
			}

			// Token: 0x14000022 RID: 34
			// (add) Token: 0x0600053D RID: 1341 RVA: 0x00062968 File Offset: 0x00060D68
			// (remove) Token: 0x0600053E RID: 1342 RVA: 0x00062990 File Offset: 0x00060D90
            public TemplateDS.FormRememberFieldRowChangeEventHandler _FormRememberFieldRowChanged;
			public event TemplateDS.FormRememberFieldRowChangeEventHandler FormRememberFieldRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormRememberFieldRowChanged += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormRememberFieldRowChanged -= value;
                }
			}

			// Token: 0x14000023 RID: 35
			// (add) Token: 0x0600053F RID: 1343 RVA: 0x000629B8 File Offset: 0x00060DB8
			// (remove) Token: 0x06000540 RID: 1344 RVA: 0x000629E0 File Offset: 0x00060DE0
            public TemplateDS.FormRememberFieldRowChangeEventHandler _FormRememberFieldRowDeleting;
			public event TemplateDS.FormRememberFieldRowChangeEventHandler FormRememberFieldRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormRememberFieldRowDeleting += value;
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormRememberFieldRowDeleting -= value;
                }
			}

			// Token: 0x14000024 RID: 36
			// (add) Token: 0x06000541 RID: 1345 RVA: 0x00062A08 File Offset: 0x00060E08
			// (remove) Token: 0x06000542 RID: 1346 RVA: 0x00062A30 File Offset: 0x00060E30
            public TemplateDS.FormRememberFieldRowChangeEventHandler _FormRememberFieldRowDeleted;
            public event TemplateDS.FormRememberFieldRowChangeEventHandler FormRememberFieldRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._FormRememberFieldRowDeleted += value;

                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._FormRememberFieldRowDeleted -= value;
                }
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x00062A58 File Offset: 0x00060E58
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddFormRememberFieldRow(TemplateDS.FormRememberFieldRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x00062A78 File Offset: 0x00060E78
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateDS.FormRememberFieldRow AddFormRememberFieldRow(int FormID, string FieldName, string FieldValue)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateDS.FormRememberFieldRow formRememberFieldRow = (TemplateDS.FormRememberFieldRow)base.NewRow();
				object[] itemArray = new object[]
				{
					FormID,
					FieldName,
					FieldValue
				};
				formRememberFieldRow.ItemArray = itemArray;
				base.Rows.Add(formRememberFieldRow);
				return formRememberFieldRow;
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x00062AD8 File Offset: 0x00060ED8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual IEnumerator GetEnumerator()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x00062B08 File Offset: 0x00060F08
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				TemplateDS.FormRememberFieldDataTable formRememberFieldDataTable = (TemplateDS.FormRememberFieldDataTable)base.Clone();
				formRememberFieldDataTable.InitVars();
				return formRememberFieldDataTable;
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x00062B40 File Offset: 0x00060F40
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new TemplateDS.FormRememberFieldDataTable();
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x00062B68 File Offset: 0x00060F68
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnFormID = base.Columns["FormID"];
				this.columnFieldName = base.Columns["FieldName"];
				this.columnFieldValue = base.Columns["FieldValue"];
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x00062BC8 File Offset: 0x00060FC8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnFormID = new DataColumn("FormID", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnFormID);
				this.columnFieldName = new DataColumn("FieldName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFieldName);
				this.columnFieldValue = new DataColumn("FieldValue", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFieldValue);
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x00062C70 File Offset: 0x00061070
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateDS.FormRememberFieldRow NewFormRememberFieldRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (TemplateDS.FormRememberFieldRow)base.NewRow();
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x00062CA0 File Offset: 0x000610A0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new TemplateDS.FormRememberFieldRow(builder);
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x00062CCC File Offset: 0x000610CC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(TemplateDS.FormRememberFieldRow);
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x00062CFC File Offset: 0x000610FC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this._FormRememberFieldRowChanged != null)
				{
					this._FormRememberFieldRowChanged(this, new TemplateDS.FormRememberFieldRowChangeEvent((TemplateDS.FormRememberFieldRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600054E RID: 1358 RVA: 0x00062D58 File Offset: 0x00061158
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this._FormRememberFieldRowChanging != null)
				{
					this._FormRememberFieldRowChanging(this, new TemplateDS.FormRememberFieldRowChangeEvent((TemplateDS.FormRememberFieldRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600054F RID: 1359 RVA: 0x00062DB4 File Offset: 0x000611B4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this._FormRememberFieldRowDeleted != null)
				{
					this._FormRememberFieldRowDeleted(this, new TemplateDS.FormRememberFieldRowChangeEvent((TemplateDS.FormRememberFieldRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x00062E10 File Offset: 0x00061210
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this._FormRememberFieldRowDeleting != null)
				{
					this._FormRememberFieldRowDeleting(this, new TemplateDS.FormRememberFieldRowChangeEvent((TemplateDS.FormRememberFieldRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x00062E6C File Offset: 0x0006126C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveFormRememberFieldRow(TemplateDS.FormRememberFieldRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x06000552 RID: 1362 RVA: 0x00062E8C File Offset: 0x0006128C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				TemplateDS templateDS = new TemplateDS();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = templateDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "FormRememberFieldDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = templateDS.GetSchemaSerializable();
				XmlSchemaComplexType result;
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									result = xmlSchemaComplexType;
									return result;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				result = xmlSchemaComplexType;
				return result;
			}

			// Token: 0x04000313 RID: 787
			private DataColumn columnFormID;

			// Token: 0x04000314 RID: 788
			private DataColumn columnFieldName;

			// Token: 0x04000315 RID: 789
			private DataColumn columnFieldValue;
		}

		// Token: 0x02000071 RID: 113
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class TemplatePropertyRow : DataRow
		{
			// Token: 0x06000553 RID: 1363 RVA: 0x0006311C File Offset: 0x0006151C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TemplatePropertyRow(DataRowBuilder rb) : base(rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.tableTemplateProperty = (TemplateDS.TemplatePropertyDataTable)base.Table;
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000554 RID: 1364 RVA: 0x0006314C File Offset: 0x0006154C
			// (set) Token: 0x06000555 RID: 1365 RVA: 0x000631A8 File Offset: 0x000615A8
			[DebuggerNonUserCode]
			public string PropertyName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableTemplateProperty.PropertyNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PropertyName' in table 'TemplateProperty' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableTemplateProperty.PropertyNameColumn] = value;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000556 RID: 1366 RVA: 0x000631CC File Offset: 0x000615CC
			// (set) Token: 0x06000557 RID: 1367 RVA: 0x00063228 File Offset: 0x00061628
			[DebuggerNonUserCode]
			public string PropertyValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableTemplateProperty.PropertyValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PropertyValue' in table 'TemplateProperty' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableTemplateProperty.PropertyValueColumn] = value;
				}
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x0006324C File Offset: 0x0006164C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsPropertyNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateProperty.PropertyNameColumn);
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x00063280 File Offset: 0x00061680
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetPropertyNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateProperty.PropertyNameColumn] = Convert.DBNull;
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x000632A8 File Offset: 0x000616A8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsPropertyValueNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateProperty.PropertyValueColumn);
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x000632DC File Offset: 0x000616DC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetPropertyValueNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateProperty.PropertyValueColumn] = Convert.DBNull;
			}

			// Token: 0x0400031A RID: 794
			private TemplateDS.TemplatePropertyDataTable tableTemplateProperty;
		}

		// Token: 0x02000072 RID: 114
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class FormInfoRow : DataRow
		{
			// Token: 0x0600055C RID: 1372 RVA: 0x00063304 File Offset: 0x00061704
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal FormInfoRow(DataRowBuilder rb) : base(rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.tableFormInfo = (TemplateDS.FormInfoDataTable)base.Table;
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x0600055D RID: 1373 RVA: 0x00063334 File Offset: 0x00061734
			// (set) Token: 0x0600055E RID: 1374 RVA: 0x00063390 File Offset: 0x00061790
			[DebuggerNonUserCode]
			public int FormID
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					int result;
					try
					{
						result = (int)base[this.tableFormInfo.FormIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FormID' in table 'FormInfo' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormInfo.FormIDColumn] = value;
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x0600055F RID: 1375 RVA: 0x000633BC File Offset: 0x000617BC
			// (set) Token: 0x06000560 RID: 1376 RVA: 0x00063418 File Offset: 0x00061818
			[DebuggerNonUserCode]
			public string Type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableFormInfo.TypeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Type' in table 'FormInfo' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormInfo.TypeColumn] = value;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x06000561 RID: 1377 RVA: 0x0006343C File Offset: 0x0006183C
			// (set) Token: 0x06000562 RID: 1378 RVA: 0x00063498 File Offset: 0x00061898
			[DebuggerNonUserCode]
			public string Name
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableFormInfo.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'FormInfo' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormInfo.NameColumn] = value;
				}
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x000634BC File Offset: 0x000618BC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsFormIDNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormInfo.FormIDColumn);
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x000634F0 File Offset: 0x000618F0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetFormIDNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormInfo.FormIDColumn] = Convert.DBNull;
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x00063518 File Offset: 0x00061918
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsTypeNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormInfo.TypeColumn);
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0006354C File Offset: 0x0006194C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetTypeNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormInfo.TypeColumn] = Convert.DBNull;
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00063574 File Offset: 0x00061974
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormInfo.NameColumn);
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x000635A8 File Offset: 0x000619A8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormInfo.NameColumn] = Convert.DBNull;
			}

			// Token: 0x0400031B RID: 795
			private TemplateDS.FormInfoDataTable tableFormInfo;
		}

		// Token: 0x02000073 RID: 115
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class FormPropertyRow : DataRow
		{
			// Token: 0x06000569 RID: 1385 RVA: 0x000635D0 File Offset: 0x000619D0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal FormPropertyRow(DataRowBuilder rb) : base(rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.tableFormProperty = (TemplateDS.FormPropertyDataTable)base.Table;
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x00063600 File Offset: 0x00061A00
			// (set) Token: 0x0600056B RID: 1387 RVA: 0x0006365C File Offset: 0x00061A5C
			[DebuggerNonUserCode]
			public int FormID
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					int result;
					try
					{
						result = (int)base[this.tableFormProperty.FormIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FormID' in table 'FormProperty' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormProperty.FormIDColumn] = value;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x0600056C RID: 1388 RVA: 0x00063688 File Offset: 0x00061A88
			// (set) Token: 0x0600056D RID: 1389 RVA: 0x000636E4 File Offset: 0x00061AE4
			[DebuggerNonUserCode]
			public string PropertyName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableFormProperty.PropertyNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PropertyName' in table 'FormProperty' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormProperty.PropertyNameColumn] = value;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x0600056E RID: 1390 RVA: 0x00063708 File Offset: 0x00061B08
			// (set) Token: 0x0600056F RID: 1391 RVA: 0x00063764 File Offset: 0x00061B64
			[DebuggerNonUserCode]
			public string PropertyValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableFormProperty.PropertyValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PropertyValue' in table 'FormProperty' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormProperty.PropertyValueColumn] = value;
				}
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00063788 File Offset: 0x00061B88
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsFormIDNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormProperty.FormIDColumn);
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x000637BC File Offset: 0x00061BBC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetFormIDNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormProperty.FormIDColumn] = Convert.DBNull;
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x000637E4 File Offset: 0x00061BE4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsPropertyNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormProperty.PropertyNameColumn);
			}

			// Token: 0x06000573 RID: 1395 RVA: 0x00063818 File Offset: 0x00061C18
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetPropertyNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormProperty.PropertyNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x00063840 File Offset: 0x00061C40
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsPropertyValueNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormProperty.PropertyValueColumn);
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x00063874 File Offset: 0x00061C74
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetPropertyValueNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormProperty.PropertyValueColumn] = Convert.DBNull;
			}

			// Token: 0x0400031C RID: 796
			private TemplateDS.FormPropertyDataTable tableFormProperty;
		}

		// Token: 0x02000074 RID: 116
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class FormRememberFieldRow : DataRow
		{
			// Token: 0x06000576 RID: 1398 RVA: 0x0006389C File Offset: 0x00061C9C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal FormRememberFieldRow(DataRowBuilder rb) : base(rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.tableFormRememberField = (TemplateDS.FormRememberFieldDataTable)base.Table;
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000577 RID: 1399 RVA: 0x000638CC File Offset: 0x00061CCC
			// (set) Token: 0x06000578 RID: 1400 RVA: 0x00063928 File Offset: 0x00061D28
			[DebuggerNonUserCode]
			public int FormID
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					int result;
					try
					{
						result = (int)base[this.tableFormRememberField.FormIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FormID' in table 'FormRememberField' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormRememberField.FormIDColumn] = value;
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x00063954 File Offset: 0x00061D54
			// (set) Token: 0x0600057A RID: 1402 RVA: 0x000639B0 File Offset: 0x00061DB0
			[DebuggerNonUserCode]
			public string FieldName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableFormRememberField.FieldNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FieldName' in table 'FormRememberField' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormRememberField.FieldNameColumn] = value;
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x0600057B RID: 1403 RVA: 0x000639D4 File Offset: 0x00061DD4
			// (set) Token: 0x0600057C RID: 1404 RVA: 0x00063A30 File Offset: 0x00061E30
			[DebuggerNonUserCode]
			public string FieldValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableFormRememberField.FieldValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FieldValue' in table 'FormRememberField' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableFormRememberField.FieldValueColumn] = value;
				}
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x00063A54 File Offset: 0x00061E54
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsFormIDNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormRememberField.FormIDColumn);
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x00063A88 File Offset: 0x00061E88
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetFormIDNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormRememberField.FormIDColumn] = Convert.DBNull;
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x00063AB0 File Offset: 0x00061EB0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsFieldNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormRememberField.FieldNameColumn);
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x00063AE4 File Offset: 0x00061EE4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetFieldNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormRememberField.FieldNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x00063B0C File Offset: 0x00061F0C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsFieldValueNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableFormRememberField.FieldValueColumn);
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x00063B40 File Offset: 0x00061F40
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetFieldValueNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableFormRememberField.FieldValueColumn] = Convert.DBNull;
			}

			// Token: 0x0400031D RID: 797
			private TemplateDS.FormRememberFieldDataTable tableFormRememberField;
		}

		// Token: 0x02000075 RID: 117
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class TemplatePropertyRowChangeEvent : EventArgs
		{
			// Token: 0x06000583 RID: 1411 RVA: 0x00063B68 File Offset: 0x00061F68
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplatePropertyRowChangeEvent(TemplateDS.TemplatePropertyRow row, DataRowAction action) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000584 RID: 1412 RVA: 0x00063B94 File Offset: 0x00061F94
			[DebuggerNonUserCode]
			public TemplateDS.TemplatePropertyRow Row
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventRow;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000585 RID: 1413 RVA: 0x00063BC0 File Offset: 0x00061FC0
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventAction;
				}
			}

			// Token: 0x0400031E RID: 798
			private TemplateDS.TemplatePropertyRow eventRow;

			// Token: 0x0400031F RID: 799
			private DataRowAction eventAction;
		}

		// Token: 0x02000076 RID: 118
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class FormInfoRowChangeEvent : EventArgs
		{
			// Token: 0x06000586 RID: 1414 RVA: 0x00063BEC File Offset: 0x00061FEC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FormInfoRowChangeEvent(TemplateDS.FormInfoRow row, DataRowAction action) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000587 RID: 1415 RVA: 0x00063C18 File Offset: 0x00062018
			[DebuggerNonUserCode]
			public TemplateDS.FormInfoRow Row
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventRow;
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000588 RID: 1416 RVA: 0x00063C44 File Offset: 0x00062044
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventAction;
				}
			}

			// Token: 0x04000320 RID: 800
			private TemplateDS.FormInfoRow eventRow;

			// Token: 0x04000321 RID: 801
			private DataRowAction eventAction;
		}

		// Token: 0x02000077 RID: 119
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class FormPropertyRowChangeEvent : EventArgs
		{
			// Token: 0x06000589 RID: 1417 RVA: 0x00063C70 File Offset: 0x00062070
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FormPropertyRowChangeEvent(TemplateDS.FormPropertyRow row, DataRowAction action) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x0600058A RID: 1418 RVA: 0x00063C9C File Offset: 0x0006209C
			[DebuggerNonUserCode]
			public TemplateDS.FormPropertyRow Row
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventRow;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x0600058B RID: 1419 RVA: 0x00063CC8 File Offset: 0x000620C8
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventAction;
				}
			}

			// Token: 0x04000322 RID: 802
			private TemplateDS.FormPropertyRow eventRow;

			// Token: 0x04000323 RID: 803
			private DataRowAction eventAction;
		}

		// Token: 0x02000078 RID: 120
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class FormRememberFieldRowChangeEvent : EventArgs
		{
			// Token: 0x0600058C RID: 1420 RVA: 0x00063CF4 File Offset: 0x000620F4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FormRememberFieldRowChangeEvent(TemplateDS.FormRememberFieldRow row, DataRowAction action) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x0600058D RID: 1421 RVA: 0x00063D20 File Offset: 0x00062120
			[DebuggerNonUserCode]
			public TemplateDS.FormRememberFieldRow Row
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventRow;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x0600058E RID: 1422 RVA: 0x00063D4C File Offset: 0x0006214C
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventAction;
				}
			}

			// Token: 0x04000324 RID: 804
			private TemplateDS.FormRememberFieldRow eventRow;

			// Token: 0x04000325 RID: 805
			private DataRowAction eventAction;
		}
	}
}
