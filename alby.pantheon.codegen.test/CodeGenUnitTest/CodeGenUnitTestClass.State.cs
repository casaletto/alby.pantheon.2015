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

using nu = NUnit.Framework;
using t = alby.pantheon.codegen.table ;

namespace alby.pantheon.codegen.test
{
	public partial class CodeGenUnitTestClass : acr.CodeGenUnitTestBase
	{
		// Address
		protected t.AddressFactory factory٠AddressFactory = new t.AddressFactory() ;
		 
		protected t.Address obj0٠Address = new t.Address() ;
		protected t.Address obj1٠Address = null ;
		protected t.Address obj2٠Address = null ;
		protected t.Address obj3٠Address = null ;
		 
		protected int rowcount0٠Address = 0 ;
		protected int rowcount1٠Address = 0 ;
		protected int rowcount2٠Address = 0 ;
		protected int rowcount3٠Address = 0 ;
		 
		// Auditing
		protected t.AuditingFactory factory٠AuditingFactory = new t.AuditingFactory() ;
		 
		protected t.Auditing obj0٠Auditing = new t.Auditing() ;
		protected t.Auditing obj1٠Auditing = null ;
		protected t.Auditing obj2٠Auditing = null ;
		protected t.Auditing obj3٠Auditing = null ;
		 
		protected int rowcount0٠Auditing = 0 ;
		protected int rowcount1٠Auditing = 0 ;
		protected int rowcount2٠Auditing = 0 ;
		protected int rowcount3٠Auditing = 0 ;
		 
		// Centre
		protected t.CentreFactory factory٠CentreFactory = new t.CentreFactory() ;
		 
		protected t.Centre obj0٠Centre = new t.Centre() ;
		protected t.Centre obj1٠Centre = null ;
		protected t.Centre obj2٠Centre = null ;
		protected t.Centre obj3٠Centre = null ;
		 
		protected int rowcount0٠Centre = 0 ;
		protected int rowcount1٠Centre = 0 ;
		protected int rowcount2٠Centre = 0 ;
		protected int rowcount3٠Centre = 0 ;
		 
		// Chain
		protected t.ChainFactory factory٠ChainFactory = new t.ChainFactory() ;
		 
		protected t.Chain obj0٠Chain = new t.Chain() ;
		protected t.Chain obj1٠Chain = null ;
		protected t.Chain obj2٠Chain = null ;
		protected t.Chain obj3٠Chain = null ;
		 
		protected int rowcount0٠Chain = 0 ;
		protected int rowcount1٠Chain = 0 ;
		protected int rowcount2٠Chain = 0 ;
		protected int rowcount3٠Chain = 0 ;
		 
		// Communication
		protected t.CommunicationFactory factory٠CommunicationFactory = new t.CommunicationFactory() ;
		 
		protected t.Communication obj0٠Communication = new t.Communication() ;
		protected t.Communication obj1٠Communication = null ;
		protected t.Communication obj2٠Communication = null ;
		protected t.Communication obj3٠Communication = null ;
		 
		protected int rowcount0٠Communication = 0 ;
		protected int rowcount1٠Communication = 0 ;
		protected int rowcount2٠Communication = 0 ;
		protected int rowcount3٠Communication = 0 ;
		 
		// ConsumerPriceIndexRentReview
		protected t.ConsumerPriceIndexRentReviewFactory factory٠ConsumerPriceIndexRentReviewFactory = new t.ConsumerPriceIndexRentReviewFactory() ;
		 
		protected t.ConsumerPriceIndexRentReview obj0٠ConsumerPriceIndexRentReview = new t.ConsumerPriceIndexRentReview() ;
		protected t.ConsumerPriceIndexRentReview obj1٠ConsumerPriceIndexRentReview = null ;
		protected t.ConsumerPriceIndexRentReview obj2٠ConsumerPriceIndexRentReview = null ;
		protected t.ConsumerPriceIndexRentReview obj3٠ConsumerPriceIndexRentReview = null ;
		 
		protected int rowcount0٠ConsumerPriceIndexRentReview = 0 ;
		protected int rowcount1٠ConsumerPriceIndexRentReview = 0 ;
		protected int rowcount2٠ConsumerPriceIndexRentReview = 0 ;
		protected int rowcount3٠ConsumerPriceIndexRentReview = 0 ;
		 
