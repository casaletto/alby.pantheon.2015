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
		public int dt_displayoaerror_u
		(
			sds.SqlConnection connˡ, 
			int? iObject, 
			int? iresult, 
			out sd.DataSet dsˡ, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "dt_displayoaerror_u" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡiObject = base.AddParameterˡ( parametersˡ, "@iObject", iObject, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡiresult = base.AddParameterˡ( parametersˡ, "@iresult", iresult, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡrcˡ = base.AddParameterReturnValueˡ( parametersˡ, "@rcˡ" ) ; 
			 
			dsˡ = base.Executeˡ( connˡ, tranˡ, schemaˡ, spˡ, parametersˡ ) ;
			 
			return base.GetParameterValueˡ<int>( paramˡrcˡ ) ;
		}
	}

}

