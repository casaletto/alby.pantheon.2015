﻿
// This file was automatically generated by the code gen tool - do not modify.

using System ;
using scg = System.Collections.Generic ;
using sd = System.Data ;
using sds = System.Data.SqlClient ;
using sr = System.Reflection ;
using mst = Microsoft.SqlServer.Types ;
using mss = Microsoft.SqlServer.Server ;
using acr = alby.codegen.runtime ;
using ns = alby.pantheon.codegen;

namespace alby.pantheon.codegen.table
{
	public partial class ExpenseDetailFactory : acr.FactoryBase< ExpenseDetail, ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		static ExpenseDetailFactory() 
		{
			_assemblyˡ = sr.Assembly.GetExecutingAssembly() ;
			_schemaˡ = "dbo" ;
			_tableˡ = "ExpenseDetail" ;
			_selectˡ = "select * from {0} t " ;
			_insertˡ = "insert {0} ( [ExpenseDetailID], [ExpenseTotal], [ExpensePaymentCommenceDate], [ExpensePaymentCommenceDateText], [OperatingPercent], [OperatingExpense], [OperatingSQM], [StatutoryPercent], [StatutoryExpense], [StatutorySQM], [ACGeneralEnergyPercent], [ACGeneralEnergyExpense], [ACGeneralEnergySQM], [ACMaintenanceRepairPercent], [ACMaintenanceRepairExpense], [ACMaintenanceRepairSQM], [UpdateUserCode], [UpdateDateTime] ) values ( @ExpenseDetailID, @ExpenseTotal, @ExpensePaymentCommenceDate, @ExpensePaymentCommenceDateText, @OperatingPercent, @OperatingExpense, @OperatingSQM, @StatutoryPercent, @StatutoryExpense, @StatutorySQM, @ACGeneralEnergyPercent, @ACGeneralEnergyExpense, @ACGeneralEnergySQM, @ACMaintenanceRepairPercent, @ACMaintenanceRepairExpense, @ACMaintenanceRepairSQM, @UpdateUserCode, @UpdateDateTime ) " ;
			_insertIdentityˡ = "insert {0} ( [ExpenseDetailID], [ExpenseTotal], [ExpensePaymentCommenceDate], [ExpensePaymentCommenceDateText], [OperatingPercent], [OperatingExpense], [OperatingSQM], [StatutoryPercent], [StatutoryExpense], [StatutorySQM], [ACGeneralEnergyPercent], [ACGeneralEnergyExpense], [ACGeneralEnergySQM], [ACMaintenanceRepairPercent], [ACMaintenanceRepairExpense], [ACMaintenanceRepairSQM], [UpdateUserCode], [UpdateDateTime] ) values ( @ExpenseDetailID, @ExpenseTotal, @ExpensePaymentCommenceDate, @ExpensePaymentCommenceDateText, @OperatingPercent, @OperatingExpense, @OperatingSQM, @StatutoryPercent, @StatutoryExpense, @StatutorySQM, @ACGeneralEnergyPercent, @ACGeneralEnergyExpense, @ACGeneralEnergySQM, @ACMaintenanceRepairPercent, @ACMaintenanceRepairExpense, @ACMaintenanceRepairSQM, @UpdateUserCode, @UpdateDateTime ) " ;
			_updateˡ = "update {0} set [ExpenseDetailID] = @ExpenseDetailID, [ExpenseTotal] = @ExpenseTotal, [ExpensePaymentCommenceDate] = @ExpensePaymentCommenceDate, [ExpensePaymentCommenceDateText] = @ExpensePaymentCommenceDateText, [OperatingPercent] = @OperatingPercent, [OperatingExpense] = @OperatingExpense, [OperatingSQM] = @OperatingSQM, [StatutoryPercent] = @StatutoryPercent, [StatutoryExpense] = @StatutoryExpense, [StatutorySQM] = @StatutorySQM, [ACGeneralEnergyPercent] = @ACGeneralEnergyPercent, [ACGeneralEnergyExpense] = @ACGeneralEnergyExpense, [ACGeneralEnergySQM] = @ACGeneralEnergySQM, [ACMaintenanceRepairPercent] = @ACMaintenanceRepairPercent, [ACMaintenanceRepairExpense] = @ACMaintenanceRepairExpense, [ACMaintenanceRepairSQM] = @ACMaintenanceRepairSQM, [UpdateUserCode] = @UpdateUserCode, [UpdateDateTime] = @UpdateDateTime " ;
			_deleteˡ = "delete {0} " ;
			_whereLoadPKˡ = "where [ExpenseDetailID] = @pk_ExpenseDetailID " ;
			_whereSavePKˡ = "where [ExpenseDetailID] = @pk_ExpenseDetailID " ;
		}