		// CostCentreOutgoing
		protected t.CostCentreOutgoingFactory factory٠CostCentreOutgoingFactory = new t.CostCentreOutgoingFactory() ;
		 
		protected t.CostCentreOutgoing obj0٠CostCentreOutgoing = new t.CostCentreOutgoing() ;
		protected t.CostCentreOutgoing obj1٠CostCentreOutgoing = null ;
		protected t.CostCentreOutgoing obj2٠CostCentreOutgoing = null ;
		protected t.CostCentreOutgoing obj3٠CostCentreOutgoing = null ;
		 
		protected int rowcount0٠CostCentreOutgoing = 0 ;
		protected int rowcount1٠CostCentreOutgoing = 0 ;
		protected int rowcount2٠CostCentreOutgoing = 0 ;
		protected int rowcount3٠CostCentreOutgoing = 0 ;
		 
		// CostCentreOutgoingArchive
		protected t.CostCentreOutgoingArchiveFactory factory٠CostCentreOutgoingArchiveFactory = new t.CostCentreOutgoingArchiveFactory() ;
		 
		protected t.CostCentreOutgoingArchive obj0٠CostCentreOutgoingArchive = new t.CostCentreOutgoingArchive() ;
		protected t.CostCentreOutgoingArchive obj1٠CostCentreOutgoingArchive = null ;
		protected t.CostCentreOutgoingArchive obj2٠CostCentreOutgoingArchive = null ;
		protected t.CostCentreOutgoingArchive obj3٠CostCentreOutgoingArchive = null ;
		 
		protected int rowcount0٠CostCentreOutgoingArchive = 0 ;
		protected int rowcount1٠CostCentreOutgoingArchive = 0 ;
		protected int rowcount2٠CostCentreOutgoingArchive = 0 ;
		protected int rowcount3٠CostCentreOutgoingArchive = 0 ;
		 
		// CostCentreStage
		protected t.CostCentreStageFactory factory٠CostCentreStageFactory = new t.CostCentreStageFactory() ;
		 
		protected t.CostCentreStage obj0٠CostCentreStage = new t.CostCentreStage() ;
		protected t.CostCentreStage obj1٠CostCentreStage = null ;
		protected t.CostCentreStage obj2٠CostCentreStage = null ;
		protected t.CostCentreStage obj3٠CostCentreStage = null ;
		 
		protected int rowcount0٠CostCentreStage = 0 ;
		protected int rowcount1٠CostCentreStage = 0 ;
		protected int rowcount2٠CostCentreStage = 0 ;
		protected int rowcount3٠CostCentreStage = 0 ;
		 
		// databaseVersion
		protected t.databaseVersionFactory factory٠databaseVersionFactory = new t.databaseVersionFactory() ;
		 
		protected t.databaseVersion obj0٠databaseVersion = new t.databaseVersion() ;
		protected t.databaseVersion obj1٠databaseVersion = null ;
		protected t.databaseVersion obj2٠databaseVersion = null ;
		protected t.databaseVersion obj3٠databaseVersion = null ;
		 
		protected int rowcount0٠databaseVersion = 0 ;
		protected int rowcount1٠databaseVersion = 0 ;
		protected int rowcount2٠databaseVersion = 0 ;
		protected int rowcount3٠databaseVersion = 0 ;
		 
		// Document
		protected t.DocumentFactory factory٠DocumentFactory = new t.DocumentFactory() ;
		 
		protected t.Document obj0٠Document = new t.Document() ;
		protected t.Document obj1٠Document = null ;
		protected t.Document obj2٠Document = null ;
		protected t.Document obj3٠Document = null ;
		 
		protected int rowcount0٠Document = 0 ;
		protected int rowcount1٠Document = 0 ;
		protected int rowcount2٠Document = 0 ;
		protected int rowcount3٠Document = 0 ;
		 
		// dtproperties
		protected t.dtpropertiesFactory factory٠dtpropertiesFactory = new t.dtpropertiesFactory() ;
		 
		protected t.dtproperties obj0٠dtproperties = new t.dtproperties() ;
		protected t.dtproperties obj1٠dtproperties = null ;
		protected t.dtproperties obj2٠dtproperties = null ;
		protected t.dtproperties obj3٠dtproperties = null ;
		 
