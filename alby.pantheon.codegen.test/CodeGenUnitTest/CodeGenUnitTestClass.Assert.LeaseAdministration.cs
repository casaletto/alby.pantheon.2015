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
		protected void Assert٠LeaseAdministration( bool insert, t.LeaseAdministration newobj, t.LeaseAdministration oldobj )
		{
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[37/40] LeaseAdministration - assert" ) ;
		 
			nu.Assert.IsNotNull( newobj.LeaseAdministrationID, "LeaseAdministration.LeaseAdministrationID" ) ;
			nu.Assert.IsNotNull( newobj.StaffID, "LeaseAdministration.StaffID" ) ;
			nu.Assert.IsNotNull( newobj.DeedOfConsentRequiredIndicator, "LeaseAdministration.DeedOfConsentRequiredIndicator" ) ;
			nu.Assert.IsNotNull( newobj.FranchiseID, "LeaseAdministration.FranchiseID" ) ;
			nu.Assert.IsNotNull( newobj.PaymentTypeID, "LeaseAdministration.PaymentTypeID" ) ;
			nu.Assert.IsNotNull( newobj.SendDocumentsTo, "LeaseAdministration.SendDocumentsTo" ) ;
			nu.Assert.IsNotNull( newobj.TenantRenewingIndicator, "LeaseAdministration.TenantRenewingIndicator" ) ;
			nu.Assert.IsNotNull( newobj.TenantRelocatingIndicator, "LeaseAdministration.TenantRelocatingIndicator" ) ;
			nu.Assert.IsNotNull( newobj.RelocationClauseRequiredIndicator, "LeaseAdministration.RelocationClauseRequiredIndicator" ) ;
			nu.Assert.IsNotNull( newobj.BankOrFinInstitIndicator, "LeaseAdministration.BankOrFinInstitIndicator" ) ;
			nu.Assert.IsNotNull( newobj.BankOrFinInstitSpecialConvenantsRequiredIndicator, "LeaseAdministration.BankOrFinInstitSpecialConvenantsRequiredIndicator" ) ;
			nu.Assert.IsNotNull( newobj.SpecialPrecinctConvenants, "LeaseAdministration.SpecialPrecinctConvenants" ) ;
			nu.Assert.IsNotNull( newobj.UpdateUserCode, "LeaseAdministration.UpdateUserCode" ) ;
			nu.Assert.IsNotNull( newobj.UpdateDateTime, "LeaseAdministration.UpdateDateTime" ) ;
			nu.Assert.IsNotNull( newobj.RowTimestamp, "LeaseAdministration.RowTimestamp" ) ;
		 
			base.AssertAreEqual( newobj.LeaseAdministrationID, oldobj.LeaseAdministrationID, "LeaseAdministration.LeaseAdministrationID" ) ;
			base.AssertAreEqual( newobj.StaffID, oldobj.StaffID, "LeaseAdministration.StaffID" ) ;
			base.AssertAreEqual( newobj.DeedOfConsentRequiredIndicator, oldobj.DeedOfConsentRequiredIndicator, "LeaseAdministration.DeedOfConsentRequiredIndicator" ) ;
			base.AssertAreEqual( newobj.FranchiseID, oldobj.FranchiseID, "LeaseAdministration.FranchiseID" ) ;
			base.AssertAreEqual( newobj.PaymentTypeID, oldobj.PaymentTypeID, "LeaseAdministration.PaymentTypeID" ) ;
			base.AssertAreEqual( newobj.SendDocumentsTo, oldobj.SendDocumentsTo, "LeaseAdministration.SendDocumentsTo" ) ;
			base.AssertAreEqual( newobj.TenantRenewingIndicator, oldobj.TenantRenewingIndicator, "LeaseAdministration.TenantRenewingIndicator" ) ;
			base.AssertAreEqual( newobj.TenantRelocatingIndicator, oldobj.TenantRelocatingIndicator, "LeaseAdministration.TenantRelocatingIndicator" ) ;
			base.AssertAreEqual( newobj.RelocationClauseRequiredIndicator, oldobj.RelocationClauseRequiredIndicator, "LeaseAdministration.RelocationClauseRequiredIndicator" ) ;
			base.AssertAreEqual( newobj.BankOrFinInstitIndicator, oldobj.BankOrFinInstitIndicator, "LeaseAdministration.BankOrFinInstitIndicator" ) ;
			base.AssertAreEqual( newobj.BankOrFinInstitSpecialConvenantsRequiredIndicator, oldobj.BankOrFinInstitSpecialConvenantsRequiredIndicator, "LeaseAdministration.BankOrFinInstitSpecialConvenantsRequiredIndicator" ) ;
			base.AssertAreEqual( newobj.SpecialPrecinctConvenants, oldobj.SpecialPrecinctConvenants, "LeaseAdministration.SpecialPrecinctConvenants" ) ;
			base.AssertAreEqual( newobj.UpdateUserCode, oldobj.UpdateUserCode, "LeaseAdministration.UpdateUserCode" ) ;
			base.AssertAreEqual( newobj.UpdateDateTime, oldobj.UpdateDateTime, "LeaseAdministration.UpdateDateTime" ) ;
		 
		}
	}

}
