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
	public partial class VacantPossessionDetail : acr.RowBase
	{
		public const string column٠VacantPossessionDetailID  = "VacantPossessionDetailID" ;
		public const string column٠VacantPossessionTenantApplicable  = "VacantPossessionTenantApplicable" ;
		public const string column٠VacantPossessionTenantShopNo  = "VacantPossessionTenantShopNo" ;
		public const string column٠VacantPossessionTenantDate  = "VacantPossessionTenantDate" ;
		public const string column٠VacantPossessionLesseeApplicable  = "VacantPossessionLesseeApplicable" ;
		public const string column٠VacantPossessionLesseeShopNo  = "VacantPossessionLesseeShopNo" ;
		public const string column٠VacantPossessionLesseeDate  = "VacantPossessionLesseeDate" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		public const string column٠VacantPossessionTenantTradingName  = "VacantPossessionTenantTradingName" ;
		public const string column٠VacantPossessionLesseeTradingName  = "VacantPossessionLesseeTradingName" ;
		 
		public int? VacantPossessionDetailID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠VacantPossessionDetailID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠VacantPossessionDetailID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string VacantPossessionTenantApplicable
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠VacantPossessionTenantApplicable ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠VacantPossessionTenantApplicable, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string VacantPossessionTenantShopNo
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠VacantPossessionTenantShopNo ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠VacantPossessionTenantShopNo, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? VacantPossessionTenantDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠VacantPossessionTenantDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠VacantPossessionTenantDate, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string VacantPossessionLesseeApplicable
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠VacantPossessionLesseeApplicable ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠VacantPossessionLesseeApplicable, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string VacantPossessionLesseeShopNo
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠VacantPossessionLesseeShopNo ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠VacantPossessionLesseeShopNo, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? VacantPossessionLesseeDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠VacantPossessionLesseeDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠VacantPossessionLesseeDate, value, ref _dirtyˡ ) ; 
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
		 
		public string VacantPossessionTenantTradingName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠VacantPossessionTenantTradingName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠VacantPossessionTenantTradingName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string VacantPossessionLesseeTradingName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠VacantPossessionLesseeTradingName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠VacantPossessionLesseeTradingName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public VacantPossessionDetail() : base()
		{
			base._dicˡ[ column٠VacantPossessionDetailID ] = null ;
			base._dicˡ[ column٠VacantPossessionTenantApplicable ] = null ;
			base._dicˡ[ column٠VacantPossessionTenantShopNo ] = null ;
			base._dicˡ[ column٠VacantPossessionTenantDate ] = null ;
			base._dicˡ[ column٠VacantPossessionLesseeApplicable ] = null ;
			base._dicˡ[ column٠VacantPossessionLesseeShopNo ] = null ;
			base._dicˡ[ column٠VacantPossessionLesseeDate ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
			base._dicˡ[ column٠VacantPossessionTenantTradingName ] = null ;
			base._dicˡ[ column٠VacantPossessionLesseeTradingName ] = null ;
		 
			base._dicPKˡ[ column٠VacantPossessionDetailID ] = null ;
		 
		}

	}

}

