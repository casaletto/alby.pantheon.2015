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
	public partial class dt_getpropertiesbyid_u٠rs1 : acr.RowBase
	{
		public const string column٠property  = "property" ;
		public const string column٠version  = "version" ;
		public const string column٠uvalue  = "uvalue" ;
		public const string column٠lvalue  = "lvalue" ;
		 
		public string property
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠property ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠property, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? version
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠version ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠version, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string uvalue
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠uvalue ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠uvalue, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public byte[] lvalue
		{
			get
			{
				return base.GetValueˡ<byte[]>( _dicˡ, column٠lvalue ) ; 
			}
			set
			{
				base.SetValueˡ<byte[]>( _dicˡ, column٠lvalue, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public dt_getpropertiesbyid_u٠rs1() : base()
		{
			base._dicˡ[ column٠property ] = null ;
			base._dicˡ[ column٠version ] = null ;
			base._dicˡ[ column٠uvalue ] = null ;
			base._dicˡ[ column٠lvalue ] = null ;
		 
		}

	}

}

