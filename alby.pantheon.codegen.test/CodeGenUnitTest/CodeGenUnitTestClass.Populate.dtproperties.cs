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
		protected void Populate٠dtproperties( bool insert, t.dtproperties obj )
		{
			if ( insert )
			{
				obj.objectid = -100 ;
				obj.property = "@" ;
				obj.value = "@" ;
				obj.uvalue = "@" ;
				obj.lvalue = new byte[] { 0x01 } ;
				obj.version = -100 ;
			}
			else // update
			{
				obj.objectid = -200 ;
				obj.value = "#" ;
				obj.uvalue = "#" ;
				obj.lvalue = new byte[] { 0x02 } ;
				obj.version = -200 ;
			}
			 
		}
	}

}

