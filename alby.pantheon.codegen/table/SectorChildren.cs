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
	public partial class Sector : acr.RowBase
	{
		public scg.List<Lease> children٠Lease٠By٠SectorID( sds.SqlConnection connˡ, int? topNˡ = null, scg.List<acr.CodeGenOrderBy> orderByˡ = null, sds.SqlTransaction tranˡ = null )
		{
			LeaseFactory factoryˡ = new LeaseFactory() ; 
			return factoryˡ.LoadByForeignKey٠From٠Sector٠By٠SectorID
			(
				connˡ,
				this.SectorID, 
				topNˡ,
				orderByˡ,
				tranˡ
			) ;
		}

	}

}

