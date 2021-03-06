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
		protected void Assert٠RDMFeeParam( bool insert, t.RDMFeeParam newobj, t.RDMFeeParam oldobj )
		{
			acr.CodeGenEtc.ConsoleMessage( ! this.QuietMode, "[14/40] RDMFeeParam - assert" ) ;
		 
			nu.Assert.IsNotNull( newobj.RDMFeeParamID, "RDMFeeParam.RDMFeeParamID" ) ;
			nu.Assert.IsNotNull( newobj.TotalRDMFee, "RDMFeeParam.TotalRDMFee" ) ;
			nu.Assert.IsNotNull( newobj.UpdateUserCode, "RDMFeeParam.UpdateUserCode" ) ;
			nu.Assert.IsNotNull( newobj.UpdateDateTime, "RDMFeeParam.UpdateDateTime" ) ;
			nu.Assert.IsNotNull( newobj.RowTimestamp, "RDMFeeParam.RowTimestamp" ) ;
		 
			base.AssertAreEqual( newobj.RDMFeeParamID, oldobj.RDMFeeParamID, "RDMFeeParam.RDMFeeParamID" ) ;
			base.AssertAreEqual( newobj.TotalRDMFee, oldobj.TotalRDMFee, "RDMFeeParam.TotalRDMFee" ) ;
			base.AssertAreEqual( newobj.UpdateUserCode, oldobj.UpdateUserCode, "RDMFeeParam.UpdateUserCode" ) ;
			base.AssertAreEqual( newobj.UpdateDateTime, oldobj.UpdateDateTime, "RDMFeeParam.UpdateDateTime" ) ;
		 
		}
	}

}