		protected int rowcount0٠dtproperties = 0 ;
		protected int rowcount1٠dtproperties = 0 ;
		protected int rowcount2٠dtproperties = 0 ;
		protected int rowcount3٠dtproperties = 0 ;
		 
		// Email
		protected t.EmailFactory factory٠EmailFactory = new t.EmailFactory() ;
		 
		protected t.Email obj0٠Email = new t.Email() ;
		protected t.Email obj1٠Email = null ;
		protected t.Email obj2٠Email = null ;
		protected t.Email obj3٠Email = null ;
		 
		protected int rowcount0٠Email = 0 ;
		protected int rowcount1٠Email = 0 ;
		protected int rowcount2٠Email = 0 ;
		protected int rowcount3٠Email = 0 ;
		 
		// ExpenseDetail
		protected t.ExpenseDetailFactory factory٠ExpenseDetailFactory = new t.ExpenseDetailFactory() ;
		 
		protected t.ExpenseDetail obj0٠ExpenseDetail = new t.ExpenseDetail() ;
		protected t.ExpenseDetail obj1٠ExpenseDetail = null ;
		protected t.ExpenseDetail obj2٠ExpenseDetail = null ;
		protected t.ExpenseDetail obj3٠ExpenseDetail = null ;
		 
		protected int rowcount0٠ExpenseDetail = 0 ;
		protected int rowcount1٠ExpenseDetail = 0 ;
		protected int rowcount2٠ExpenseDetail = 0 ;
		protected int rowcount3٠ExpenseDetail = 0 ;
		 
		// FitoutDetail
		protected t.FitoutDetailFactory factory٠FitoutDetailFactory = new t.FitoutDetailFactory() ;
		 
		protected t.FitoutDetail obj0٠FitoutDetail = new t.FitoutDetail() ;
		protected t.FitoutDetail obj1٠FitoutDetail = null ;
		protected t.FitoutDetail obj2٠FitoutDetail = null ;
		protected t.FitoutDetail obj3٠FitoutDetail = null ;
		 
		protected int rowcount0٠FitoutDetail = 0 ;
		protected int rowcount1٠FitoutDetail = 0 ;
		protected int rowcount2٠FitoutDetail = 0 ;
		protected int rowcount3٠FitoutDetail = 0 ;
		 
		// FixedIncreaseRentReview
		protected t.FixedIncreaseRentReviewFactory factory٠FixedIncreaseRentReviewFactory = new t.FixedIncreaseRentReviewFactory() ;
		 
		protected t.FixedIncreaseRentReview obj0٠FixedIncreaseRentReview = new t.FixedIncreaseRentReview() ;
		protected t.FixedIncreaseRentReview obj1٠FixedIncreaseRentReview = null ;
		protected t.FixedIncreaseRentReview obj2٠FixedIncreaseRentReview = null ;
		protected t.FixedIncreaseRentReview obj3٠FixedIncreaseRentReview = null ;
		 
		protected int rowcount0٠FixedIncreaseRentReview = 0 ;
		protected int rowcount1٠FixedIncreaseRentReview = 0 ;
		protected int rowcount2٠FixedIncreaseRentReview = 0 ;
		protected int rowcount3٠FixedIncreaseRentReview = 0 ;
		 
		// Franchise
		protected t.FranchiseFactory factory٠FranchiseFactory = new t.FranchiseFactory() ;
		 
		protected t.Franchise obj0٠Franchise = new t.Franchise() ;
		protected t.Franchise obj1٠Franchise = null ;
		protected t.Franchise obj2٠Franchise = null ;
		protected t.Franchise obj3٠Franchise = null ;
		 
		protected int rowcount0٠Franchise = 0 ;
		protected int rowcount1٠Franchise = 0 ;
		protected int rowcount2٠Franchise = 0 ;
		protected int rowcount3٠Franchise = 0 ;
		 
		// IDGenerator
		protected t.IDGeneratorFactory factory٠IDGeneratorFactory = new t.IDGeneratorFactory() ;
		 
