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
		protected void Populate٠LeaseExecutive( bool insert, t.LeaseExecutive obj )
		{
			if ( insert )
			{
				obj.PartyID = obj1٠Party != null ? obj1٠Party.PartyID : obj0٠Party.PartyID ;
				obj.DisplayOrder = -100 ;
				obj.UpdateUserCode = "@" ;
				obj.UpdateDateTime = new DateTime(1900,1,1) ;
				obj.DeletionIndicator = "@" ;
			}
			else // update
			{
				obj.DisplayOrder = -200 ;
				obj.UpdateUserCode = "#" ;
				obj.UpdateDateTime = new DateTime(1901,12,31) ;
				obj.DeletionIndicator = "#" ;
			}
			 
		}
	}

}

