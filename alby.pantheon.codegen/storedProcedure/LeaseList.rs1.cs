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
	public partial class LeaseList٠rs1 : acr.RowBase
	{
		public const string column٠LeaseID  = "LeaseID" ;
		public const string column٠LeaseStatus  = "LeaseStatus" ;
		public const string column٠PIMSUsageCode  = "PIMSUsageCode" ;
		public const string column٠LeaseTypeID  = "LeaseTypeID" ;
		public const string column٠CostCentreStageID  = "CostCentreStageID" ;
		public const string column٠StageNumber  = "StageNumber" ;
		public const string column٠ShopNo  = "ShopNo" ;
		public const string column٠Level  = "Level" ;
		public const string column٠Area  = "Area" ;
		public const string column٠AreaType  = "AreaType" ;
		public const string column٠PrecinctID  = "PrecinctID" ;
		public const string column٠SectorID  = "SectorID" ;
		public const string column٠ShopTypeID  = "ShopTypeID" ;
		public const string column٠LeaseExecutiveID  = "LeaseExecutiveID" ;
		public const string column٠LeaseGuarantorID  = "LeaseGuarantorID" ;
		public const string column٠LesseeID  = "LesseeID" ;
		public const string column٠SolicitorID  = "SolicitorID" ;
		public const string column٠CommenceDate  = "CommenceDate" ;
		public const string column٠ExpiryDate  = "ExpiryDate" ;
		public const string column٠LeaseTermYears  = "LeaseTermYears" ;
		public const string column٠LeaseTermMonths  = "LeaseTermMonths" ;
		public const string column٠LeaseTermDays  = "LeaseTermDays" ;
		public const string column٠LeaseTermText  = "LeaseTermText" ;
		public const string column٠LOIIssueDate  = "LOIIssueDate" ;
		public const string column٠LOIDueDate  = "LOIDueDate" ;
		public const string column٠CompanyName  = "CompanyName" ;
		public const string column٠ACN  = "ACN" ;
		public const string column٠ABN  = "ABN" ;
		public const string column٠LesseeName  = "LesseeName" ;
		public const string column٠TradingName  = "TradingName" ;
		public const string column٠ChainID  = "ChainID" ;
		public const string column٠SalesCategoryID  = "SalesCategoryID" ;
		public const string column٠PermittedUse  = "PermittedUse" ;
		public const string column٠ExpenseDetailID  = "ExpenseDetailID" ;
		public const string column٠FitoutDetailID  = "FitoutDetailID" ;
		public const string column٠LeaseAdministrationID  = "LeaseAdministrationID" ;
		public const string column٠LeaseCommentID  = "LeaseCommentID" ;
		public const string column٠LeaseConditionID  = "LeaseConditionID" ;
		public const string column٠RentDetailID  = "RentDetailID" ;
		public const string column٠SurrenderDetailID  = "SurrenderDetailID" ;
		public const string column٠VacantPossessionDetailID  = "VacantPossessionDetailID" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? LeaseID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string LeaseStatus
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠LeaseStatus ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠LeaseStatus, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string PIMSUsageCode
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠PIMSUsageCode ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠PIMSUsageCode, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseTypeID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseTypeID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseTypeID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? CostCentreStageID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠CostCentreStageID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠CostCentreStageID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string StageNumber
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠StageNumber ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠StageNumber, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string ShopNo
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠ShopNo ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠ShopNo, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Level
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Level ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Level, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? Area
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠Area ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠Area, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string AreaType
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠AreaType ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠AreaType, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? PrecinctID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠PrecinctID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠PrecinctID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? SectorID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠SectorID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠SectorID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? ShopTypeID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠ShopTypeID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠ShopTypeID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseExecutiveID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseExecutiveID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseExecutiveID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseGuarantorID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseGuarantorID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseGuarantorID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LesseeID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LesseeID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LesseeID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? SolicitorID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠SolicitorID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠SolicitorID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? CommenceDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠CommenceDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠CommenceDate, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? ExpiryDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠ExpiryDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠ExpiryDate, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseTermYears
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseTermYears ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseTermYears, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseTermMonths
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseTermMonths ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseTermMonths, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseTermDays
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseTermDays ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseTermDays, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string LeaseTermText
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠LeaseTermText ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠LeaseTermText, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? LOIIssueDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠LOIIssueDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠LOIIssueDate, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? LOIDueDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠LOIDueDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠LOIDueDate, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string CompanyName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠CompanyName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠CompanyName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string ACN
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠ACN ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠ACN, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string ABN
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠ABN ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠ABN, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string LesseeName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠LesseeName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠LesseeName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string TradingName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠TradingName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠TradingName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? ChainID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠ChainID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠ChainID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? SalesCategoryID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠SalesCategoryID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠SalesCategoryID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string PermittedUse
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠PermittedUse ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠PermittedUse, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? ExpenseDetailID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠ExpenseDetailID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠ExpenseDetailID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? FitoutDetailID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠FitoutDetailID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠FitoutDetailID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseAdministrationID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseAdministrationID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseAdministrationID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseCommentID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseCommentID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseCommentID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseConditionID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseConditionID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseConditionID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? RentDetailID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠RentDetailID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠RentDetailID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? SurrenderDetailID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠SurrenderDetailID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠SurrenderDetailID, value, ref _dirtyˡ ) ; 
			}
		}
		 
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
		 
		public LeaseList٠rs1() : base()
		{
			base._dicˡ[ column٠LeaseID ] = null ;
			base._dicˡ[ column٠LeaseStatus ] = null ;
			base._dicˡ[ column٠PIMSUsageCode ] = null ;
			base._dicˡ[ column٠LeaseTypeID ] = null ;
			base._dicˡ[ column٠CostCentreStageID ] = null ;
			base._dicˡ[ column٠StageNumber ] = null ;
			base._dicˡ[ column٠ShopNo ] = null ;
			base._dicˡ[ column٠Level ] = null ;
			base._dicˡ[ column٠Area ] = null ;
			base._dicˡ[ column٠AreaType ] = null ;
			base._dicˡ[ column٠PrecinctID ] = null ;
			base._dicˡ[ column٠SectorID ] = null ;
			base._dicˡ[ column٠ShopTypeID ] = null ;
			base._dicˡ[ column٠LeaseExecutiveID ] = null ;
			base._dicˡ[ column٠LeaseGuarantorID ] = null ;
			base._dicˡ[ column٠LesseeID ] = null ;
			base._dicˡ[ column٠SolicitorID ] = null ;
			base._dicˡ[ column٠CommenceDate ] = null ;
			base._dicˡ[ column٠ExpiryDate ] = null ;
			base._dicˡ[ column٠LeaseTermYears ] = null ;
			base._dicˡ[ column٠LeaseTermMonths ] = null ;
			base._dicˡ[ column٠LeaseTermDays ] = null ;
			base._dicˡ[ column٠LeaseTermText ] = null ;
			base._dicˡ[ column٠LOIIssueDate ] = null ;
			base._dicˡ[ column٠LOIDueDate ] = null ;
			base._dicˡ[ column٠CompanyName ] = null ;
			base._dicˡ[ column٠ACN ] = null ;
			base._dicˡ[ column٠ABN ] = null ;
			base._dicˡ[ column٠LesseeName ] = null ;
			base._dicˡ[ column٠TradingName ] = null ;
			base._dicˡ[ column٠ChainID ] = null ;
			base._dicˡ[ column٠SalesCategoryID ] = null ;
			base._dicˡ[ column٠PermittedUse ] = null ;
			base._dicˡ[ column٠ExpenseDetailID ] = null ;
			base._dicˡ[ column٠FitoutDetailID ] = null ;
			base._dicˡ[ column٠LeaseAdministrationID ] = null ;
			base._dicˡ[ column٠LeaseCommentID ] = null ;
			base._dicˡ[ column٠LeaseConditionID ] = null ;
			base._dicˡ[ column٠RentDetailID ] = null ;
			base._dicˡ[ column٠SurrenderDetailID ] = null ;
			base._dicˡ[ column٠VacantPossessionDetailID ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
		}

	}

}