		protected t.IDGenerator obj0٠IDGenerator = new t.IDGenerator() ;
		protected t.IDGenerator obj1٠IDGenerator = null ;
		protected t.IDGenerator obj2٠IDGenerator = null ;
		protected t.IDGenerator obj3٠IDGenerator = null ;
		 
		protected int rowcount0٠IDGenerator = 0 ;
		protected int rowcount1٠IDGenerator = 0 ;
		protected int rowcount2٠IDGenerator = 0 ;
		protected int rowcount3٠IDGenerator = 0 ;
		 
		// Lease
		protected t.LeaseFactory factory٠LeaseFactory = new t.LeaseFactory() ;
		 
		protected t.Lease obj0٠Lease = new t.Lease() ;
		protected t.Lease obj1٠Lease = null ;
		protected t.Lease obj2٠Lease = null ;
		protected t.Lease obj3٠Lease = null ;
		 
		protected int rowcount0٠Lease = 0 ;
		protected int rowcount1٠Lease = 0 ;
		protected int rowcount2٠Lease = 0 ;
		protected int rowcount3٠Lease = 0 ;
		 
		// LeaseAdministration
		protected t.LeaseAdministrationFactory factory٠LeaseAdministrationFactory = new t.LeaseAdministrationFactory() ;
		 
		protected t.LeaseAdministration obj0٠LeaseAdministration = new t.LeaseAdministration() ;
		protected t.LeaseAdministration obj1٠LeaseAdministration = null ;
		protected t.LeaseAdministration obj2٠LeaseAdministration = null ;
		protected t.LeaseAdministration obj3٠LeaseAdministration = null ;
		 
		protected int rowcount0٠LeaseAdministration = 0 ;
		protected int rowcount1٠LeaseAdministration = 0 ;
		protected int rowcount2٠LeaseAdministration = 0 ;
		protected int rowcount3٠LeaseAdministration = 0 ;
		 
		// LeaseComment
		protected t.LeaseCommentFactory factory٠LeaseCommentFactory = new t.LeaseCommentFactory() ;
		 
		protected t.LeaseComment obj0٠LeaseComment = new t.LeaseComment() ;
		protected t.LeaseComment obj1٠LeaseComment = null ;
		protected t.LeaseComment obj2٠LeaseComment = null ;
		protected t.LeaseComment obj3٠LeaseComment = null ;
		 
		protected int rowcount0٠LeaseComment = 0 ;
		protected int rowcount1٠LeaseComment = 0 ;
		protected int rowcount2٠LeaseComment = 0 ;
		protected int rowcount3٠LeaseComment = 0 ;
		 
		// LeaseCondition
		protected t.LeaseConditionFactory factory٠LeaseConditionFactory = new t.LeaseConditionFactory() ;
		 
		protected t.LeaseCondition obj0٠LeaseCondition = new t.LeaseCondition() ;
		protected t.LeaseCondition obj1٠LeaseCondition = null ;
		protected t.LeaseCondition obj2٠LeaseCondition = null ;
		protected t.LeaseCondition obj3٠LeaseCondition = null ;
		 
		protected int rowcount0٠LeaseCondition = 0 ;
		protected int rowcount1٠LeaseCondition = 0 ;
		protected int rowcount2٠LeaseCondition = 0 ;
		protected int rowcount3٠LeaseCondition = 0 ;
		 
		// LeaseExecutive
		protected t.LeaseExecutiveFactory factory٠LeaseExecutiveFactory = new t.LeaseExecutiveFactory() ;
		 
		protected t.LeaseExecutive obj0٠LeaseExecutive = new t.LeaseExecutive() ;
		protected t.LeaseExecutive obj1٠LeaseExecutive = null ;
		protected t.LeaseExecutive obj2٠LeaseExecutive = null ;
		protected t.LeaseExecutive obj3٠LeaseExecutive = null ;
		 
		protected int rowcount0٠LeaseExecutive = 0 ;
		protected int rowcount1٠LeaseExecutive = 0 ;
		protected int rowcount2٠LeaseExecutive = 0 ;
		protected int rowcount3٠LeaseExecutive = 0 ;
		 
		// LeaseGuarantor
		protected t.LeaseGuarantorFactory factory٠LeaseGuarantorFactory = new t.LeaseGuarantorFactory() ;
		 
