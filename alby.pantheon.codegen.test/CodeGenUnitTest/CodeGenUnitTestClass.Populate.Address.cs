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
		protected void Populate٠Address( bool insert, t.Address obj )
		{
			if ( insert )
			{
				obj.AddressID = toint( factory٠AddressFactory.GetNextIdˡ( _connection, t.Address.column٠AddressID, true ).ToString() ) ;
				obj.PartyID = obj1٠Party != null ? obj1٠Party.PartyID : obj0٠Party.PartyID ;
				obj.AddressType = "@" ;
				obj.AddressLine1 = "@" ;
				obj.AddressLine2 = "@" ;
				obj.Suburb = "@" ;
				obj.Town = "@" ;
				obj.State = "@" ;
				obj.Postcode = "@" ;
				obj.Country = "@" ;
				obj.UpdateUserCode = "@" ;
				obj.UpdateDateTime = new DateTime(1900,1,1) ;
			}
			else // update
			{
				obj.AddressType = "#" ;
				obj.AddressLine1 = "#" ;
				obj.AddressLine2 = "#" ;
				obj.Suburb = "#" ;
				obj.Town = "#" ;
				obj.State = "#" ;
				obj.Postcode = "#" ;
				obj.Country = "#" ;
				obj.UpdateUserCode = "#" ;
				obj.UpdateDateTime = new DateTime(1901,12,31) ;
			}
			 
		}
	}

}

