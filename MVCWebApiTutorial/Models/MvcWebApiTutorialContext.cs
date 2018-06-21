﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebApiTutorial.Models
{
	public class MvcWebApiTutorialContext : DbContext
	{
		public MvcWebApiTutorialContext() : base() { }

		public System.Data.Entity.DbSet<MVCWebApiTutorial.Models.Customer> Customers { get; set; }

	}
}