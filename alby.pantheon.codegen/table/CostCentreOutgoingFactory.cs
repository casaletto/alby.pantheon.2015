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
	public partial class CostCentreOutgoingFactory : acr.FactoryBase< CostCentreOutgoing, ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		static CostCentreOutgoingFactory() 
		{
			_assemblyˡ = sr.Assembly.GetExecutingAssembly() ;
			_schemaˡ = "dbo" ;
			_tableˡ = "CostCentreOutgoing" ;
			_selectˡ = "select * from {0} t " ;
			_insertˡ = "insert {0} ( [CostCentreOutgoingID], [CostCentreStageID], [OperatingGLA], [OperatingAmount], [StatutoryGLA], [StatutoryAmount], [ACGeneralEnergyGLA], [ACGeneralEnergyAmount], [ACMaintenanceRepairGLA], [ACMaintenanceRepairAmount], [UpdateUserCode], [UpdateDateTime] ) values ( @CostCentreOutgoingID, @CostCentreStageID, @OperatingGLA, @OperatingAmount, @StatutoryGLA, @StatutoryAmount, @ACGeneralEnergyGLA, @ACGeneralEnergyAmount, @ACMaintenanceRepairGLA, @ACMaintenanceRepairAmount, @UpdateUserCode, @UpdateDateTime ) " ;
			_insertIdentityˡ = "insert {0} ( [CostCentreOutgoingID], [CostCentreStageID], [OperatingGLA], [OperatingAmount], [StatutoryGLA], [StatutoryAmount], [ACGeneralEnergyGLA], [ACGeneralEnergyAmount], [ACMaintenanceRepairGLA], [ACMaintenanceRepairAmount], [UpdateUserCode], [UpdateDateTime] ) values ( @CostCentreOutgoingID, @CostCentreStageID, @OperatingGLA, @OperatingAmount, @StatutoryGLA, @StatutoryAmount, @ACGeneralEnergyGLA, @ACGeneralEnergyAmount, @ACMaintenanceRepairGLA, @ACMaintenanceRepairAmount, @UpdateUserCode, @UpdateDateTime ) " ;
			_updateˡ = "update {0} set [CostCentreOutgoingID] = @CostCentreOutgoingID, [CostCentreStageID] = @CostCentreStageID, [OperatingGLA] = @OperatingGLA, [OperatingAmount] = @OperatingAmount, [StatutoryGLA] = @StatutoryGLA, [StatutoryAmount] = @StatutoryAmount, [ACGeneralEnergyGLA] = @ACGeneralEnergyGLA, [ACGeneralEnergyAmount] = @ACGeneralEnergyAmount, [ACMaintenanceRepairGLA] = @ACMaintenanceRepairGLA, [ACMaintenanceRepairAmount] = @ACMaintenanceRepairAmount, [UpdateUserCode] = @UpdateUserCode, [UpdateDateTime] = @UpdateDateTime " ;
			_deleteˡ = "delete {0} " ;
			_whereLoadPKˡ = "where [CostCentreOutgoingID] = @pk_CostCentreOutgoingID " ;
			_whereSavePKˡ = "where [CostCentreOutgoingID] = @pk_CostCentreOutgoingID " ;
		}

		public CostCentreOutgoing Saveˡ( sds.SqlConnection connˡ, CostCentreOutgoing rowˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal, bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_CostCentreOutgoingID", rowˡ.PrimaryKeyDictionaryˡ[ CostCentreOutgoing.column٠CostCentreOutgoingID ] );
			base.AddParameterˡ( parametersˡ, "@CostCentreOutgoingID", rowˡ.CostCentreOutgoingID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@CostCentreStageID", rowˡ.CostCentreStageID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@OperatingGLA", rowˡ.OperatingGLA, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@OperatingAmount", rowˡ.OperatingAmount, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@StatutoryGLA", rowˡ.StatutoryGLA, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@StatutoryAmount", rowˡ.StatutoryAmount, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACGeneralEnergyGLA", rowˡ.ACGeneralEnergyGLA, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACGeneralEnergyAmount", rowˡ.ACGeneralEnergyAmount, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACMaintenanceRepairGLA", rowˡ.ACMaintenanceRepairGLA, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ACMaintenanceRepairAmount", rowˡ.ACMaintenanceRepairAmount, sd.SqlDbType.Decimal );
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
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.CostCentreOutgoingID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Insert ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.CostCentreOutgoingID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Delete )
				return null ;
			else
				return rowˡ ;
		}

		public scg.List<CostCentreOutgoing> Saveˡ( sds.SqlConnection connˡ, scg.List<CostCentreOutgoing> rowListˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal,  bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<CostCentreOutgoing> rowList2ˡ = new scg.List<CostCentreOutgoing>();
			foreach( CostCentreOutgoing rowˡ in rowListˡ )
			{
				CostCentreOutgoing row2ˡ = this.Saveˡ( connˡ, rowˡ, saveStrategyˡ, identityProvidedˡ, tranˡ ) ;
				if ( row2ˡ != null )	rowList2ˡ.Add( row2ˡ ) ;
			}
			return rowList2ˡ ;
		}

		public CostCentreOutgoing LoadByPrimaryKeyˡ
		(
			sds.SqlConnection connˡ,
			int? CostCentreOutgoingID,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_CostCentreOutgoingID", CostCentreOutgoingID );
			return base.ExecuteQueryReturnOneˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, _whereLoadPKˡ, false ) ;
		}

		public scg.List<CostCentreOutgoing> LoadByForeignKey٠From٠CostCentreStage٠By٠CostCentreStageID
		(
			sds.SqlConnection connˡ,
			int? CostCentreStageID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@CostCentreStageID", CostCentreStageID );
			string whereˡ = "where [CostCentreStageID] = @CostCentreStageID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<CostCentreOutgoing> Loadˡ
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

		public scg.List<CostCentreOutgoing> LoadByWhereˡ
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
