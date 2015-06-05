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
		public int CommunicationUpdate
		(
			sds.SqlConnection connˡ, 
			int? CommunicationID, 
			int? PartyID, 
			string CommunicationTypeDescription, 
			string CommunicationDetail, 
			string UpdateUserCode, 
			DateTime? UpdateDateTime, 
			ref byte[] RowTimestamp, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "CommunicationUpdate" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡCommunicationID = base.AddParameterˡ( parametersˡ, "@CommunicationID", CommunicationID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡPartyID = base.AddParameterˡ( parametersˡ, "@PartyID", PartyID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡCommunicationTypeDescription = base.AddParameterˡ( parametersˡ, "@CommunicationTypeDescription", CommunicationTypeDescription, sd.SqlDbType.VarChar, true, 60, null, null ) ; 
			sds.SqlParameter paramˡCommunicationDetail = base.AddParameterˡ( parametersˡ, "@CommunicationDetail", CommunicationDetail, sd.SqlDbType.NVarChar, true, 50, null, null ) ; 
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

