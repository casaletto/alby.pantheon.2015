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

namespace alby.pantheon.codegen.table
{
	public partial class RentReviewType : acr.RowBase
	{
		public scg.List<RentDetail> children٠RentDetail٠By٠AtOptionRentReviewTypeID( sds.SqlConnection connˡ, int? topNˡ = null, scg.List<acr.CodeGenOrderBy> orderByˡ = null, sds.SqlTransaction tranˡ = null )
		{
			RentDetailFactory factoryˡ = new RentDetailFactory() ; 
			return factoryˡ.LoadByForeignKey٠From٠RentReviewType٠By٠AtOptionRentReviewTypeID
			(
				connˡ,
				this.RentReviewTypeID, 
				topNˡ,
				orderByˡ,
				tranˡ
			) ;
		}

		public scg.List<RentDetail> children٠RentDetail٠By٠DuringOptionRentReviewTypeID( sds.SqlConnection connˡ, int? topNˡ = null, scg.List<acr.CodeGenOrderBy> orderByˡ = null, sds.SqlTransaction tranˡ = null )
		{
			RentDetailFactory factoryˡ = new RentDetailFactory() ; 
			return factoryˡ.LoadByForeignKey٠From٠RentReviewType٠By٠DuringOptionRentReviewTypeID
			(
				connˡ,
				this.RentReviewTypeID, 
				topNˡ,
				orderByˡ,
				tranˡ
			) ;
		}

		public scg.List<RentReview> children٠RentReview٠By٠RentReviewTypeID( sds.SqlConnection connˡ, int? topNˡ = null, scg.List<acr.CodeGenOrderBy> orderByˡ = null, sds.SqlTransaction tranˡ = null )
		{
			RentReviewFactory factoryˡ = new RentReviewFactory() ; 
			return factoryˡ.LoadByForeignKey٠From٠RentReviewType٠By٠RentReviewTypeID
			(
				connˡ,
				this.RentReviewTypeID, 
				topNˡ,
				orderByˡ,
				tranˡ
			) ;
		}

	}

}