		protected t.LeaseGuarantor obj0٠LeaseGuarantor = new t.LeaseGuarantor() ;
		protected t.LeaseGuarantor obj1٠LeaseGuarantor = null ;
		protected t.LeaseGuarantor obj2٠LeaseGuarantor = null ;
		protected t.LeaseGuarantor obj3٠LeaseGuarantor = null ;
		 
		protected int rowcount0٠LeaseGuarantor = 0 ;
		protected int rowcount1٠LeaseGuarantor = 0 ;
		protected int rowcount2٠LeaseGuarantor = 0 ;
		protected int rowcount3٠LeaseGuarantor = 0 ;
		 
		// LeaseType
		protected t.LeaseTypeFactory factory٠LeaseTypeFactory = new t.LeaseTypeFactory() ;
		 
		protected t.LeaseType obj0٠LeaseType = new t.LeaseType() ;
		protected t.LeaseType obj1٠LeaseType = null ;
		protected t.LeaseType obj2٠LeaseType = null ;
		protected t.LeaseType obj3٠LeaseType = null ;
		 
		protected int rowcount0٠LeaseType = 0 ;
		protected int rowcount1٠LeaseType = 0 ;
		protected int rowcount2٠LeaseType = 0 ;
		protected int rowcount3٠LeaseType = 0 ;
		 
		// Lessee
		protected t.LesseeFactory factory٠LesseeFactory = new t.LesseeFactory() ;
		 
		protected t.Lessee obj0٠Lessee = new t.Lessee() ;
		protected t.Lessee obj1٠Lessee = null ;
		protected t.Lessee obj2٠Lessee = null ;
		protected t.Lessee obj3٠Lessee = null ;
		 
		protected int rowcount0٠Lessee = 0 ;
		protected int rowcount1٠Lessee = 0 ;
		protected int rowcount2٠Lessee = 0 ;
		protected int rowcount3٠Lessee = 0 ;
		 
		// LogEntry
		protected t.LogEntryFactory factory٠LogEntryFactory = new t.LogEntryFactory() ;
		 
		protected t.LogEntry obj0٠LogEntry = new t.LogEntry() ;
		protected t.LogEntry obj1٠LogEntry = null ;
		protected t.LogEntry obj2٠LogEntry = null ;
		protected t.LogEntry obj3٠LogEntry = null ;
		 
		protected int rowcount0٠LogEntry = 0 ;
		protected int rowcount1٠LogEntry = 0 ;
		protected int rowcount2٠LogEntry = 0 ;
		protected int rowcount3٠LogEntry = 0 ;
		 
		// Party
		protected t.PartyFactory factory٠PartyFactory = new t.PartyFactory() ;
		 
		protected t.Party obj0٠Party = new t.Party() ;
		protected t.Party obj1٠Party = null ;
		protected t.Party obj2٠Party = null ;
		protected t.Party obj3٠Party = null ;
		 
		protected int rowcount0٠Party = 0 ;
		protected int rowcount1٠Party = 0 ;
		protected int rowcount2٠Party = 0 ;
		protected int rowcount3٠Party = 0 ;
		 
		// PaymentType
		protected t.PaymentTypeFactory factory٠PaymentTypeFactory = new t.PaymentTypeFactory() ;
		 
		protected t.PaymentType obj0٠PaymentType = new t.PaymentType() ;
		protected t.PaymentType obj1٠PaymentType = null ;
		protected t.PaymentType obj2٠PaymentType = null ;
		protected t.PaymentType obj3٠PaymentType = null ;
		 
		protected int rowcount0٠PaymentType = 0 ;
		protected int rowcount1٠PaymentType = 0 ;
		protected int rowcount2٠PaymentType = 0 ;
		protected int rowcount3٠PaymentType = 0 ;
		 
		// Precinct
		protected t.PrecinctFactory factory٠PrecinctFactory = new t.PrecinctFactory() ;
		 
		protected t.Precinct obj0٠Precinct = new t.Precinct() ;
		protected t.Precinct obj1٠Precinct = null ;
		protected t.Precinct obj2٠Precinct = null ;
		protected t.Precinct obj3٠Precinct = null ;
		 
