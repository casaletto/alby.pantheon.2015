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
	public partial class IDGeneratorGet٠rs1 : acr.RowBase
	{
		public const string column٠ID  = "ID" ;
		public const string column٠NewID  = "NewID" ;
		public const string column٠AssignedTypeDescription  = "AssignedTypeDescription" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? ID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠ID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠ID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? NewID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠NewID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠NewID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string AssignedTypeDescription
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠AssignedTypeDescription ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠AssignedTypeDescription, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string UpdateUserCode
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠UpdateUserCode ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠UpdateUserCode, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? UpdateDateTime
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠UpdateDateTime ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠UpdateDateTime, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public byte[] RowTimestamp
		{
			get
			{
				return base.GetValueˡ<byte[]>( _dicˡ, column٠RowTimestamp ) ; 
			}
			set
			{
				base.SetValueˡ<byte[]>( _dicˡ, column٠RowTimestamp, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public IDGeneratorGet٠rs1() : base()
		{
			base._dicˡ[ column٠ID ] = null ;
			base._dicˡ[ column٠NewID ] = null ;
			base._dicˡ[ column٠AssignedTypeDescription ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
		}

	}

}

