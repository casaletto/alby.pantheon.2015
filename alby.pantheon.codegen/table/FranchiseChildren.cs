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
	public partial class Franchise : acr.RowBase
	{
		public Party parent٠Party٠By٠PartyID( sds.SqlConnection connˡ, sds.SqlTransaction tranˡ = null )
		{
			PartyFactory factoryˡ = new PartyFactory() ; 
			return factoryˡ.LoadByPrimaryKeyˡ
			(
				connˡ,
				this.PartyID, 
				tranˡ
			) ;
		}

		public scg.List<LeaseAdministration> children٠LeaseAdministration٠By٠FranchiseID( sds.SqlConnection connˡ, int? topNˡ = null, scg.List<acr.CodeGenOrderBy> orderByˡ = null, sds.SqlTransaction tranˡ = null )
		{
			LeaseAdministrationFactory factoryˡ = new LeaseAdministrationFactory() ; 
			return factoryˡ.LoadByForeignKey٠From٠Franchise٠By٠FranchiseID
			(
				connˡ,
				this.PartyID, 
				topNˡ,
				orderByˡ,
				tranˡ
			) ;
		}

	}

}