		protected int rowcount0٠Precinct = 0 ;
		protected int rowcount1٠Precinct = 0 ;
		protected int rowcount2٠Precinct = 0 ;
		protected int rowcount3٠Precinct = 0 ;
		 
		// RDMFeeParam
		protected t.RDMFeeParamFactory factory٠RDMFeeParamFactory = new t.RDMFeeParamFactory() ;
		 
		protected t.RDMFeeParam obj0٠RDMFeeParam = new t.RDMFeeParam() ;
		protected t.RDMFeeParam obj1٠RDMFeeParam = null ;
		protected t.RDMFeeParam obj2٠RDMFeeParam = null ;
		protected t.RDMFeeParam obj3٠RDMFeeParam = null ;
		 
		protected int rowcount0٠RDMFeeParam = 0 ;
		protected int rowcount1٠RDMFeeParam = 0 ;
		protected int rowcount2٠RDMFeeParam = 0 ;
		protected int rowcount3٠RDMFeeParam = 0 ;
		 
		// RentDetail
		protected t.RentDetailFactory factory٠RentDetailFactory = new t.RentDetailFactory() ;
		 
		protected t.RentDetail obj0٠RentDetail = new t.RentDetail() ;
		protected t.RentDetail obj1٠RentDetail = null ;
		protected t.RentDetail obj2٠RentDetail = null ;
		protected t.RentDetail obj3٠RentDetail = null ;
		 
		protected int rowcount0٠RentDetail = 0 ;
		protected int rowcount1٠RentDetail = 0 ;
		protected int rowcount2٠RentDetail = 0 ;
		protected int rowcount3٠RentDetail = 0 ;
		 
		// RentReview
		protected t.RentReviewFactory factory٠RentReviewFactory = new t.RentReviewFactory() ;
		 
		protected t.RentReview obj0٠RentReview = new t.RentReview() ;
		protected t.RentReview obj1٠RentReview = null ;
		protected t.RentReview obj2٠RentReview = null ;
		protected t.RentReview obj3٠RentReview = null ;
		 
		protected int rowcount0٠RentReview = 0 ;
		protected int rowcount1٠RentReview = 0 ;
		protected int rowcount2٠RentReview = 0 ;
		protected int rowcount3٠RentReview = 0 ;
		 
		// RentReviewType
		protected t.RentReviewTypeFactory factory٠RentReviewTypeFactory = new t.RentReviewTypeFactory() ;
		 
		protected t.RentReviewType obj0٠RentReviewType = new t.RentReviewType() ;
		protected t.RentReviewType obj1٠RentReviewType = null ;
		protected t.RentReviewType obj2٠RentReviewType = null ;
		protected t.RentReviewType obj3٠RentReviewType = null ;
		 
		protected int rowcount0٠RentReviewType = 0 ;
		protected int rowcount1٠RentReviewType = 0 ;
		protected int rowcount2٠RentReviewType = 0 ;
		protected int rowcount3٠RentReviewType = 0 ;
		 
		// SalesCategory
		protected t.SalesCategoryFactory factory٠SalesCategoryFactory = new t.SalesCategoryFactory() ;
		 
		protected t.SalesCategory obj0٠SalesCategory = new t.SalesCategory() ;
		protected t.SalesCategory obj1٠SalesCategory = null ;
		protected t.SalesCategory obj2٠SalesCategory = null ;
		protected t.SalesCategory obj3٠SalesCategory = null ;
		 
		protected int rowcount0٠SalesCategory = 0 ;
		protected int rowcount1٠SalesCategory = 0 ;
		protected int rowcount2٠SalesCategory = 0 ;
		protected int rowcount3٠SalesCategory = 0 ;
		 
		// Sector
		protected t.SectorFactory factory٠SectorFactory = new t.SectorFactory() ;
		 
		protected t.Sector obj0٠Sector = new t.Sector() ;
		protected t.Sector obj1٠Sector = null ;
		protected t.Sector obj2٠Sector = null ;
		protected t.Sector obj3٠Sector = null ;
		 
		protected int rowcount0٠Sector = 0 ;
		protected int rowcount1٠Sector = 0 ;
		protected int rowcount2٠Sector = 0 ;
		protected int rowcount3٠Sector = 0 ;
		 
