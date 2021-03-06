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
		public int LeaseGuarantorGet
		(
			sds.SqlConnection connˡ, 
			int? PartyID, 
			string UpdateUserCode, 
			DateTime? UpdateDateTime, 
			out scg.List<LeaseGuarantorGet٠rs1> rsˡ1, 
			out scg.List<LeaseGuarantorGet٠rs2> rsˡ2, 
			out scg.List<LeaseGuarantorGet٠rs3> rsˡ3, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "LeaseGuarantorGet" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡPartyID = base.AddParameterˡ( parametersˡ, "@PartyID", PartyID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡUpdateUserCode = base.AddParameterˡ( parametersˡ, "@UpdateUserCode", UpdateUserCode, sd.SqlDbType.VarChar, true, 50, null, null ) ; 
			sds.SqlParameter paramˡUpdateDateTime = base.AddParameterˡ( parametersˡ, "@UpdateDateTime", UpdateDateTime, sd.SqlDbType.DateTime, true, null, null, null ) ; 
			sds.SqlParameter paramˡrcˡ = base.AddParameterReturnValueˡ( parametersˡ, "@rcˡ" ) ; 
			 
			sd.DataSet dsˡ = base.Executeˡ( connˡ, tranˡ, schemaˡ, spˡ, parametersˡ ) ;
			 
			rsˡ1 = base.ToRecordsetˡ<LeaseGuarantorGet٠rs1>( dsˡ, 1 ) ;
			rsˡ2 = base.ToRecordsetˡ<LeaseGuarantorGet٠rs2>( dsˡ, 2 ) ;
			rsˡ3 = base.ToRecordsetˡ<LeaseGuarantorGet٠rs3>( dsˡ, 3 ) ;
			 
			return base.GetParameterValueˡ<int>( paramˡrcˡ ) ;
		}
	}

}

