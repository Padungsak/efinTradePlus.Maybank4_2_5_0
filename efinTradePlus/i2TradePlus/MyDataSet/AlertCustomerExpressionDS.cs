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
	// Token: 0x0200021D RID: 541
	[ToolboxItem(true), XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code"), HelpKeyword("vs.data.DataSet"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlRoot("AlertCustomerExpressionDS")]
	[Serializable]
	public class AlertCustomerExpressionDS : DataSet
	{
		// Token: 0x06001321 RID: 4897 RVA: 0x000FA244 File Offset: 0x000F8644
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlertCustomerExpressionDS()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base..ctor();
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000FA2B0 File Offset: 0x000F86B0
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected AlertCustomerExpressionDS(SerializationInfo info, StreamingContext context)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base..ctor(info, context, false);
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
					if (dataSet.Tables["AlertCollection"] != null)
					{
						base.Tables.Add(new AlertCustomerExpressionDS.AlertCollectionDataTable(dataSet.Tables["AlertCollection"]));
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x000FA460 File Offset: 0x000F8860
		[DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
		public AlertCustomerExpressionDS.AlertCollectionDataTable AlertCollection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableAlertCollection;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x000FA48C File Offset: 0x000F888C
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x000FA4B8 File Offset: 0x000F88B8
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

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x000FA4D0 File Offset: 0x000F88D0
		[DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x000FA4FC File Offset: 0x000F88FC
		[DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06001328 RID: 4904 RVA: 0x000FA528 File Offset: 0x000F8928
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

		// Token: 0x06001329 RID: 4905 RVA: 0x000FA550 File Offset: 0x000F8950
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DataSet Clone()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			AlertCustomerExpressionDS alertCustomerExpressionDS = (AlertCustomerExpressionDS)base.Clone();
			alertCustomerExpressionDS.InitVars();
			alertCustomerExpressionDS.SchemaSerializationMode = this.SchemaSerializationMode;
			return alertCustomerExpressionDS;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x000FA594 File Offset: 0x000F8994
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

		// Token: 0x0600132B RID: 4907 RVA: 0x000FA5B8 File Offset: 0x000F89B8
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

		// Token: 0x0600132C RID: 4908 RVA: 0x000FA5DC File Offset: 0x000F89DC
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
				if (dataSet.Tables["AlertCollection"] != null)
				{
					base.Tables.Add(new AlertCustomerExpressionDS.AlertCollectionDataTable(dataSet.Tables["AlertCollection"]));
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

		// Token: 0x0600132D RID: 4909 RVA: 0x000FA6D8 File Offset: 0x000F8AD8
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

		// Token: 0x0600132E RID: 4910 RVA: 0x000FA724 File Offset: 0x000F8B24
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

		// Token: 0x0600132F RID: 4911 RVA: 0x000FA740 File Offset: 0x000F8B40
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InitVars(bool initTable)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tableAlertCollection = (AlertCustomerExpressionDS.AlertCollectionDataTable)base.Tables["AlertCollection"];
			if (initTable)
			{
				if (this.tableAlertCollection != null)
				{
					this.tableAlertCollection.InitVars();
				}
			}
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x000FA7A4 File Offset: 0x000F8BA4
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitClass()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.DataSetName = "AlertCustomerExpressionDS";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/AlertCustomerExpressionDS.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableAlertCollection = new AlertCustomerExpressionDS.AlertCollectionDataTable();
			base.Tables.Add(this.tableAlertCollection);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x000FA814 File Offset: 0x000F8C14
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeAlertCollection()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000FA838 File Offset: 0x000F8C38
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

		// Token: 0x06001333 RID: 4915 RVA: 0x000FA870 File Offset: 0x000F8C70
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			AlertCustomerExpressionDS alertCustomerExpressionDS = new AlertCustomerExpressionDS();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = alertCustomerExpressionDS.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = alertCustomerExpressionDS.GetSchemaSerializable();
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

		// Token: 0x040009F2 RID: 2546
		private AlertCustomerExpressionDS.AlertCollectionDataTable tableAlertCollection;

		// Token: 0x040009F3 RID: 2547
		private SchemaSerializationMode _schemaSerializationMode;

		// Token: 0x0200021E RID: 542
		// (Invoke) Token: 0x06001335 RID: 4917
		public delegate void AlertCollectionRowChangeEventHandler(object sender, AlertCustomerExpressionDS.AlertCollectionRowChangeEvent e);

		// Token: 0x0200021F RID: 543
		[XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[Serializable]
		public class AlertCollectionDataTable : DataTable, IEnumerable
		{
			// Token: 0x06001338 RID: 4920 RVA: 0x000FAA40 File Offset: 0x000F8E40
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AlertCollectionDataTable()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				base..ctor();
				base.TableName = "AlertCollection";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001339 RID: 4921 RVA: 0x000FAA80 File Offset: 0x000F8E80
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal AlertCollectionDataTable(DataTable table)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				base..ctor();
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

			// Token: 0x0600133A RID: 4922 RVA: 0x000FAB64 File Offset: 0x000F8F64
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected AlertCollectionDataTable(SerializationInfo info, StreamingContext context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				base..ctor(info, context);
				this.InitVars();
			}

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x0600133B RID: 4923 RVA: 0x000FAB8C File Offset: 0x000F8F8C
			[DebuggerNonUserCode]
			public DataColumn SymbolColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnSymbol;
				}
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x0600133C RID: 4924 RVA: 0x000FABB8 File Offset: 0x000F8FB8
			[DebuggerNonUserCode]
			public DataColumn ValuesColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnValues;
				}
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x0600133D RID: 4925 RVA: 0x000FABE4 File Offset: 0x000F8FE4
			[DebuggerNonUserCode]
			public DataColumn OperatorColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnOperator;
				}
			}

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x0600133E RID: 4926 RVA: 0x000FAC10 File Offset: 0x000F9010
			[DebuggerNonUserCode]
			public DataColumn ColumnsAlertColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnColumnsAlert;
				}
			}

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x0600133F RID: 4927 RVA: 0x000FAC3C File Offset: 0x000F903C
			[DebuggerNonUserCode]
			public DataColumn IsFirstTimeOnlyColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnIsFirstTimeOnly;
				}
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x06001340 RID: 4928 RVA: 0x000FAC68 File Offset: 0x000F9068
			[DebuggerNonUserCode]
			public DataColumn IsPrepareOrderColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnIsPrepareOrder;
				}
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x06001341 RID: 4929 RVA: 0x000FAC94 File Offset: 0x000F9094
			[DebuggerNonUserCode]
			public DataColumn OrderParamColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnOrderParam;
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x06001342 RID: 4930 RVA: 0x000FACC0 File Offset: 0x000F90C0
			[DebuggerNonUserCode]
			public DataColumn AlertTimeColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnAlertTime;
				}
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x06001343 RID: 4931 RVA: 0x000FACEC File Offset: 0x000F90EC
			[DebuggerNonUserCode]
			public DataColumn AlertValueColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnAlertValue;
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x06001344 RID: 4932 RVA: 0x000FAD18 File Offset: 0x000F9118
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

			// Token: 0x1700025F RID: 607
			[DebuggerNonUserCode]
			public AlertCustomerExpressionDS.AlertCollectionRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (AlertCustomerExpressionDS.AlertCollectionRow)base.Rows[index];
				}
			}

			// Token: 0x140000C8 RID: 200
			// (add) Token: 0x06001346 RID: 4934 RVA: 0x000FAD7C File Offset: 0x000F917C
			// (remove) Token: 0x06001347 RID: 4935 RVA: 0x000FADA4 File Offset: 0x000F91A4
			public event AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler AlertCollectionRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.AlertCollectionRowChanging = (AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler)Delegate.Combine(this.AlertCollectionRowChanging, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.AlertCollectionRowChanging = (AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler)Delegate.Remove(this.AlertCollectionRowChanging, value);
				}
			}

			// Token: 0x140000C9 RID: 201
			// (add) Token: 0x06001348 RID: 4936 RVA: 0x000FADCC File Offset: 0x000F91CC
			// (remove) Token: 0x06001349 RID: 4937 RVA: 0x000FADF4 File Offset: 0x000F91F4
			public event AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler AlertCollectionRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.AlertCollectionRowChanged = (AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler)Delegate.Combine(this.AlertCollectionRowChanged, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.AlertCollectionRowChanged = (AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler)Delegate.Remove(this.AlertCollectionRowChanged, value);
				}
			}

			// Token: 0x140000CA RID: 202
			// (add) Token: 0x0600134A RID: 4938 RVA: 0x000FAE1C File Offset: 0x000F921C
			// (remove) Token: 0x0600134B RID: 4939 RVA: 0x000FAE44 File Offset: 0x000F9244
			public event AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler AlertCollectionRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.AlertCollectionRowDeleting = (AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler)Delegate.Combine(this.AlertCollectionRowDeleting, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.AlertCollectionRowDeleting = (AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler)Delegate.Remove(this.AlertCollectionRowDeleting, value);
				}
			}

			// Token: 0x140000CB RID: 203
			// (add) Token: 0x0600134C RID: 4940 RVA: 0x000FAE6C File Offset: 0x000F926C
			// (remove) Token: 0x0600134D RID: 4941 RVA: 0x000FAE94 File Offset: 0x000F9294
			public event AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler AlertCollectionRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.AlertCollectionRowDeleted = (AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler)Delegate.Combine(this.AlertCollectionRowDeleted, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.AlertCollectionRowDeleted = (AlertCustomerExpressionDS.AlertCollectionRowChangeEventHandler)Delegate.Remove(this.AlertCollectionRowDeleted, value);
				}
			}

			// Token: 0x0600134E RID: 4942 RVA: 0x000FAEBC File Offset: 0x000F92BC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddAlertCollectionRow(AlertCustomerExpressionDS.AlertCollectionRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x0600134F RID: 4943 RVA: 0x000FAEDC File Offset: 0x000F92DC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AlertCustomerExpressionDS.AlertCollectionRow AddAlertCollectionRow(string Symbol, string Values, string Operator, string ColumnsAlert, bool IsFirstTimeOnly, bool IsPrepareOrder, string OrderParam, string AlertTime, string AlertValue)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				AlertCustomerExpressionDS.AlertCollectionRow alertCollectionRow = (AlertCustomerExpressionDS.AlertCollectionRow)base.NewRow();
				object[] itemArray = new object[]
				{
					Symbol,
					Values,
					Operator,
					ColumnsAlert,
					IsFirstTimeOnly,
					IsPrepareOrder,
					OrderParam,
					AlertTime,
					AlertValue
				};
				alertCollectionRow.ItemArray = itemArray;
				base.Rows.Add(alertCollectionRow);
				return alertCollectionRow;
			}

			// Token: 0x06001350 RID: 4944 RVA: 0x000FAF60 File Offset: 0x000F9360
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

			// Token: 0x06001351 RID: 4945 RVA: 0x000FAF90 File Offset: 0x000F9390
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				AlertCustomerExpressionDS.AlertCollectionDataTable alertCollectionDataTable = (AlertCustomerExpressionDS.AlertCollectionDataTable)base.Clone();
				alertCollectionDataTable.InitVars();
				return alertCollectionDataTable;
			}

			// Token: 0x06001352 RID: 4946 RVA: 0x000FAFC8 File Offset: 0x000F93C8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new AlertCustomerExpressionDS.AlertCollectionDataTable();
			}

			// Token: 0x06001353 RID: 4947 RVA: 0x000FAFF0 File Offset: 0x000F93F0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnSymbol = base.Columns["Symbol"];
				this.columnValues = base.Columns["Values"];
				this.columnOperator = base.Columns["Operator"];
				this.columnColumnsAlert = base.Columns["ColumnsAlert"];
				this.columnIsFirstTimeOnly = base.Columns["IsFirstTimeOnly"];
				this.columnIsPrepareOrder = base.Columns["IsPrepareOrder"];
				this.columnOrderParam = base.Columns["OrderParam"];
				this.columnAlertTime = base.Columns["AlertTime"];
				this.columnAlertValue = base.Columns["AlertValue"];
			}

			// Token: 0x06001354 RID: 4948 RVA: 0x000FB0D4 File Offset: 0x000F94D4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnSymbol = new DataColumn("Symbol", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSymbol);
				this.columnValues = new DataColumn("Values", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValues);
				this.columnOperator = new DataColumn("Operator", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOperator);
				this.columnColumnsAlert = new DataColumn("ColumnsAlert", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumnsAlert);
				this.columnIsFirstTimeOnly = new DataColumn("IsFirstTimeOnly", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnIsFirstTimeOnly);
				this.columnIsPrepareOrder = new DataColumn("IsPrepareOrder", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnIsPrepareOrder);
				this.columnOrderParam = new DataColumn("OrderParam", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrderParam);
				this.columnAlertTime = new DataColumn("AlertTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAlertTime);
				this.columnAlertValue = new DataColumn("AlertValue", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAlertValue);
				this.columnSymbol.DefaultValue = "";
				this.columnValues.DefaultValue = "";
				this.columnOperator.DefaultValue = "";
				this.columnColumnsAlert.DefaultValue = "";
				this.columnIsFirstTimeOnly.DefaultValue = false;
				this.columnIsPrepareOrder.AllowDBNull = false;
				this.columnIsPrepareOrder.DefaultValue = false;
				this.columnOrderParam.AllowDBNull = false;
				this.columnOrderParam.DefaultValue = "";
				this.columnAlertTime.DefaultValue = "";
				this.columnAlertValue.DefaultValue = "";
			}

			// Token: 0x06001355 RID: 4949 RVA: 0x000FB344 File Offset: 0x000F9744
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AlertCustomerExpressionDS.AlertCollectionRow NewAlertCollectionRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (AlertCustomerExpressionDS.AlertCollectionRow)base.NewRow();
			}

			// Token: 0x06001356 RID: 4950 RVA: 0x000FB374 File Offset: 0x000F9774
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new AlertCustomerExpressionDS.AlertCollectionRow(builder);
			}

			// Token: 0x06001357 RID: 4951 RVA: 0x000FB3A0 File Offset: 0x000F97A0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(AlertCustomerExpressionDS.AlertCollectionRow);
			}

			// Token: 0x06001358 RID: 4952 RVA: 0x000FB3D0 File Offset: 0x000F97D0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this.AlertCollectionRowChanged != null)
				{
					this.AlertCollectionRowChanged(this, new AlertCustomerExpressionDS.AlertCollectionRowChangeEvent((AlertCustomerExpressionDS.AlertCollectionRow)e.Row, e.Action));
				}
			}

			// Token: 0x06001359 RID: 4953 RVA: 0x000FB42C File Offset: 0x000F982C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this.AlertCollectionRowChanging != null)
				{
					this.AlertCollectionRowChanging(this, new AlertCustomerExpressionDS.AlertCollectionRowChangeEvent((AlertCustomerExpressionDS.AlertCollectionRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600135A RID: 4954 RVA: 0x000FB488 File Offset: 0x000F9888
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this.AlertCollectionRowDeleted != null)
				{
					this.AlertCollectionRowDeleted(this, new AlertCustomerExpressionDS.AlertCollectionRowChangeEvent((AlertCustomerExpressionDS.AlertCollectionRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600135B RID: 4955 RVA: 0x000FB4E4 File Offset: 0x000F98E4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this.AlertCollectionRowDeleting != null)
				{
					this.AlertCollectionRowDeleting(this, new AlertCustomerExpressionDS.AlertCollectionRowChangeEvent((AlertCustomerExpressionDS.AlertCollectionRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600135C RID: 4956 RVA: 0x000FB540 File Offset: 0x000F9940
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveAlertCollectionRow(AlertCustomerExpressionDS.AlertCollectionRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x0600135D RID: 4957 RVA: 0x000FB560 File Offset: 0x000F9960
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
				AlertCustomerExpressionDS alertCustomerExpressionDS = new AlertCustomerExpressionDS();
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
				xmlSchemaAttribute.FixedValue = alertCustomerExpressionDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "AlertCollectionDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = alertCustomerExpressionDS.GetSchemaSerializable();
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

			// Token: 0x040009F4 RID: 2548
			private DataColumn columnSymbol;

			// Token: 0x040009F5 RID: 2549
			private DataColumn columnValues;

			// Token: 0x040009F6 RID: 2550
			private DataColumn columnOperator;

			// Token: 0x040009F7 RID: 2551
			private DataColumn columnColumnsAlert;

			// Token: 0x040009F8 RID: 2552
			private DataColumn columnIsFirstTimeOnly;

			// Token: 0x040009F9 RID: 2553
			private DataColumn columnIsPrepareOrder;

			// Token: 0x040009FA RID: 2554
			private DataColumn columnOrderParam;

			// Token: 0x040009FB RID: 2555
			private DataColumn columnAlertTime;

			// Token: 0x040009FC RID: 2556
			private DataColumn columnAlertValue;
		}

		// Token: 0x02000220 RID: 544
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class AlertCollectionRow : DataRow
		{
			// Token: 0x0600135E RID: 4958 RVA: 0x000FB7F0 File Offset: 0x000F9BF0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal AlertCollectionRow(DataRowBuilder rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				base..ctor(rb);
				this.tableAlertCollection = (AlertCustomerExpressionDS.AlertCollectionDataTable)base.Table;
			}

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x0600135F RID: 4959 RVA: 0x000FB820 File Offset: 0x000F9C20
			// (set) Token: 0x06001360 RID: 4960 RVA: 0x000FB878 File Offset: 0x000F9C78
			[DebuggerNonUserCode]
			public string Symbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsSymbolNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableAlertCollection.SymbolColumn];
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
					base[this.tableAlertCollection.SymbolColumn] = value;
				}
			}

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x06001361 RID: 4961 RVA: 0x000FB89C File Offset: 0x000F9C9C
			// (set) Token: 0x06001362 RID: 4962 RVA: 0x000FB8F4 File Offset: 0x000F9CF4
			[DebuggerNonUserCode]
			public string Values
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsValuesNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableAlertCollection.ValuesColumn];
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
					base[this.tableAlertCollection.ValuesColumn] = value;
				}
			}

			// Token: 0x17000262 RID: 610
			// (get) Token: 0x06001363 RID: 4963 RVA: 0x000FB918 File Offset: 0x000F9D18
			// (set) Token: 0x06001364 RID: 4964 RVA: 0x000FB970 File Offset: 0x000F9D70
			[DebuggerNonUserCode]
			public string Operator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsOperatorNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableAlertCollection.OperatorColumn];
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
					base[this.tableAlertCollection.OperatorColumn] = value;
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x06001365 RID: 4965 RVA: 0x000FB994 File Offset: 0x000F9D94
			// (set) Token: 0x06001366 RID: 4966 RVA: 0x000FB9EC File Offset: 0x000F9DEC
			[DebuggerNonUserCode]
			public string ColumnsAlert
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsColumnsAlertNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableAlertCollection.ColumnsAlertColumn];
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
					base[this.tableAlertCollection.ColumnsAlertColumn] = value;
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x06001367 RID: 4967 RVA: 0x000FBA10 File Offset: 0x000F9E10
			// (set) Token: 0x06001368 RID: 4968 RVA: 0x000FBA6C File Offset: 0x000F9E6C
			[DebuggerNonUserCode]
			public bool IsFirstTimeOnly
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					bool result;
					try
					{
						result = (bool)base[this.tableAlertCollection.IsFirstTimeOnlyColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'IsFirstTimeOnly' in table 'AlertCollection' is DBNull.", innerException);
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
					base[this.tableAlertCollection.IsFirstTimeOnlyColumn] = value;
				}
			}

			// Token: 0x17000265 RID: 613
			// (get) Token: 0x06001369 RID: 4969 RVA: 0x000FBA98 File Offset: 0x000F9E98
			// (set) Token: 0x0600136A RID: 4970 RVA: 0x000FBAD4 File Offset: 0x000F9ED4
			[DebuggerNonUserCode]
			public bool IsPrepareOrder
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (bool)base[this.tableAlertCollection.IsPrepareOrderColumn];
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableAlertCollection.IsPrepareOrderColumn] = value;
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x0600136B RID: 4971 RVA: 0x000FBB00 File Offset: 0x000F9F00
			// (set) Token: 0x0600136C RID: 4972 RVA: 0x000FBB3C File Offset: 0x000F9F3C
			[DebuggerNonUserCode]
			public string OrderParam
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (string)base[this.tableAlertCollection.OrderParamColumn];
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableAlertCollection.OrderParamColumn] = value;
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x0600136D RID: 4973 RVA: 0x000FBB60 File Offset: 0x000F9F60
			// (set) Token: 0x0600136E RID: 4974 RVA: 0x000FBBB8 File Offset: 0x000F9FB8
			[DebuggerNonUserCode]
			public string AlertTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsAlertTimeNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableAlertCollection.AlertTimeColumn];
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
					base[this.tableAlertCollection.AlertTimeColumn] = value;
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x0600136F RID: 4975 RVA: 0x000FBBDC File Offset: 0x000F9FDC
			// (set) Token: 0x06001370 RID: 4976 RVA: 0x000FBC34 File Offset: 0x000FA034
			[DebuggerNonUserCode]
			public string AlertValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsAlertValueNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableAlertCollection.AlertValueColumn];
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
					base[this.tableAlertCollection.AlertValueColumn] = value;
				}
			}

			// Token: 0x06001371 RID: 4977 RVA: 0x000FBC58 File Offset: 0x000FA058
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsSymbolNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableAlertCollection.SymbolColumn);
			}

			// Token: 0x06001372 RID: 4978 RVA: 0x000FBC8C File Offset: 0x000FA08C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetSymbolNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableAlertCollection.SymbolColumn] = Convert.DBNull;
			}

			// Token: 0x06001373 RID: 4979 RVA: 0x000FBCB4 File Offset: 0x000FA0B4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsValuesNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableAlertCollection.ValuesColumn);
			}

			// Token: 0x06001374 RID: 4980 RVA: 0x000FBCE8 File Offset: 0x000FA0E8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetValuesNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableAlertCollection.ValuesColumn] = Convert.DBNull;
			}

			// Token: 0x06001375 RID: 4981 RVA: 0x000FBD10 File Offset: 0x000FA110
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsOperatorNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableAlertCollection.OperatorColumn);
			}

			// Token: 0x06001376 RID: 4982 RVA: 0x000FBD44 File Offset: 0x000FA144
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetOperatorNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableAlertCollection.OperatorColumn] = Convert.DBNull;
			}

			// Token: 0x06001377 RID: 4983 RVA: 0x000FBD6C File Offset: 0x000FA16C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsColumnsAlertNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableAlertCollection.ColumnsAlertColumn);
			}

			// Token: 0x06001378 RID: 4984 RVA: 0x000FBDA0 File Offset: 0x000FA1A0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetColumnsAlertNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableAlertCollection.ColumnsAlertColumn] = Convert.DBNull;
			}

			// Token: 0x06001379 RID: 4985 RVA: 0x000FBDC8 File Offset: 0x000FA1C8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsIsFirstTimeOnlyNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableAlertCollection.IsFirstTimeOnlyColumn);
			}

			// Token: 0x0600137A RID: 4986 RVA: 0x000FBDFC File Offset: 0x000FA1FC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetIsFirstTimeOnlyNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableAlertCollection.IsFirstTimeOnlyColumn] = Convert.DBNull;
			}

			// Token: 0x0600137B RID: 4987 RVA: 0x000FBE24 File Offset: 0x000FA224
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsAlertTimeNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableAlertCollection.AlertTimeColumn);
			}

			// Token: 0x0600137C RID: 4988 RVA: 0x000FBE58 File Offset: 0x000FA258
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetAlertTimeNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableAlertCollection.AlertTimeColumn] = Convert.DBNull;
			}

			// Token: 0x0600137D RID: 4989 RVA: 0x000FBE80 File Offset: 0x000FA280
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsAlertValueNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableAlertCollection.AlertValueColumn);
			}

			// Token: 0x0600137E RID: 4990 RVA: 0x000FBEB4 File Offset: 0x000FA2B4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetAlertValueNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableAlertCollection.AlertValueColumn] = Convert.DBNull;
			}

			// Token: 0x04000A01 RID: 2561
			private AlertCustomerExpressionDS.AlertCollectionDataTable tableAlertCollection;
		}

		// Token: 0x02000221 RID: 545
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class AlertCollectionRowChangeEvent : EventArgs
		{
			// Token: 0x0600137F RID: 4991 RVA: 0x000FBEDC File Offset: 0x000FA2DC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AlertCollectionRowChangeEvent(AlertCustomerExpressionDS.AlertCollectionRow row, DataRowAction action)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				base..ctor();
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06001380 RID: 4992 RVA: 0x000FBF08 File Offset: 0x000FA308
			[DebuggerNonUserCode]
			public AlertCustomerExpressionDS.AlertCollectionRow Row
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

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06001381 RID: 4993 RVA: 0x000FBF34 File Offset: 0x000FA334
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

			// Token: 0x04000A02 RID: 2562
			private AlertCustomerExpressionDS.AlertCollectionRow eventRow;

			// Token: 0x04000A03 RID: 2563
			private DataRowAction eventAction;
		}
	}
}
