// This file has been autogenerated from a class added in the UI designer.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Shared;
using System.Collections.Generic;

namespace MasterDetail
{
	public partial class AccountViewController : UITableViewController
	{
		public AccountViewController (IntPtr handle) : base (handle)
		{
		}

		Account current;
		AccountListViewController Delegate;
		public void SetData( AccountListViewController d, Account data)
		{
			current = data;
			Delegate = d;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			AccountTypeLabel.Text = current.AccountType;
			AccountSubTypeLabel.Text = current.AccountSubType;
			AccountNumberLabel.Text = current.AccountNumber;
			BalanceLabel.Text = String.Format ("{0:C}", current.Balance);


			TransactionsTableView.Source = new TransactionTableSources (current.Transactions as List<Transaction>);

		}
	}
}
