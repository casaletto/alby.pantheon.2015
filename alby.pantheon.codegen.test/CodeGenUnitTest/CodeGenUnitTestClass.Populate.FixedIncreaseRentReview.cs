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
		protected void Populate٠FixedIncreaseRentReview( bool insert, t.FixedIncreaseRentReview obj )
		{
			if ( insert )
			{
				obj.RentReviewID = obj1٠RentReview != null ? obj1٠RentReview.RentReviewID : obj0٠RentReview.RentReviewID ;
				obj.RentReviewIncrease = -1.0m ;
				obj.RentReviewIncreaseText = "@" ;
				obj.Anniversary1 = -1.0m ;
				obj.Anniversary2 = -1.0m ;
				obj.Anniversary3 = -1.0m ;
				obj.Anniversary4 = -1.0m ;
				obj.Anniversary5 = -1.0m ;
				obj.Anniversary6 = -1.0m ;
				obj.Anniversary7 = -1.0m ;
				obj.Anniversary8 = -1.0m ;
				obj.Anniversary9 = -1.0m ;
				obj.UpdateUserCode = "@" ;
				obj.UpdateDateTime = new DateTime(1900,1,1) ;
			}
			else // update
			{
				obj.RentReviewIncrease = -2.0m ;
				obj.RentReviewIncreaseText = "#" ;
				obj.Anniversary1 = -2.0m ;
				obj.Anniversary2 = -2.0m ;
				obj.Anniversary3 = -2.0m ;
				obj.Anniversary4 = -2.0m ;
				obj.Anniversary5 = -2.0m ;
				obj.Anniversary6 = -2.0m ;
				obj.Anniversary7 = -2.0m ;
				obj.Anniversary8 = -2.0m ;
				obj.Anniversary9 = -2.0m ;
				obj.UpdateUserCode = "#" ;
				obj.UpdateDateTime = new DateTime(1901,12,31) ;
			}
			 
		}
	}

}

