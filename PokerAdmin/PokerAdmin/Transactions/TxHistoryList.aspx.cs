using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Admin.Transactions
{
	/// <summary>
	/// Summary description for GameProcessMaintenance.
	/// </summary>
	public class TxHistoryList : Components.MaintenancePage
	{
		protected System.Web.UI.WebControls.DataGrid oGrid;
	
		public TxHistoryList()
		{
			nEditPageNum     = Config.PageTxHistoryDetails;
			sGridSourceQuery = Config.DbGetTxHistoryList;
		}

		protected override void BindGrid()
		{
			PrepareHyperLinkColumn(0, "UserName", "id");
			PrepareHyperLinkColumn(1, "TxTypeName", "id");
			PrepareHyperLinkColumn(2, "TxAmount", "id");
			PrepareHyperLinkColumn(3, "RecordDate", "id");
			base.BindGrid();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion
	}
}