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
		protected void Populate٠IDGenerator( bool insert, t.IDGenerator obj )
		{
			if ( insert )
			{
				obj.ID = toint( factory٠IDGeneratorFactory.GetNextIdˡ( _connection, t.IDGenerator.column٠ID, true ).ToString() ) ;
				obj.NewID = -100 ;
				obj.AssignedTypeDescription = "@" ;
				obj.UpdateUserCode = "@" ;
				obj.UpdateDateTime = new DateTime(1900,1,1) ;
			}
			else // update
			{
				obj.NewID = -200 ;
				obj.AssignedTypeDescription = "#" ;
				obj.UpdateUserCode = "#" ;
				obj.UpdateDateTime = new DateTime(1901,12,31) ;
			}
			 
		}
	}

}
