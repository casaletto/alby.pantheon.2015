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
	public partial class PaymentType : acr.RowBase
	{
		public const string column٠PaymentTypeID  = "PaymentTypeID" ;
		public const string column٠PaymentTypeDescription  = "PaymentTypeDescription" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? PaymentTypeID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠PaymentTypeID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠PaymentTypeID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string PaymentTypeDescription
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠PaymentTypeDescription ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠PaymentTypeDescription, value, ref _dirtyˡ ) ; 
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
		 
		public PaymentType() : base()
		{
			base._dicˡ[ column٠PaymentTypeID ] = null ;
			base._dicˡ[ column٠PaymentTypeDescription ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
			base._dicPKˡ[ column٠PaymentTypeID ] = null ;
		 
		}

	}

}
