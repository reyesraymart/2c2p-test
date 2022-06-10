﻿using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Transaction = UploadTransaction.Core.Entities.Transaction;

namespace UploadTransaction.DataLayer;

public class ProcessingDataContext : DbContext
{
	public ProcessingDataContext(DbContextOptions options) : base(options)
	{
		Database.EnsureCreated();
	}
	
	public ProcessingDataContext()
	{
	}

	public DbSet<Transaction> Transactions { get; set; }
}