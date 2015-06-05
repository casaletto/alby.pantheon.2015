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

namespace alby.pantheon.codegen.storedProcedure
{
	public partial class StoredProcedureFactory : acr.StoredProcedureFactoryBase< ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		public int CostCentreOutgoingAdd
		(
			sds.SqlConnection connˡ, 
			int? CostCentreOutgoingID, 
			int? CostCentreStageID, 
			decimal? OperatingGLA, 
			decimal? OperatingAmount, 
			decimal? StatutoryGLA, 
			decimal? StatutoryAmount, 
			decimal? ACGeneralEnergyGLA, 
			decimal? ACGeneralEnergyAmount, 
			decimal? ACMaintenanceRepairGLA, 
			decimal? ACMaintenanceRepairAmount, 
			string UpdateUserCode, 
			DateTime? UpdateDateTime, 
			ref byte[] RowTimestamp, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "CostCentreOutgoingAdd" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡCostCentreOutgoingID = base.AddParameterˡ( parametersˡ, "@CostCentreOutgoingID", CostCentreOutgoingID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡCostCentreStageID = base.AddParameterˡ( parametersˡ, "@CostCentreStageID", CostCentreStageID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡOperatingGLA = base.AddParameterˡ( parametersˡ, "@OperatingGLA", OperatingGLA, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡOperatingAmount = base.AddParameterˡ( parametersˡ, "@OperatingAmount", OperatingAmount, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡStatutoryGLA = base.AddParameterˡ( parametersˡ, "@StatutoryGLA", StatutoryGLA, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡStatutoryAmount = base.AddParameterˡ( parametersˡ, "@StatutoryAmount", StatutoryAmount, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡACGeneralEnergyGLA = base.AddParameterˡ( parametersˡ, "@ACGeneralEnergyGLA", ACGeneralEnergyGLA, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡACGeneralEnergyAmount = base.AddParameterˡ( parametersˡ, "@ACGeneralEnergyAmount", ACGeneralEnergyAmount, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡACMaintenanceRepairGLA = base.AddParameterˡ( parametersˡ, "@ACMaintenanceRepairGLA", ACMaintenanceRepairGLA, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡACMaintenanceRepairAmount = base.AddParameterˡ( parametersˡ, "@ACMaintenanceRepairAmount", ACMaintenanceRepairAmount, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡUpdateUserCode = base.AddParameterˡ( parametersˡ, "@UpdateUserCode", UpdateUserCode, sd.SqlDbType.VarChar, true, 50, null, null ) ; 
			sds.SqlParameter paramˡUpdateDateTime = base.AddParameterˡ( parametersˡ, "@UpdateDateTime", UpdateDateTime, sd.SqlDbType.DateTime, true, null, null, null ) ; 
			sds.SqlParameter paramˡRowTimestamp = base.AddParameterˡ( parametersˡ, "@RowTimestamp", RowTimestamp, sd.SqlDbType.Timestamp, false, null, null, null ) ; 
			sds.SqlParameter paramˡrcˡ = base.AddParameterReturnValueˡ( parametersˡ, "@rcˡ" ) ; 
			 
			sd.DataSet dsˡ = base.Executeˡ( connˡ, tranˡ, schemaˡ, spˡ, parametersˡ ) ;
			 
			RowTimestamp = base.GetParameterValueˡ<byte[]>( paramˡRowTimestamp ) ;
			return base.GetParameterValueˡ<int>( paramˡrcˡ ) ;
		}
	}

}