		// ShopType
		protected t.ShopTypeFactory factory٠ShopTypeFactory = new t.ShopTypeFactory() ;
		 
		protected t.ShopType obj0٠ShopType = new t.ShopType() ;
		protected t.ShopType obj1٠ShopType = null ;
		protected t.ShopType obj2٠ShopType = null ;
		protected t.ShopType obj3٠ShopType = null ;
		 
		protected int rowcount0٠ShopType = 0 ;
		protected int rowcount1٠ShopType = 0 ;
		protected int rowcount2٠ShopType = 0 ;
		protected int rowcount3٠ShopType = 0 ;
		 
		// Solicitor
		protected t.SolicitorFactory factory٠SolicitorFactory = new t.SolicitorFactory() ;
		 
		protected t.Solicitor obj0٠Solicitor = new t.Solicitor() ;
		protected t.Solicitor obj1٠Solicitor = null ;
		protected t.Solicitor obj2٠Solicitor = null ;
		protected t.Solicitor obj3٠Solicitor = null ;
		 
		protected int rowcount0٠Solicitor = 0 ;
		protected int rowcount1٠Solicitor = 0 ;
		protected int rowcount2٠Solicitor = 0 ;
		protected int rowcount3٠Solicitor = 0 ;
		 
		// SolicitorWebService
		protected t.SolicitorWebServiceFactory factory٠SolicitorWebServiceFactory = new t.SolicitorWebServiceFactory() ;
		 
		protected t.SolicitorWebService obj0٠SolicitorWebService = new t.SolicitorWebService() ;
		protected t.SolicitorWebService obj1٠SolicitorWebService = null ;
		protected t.SolicitorWebService obj2٠SolicitorWebService = null ;
		protected t.SolicitorWebService obj3٠SolicitorWebService = null ;
		 
		protected int rowcount0٠SolicitorWebService = 0 ;
		protected int rowcount1٠SolicitorWebService = 0 ;
		protected int rowcount2٠SolicitorWebService = 0 ;
		protected int rowcount3٠SolicitorWebService = 0 ;
		 
		// Staff
		protected t.StaffFactory factory٠StaffFactory = new t.StaffFactory() ;
		 
		protected t.Staff obj0٠Staff = new t.Staff() ;
		protected t.Staff obj1٠Staff = null ;
		protected t.Staff obj2٠Staff = null ;
		protected t.Staff obj3٠Staff = null ;
		 
		protected int rowcount0٠Staff = 0 ;
		protected int rowcount1٠Staff = 0 ;
		protected int rowcount2٠Staff = 0 ;
		protected int rowcount3٠Staff = 0 ;
		 
		// SurrenderDetail
		protected t.SurrenderDetailFactory factory٠SurrenderDetailFactory = new t.SurrenderDetailFactory() ;
		 
		protected t.SurrenderDetail obj0٠SurrenderDetail = new t.SurrenderDetail() ;
		protected t.SurrenderDetail obj1٠SurrenderDetail = null ;
		protected t.SurrenderDetail obj2٠SurrenderDetail = null ;
		protected t.SurrenderDetail obj3٠SurrenderDetail = null ;
		 
		protected int rowcount0٠SurrenderDetail = 0 ;
		protected int rowcount1٠SurrenderDetail = 0 ;
		protected int rowcount2٠SurrenderDetail = 0 ;
		protected int rowcount3٠SurrenderDetail = 0 ;
		 
		// VacantPossessionDetail
		protected t.VacantPossessionDetailFactory factory٠VacantPossessionDetailFactory = new t.VacantPossessionDetailFactory() ;
		 
		protected t.VacantPossessionDetail obj0٠VacantPossessionDetail = new t.VacantPossessionDetail() ;
		protected t.VacantPossessionDetail obj1٠VacantPossessionDetail = null ;
		protected t.VacantPossessionDetail obj2٠VacantPossessionDetail = null ;
		protected t.VacantPossessionDetail obj3٠VacantPossessionDetail = null ;
		 
		protected int rowcount0٠VacantPossessionDetail = 0 ;
		protected int rowcount1٠VacantPossessionDetail = 0 ;
		protected int rowcount2٠VacantPossessionDetail = 0 ;
		protected int rowcount3٠VacantPossessionDetail = 0 ;
		 
	}

}