		public ExpenseDetail Saveˡ( sds.SqlConnection connˡ, ExpenseDetail rowˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal, bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_ExpenseDetailID", rowˡ.PrimaryKeyDictionaryˡ[ ExpenseDetail.column٠ExpenseDetailID ] );
			base.AddParameterˡ( parametersˡ, "@ExpenseDetailID", rowˡ.ExpenseDetailID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@ExpenseTotal", rowˡ.ExpenseTotal, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ExpensePaymentCommenceDate", rowˡ.ExpensePaymentCommenceDate, sd.SqlDbType.DateTime );
			base.AddParameterˡ( parametersˡ, "@ExpensePaymentCommenceDateText", rowˡ.ExpensePaymentCommenceDateText, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@OperatingPercent", rowˡ.OperatingPercent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@OperatingExpense", rowˡ.OperatingExpense, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@OperatingSQM", rowˡ.OperatingSQM, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@StatutoryPercent", rowˡ.StatutoryPercent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@StatutoryExpense", rowˡ.StatutoryExpense, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@StatutorySQM", rowˡ.StatutorySQM, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACGeneralEnergyPercent", rowˡ.ACGeneralEnergyPercent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACGeneralEnergyExpense", rowˡ.ACGeneralEnergyExpense, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACGeneralEnergySQM", rowˡ.ACGeneralEnergySQM, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACMaintenanceRepairPercent", rowˡ.ACMaintenanceRepairPercent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACMaintenanceRepairExpense", rowˡ.ACMaintenanceRepairExpense, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACMaintenanceRepairSQM", rowˡ.ACMaintenanceRepairSQM, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@UpdateUserCode", rowˡ.UpdateUserCode, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@UpdateDateTime", rowˡ.UpdateDateTime, sd.SqlDbType.DateTime );
			base.AddParameterˡ( parametersˡ, "@RowTimestamp", rowˡ.RowTimestamp, sd.SqlDbType.Image );

			int? identityIDˡ = null ;
			object objˡ = null ;
		 
			acr.SaveEnum saveResultˡ ;
		 
			if ( saveStrategyˡ != acr.CodeGenSaveStrategy.Normal )
			{
				saveResultˡ = base.ExecuteForceSaveˡ( rowˡ, connˡ, tranˡ, parametersˡ, saveStrategyˡ, _insertˡ, _insertIdentityˡ, _updateˡ, _deleteˡ, _whereLoadPKˡ, false, identityProvidedˡ, out objˡ ) ;
				if ( objˡ != null )
					identityIDˡ = int.Parse( objˡ.ToString() ) ;
			}
			else
			{
				saveResultˡ = base.ExecuteSaveˡ( rowˡ, connˡ, tranˡ, parametersˡ, _insertˡ, _insertIdentityˡ, _updateˡ, _deleteˡ, _whereSavePKˡ, false, identityProvidedˡ, out objˡ ) ;
				if ( objˡ != null )
					identityIDˡ = int.Parse( objˡ.ToString() ) ;
			}
		 
			if ( saveResultˡ == acr.SaveEnum.Update ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.ExpenseDetailID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Insert ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.ExpenseDetailID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Delete )
				return null ;
			else
				return rowˡ ;
		}

		public scg.List<ExpenseDetail> Saveˡ( sds.SqlConnection connˡ, scg.List<ExpenseDetail> rowListˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal,  bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<ExpenseDetail> rowList2ˡ = new scg.List<ExpenseDetail>();
			foreach( ExpenseDetail rowˡ in rowListˡ )
			{
				ExpenseDetail row2ˡ = this.Saveˡ( connˡ, rowˡ, saveStrategyˡ, identityProvidedˡ, tranˡ ) ;
				if ( row2ˡ != null )	rowList2ˡ.Add( row2ˡ ) ;
			}
			return rowList2ˡ ;
		}

		public ExpenseDetail LoadByPrimaryKeyˡ
		(
			sds.SqlConnection connˡ,
			int? ExpenseDetailID,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_ExpenseDetailID", ExpenseDetailID );
			return base.ExecuteQueryReturnOneˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, _whereLoadPKˡ, false ) ;
		}

		public scg.List<ExpenseDetail> Loadˡ
		(
			sds.SqlConnection connˡ,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			string whereˡ = "";
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<ExpenseDetail> LoadByWhereˡ
		(
			sds.SqlConnection connˡ,
			string whereˡ,
			scg.List<sds.SqlParameter> parametersˡ = null,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

	}

}

