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
		protected void Assert٠FixedIncreaseRentReview( bool insert, t.FixedIncreaseRentReview newobj, t.FixedIncreaseRentReview oldobj )
		{
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[33/40] FixedIncreaseRentReview - assert" ) ;
		 
			nu.Assert.IsNotNull( newobj.RentReviewID, "FixedIncreaseRentReview.RentReviewID" ) ;
			nu.Assert.IsNotNull( newobj.RentReviewIncrease, "FixedIncreaseRentReview.RentReviewIncrease" ) ;
			nu.Assert.IsNotNull( newobj.RentReviewIncreaseText, "FixedIncreaseRentReview.RentReviewIncreaseText" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary1, "FixedIncreaseRentReview.Anniversary1" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary2, "FixedIncreaseRentReview.Anniversary2" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary3, "FixedIncreaseRentReview.Anniversary3" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary4, "FixedIncreaseRentReview.Anniversary4" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary5, "FixedIncreaseRentReview.Anniversary5" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary6, "FixedIncreaseRentReview.Anniversary6" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary7, "FixedIncreaseRentReview.Anniversary7" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary8, "FixedIncreaseRentReview.Anniversary8" ) ;
			nu.Assert.IsNotNull( newobj.Anniversary9, "FixedIncreaseRentReview.Anniversary9" ) ;
			nu.Assert.IsNotNull( newobj.UpdateUserCode, "FixedIncreaseRentReview.UpdateUserCode" ) ;
			nu.Assert.IsNotNull( newobj.UpdateDateTime, "FixedIncreaseRentReview.UpdateDateTime" ) ;
			nu.Assert.IsNotNull( newobj.RowTimestamp, "FixedIncreaseRentReview.RowTimestamp" ) ;
		 
			base.AssertAreEqual( newobj.RentReviewID, oldobj.RentReviewID, "FixedIncreaseRentReview.RentReviewID" ) ;
			base.AssertAreEqual( newobj.RentReviewIncrease, oldobj.RentReviewIncrease, "FixedIncreaseRentReview.RentReviewIncrease" ) ;
			base.AssertAreEqual( newobj.RentReviewIncreaseText, oldobj.RentReviewIncreaseText, "FixedIncreaseRentReview.RentReviewIncreaseText" ) ;
			base.AssertAreEqual( newobj.Anniversary1, oldobj.Anniversary1, "FixedIncreaseRentReview.Anniversary1" ) ;
			base.AssertAreEqual( newobj.Anniversary2, oldobj.Anniversary2, "FixedIncreaseRentReview.Anniversary2" ) ;
			base.AssertAreEqual( newobj.Anniversary3, oldobj.Anniversary3, "FixedIncreaseRentReview.Anniversary3" ) ;
			base.AssertAreEqual( newobj.Anniversary4, oldobj.Anniversary4, "FixedIncreaseRentReview.Anniversary4" ) ;
			base.AssertAreEqual( newobj.Anniversary5, oldobj.Anniversary5, "FixedIncreaseRentReview.Anniversary5" ) ;
			base.AssertAreEqual( newobj.Anniversary6, oldobj.Anniversary6, "FixedIncreaseRentReview.Anniversary6" ) ;
			base.AssertAreEqual( newobj.Anniversary7, oldobj.Anniversary7, "FixedIncreaseRentReview.Anniversary7" ) ;
			base.AssertAreEqual( newobj.Anniversary8, oldobj.Anniversary8, "FixedIncreaseRentReview.Anniversary8" ) ;
			base.AssertAreEqual( newobj.Anniversary9, oldobj.Anniversary9, "FixedIncreaseRentReview.Anniversary9" ) ;
			base.AssertAreEqual( newobj.UpdateUserCode, oldobj.UpdateUserCode, "FixedIncreaseRentReview.UpdateUserCode" ) ;
			base.AssertAreEqual( newobj.UpdateDateTime, oldobj.UpdateDateTime, "FixedIncreaseRentReview.UpdateDateTime" ) ;
		 
		}
	}

}
