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
		public int dt_getobjwithprop
		(
			sds.SqlConnection connˡ, 
			string property, 
			string value, 
			out scg.List<dt_getobjwithprop٠rs1> rsˡ1, 
			out scg.List<dt_getobjwithprop٠rs2> rsˡ2, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "dt_getobjwithprop" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡproperty = base.AddParameterˡ( parametersˡ, "@property", property, sd.SqlDbType.VarChar, true, 30, null, null ) ; 
			sds.SqlParameter paramˡvalue = base.AddParameterˡ( parametersˡ, "@value", value, sd.SqlDbType.VarChar, true, 255, null, null ) ; 
			sds.SqlParameter paramˡrcˡ = base.AddParameterReturnValueˡ( parametersˡ, "@rcˡ" ) ; 
			 
			sd.DataSet dsˡ = base.Executeˡ( connˡ, tranˡ, schemaˡ, spˡ, parametersˡ ) ;
			 
			rsˡ1 = base.ToRecordsetˡ<dt_getobjwithprop٠rs1>( dsˡ, 1 ) ;
			rsˡ2 = base.ToRecordsetˡ<dt_getobjwithprop٠rs2>( dsˡ, 2 ) ;
			 
			return base.GetParameterValueˡ<int>( paramˡrcˡ ) ;
		}
	}

}

