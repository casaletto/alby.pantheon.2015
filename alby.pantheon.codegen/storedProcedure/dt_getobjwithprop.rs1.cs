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
	public partial class dt_getobjwithprop٠rs1 : acr.RowBase
	{
		public const string column٠id  = "id" ;
		 
		public int? id
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠id ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠id, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public dt_getobjwithprop٠rs1() : base()
		{
			base._dicˡ[ column٠id ] = null ;
		 
		}

	}

}

