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
		protected void PopulateObjectsForInsert()
		{
			// Chain
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[1/40] Chain - insert" ) ;
			this.Populate٠Chain( true, obj0٠Chain ) ;
			this.PopulateOverride٠Chain( true, obj0٠Chain ) ;
			base.AssertFlagsBeforeInsert( obj0٠Chain ) ;
			rowcount0٠Chain = factory٠ChainFactory.GetRowCountˡ( _connection ) ;
			obj1٠Chain = factory٠ChainFactory.Saveˡ( _connection, obj0٠Chain ) ;
			nu.Assert.IsNotNull( obj1٠Chain ) ;
			base.AssertFlagsObjectLoaded( obj1٠Chain ) ;
			base.AssertFlagsAfterInsert( obj0٠Chain ) ;
			rowcount1٠Chain = factory٠ChainFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Chain, rowcount0٠Chain + 1 ) ;
			 
			// Document
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[2/40] Document - insert" ) ;
			this.Populate٠Document( true, obj0٠Document ) ;
			this.PopulateOverride٠Document( true, obj0٠Document ) ;
			base.AssertFlagsBeforeInsert( obj0٠Document ) ;
			rowcount0٠Document = factory٠DocumentFactory.GetRowCountˡ( _connection ) ;
			obj1٠Document = factory٠DocumentFactory.Saveˡ( _connection, obj0٠Document ) ;
			nu.Assert.IsNotNull( obj1٠Document ) ;
			base.AssertFlagsObjectLoaded( obj1٠Document ) ;
			base.AssertFlagsAfterInsert( obj0٠Document ) ;
			rowcount1٠Document = factory٠DocumentFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Document, rowcount0٠Document + 1 ) ;
			 
			// dtproperties
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[3/40] dtproperties - insert" ) ;
			this.Populate٠dtproperties( true, obj0٠dtproperties ) ;
			this.PopulateOverride٠dtproperties( true, obj0٠dtproperties ) ;
			base.AssertFlagsBeforeInsert( obj0٠dtproperties ) ;
			rowcount0٠dtproperties = factory٠dtpropertiesFactory.GetRowCountˡ( _connection ) ;
			obj1٠dtproperties = factory٠dtpropertiesFactory.Saveˡ( _connection, obj0٠dtproperties ) ;
			nu.Assert.IsNotNull( obj1٠dtproperties ) ;
			base.AssertFlagsObjectLoaded( obj1٠dtproperties ) ;
			base.AssertFlagsAfterInsert( obj0٠dtproperties ) ;
			rowcount1٠dtproperties = factory٠dtpropertiesFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠dtproperties, rowcount0٠dtproperties + 1 ) ;
			 
			// Email
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[4/40] Email - insert" ) ;
			this.Populate٠Email( true, obj0٠Email ) ;
			this.PopulateOverride٠Email( true, obj0٠Email ) ;
			base.AssertFlagsBeforeInsert( obj0٠Email ) ;
			rowcount0٠Email = factory٠EmailFactory.GetRowCountˡ( _connection ) ;
			obj1٠Email = factory٠EmailFactory.Saveˡ( _connection, obj0٠Email ) ;
			nu.Assert.IsNotNull( obj1٠Email ) ;
			base.AssertFlagsObjectLoaded( obj1٠Email ) ;
			base.AssertFlagsAfterInsert( obj0٠Email ) ;
			rowcount1٠Email = factory٠EmailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Email, rowcount0٠Email + 1 ) ;
			 
			// ExpenseDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[5/40] ExpenseDetail - insert" ) ;
			this.Populate٠ExpenseDetail( true, obj0٠ExpenseDetail ) ;
			this.PopulateOverride٠ExpenseDetail( true, obj0٠ExpenseDetail ) ;
			base.AssertFlagsBeforeInsert( obj0٠ExpenseDetail ) ;
			rowcount0٠ExpenseDetail = factory٠ExpenseDetailFactory.GetRowCountˡ( _connection ) ;
			obj1٠ExpenseDetail = factory٠ExpenseDetailFactory.Saveˡ( _connection, obj0٠ExpenseDetail ) ;
			nu.Assert.IsNotNull( obj1٠ExpenseDetail ) ;
			base.AssertFlagsObjectLoaded( obj1٠ExpenseDetail ) ;
			base.AssertFlagsAfterInsert( obj0٠ExpenseDetail ) ;
			rowcount1٠ExpenseDetail = factory٠ExpenseDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠ExpenseDetail, rowcount0٠ExpenseDetail + 1 ) ;
			 
			// FitoutDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[6/40] FitoutDetail - insert" ) ;
			this.Populate٠FitoutDetail( true, obj0٠FitoutDetail ) ;
			this.PopulateOverride٠FitoutDetail( true, obj0٠FitoutDetail ) ;
			base.AssertFlagsBeforeInsert( obj0٠FitoutDetail ) ;
			rowcount0٠FitoutDetail = factory٠FitoutDetailFactory.GetRowCountˡ( _connection ) ;
			obj1٠FitoutDetail = factory٠FitoutDetailFactory.Saveˡ( _connection, obj0٠FitoutDetail ) ;
			nu.Assert.IsNotNull( obj1٠FitoutDetail ) ;
			base.AssertFlagsObjectLoaded( obj1٠FitoutDetail ) ;
			base.AssertFlagsAfterInsert( obj0٠FitoutDetail ) ;
			rowcount1٠FitoutDetail = factory٠FitoutDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠FitoutDetail, rowcount0٠FitoutDetail + 1 ) ;
			 
			// IDGenerator
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[7/40] IDGenerator - insert" ) ;
			this.Populate٠IDGenerator( true, obj0٠IDGenerator ) ;
			this.PopulateOverride٠IDGenerator( true, obj0٠IDGenerator ) ;
			base.AssertFlagsBeforeInsert( obj0٠IDGenerator ) ;
			rowcount0٠IDGenerator = factory٠IDGeneratorFactory.GetRowCountˡ( _connection ) ;
			obj1٠IDGenerator = factory٠IDGeneratorFactory.Saveˡ( _connection, obj0٠IDGenerator ) ;
			nu.Assert.IsNotNull( obj1٠IDGenerator ) ;
			base.AssertFlagsObjectLoaded( obj1٠IDGenerator ) ;
			base.AssertFlagsAfterInsert( obj0٠IDGenerator ) ;
			rowcount1٠IDGenerator = factory٠IDGeneratorFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠IDGenerator, rowcount0٠IDGenerator + 1 ) ;
			 
			// LeaseComment
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[8/40] LeaseComment - insert" ) ;
			this.Populate٠LeaseComment( true, obj0٠LeaseComment ) ;
			this.PopulateOverride٠LeaseComment( true, obj0٠LeaseComment ) ;
			base.AssertFlagsBeforeInsert( obj0٠LeaseComment ) ;
			rowcount0٠LeaseComment = factory٠LeaseCommentFactory.GetRowCountˡ( _connection ) ;
			obj1٠LeaseComment = factory٠LeaseCommentFactory.Saveˡ( _connection, obj0٠LeaseComment ) ;
			nu.Assert.IsNotNull( obj1٠LeaseComment ) ;
			base.AssertFlagsObjectLoaded( obj1٠LeaseComment ) ;
			base.AssertFlagsAfterInsert( obj0٠LeaseComment ) ;
			rowcount1٠LeaseComment = factory٠LeaseCommentFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠LeaseComment, rowcount0٠LeaseComment + 1 ) ;
			 
			// LeaseCondition
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[9/40] LeaseCondition - insert" ) ;
			this.Populate٠LeaseCondition( true, obj0٠LeaseCondition ) ;
			this.PopulateOverride٠LeaseCondition( true, obj0٠LeaseCondition ) ;
			base.AssertFlagsBeforeInsert( obj0٠LeaseCondition ) ;
			rowcount0٠LeaseCondition = factory٠LeaseConditionFactory.GetRowCountˡ( _connection ) ;
			obj1٠LeaseCondition = factory٠LeaseConditionFactory.Saveˡ( _connection, obj0٠LeaseCondition ) ;
			nu.Assert.IsNotNull( obj1٠LeaseCondition ) ;
			base.AssertFlagsObjectLoaded( obj1٠LeaseCondition ) ;
			base.AssertFlagsAfterInsert( obj0٠LeaseCondition ) ;
			rowcount1٠LeaseCondition = factory٠LeaseConditionFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠LeaseCondition, rowcount0٠LeaseCondition + 1 ) ;
			 
			// LeaseType
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[10/40] LeaseType - insert" ) ;
			this.Populate٠LeaseType( true, obj0٠LeaseType ) ;
			this.PopulateOverride٠LeaseType( true, obj0٠LeaseType ) ;
			base.AssertFlagsBeforeInsert( obj0٠LeaseType ) ;
			rowcount0٠LeaseType = factory٠LeaseTypeFactory.GetRowCountˡ( _connection ) ;
			obj1٠LeaseType = factory٠LeaseTypeFactory.Saveˡ( _connection, obj0٠LeaseType ) ;
			nu.Assert.IsNotNull( obj1٠LeaseType ) ;
			base.AssertFlagsObjectLoaded( obj1٠LeaseType ) ;
			base.AssertFlagsAfterInsert( obj0٠LeaseType ) ;
			rowcount1٠LeaseType = factory٠LeaseTypeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠LeaseType, rowcount0٠LeaseType + 1 ) ;
			 
			// Party
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[11/40] Party - insert" ) ;
			this.Populate٠Party( true, obj0٠Party ) ;
			this.PopulateOverride٠Party( true, obj0٠Party ) ;
			base.AssertFlagsBeforeInsert( obj0٠Party ) ;
			rowcount0٠Party = factory٠PartyFactory.GetRowCountˡ( _connection ) ;
			obj1٠Party = factory٠PartyFactory.Saveˡ( _connection, obj0٠Party ) ;
			nu.Assert.IsNotNull( obj1٠Party ) ;
			base.AssertFlagsObjectLoaded( obj1٠Party ) ;
			base.AssertFlagsAfterInsert( obj0٠Party ) ;
			rowcount1٠Party = factory٠PartyFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Party, rowcount0٠Party + 1 ) ;
			 
			// PaymentType
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[12/40] PaymentType - insert" ) ;
			this.Populate٠PaymentType( true, obj0٠PaymentType ) ;
			this.PopulateOverride٠PaymentType( true, obj0٠PaymentType ) ;
			base.AssertFlagsBeforeInsert( obj0٠PaymentType ) ;
			rowcount0٠PaymentType = factory٠PaymentTypeFactory.GetRowCountˡ( _connection ) ;
			obj1٠PaymentType = factory٠PaymentTypeFactory.Saveˡ( _connection, obj0٠PaymentType ) ;
			nu.Assert.IsNotNull( obj1٠PaymentType ) ;
			base.AssertFlagsObjectLoaded( obj1٠PaymentType ) ;
			base.AssertFlagsAfterInsert( obj0٠PaymentType ) ;
			rowcount1٠PaymentType = factory٠PaymentTypeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠PaymentType, rowcount0٠PaymentType + 1 ) ;
			 
			// Precinct
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[13/40] Precinct - insert" ) ;
			this.Populate٠Precinct( true, obj0٠Precinct ) ;
			this.PopulateOverride٠Precinct( true, obj0٠Precinct ) ;
			base.AssertFlagsBeforeInsert( obj0٠Precinct ) ;
			rowcount0٠Precinct = factory٠PrecinctFactory.GetRowCountˡ( _connection ) ;
			obj1٠Precinct = factory٠PrecinctFactory.Saveˡ( _connection, obj0٠Precinct ) ;
			nu.Assert.IsNotNull( obj1٠Precinct ) ;
			base.AssertFlagsObjectLoaded( obj1٠Precinct ) ;
			base.AssertFlagsAfterInsert( obj0٠Precinct ) ;
			rowcount1٠Precinct = factory٠PrecinctFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Precinct, rowcount0٠Precinct + 1 ) ;
			 
			// RDMFeeParam
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[14/40] RDMFeeParam - insert" ) ;
			this.Populate٠RDMFeeParam( true, obj0٠RDMFeeParam ) ;
			this.PopulateOverride٠RDMFeeParam( true, obj0٠RDMFeeParam ) ;
			base.AssertFlagsBeforeInsert( obj0٠RDMFeeParam ) ;
			rowcount0٠RDMFeeParam = factory٠RDMFeeParamFactory.GetRowCountˡ( _connection ) ;
			obj1٠RDMFeeParam = factory٠RDMFeeParamFactory.Saveˡ( _connection, obj0٠RDMFeeParam ) ;
			nu.Assert.IsNotNull( obj1٠RDMFeeParam ) ;
			base.AssertFlagsObjectLoaded( obj1٠RDMFeeParam ) ;
			base.AssertFlagsAfterInsert( obj0٠RDMFeeParam ) ;
			rowcount1٠RDMFeeParam = factory٠RDMFeeParamFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠RDMFeeParam, rowcount0٠RDMFeeParam + 1 ) ;
			 
			// RentReviewType
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[15/40] RentReviewType - insert" ) ;
			this.Populate٠RentReviewType( true, obj0٠RentReviewType ) ;
			this.PopulateOverride٠RentReviewType( true, obj0٠RentReviewType ) ;
			base.AssertFlagsBeforeInsert( obj0٠RentReviewType ) ;
			rowcount0٠RentReviewType = factory٠RentReviewTypeFactory.GetRowCountˡ( _connection ) ;
			obj1٠RentReviewType = factory٠RentReviewTypeFactory.Saveˡ( _connection, obj0٠RentReviewType ) ;
			nu.Assert.IsNotNull( obj1٠RentReviewType ) ;
			base.AssertFlagsObjectLoaded( obj1٠RentReviewType ) ;
			base.AssertFlagsAfterInsert( obj0٠RentReviewType ) ;
			rowcount1٠RentReviewType = factory٠RentReviewTypeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠RentReviewType, rowcount0٠RentReviewType + 1 ) ;
			 
			// SalesCategory
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[16/40] SalesCategory - insert" ) ;
			this.Populate٠SalesCategory( true, obj0٠SalesCategory ) ;
			this.PopulateOverride٠SalesCategory( true, obj0٠SalesCategory ) ;
			base.AssertFlagsBeforeInsert( obj0٠SalesCategory ) ;
			rowcount0٠SalesCategory = factory٠SalesCategoryFactory.GetRowCountˡ( _connection ) ;
			obj1٠SalesCategory = factory٠SalesCategoryFactory.Saveˡ( _connection, obj0٠SalesCategory ) ;
			nu.Assert.IsNotNull( obj1٠SalesCategory ) ;
			base.AssertFlagsObjectLoaded( obj1٠SalesCategory ) ;
			base.AssertFlagsAfterInsert( obj0٠SalesCategory ) ;
			rowcount1٠SalesCategory = factory٠SalesCategoryFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠SalesCategory, rowcount0٠SalesCategory + 1 ) ;
			 
			// Sector
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[17/40] Sector - insert" ) ;
			this.Populate٠Sector( true, obj0٠Sector ) ;
			this.PopulateOverride٠Sector( true, obj0٠Sector ) ;
			base.AssertFlagsBeforeInsert( obj0٠Sector ) ;
			rowcount0٠Sector = factory٠SectorFactory.GetRowCountˡ( _connection ) ;
			obj1٠Sector = factory٠SectorFactory.Saveˡ( _connection, obj0٠Sector ) ;
			nu.Assert.IsNotNull( obj1٠Sector ) ;
			base.AssertFlagsObjectLoaded( obj1٠Sector ) ;
			base.AssertFlagsAfterInsert( obj0٠Sector ) ;
			rowcount1٠Sector = factory٠SectorFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Sector, rowcount0٠Sector + 1 ) ;
			 
			// ShopType
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[18/40] ShopType - insert" ) ;
			this.Populate٠ShopType( true, obj0٠ShopType ) ;
			this.PopulateOverride٠ShopType( true, obj0٠ShopType ) ;
			base.AssertFlagsBeforeInsert( obj0٠ShopType ) ;
			rowcount0٠ShopType = factory٠ShopTypeFactory.GetRowCountˡ( _connection ) ;
			obj1٠ShopType = factory٠ShopTypeFactory.Saveˡ( _connection, obj0٠ShopType ) ;
			nu.Assert.IsNotNull( obj1٠ShopType ) ;
			base.AssertFlagsObjectLoaded( obj1٠ShopType ) ;
			base.AssertFlagsAfterInsert( obj0٠ShopType ) ;
			rowcount1٠ShopType = factory٠ShopTypeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠ShopType, rowcount0٠ShopType + 1 ) ;
			 
			// SolicitorWebService
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[19/40] SolicitorWebService - insert" ) ;
			this.Populate٠SolicitorWebService( true, obj0٠SolicitorWebService ) ;
			this.PopulateOverride٠SolicitorWebService( true, obj0٠SolicitorWebService ) ;
			base.AssertFlagsBeforeInsert( obj0٠SolicitorWebService ) ;
			rowcount0٠SolicitorWebService = factory٠SolicitorWebServiceFactory.GetRowCountˡ( _connection ) ;
			obj1٠SolicitorWebService = factory٠SolicitorWebServiceFactory.Saveˡ( _connection, obj0٠SolicitorWebService ) ;
			nu.Assert.IsNotNull( obj1٠SolicitorWebService ) ;
			base.AssertFlagsObjectLoaded( obj1٠SolicitorWebService ) ;
			base.AssertFlagsAfterInsert( obj0٠SolicitorWebService ) ;
			rowcount1٠SolicitorWebService = factory٠SolicitorWebServiceFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠SolicitorWebService, rowcount0٠SolicitorWebService + 1 ) ;
			 
			// SurrenderDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[20/40] SurrenderDetail - insert" ) ;
			this.Populate٠SurrenderDetail( true, obj0٠SurrenderDetail ) ;
			this.PopulateOverride٠SurrenderDetail( true, obj0٠SurrenderDetail ) ;
			base.AssertFlagsBeforeInsert( obj0٠SurrenderDetail ) ;
			rowcount0٠SurrenderDetail = factory٠SurrenderDetailFactory.GetRowCountˡ( _connection ) ;
			obj1٠SurrenderDetail = factory٠SurrenderDetailFactory.Saveˡ( _connection, obj0٠SurrenderDetail ) ;
			nu.Assert.IsNotNull( obj1٠SurrenderDetail ) ;
			base.AssertFlagsObjectLoaded( obj1٠SurrenderDetail ) ;
			base.AssertFlagsAfterInsert( obj0٠SurrenderDetail ) ;
			rowcount1٠SurrenderDetail = factory٠SurrenderDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠SurrenderDetail, rowcount0٠SurrenderDetail + 1 ) ;
			 
			// VacantPossessionDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[21/40] VacantPossessionDetail - insert" ) ;
			this.Populate٠VacantPossessionDetail( true, obj0٠VacantPossessionDetail ) ;
			this.PopulateOverride٠VacantPossessionDetail( true, obj0٠VacantPossessionDetail ) ;
			base.AssertFlagsBeforeInsert( obj0٠VacantPossessionDetail ) ;
			rowcount0٠VacantPossessionDetail = factory٠VacantPossessionDetailFactory.GetRowCountˡ( _connection ) ;
			obj1٠VacantPossessionDetail = factory٠VacantPossessionDetailFactory.Saveˡ( _connection, obj0٠VacantPossessionDetail ) ;
			nu.Assert.IsNotNull( obj1٠VacantPossessionDetail ) ;
			base.AssertFlagsObjectLoaded( obj1٠VacantPossessionDetail ) ;
			base.AssertFlagsAfterInsert( obj0٠VacantPossessionDetail ) ;
			rowcount1٠VacantPossessionDetail = factory٠VacantPossessionDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠VacantPossessionDetail, rowcount0٠VacantPossessionDetail + 1 ) ;
			 
			// Address
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[22/40] Address - insert" ) ;
			this.Populate٠Address( true, obj0٠Address ) ;
			this.PopulateOverride٠Address( true, obj0٠Address ) ;
			base.AssertFlagsBeforeInsert( obj0٠Address ) ;
			rowcount0٠Address = factory٠AddressFactory.GetRowCountˡ( _connection ) ;
			obj1٠Address = factory٠AddressFactory.Saveˡ( _connection, obj0٠Address ) ;
			nu.Assert.IsNotNull( obj1٠Address ) ;
			base.AssertFlagsObjectLoaded( obj1٠Address ) ;
			base.AssertFlagsAfterInsert( obj0٠Address ) ;
			rowcount1٠Address = factory٠AddressFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Address, rowcount0٠Address + 1 ) ;
			 
			// Centre
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[23/40] Centre - insert" ) ;
			this.Populate٠Centre( true, obj0٠Centre ) ;
			this.PopulateOverride٠Centre( true, obj0٠Centre ) ;
			base.AssertFlagsBeforeInsert( obj0٠Centre ) ;
			rowcount0٠Centre = factory٠CentreFactory.GetRowCountˡ( _connection ) ;
			obj1٠Centre = factory٠CentreFactory.Saveˡ( _connection, obj0٠Centre ) ;
			nu.Assert.IsNotNull( obj1٠Centre ) ;
			base.AssertFlagsObjectLoaded( obj1٠Centre ) ;
			base.AssertFlagsAfterInsert( obj0٠Centre ) ;
			rowcount1٠Centre = factory٠CentreFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Centre, rowcount0٠Centre + 1 ) ;
			 
			// Communication
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[24/40] Communication - insert" ) ;
			this.Populate٠Communication( true, obj0٠Communication ) ;
			this.PopulateOverride٠Communication( true, obj0٠Communication ) ;
			base.AssertFlagsBeforeInsert( obj0٠Communication ) ;
			rowcount0٠Communication = factory٠CommunicationFactory.GetRowCountˡ( _connection ) ;
			obj1٠Communication = factory٠CommunicationFactory.Saveˡ( _connection, obj0٠Communication ) ;
			nu.Assert.IsNotNull( obj1٠Communication ) ;
			base.AssertFlagsObjectLoaded( obj1٠Communication ) ;
			base.AssertFlagsAfterInsert( obj0٠Communication ) ;
			rowcount1٠Communication = factory٠CommunicationFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Communication, rowcount0٠Communication + 1 ) ;
			 
			// CostCentreStage
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[25/40] CostCentreStage - insert" ) ;
			this.Populate٠CostCentreStage( true, obj0٠CostCentreStage ) ;
			this.PopulateOverride٠CostCentreStage( true, obj0٠CostCentreStage ) ;
			base.AssertFlagsBeforeInsert( obj0٠CostCentreStage ) ;
			rowcount0٠CostCentreStage = factory٠CostCentreStageFactory.GetRowCountˡ( _connection ) ;
			obj1٠CostCentreStage = factory٠CostCentreStageFactory.Saveˡ( _connection, obj0٠CostCentreStage ) ;
			nu.Assert.IsNotNull( obj1٠CostCentreStage ) ;
			base.AssertFlagsObjectLoaded( obj1٠CostCentreStage ) ;
			base.AssertFlagsAfterInsert( obj0٠CostCentreStage ) ;
			rowcount1٠CostCentreStage = factory٠CostCentreStageFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠CostCentreStage, rowcount0٠CostCentreStage + 1 ) ;
			 
			// CostCentreOutgoing
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[26/40] CostCentreOutgoing - insert" ) ;
			this.Populate٠CostCentreOutgoing( true, obj0٠CostCentreOutgoing ) ;
			this.PopulateOverride٠CostCentreOutgoing( true, obj0٠CostCentreOutgoing ) ;
			base.AssertFlagsBeforeInsert( obj0٠CostCentreOutgoing ) ;
			rowcount0٠CostCentreOutgoing = factory٠CostCentreOutgoingFactory.GetRowCountˡ( _connection ) ;
			obj1٠CostCentreOutgoing = factory٠CostCentreOutgoingFactory.Saveˡ( _connection, obj0٠CostCentreOutgoing ) ;
			nu.Assert.IsNotNull( obj1٠CostCentreOutgoing ) ;
			base.AssertFlagsObjectLoaded( obj1٠CostCentreOutgoing ) ;
			base.AssertFlagsAfterInsert( obj0٠CostCentreOutgoing ) ;
			rowcount1٠CostCentreOutgoing = factory٠CostCentreOutgoingFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠CostCentreOutgoing, rowcount0٠CostCentreOutgoing + 1 ) ;
			 
			// CostCentreOutgoingArchive
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[27/40] CostCentreOutgoingArchive - insert" ) ;
			this.Populate٠CostCentreOutgoingArchive( true, obj0٠CostCentreOutgoingArchive ) ;
			this.PopulateOverride٠CostCentreOutgoingArchive( true, obj0٠CostCentreOutgoingArchive ) ;
			base.AssertFlagsBeforeInsert( obj0٠CostCentreOutgoingArchive ) ;
			rowcount0٠CostCentreOutgoingArchive = factory٠CostCentreOutgoingArchiveFactory.GetRowCountˡ( _connection ) ;
			obj1٠CostCentreOutgoingArchive = factory٠CostCentreOutgoingArchiveFactory.Saveˡ( _connection, obj0٠CostCentreOutgoingArchive ) ;
			nu.Assert.IsNotNull( obj1٠CostCentreOutgoingArchive ) ;
			base.AssertFlagsObjectLoaded( obj1٠CostCentreOutgoingArchive ) ;
			base.AssertFlagsAfterInsert( obj0٠CostCentreOutgoingArchive ) ;
			rowcount1٠CostCentreOutgoingArchive = factory٠CostCentreOutgoingArchiveFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠CostCentreOutgoingArchive, rowcount0٠CostCentreOutgoingArchive + 1 ) ;
			 
			// Franchise
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[28/40] Franchise - insert" ) ;
			this.Populate٠Franchise( true, obj0٠Franchise ) ;
			this.PopulateOverride٠Franchise( true, obj0٠Franchise ) ;
			base.AssertFlagsBeforeInsert( obj0٠Franchise ) ;
			rowcount0٠Franchise = factory٠FranchiseFactory.GetRowCountˡ( _connection ) ;
			obj1٠Franchise = factory٠FranchiseFactory.Saveˡ( _connection, obj0٠Franchise ) ;
			nu.Assert.IsNotNull( obj1٠Franchise ) ;
			base.AssertFlagsObjectLoaded( obj1٠Franchise ) ;
			base.AssertFlagsAfterInsert( obj0٠Franchise ) ;
			rowcount1٠Franchise = factory٠FranchiseFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Franchise, rowcount0٠Franchise + 1 ) ;
			 
			// LeaseExecutive
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[29/40] LeaseExecutive - insert" ) ;
			this.Populate٠LeaseExecutive( true, obj0٠LeaseExecutive ) ;
			this.PopulateOverride٠LeaseExecutive( true, obj0٠LeaseExecutive ) ;
			base.AssertFlagsBeforeInsert( obj0٠LeaseExecutive ) ;
			rowcount0٠LeaseExecutive = factory٠LeaseExecutiveFactory.GetRowCountˡ( _connection ) ;
			obj1٠LeaseExecutive = factory٠LeaseExecutiveFactory.Saveˡ( _connection, obj0٠LeaseExecutive ) ;
			nu.Assert.IsNotNull( obj1٠LeaseExecutive ) ;
			base.AssertFlagsObjectLoaded( obj1٠LeaseExecutive ) ;
			base.AssertFlagsAfterInsert( obj0٠LeaseExecutive ) ;
			rowcount1٠LeaseExecutive = factory٠LeaseExecutiveFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠LeaseExecutive, rowcount0٠LeaseExecutive + 1 ) ;
			 
			// Lessee
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[30/40] Lessee - insert" ) ;
			this.Populate٠Lessee( true, obj0٠Lessee ) ;
			this.PopulateOverride٠Lessee( true, obj0٠Lessee ) ;
			base.AssertFlagsBeforeInsert( obj0٠Lessee ) ;
			rowcount0٠Lessee = factory٠LesseeFactory.GetRowCountˡ( _connection ) ;
			obj1٠Lessee = factory٠LesseeFactory.Saveˡ( _connection, obj0٠Lessee ) ;
			nu.Assert.IsNotNull( obj1٠Lessee ) ;
			base.AssertFlagsObjectLoaded( obj1٠Lessee ) ;
			base.AssertFlagsAfterInsert( obj0٠Lessee ) ;
			rowcount1٠Lessee = factory٠LesseeFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Lessee, rowcount0٠Lessee + 1 ) ;
			 
			// RentReview
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[31/40] RentReview - insert" ) ;
			this.Populate٠RentReview( true, obj0٠RentReview ) ;
			this.PopulateOverride٠RentReview( true, obj0٠RentReview ) ;
			base.AssertFlagsBeforeInsert( obj0٠RentReview ) ;
			rowcount0٠RentReview = factory٠RentReviewFactory.GetRowCountˡ( _connection ) ;
			obj1٠RentReview = factory٠RentReviewFactory.Saveˡ( _connection, obj0٠RentReview ) ;
			nu.Assert.IsNotNull( obj1٠RentReview ) ;
			base.AssertFlagsObjectLoaded( obj1٠RentReview ) ;
			base.AssertFlagsAfterInsert( obj0٠RentReview ) ;
			rowcount1٠RentReview = factory٠RentReviewFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠RentReview, rowcount0٠RentReview + 1 ) ;
			 
			// ConsumerPriceIndexRentReview
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[32/40] ConsumerPriceIndexRentReview - insert" ) ;
			this.Populate٠ConsumerPriceIndexRentReview( true, obj0٠ConsumerPriceIndexRentReview ) ;
			this.PopulateOverride٠ConsumerPriceIndexRentReview( true, obj0٠ConsumerPriceIndexRentReview ) ;
			base.AssertFlagsBeforeInsert( obj0٠ConsumerPriceIndexRentReview ) ;
			rowcount0٠ConsumerPriceIndexRentReview = factory٠ConsumerPriceIndexRentReviewFactory.GetRowCountˡ( _connection ) ;
			obj1٠ConsumerPriceIndexRentReview = factory٠ConsumerPriceIndexRentReviewFactory.Saveˡ( _connection, obj0٠ConsumerPriceIndexRentReview ) ;
			nu.Assert.IsNotNull( obj1٠ConsumerPriceIndexRentReview ) ;
			base.AssertFlagsObjectLoaded( obj1٠ConsumerPriceIndexRentReview ) ;
			base.AssertFlagsAfterInsert( obj0٠ConsumerPriceIndexRentReview ) ;
			rowcount1٠ConsumerPriceIndexRentReview = factory٠ConsumerPriceIndexRentReviewFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠ConsumerPriceIndexRentReview, rowcount0٠ConsumerPriceIndexRentReview + 1 ) ;
			 
			// FixedIncreaseRentReview
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[33/40] FixedIncreaseRentReview - insert" ) ;
			this.Populate٠FixedIncreaseRentReview( true, obj0٠FixedIncreaseRentReview ) ;
			this.PopulateOverride٠FixedIncreaseRentReview( true, obj0٠FixedIncreaseRentReview ) ;
			base.AssertFlagsBeforeInsert( obj0٠FixedIncreaseRentReview ) ;
			rowcount0٠FixedIncreaseRentReview = factory٠FixedIncreaseRentReviewFactory.GetRowCountˡ( _connection ) ;
			obj1٠FixedIncreaseRentReview = factory٠FixedIncreaseRentReviewFactory.Saveˡ( _connection, obj0٠FixedIncreaseRentReview ) ;
			nu.Assert.IsNotNull( obj1٠FixedIncreaseRentReview ) ;
			base.AssertFlagsObjectLoaded( obj1٠FixedIncreaseRentReview ) ;
			base.AssertFlagsAfterInsert( obj0٠FixedIncreaseRentReview ) ;
			rowcount1٠FixedIncreaseRentReview = factory٠FixedIncreaseRentReviewFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠FixedIncreaseRentReview, rowcount0٠FixedIncreaseRentReview + 1 ) ;
			 
			// RentDetail
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[34/40] RentDetail - insert" ) ;
			this.Populate٠RentDetail( true, obj0٠RentDetail ) ;
			this.PopulateOverride٠RentDetail( true, obj0٠RentDetail ) ;
			base.AssertFlagsBeforeInsert( obj0٠RentDetail ) ;
			rowcount0٠RentDetail = factory٠RentDetailFactory.GetRowCountˡ( _connection ) ;
			obj1٠RentDetail = factory٠RentDetailFactory.Saveˡ( _connection, obj0٠RentDetail ) ;
			nu.Assert.IsNotNull( obj1٠RentDetail ) ;
			base.AssertFlagsObjectLoaded( obj1٠RentDetail ) ;
			base.AssertFlagsAfterInsert( obj0٠RentDetail ) ;
			rowcount1٠RentDetail = factory٠RentDetailFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠RentDetail, rowcount0٠RentDetail + 1 ) ;
			 
			// Solicitor
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[35/40] Solicitor - insert" ) ;
			this.Populate٠Solicitor( true, obj0٠Solicitor ) ;
			this.PopulateOverride٠Solicitor( true, obj0٠Solicitor ) ;
			base.AssertFlagsBeforeInsert( obj0٠Solicitor ) ;
			rowcount0٠Solicitor = factory٠SolicitorFactory.GetRowCountˡ( _connection ) ;
			obj1٠Solicitor = factory٠SolicitorFactory.Saveˡ( _connection, obj0٠Solicitor ) ;
			nu.Assert.IsNotNull( obj1٠Solicitor ) ;
			base.AssertFlagsObjectLoaded( obj1٠Solicitor ) ;
			base.AssertFlagsAfterInsert( obj0٠Solicitor ) ;
			rowcount1٠Solicitor = factory٠SolicitorFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Solicitor, rowcount0٠Solicitor + 1 ) ;
			 
			// Staff
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[36/40] Staff - insert" ) ;
			this.Populate٠Staff( true, obj0٠Staff ) ;
			this.PopulateOverride٠Staff( true, obj0٠Staff ) ;
			base.AssertFlagsBeforeInsert( obj0٠Staff ) ;
			rowcount0٠Staff = factory٠StaffFactory.GetRowCountˡ( _connection ) ;
			obj1٠Staff = factory٠StaffFactory.Saveˡ( _connection, obj0٠Staff ) ;
			nu.Assert.IsNotNull( obj1٠Staff ) ;
			base.AssertFlagsObjectLoaded( obj1٠Staff ) ;
			base.AssertFlagsAfterInsert( obj0٠Staff ) ;
			rowcount1٠Staff = factory٠StaffFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Staff, rowcount0٠Staff + 1 ) ;
			 
			// LeaseAdministration
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[37/40] LeaseAdministration - insert" ) ;
			this.Populate٠LeaseAdministration( true, obj0٠LeaseAdministration ) ;
			this.PopulateOverride٠LeaseAdministration( true, obj0٠LeaseAdministration ) ;
			base.AssertFlagsBeforeInsert( obj0٠LeaseAdministration ) ;
			rowcount0٠LeaseAdministration = factory٠LeaseAdministrationFactory.GetRowCountˡ( _connection ) ;
			obj1٠LeaseAdministration = factory٠LeaseAdministrationFactory.Saveˡ( _connection, obj0٠LeaseAdministration ) ;
			nu.Assert.IsNotNull( obj1٠LeaseAdministration ) ;
			base.AssertFlagsObjectLoaded( obj1٠LeaseAdministration ) ;
			base.AssertFlagsAfterInsert( obj0٠LeaseAdministration ) ;
			rowcount1٠LeaseAdministration = factory٠LeaseAdministrationFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠LeaseAdministration, rowcount0٠LeaseAdministration + 1 ) ;
			 
			// Lease
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[38/40] Lease - insert" ) ;
			this.Populate٠Lease( true, obj0٠Lease ) ;
			this.PopulateOverride٠Lease( true, obj0٠Lease ) ;
			base.AssertFlagsBeforeInsert( obj0٠Lease ) ;
			rowcount0٠Lease = factory٠LeaseFactory.GetRowCountˡ( _connection ) ;
			obj1٠Lease = factory٠LeaseFactory.Saveˡ( _connection, obj0٠Lease ) ;
			nu.Assert.IsNotNull( obj1٠Lease ) ;
			base.AssertFlagsObjectLoaded( obj1٠Lease ) ;
			base.AssertFlagsAfterInsert( obj0٠Lease ) ;
			rowcount1٠Lease = factory٠LeaseFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠Lease, rowcount0٠Lease + 1 ) ;
			 
			// LeaseGuarantor
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[39/40] LeaseGuarantor - insert" ) ;
			this.Populate٠LeaseGuarantor( true, obj0٠LeaseGuarantor ) ;
			this.PopulateOverride٠LeaseGuarantor( true, obj0٠LeaseGuarantor ) ;
			base.AssertFlagsBeforeInsert( obj0٠LeaseGuarantor ) ;
			rowcount0٠LeaseGuarantor = factory٠LeaseGuarantorFactory.GetRowCountˡ( _connection ) ;
			obj1٠LeaseGuarantor = factory٠LeaseGuarantorFactory.Saveˡ( _connection, obj0٠LeaseGuarantor ) ;
			nu.Assert.IsNotNull( obj1٠LeaseGuarantor ) ;
			base.AssertFlagsObjectLoaded( obj1٠LeaseGuarantor ) ;
			base.AssertFlagsAfterInsert( obj0٠LeaseGuarantor ) ;
			rowcount1٠LeaseGuarantor = factory٠LeaseGuarantorFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠LeaseGuarantor, rowcount0٠LeaseGuarantor + 1 ) ;
			 
			// LogEntry
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[40/40] LogEntry - insert" ) ;
			this.Populate٠LogEntry( true, obj0٠LogEntry ) ;
			this.PopulateOverride٠LogEntry( true, obj0٠LogEntry ) ;
			base.AssertFlagsBeforeInsert( obj0٠LogEntry ) ;
			rowcount0٠LogEntry = factory٠LogEntryFactory.GetRowCountˡ( _connection ) ;
			obj1٠LogEntry = factory٠LogEntryFactory.Saveˡ( _connection, obj0٠LogEntry ) ;
			nu.Assert.IsNotNull( obj1٠LogEntry ) ;
			base.AssertFlagsObjectLoaded( obj1٠LogEntry ) ;
			base.AssertFlagsAfterInsert( obj0٠LogEntry ) ;
			rowcount1٠LogEntry = factory٠LogEntryFactory.GetRowCountˡ( _connection ) ;
			nu.Assert.AreEqual( rowcount1٠LogEntry, rowcount0٠LogEntry + 1 ) ;
			 
		}
	}

}

