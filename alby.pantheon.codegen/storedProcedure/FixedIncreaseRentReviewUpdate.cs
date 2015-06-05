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
		public int FixedIncreaseRentReviewUpdate
		(
			sds.SqlConnection connˡ, 
			int? RentReviewID, 
			decimal? RentReviewIncrease, 
			string RentReviewIncreaseText, 
			decimal? Anniversary1, 
			decimal? Anniversary2, 
			decimal? Anniversary3, 
			decimal? Anniversary4, 
			decimal? Anniversary5, 
			decimal? Anniversary6, 
			decimal? Anniversary7, 
			decimal? Anniversary8, 
			decimal? Anniversary9, 
			int? RentReviewTypeID, 
			string UpdateUserCode, 
			DateTime? UpdateDateTime, 
			ref byte[] RowTimestamp, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "FixedIncreaseRentReviewUpdate" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡRentReviewID = base.AddParameterˡ( parametersˡ, "@RentReviewID", RentReviewID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡRentReviewIncrease = base.AddParameterˡ( parametersˡ, "@RentReviewIncrease", RentReviewIncrease, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡRentReviewIncreaseText = base.AddParameterˡ( parametersˡ, "@RentReviewIncreaseText", RentReviewIncreaseText, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡAnniversary1 = base.AddParameterˡ( parametersˡ, "@Anniversary1", Anniversary1, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAnniversary2 = base.AddParameterˡ( parametersˡ, "@Anniversary2", Anniversary2, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAnniversary3 = base.AddParameterˡ( parametersˡ, "@Anniversary3", Anniversary3, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAnniversary4 = base.AddParameterˡ( parametersˡ, "@Anniversary4", Anniversary4, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAnniversary5 = base.AddParameterˡ( parametersˡ, "@Anniversary5", Anniversary5, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAnniversary6 = base.AddParameterˡ( parametersˡ, "@Anniversary6", Anniversary6, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAnniversary7 = base.AddParameterˡ( parametersˡ, "@Anniversary7", Anniversary7, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAnniversary8 = base.AddParameterˡ( parametersˡ, "@Anniversary8", Anniversary8, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAnniversary9 = base.AddParameterˡ( parametersˡ, "@Anniversary9", Anniversary9, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡRentReviewTypeID = base.AddParameterˡ( parametersˡ, "@RentReviewTypeID", RentReviewTypeID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
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

