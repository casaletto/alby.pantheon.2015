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
		public int AddressUpdate
		(
			sds.SqlConnection connˡ, 
			int? AddressID, 
			int? PartyID, 
			string AddressType, 
			string AddressLine1, 
			string AddressLine2, 
			string Suburb, 
			string Town, 
			string State, 
			string Postcode, 
			string Country, 
			string UpdateUserCode, 
			DateTime? UpdateDateTime, 
			ref byte[] RowTimestamp, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "AddressUpdate" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡAddressID = base.AddParameterˡ( parametersˡ, "@AddressID", AddressID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡPartyID = base.AddParameterˡ( parametersˡ, "@PartyID", PartyID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡAddressType = base.AddParameterˡ( parametersˡ, "@AddressType", AddressType, sd.SqlDbType.NVarChar, true, 20, null, null ) ; 
			sds.SqlParameter paramˡAddressLine1 = base.AddParameterˡ( parametersˡ, "@AddressLine1", AddressLine1, sd.SqlDbType.NVarChar, true, 50, null, null ) ; 
			sds.SqlParameter paramˡAddressLine2 = base.AddParameterˡ( parametersˡ, "@AddressLine2", AddressLine2, sd.SqlDbType.NVarChar, true, 50, null, null ) ; 
			sds.SqlParameter paramˡSuburb = base.AddParameterˡ( parametersˡ, "@Suburb", Suburb, sd.SqlDbType.NVarChar, true, 50, null, null ) ; 
			sds.SqlParameter paramˡTown = base.AddParameterˡ( parametersˡ, "@Town", Town, sd.SqlDbType.NVarChar, true, 50, null, null ) ; 
			sds.SqlParameter paramˡState = base.AddParameterˡ( parametersˡ, "@State", State, sd.SqlDbType.NVarChar, true, 10, null, null ) ; 
			sds.SqlParameter paramˡPostcode = base.AddParameterˡ( parametersˡ, "@Postcode", Postcode, sd.SqlDbType.NVarChar, true, 10, null, null ) ; 
			sds.SqlParameter paramˡCountry = base.AddParameterˡ( parametersˡ, "@Country", Country, sd.SqlDbType.NVarChar, true, 50, null, null ) ; 
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

