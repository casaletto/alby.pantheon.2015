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
		public int dt_getpropertiesbyid_u
		(
			sds.SqlConnection connˡ, 
			int? id, 
			string property, 
			out scg.List<dt_getpropertiesbyid_u٠rs1> rsˡ1, 
			out scg.List<dt_getpropertiesbyid_u٠rs2> rsˡ2, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "dt_getpropertiesbyid_u" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡid = base.AddParameterˡ( parametersˡ, "@id", id, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡproperty = base.AddParameterˡ( parametersˡ, "@property", property, sd.SqlDbType.VarChar, true, 64, null, null ) ; 
			sds.SqlParameter paramˡrcˡ = base.AddParameterReturnValueˡ( parametersˡ, "@rcˡ" ) ; 
			 
			sd.DataSet dsˡ = base.Executeˡ( connˡ, tranˡ, schemaˡ, spˡ, parametersˡ ) ;
			 
			rsˡ1 = base.ToRecordsetˡ<dt_getpropertiesbyid_u٠rs1>( dsˡ, 1 ) ;
			rsˡ2 = base.ToRecordsetˡ<dt_getpropertiesbyid_u٠rs2>( dsˡ, 2 ) ;
			 
			return base.GetParameterValueˡ<int>( paramˡrcˡ ) ;
		}
	}

}

