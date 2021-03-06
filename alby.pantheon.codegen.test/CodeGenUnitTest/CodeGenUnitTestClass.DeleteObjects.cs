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
		protected void DeleteObjects()
		{
			// LogEntry
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[1/40] LogEntry - delete" ) ;
			obj2٠LogEntry.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠LogEntry ) ;
			obj3٠LogEntry = factory٠LogEntryFactory.Saveˡ( _connection, obj2٠LogEntry ) ;
			nu.Assert.IsNull( obj3٠LogEntry ) ;
			base.AssertFlagsAfterDelete( obj2٠LogEntry ) ;
			rowcount3٠LogEntry = factory٠LogEntryFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠LogEntry, rowcount0٠LogEntry ) ;
			 
			// LeaseGuarantor
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[2/40] LeaseGuarantor - delete" ) ;
			obj2٠LeaseGuarantor.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠LeaseGuarantor ) ;
			obj3٠LeaseGuarantor = factory٠LeaseGuarantorFactory.Saveˡ( _connection, obj2٠LeaseGuarantor ) ;
			nu.Assert.IsNull( obj3٠LeaseGuarantor ) ;
			base.AssertFlagsAfterDelete( obj2٠LeaseGuarantor ) ;
			rowcount3٠LeaseGuarantor = factory٠LeaseGuarantorFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠LeaseGuarantor, rowcount0٠LeaseGuarantor ) ;
			 
			// Lease
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[3/40] Lease - delete" ) ;
			obj2٠Lease.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Lease ) ;
			obj3٠Lease = factory٠LeaseFactory.Saveˡ( _connection, obj2٠Lease ) ;
			nu.Assert.IsNull( obj3٠Lease ) ;
			base.AssertFlagsAfterDelete( obj2٠Lease ) ;
			rowcount3٠Lease = factory٠LeaseFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Lease, rowcount0٠Lease ) ;
			 
			// LeaseAdministration
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[4/40] LeaseAdministration - delete" ) ;
			obj2٠LeaseAdministration.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠LeaseAdministration ) ;
			obj3٠LeaseAdministration = factory٠LeaseAdministrationFactory.Saveˡ( _connection, obj2٠LeaseAdministration ) ;
			nu.Assert.IsNull( obj3٠LeaseAdministration ) ;
			base.AssertFlagsAfterDelete( obj2٠LeaseAdministration ) ;
			rowcount3٠LeaseAdministration = factory٠LeaseAdministrationFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠LeaseAdministration, rowcount0٠LeaseAdministration ) ;
			 
			// Staff
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[5/40] Staff - delete" ) ;
			obj2٠Staff.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Staff ) ;
			obj3٠Staff = factory٠StaffFactory.Saveˡ( _connection, obj2٠Staff ) ;
			nu.Assert.IsNull( obj3٠Staff ) ;
			base.AssertFlagsAfterDelete( obj2٠Staff ) ;
			rowcount3٠Staff = factory٠StaffFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Staff, rowcount0٠Staff ) ;
			 
			// Solicitor
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[6/40] Solicitor - delete" ) ;
			obj2٠Solicitor.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Solicitor ) ;
			obj3٠Solicitor = factory٠SolicitorFactory.Saveˡ( _connection, obj2٠Solicitor ) ;
			nu.Assert.IsNull( obj3٠Solicitor ) ;
			base.AssertFlagsAfterDelete( obj2٠Solicitor ) ;
			rowcount3٠Solicitor = factory٠SolicitorFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Solicitor, rowcount0٠Solicitor ) ;
			 
			// RentDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[7/40] RentDetail - delete" ) ;
			obj2٠RentDetail.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠RentDetail ) ;
			obj3٠RentDetail = factory٠RentDetailFactory.Saveˡ( _connection, obj2٠RentDetail ) ;
			nu.Assert.IsNull( obj3٠RentDetail ) ;
			base.AssertFlagsAfterDelete( obj2٠RentDetail ) ;
			rowcount3٠RentDetail = factory٠RentDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠RentDetail, rowcount0٠RentDetail ) ;
			 
			// FixedIncreaseRentReview
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[8/40] FixedIncreaseRentReview - delete" ) ;
			obj2٠FixedIncreaseRentReview.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠FixedIncreaseRentReview ) ;
			obj3٠FixedIncreaseRentReview = factory٠FixedIncreaseRentReviewFactory.Saveˡ( _connection, obj2٠FixedIncreaseRentReview ) ;
			nu.Assert.IsNull( obj3٠FixedIncreaseRentReview ) ;
			base.AssertFlagsAfterDelete( obj2٠FixedIncreaseRentReview ) ;
			rowcount3٠FixedIncreaseRentReview = factory٠FixedIncreaseRentReviewFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠FixedIncreaseRentReview, rowcount0٠FixedIncreaseRentReview ) ;
			 
			// ConsumerPriceIndexRentReview
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[9/40] ConsumerPriceIndexRentReview - delete" ) ;
			obj2٠ConsumerPriceIndexRentReview.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠ConsumerPriceIndexRentReview ) ;
			obj3٠ConsumerPriceIndexRentReview = factory٠ConsumerPriceIndexRentReviewFactory.Saveˡ( _connection, obj2٠ConsumerPriceIndexRentReview ) ;
			nu.Assert.IsNull( obj3٠ConsumerPriceIndexRentReview ) ;
			base.AssertFlagsAfterDelete( obj2٠ConsumerPriceIndexRentReview ) ;
			rowcount3٠ConsumerPriceIndexRentReview = factory٠ConsumerPriceIndexRentReviewFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠ConsumerPriceIndexRentReview, rowcount0٠ConsumerPriceIndexRentReview ) ;
			 
			// RentReview
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[10/40] RentReview - delete" ) ;
			obj2٠RentReview.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠RentReview ) ;
			obj3٠RentReview = factory٠RentReviewFactory.Saveˡ( _connection, obj2٠RentReview ) ;
			nu.Assert.IsNull( obj3٠RentReview ) ;
			base.AssertFlagsAfterDelete( obj2٠RentReview ) ;
			rowcount3٠RentReview = factory٠RentReviewFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠RentReview, rowcount0٠RentReview ) ;
			 
			// Lessee
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[11/40] Lessee - delete" ) ;
			obj2٠Lessee.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Lessee ) ;
			obj3٠Lessee = factory٠LesseeFactory.Saveˡ( _connection, obj2٠Lessee ) ;
			nu.Assert.IsNull( obj3٠Lessee ) ;
			base.AssertFlagsAfterDelete( obj2٠Lessee ) ;
			rowcount3٠Lessee = factory٠LesseeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Lessee, rowcount0٠Lessee ) ;
			 
			// LeaseExecutive
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[12/40] LeaseExecutive - delete" ) ;
			obj2٠LeaseExecutive.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠LeaseExecutive ) ;
			obj3٠LeaseExecutive = factory٠LeaseExecutiveFactory.Saveˡ( _connection, obj2٠LeaseExecutive ) ;
			nu.Assert.IsNull( obj3٠LeaseExecutive ) ;
			base.AssertFlagsAfterDelete( obj2٠LeaseExecutive ) ;
			rowcount3٠LeaseExecutive = factory٠LeaseExecutiveFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠LeaseExecutive, rowcount0٠LeaseExecutive ) ;
			 
			// Franchise
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[13/40] Franchise - delete" ) ;
			obj2٠Franchise.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Franchise ) ;
			obj3٠Franchise = factory٠FranchiseFactory.Saveˡ( _connection, obj2٠Franchise ) ;
			nu.Assert.IsNull( obj3٠Franchise ) ;
			base.AssertFlagsAfterDelete( obj2٠Franchise ) ;
			rowcount3٠Franchise = factory٠FranchiseFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Franchise, rowcount0٠Franchise ) ;
			 
			// CostCentreOutgoingArchive
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[14/40] CostCentreOutgoingArchive - delete" ) ;
			obj2٠CostCentreOutgoingArchive.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠CostCentreOutgoingArchive ) ;
			obj3٠CostCentreOutgoingArchive = factory٠CostCentreOutgoingArchiveFactory.Saveˡ( _connection, obj2٠CostCentreOutgoingArchive ) ;
			nu.Assert.IsNull( obj3٠CostCentreOutgoingArchive ) ;
			base.AssertFlagsAfterDelete( obj2٠CostCentreOutgoingArchive ) ;
			rowcount3٠CostCentreOutgoingArchive = factory٠CostCentreOutgoingArchiveFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠CostCentreOutgoingArchive, rowcount0٠CostCentreOutgoingArchive ) ;
			 
			// CostCentreOutgoing
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[15/40] CostCentreOutgoing - delete" ) ;
			obj2٠CostCentreOutgoing.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠CostCentreOutgoing ) ;
			obj3٠CostCentreOutgoing = factory٠CostCentreOutgoingFactory.Saveˡ( _connection, obj2٠CostCentreOutgoing ) ;
			nu.Assert.IsNull( obj3٠CostCentreOutgoing ) ;
			base.AssertFlagsAfterDelete( obj2٠CostCentreOutgoing ) ;
			rowcount3٠CostCentreOutgoing = factory٠CostCentreOutgoingFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠CostCentreOutgoing, rowcount0٠CostCentreOutgoing ) ;
			 
			// CostCentreStage
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[16/40] CostCentreStage - delete" ) ;
			obj2٠CostCentreStage.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠CostCentreStage ) ;
			obj3٠CostCentreStage = factory٠CostCentreStageFactory.Saveˡ( _connection, obj2٠CostCentreStage ) ;
			nu.Assert.IsNull( obj3٠CostCentreStage ) ;
			base.AssertFlagsAfterDelete( obj2٠CostCentreStage ) ;
			rowcount3٠CostCentreStage = factory٠CostCentreStageFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠CostCentreStage, rowcount0٠CostCentreStage ) ;
			 
			// Communication
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[17/40] Communication - delete" ) ;
			obj2٠Communication.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Communication ) ;
			obj3٠Communication = factory٠CommunicationFactory.Saveˡ( _connection, obj2٠Communication ) ;
			nu.Assert.IsNull( obj3٠Communication ) ;
			base.AssertFlagsAfterDelete( obj2٠Communication ) ;
			rowcount3٠Communication = factory٠CommunicationFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Communication, rowcount0٠Communication ) ;
			 
			// Centre
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[18/40] Centre - delete" ) ;
			obj2٠Centre.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Centre ) ;
			obj3٠Centre = factory٠CentreFactory.Saveˡ( _connection, obj2٠Centre ) ;
			nu.Assert.IsNull( obj3٠Centre ) ;
			base.AssertFlagsAfterDelete( obj2٠Centre ) ;
			rowcount3٠Centre = factory٠CentreFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Centre, rowcount0٠Centre ) ;
			 
			// Address
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[19/40] Address - delete" ) ;
			obj2٠Address.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Address ) ;
			obj3٠Address = factory٠AddressFactory.Saveˡ( _connection, obj2٠Address ) ;
			nu.Assert.IsNull( obj3٠Address ) ;
			base.AssertFlagsAfterDelete( obj2٠Address ) ;
			rowcount3٠Address = factory٠AddressFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Address, rowcount0٠Address ) ;
			 
			// VacantPossessionDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[20/40] VacantPossessionDetail - delete" ) ;
			obj2٠VacantPossessionDetail.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠VacantPossessionDetail ) ;
			obj3٠VacantPossessionDetail = factory٠VacantPossessionDetailFactory.Saveˡ( _connection, obj2٠VacantPossessionDetail ) ;
			nu.Assert.IsNull( obj3٠VacantPossessionDetail ) ;
			base.AssertFlagsAfterDelete( obj2٠VacantPossessionDetail ) ;
			rowcount3٠VacantPossessionDetail = factory٠VacantPossessionDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠VacantPossessionDetail, rowcount0٠VacantPossessionDetail ) ;
			 
			// SurrenderDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[21/40] SurrenderDetail - delete" ) ;
			obj2٠SurrenderDetail.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠SurrenderDetail ) ;
			obj3٠SurrenderDetail = factory٠SurrenderDetailFactory.Saveˡ( _connection, obj2٠SurrenderDetail ) ;
			nu.Assert.IsNull( obj3٠SurrenderDetail ) ;
			base.AssertFlagsAfterDelete( obj2٠SurrenderDetail ) ;
			rowcount3٠SurrenderDetail = factory٠SurrenderDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠SurrenderDetail, rowcount0٠SurrenderDetail ) ;
			 
			// SolicitorWebService
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[22/40] SolicitorWebService - delete" ) ;
			obj2٠SolicitorWebService.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠SolicitorWebService ) ;
			obj3٠SolicitorWebService = factory٠SolicitorWebServiceFactory.Saveˡ( _connection, obj2٠SolicitorWebService ) ;
			nu.Assert.IsNull( obj3٠SolicitorWebService ) ;
			base.AssertFlagsAfterDelete( obj2٠SolicitorWebService ) ;
			rowcount3٠SolicitorWebService = factory٠SolicitorWebServiceFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠SolicitorWebService, rowcount0٠SolicitorWebService ) ;
			 
			// ShopType
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[23/40] ShopType - delete" ) ;
			obj2٠ShopType.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠ShopType ) ;
			obj3٠ShopType = factory٠ShopTypeFactory.Saveˡ( _connection, obj2٠ShopType ) ;
			nu.Assert.IsNull( obj3٠ShopType ) ;
			base.AssertFlagsAfterDelete( obj2٠ShopType ) ;
			rowcount3٠ShopType = factory٠ShopTypeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠ShopType, rowcount0٠ShopType ) ;
			 
			// Sector
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[24/40] Sector - delete" ) ;
			obj2٠Sector.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Sector ) ;
			obj3٠Sector = factory٠SectorFactory.Saveˡ( _connection, obj2٠Sector ) ;
			nu.Assert.IsNull( obj3٠Sector ) ;
			base.AssertFlagsAfterDelete( obj2٠Sector ) ;
			rowcount3٠Sector = factory٠SectorFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Sector, rowcount0٠Sector ) ;
			 
			// SalesCategory
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[25/40] SalesCategory - delete" ) ;
			obj2٠SalesCategory.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠SalesCategory ) ;
			obj3٠SalesCategory = factory٠SalesCategoryFactory.Saveˡ( _connection, obj2٠SalesCategory ) ;
			nu.Assert.IsNull( obj3٠SalesCategory ) ;
			base.AssertFlagsAfterDelete( obj2٠SalesCategory ) ;
			rowcount3٠SalesCategory = factory٠SalesCategoryFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠SalesCategory, rowcount0٠SalesCategory ) ;
			 
			// RentReviewType
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[26/40] RentReviewType - delete" ) ;
			obj2٠RentReviewType.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠RentReviewType ) ;
			obj3٠RentReviewType = factory٠RentReviewTypeFactory.Saveˡ( _connection, obj2٠RentReviewType ) ;
			nu.Assert.IsNull( obj3٠RentReviewType ) ;
			base.AssertFlagsAfterDelete( obj2٠RentReviewType ) ;
			rowcount3٠RentReviewType = factory٠RentReviewTypeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠RentReviewType, rowcount0٠RentReviewType ) ;
			 
			// RDMFeeParam
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[27/40] RDMFeeParam - delete" ) ;
			obj2٠RDMFeeParam.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠RDMFeeParam ) ;
			obj3٠RDMFeeParam = factory٠RDMFeeParamFactory.Saveˡ( _connection, obj2٠RDMFeeParam ) ;
			nu.Assert.IsNull( obj3٠RDMFeeParam ) ;
			base.AssertFlagsAfterDelete( obj2٠RDMFeeParam ) ;
			rowcount3٠RDMFeeParam = factory٠RDMFeeParamFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠RDMFeeParam, rowcount0٠RDMFeeParam ) ;
			 
			// Precinct
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[28/40] Precinct - delete" ) ;
			obj2٠Precinct.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Precinct ) ;
			obj3٠Precinct = factory٠PrecinctFactory.Saveˡ( _connection, obj2٠Precinct ) ;
			nu.Assert.IsNull( obj3٠Precinct ) ;
			base.AssertFlagsAfterDelete( obj2٠Precinct ) ;
			rowcount3٠Precinct = factory٠PrecinctFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Precinct, rowcount0٠Precinct ) ;
			 
			// PaymentType
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[29/40] PaymentType - delete" ) ;
			obj2٠PaymentType.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠PaymentType ) ;
			obj3٠PaymentType = factory٠PaymentTypeFactory.Saveˡ( _connection, obj2٠PaymentType ) ;
			nu.Assert.IsNull( obj3٠PaymentType ) ;
			base.AssertFlagsAfterDelete( obj2٠PaymentType ) ;
			rowcount3٠PaymentType = factory٠PaymentTypeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠PaymentType, rowcount0٠PaymentType ) ;
			 
			// Party
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[30/40] Party - delete" ) ;
			obj2٠Party.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Party ) ;
			obj3٠Party = factory٠PartyFactory.Saveˡ( _connection, obj2٠Party ) ;
			nu.Assert.IsNull( obj3٠Party ) ;
			base.AssertFlagsAfterDelete( obj2٠Party ) ;
			rowcount3٠Party = factory٠PartyFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Party, rowcount0٠Party ) ;
			 
			// LeaseType
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[31/40] LeaseType - delete" ) ;
			obj2٠LeaseType.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠LeaseType ) ;
			obj3٠LeaseType = factory٠LeaseTypeFactory.Saveˡ( _connection, obj2٠LeaseType ) ;
			nu.Assert.IsNull( obj3٠LeaseType ) ;
			base.AssertFlagsAfterDelete( obj2٠LeaseType ) ;
			rowcount3٠LeaseType = factory٠LeaseTypeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠LeaseType, rowcount0٠LeaseType ) ;
			 
			// LeaseCondition
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[32/40] LeaseCondition - delete" ) ;
			obj2٠LeaseCondition.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠LeaseCondition ) ;
			obj3٠LeaseCondition = factory٠LeaseConditionFactory.Saveˡ( _connection, obj2٠LeaseCondition ) ;
			nu.Assert.IsNull( obj3٠LeaseCondition ) ;
			base.AssertFlagsAfterDelete( obj2٠LeaseCondition ) ;
			rowcount3٠LeaseCondition = factory٠LeaseConditionFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠LeaseCondition, rowcount0٠LeaseCondition ) ;
			 
			// LeaseComment
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[33/40] LeaseComment - delete" ) ;
			obj2٠LeaseComment.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠LeaseComment ) ;
			obj3٠LeaseComment = factory٠LeaseCommentFactory.Saveˡ( _connection, obj2٠LeaseComment ) ;
			nu.Assert.IsNull( obj3٠LeaseComment ) ;
			base.AssertFlagsAfterDelete( obj2٠LeaseComment ) ;
			rowcount3٠LeaseComment = factory٠LeaseCommentFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠LeaseComment, rowcount0٠LeaseComment ) ;
			 
			// IDGenerator
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[34/40] IDGenerator - delete" ) ;
			obj2٠IDGenerator.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠IDGenerator ) ;
			obj3٠IDGenerator = factory٠IDGeneratorFactory.Saveˡ( _connection, obj2٠IDGenerator ) ;
			nu.Assert.IsNull( obj3٠IDGenerator ) ;
			base.AssertFlagsAfterDelete( obj2٠IDGenerator ) ;
			rowcount3٠IDGenerator = factory٠IDGeneratorFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠IDGenerator, rowcount0٠IDGenerator ) ;
			 
			// FitoutDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[35/40] FitoutDetail - delete" ) ;
			obj2٠FitoutDetail.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠FitoutDetail ) ;
			obj3٠FitoutDetail = factory٠FitoutDetailFactory.Saveˡ( _connection, obj2٠FitoutDetail ) ;
			nu.Assert.IsNull( obj3٠FitoutDetail ) ;
			base.AssertFlagsAfterDelete( obj2٠FitoutDetail ) ;
			rowcount3٠FitoutDetail = factory٠FitoutDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠FitoutDetail, rowcount0٠FitoutDetail ) ;
			 
			// ExpenseDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[36/40] ExpenseDetail - delete" ) ;
			obj2٠ExpenseDetail.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠ExpenseDetail ) ;
			obj3٠ExpenseDetail = factory٠ExpenseDetailFactory.Saveˡ( _connection, obj2٠ExpenseDetail ) ;
			nu.Assert.IsNull( obj3٠ExpenseDetail ) ;
			base.AssertFlagsAfterDelete( obj2٠ExpenseDetail ) ;
			rowcount3٠ExpenseDetail = factory٠ExpenseDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠ExpenseDetail, rowcount0٠ExpenseDetail ) ;
			 
			// Email
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[37/40] Email - delete" ) ;
			obj2٠Email.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Email ) ;
			obj3٠Email = factory٠EmailFactory.Saveˡ( _connection, obj2٠Email ) ;
			nu.Assert.IsNull( obj3٠Email ) ;
			base.AssertFlagsAfterDelete( obj2٠Email ) ;
			rowcount3٠Email = factory٠EmailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Email, rowcount0٠Email ) ;
			 
			// dtproperties
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[38/40] dtproperties - delete" ) ;
			obj2٠dtproperties.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠dtproperties ) ;
			obj3٠dtproperties = factory٠dtpropertiesFactory.Saveˡ( _connection, obj2٠dtproperties ) ;
			nu.Assert.IsNull( obj3٠dtproperties ) ;
			base.AssertFlagsAfterDelete( obj2٠dtproperties ) ;
			rowcount3٠dtproperties = factory٠dtpropertiesFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠dtproperties, rowcount0٠dtproperties ) ;
			 
			// Document
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[39/40] Document - delete" ) ;
			obj2٠Document.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Document ) ;
			obj3٠Document = factory٠DocumentFactory.Saveˡ( _connection, obj2٠Document ) ;
			nu.Assert.IsNull( obj3٠Document ) ;
			base.AssertFlagsAfterDelete( obj2٠Document ) ;
			rowcount3٠Document = factory٠DocumentFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Document, rowcount0٠Document ) ;
			 
			// Chain
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[40/40] Chain - delete" ) ;
			obj2٠Chain.MarkForDeletionˡ = true ;
			base.AssertFlagsBeforeDelete( obj2٠Chain ) ;
			obj3٠Chain = factory٠ChainFactory.Saveˡ( _connection, obj2٠Chain ) ;
			nu.Assert.IsNull( obj3٠Chain ) ;
			base.AssertFlagsAfterDelete( obj2٠Chain ) ;
			rowcount3٠Chain = factory٠ChainFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount3٠Chain, rowcount0٠Chain ) ;
			 
		}
	}

}

