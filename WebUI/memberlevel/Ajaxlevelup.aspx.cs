﻿
    using DBUtility;
    using System;
    using System.Web.UI;

    public partial class  Ajaxlevelup : Page
    {
        private BaseClass bc = new BaseClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string lNum = base.Server.UrlDecode(base.Request.QueryString["lNum"].ToString());
                string lName = base.Server.UrlDecode(base.Request.QueryString["lName"].ToString());
                string lDiscount = base.Server.UrlDecode(base.Request.QueryString["lDiscount"].ToString());
                string ljifen = base.Server.UrlDecode(base.Request.QueryString["ljifen"].ToString());
                string lNblance = base.Server.UrlDecode(base.Request.QueryString["lNblance"].ToString());
                string lNjifen = base.Server.UrlDecode(base.Request.QueryString["lNjifen"].ToString());
                string lBuyprice = base.Server.UrlDecode(base.Request.QueryString["lBuyprice"].ToString());
                string lRemark = base.Server.UrlDecode(base.Request.QueryString["lRemark"].ToString());
                string lPasttime = base.Server.UrlDecode(base.Request.QueryString["lPasttime"].ToString());
                string strnum = "l" + DateTime.Now.ToString("yyMMddHHmmss");
                string lStates = base.Server.UrlDecode(base.Request.QueryString["lStates"].ToString());
                string sqlup = "update  memberlevel set lName='" + lName + "',lDiscount='" + lDiscount + "',ljifen='" + ljifen + "',lNblance='" + lNblance + "',lNjifen='" + lNjifen + "',lBuyprice='" + lBuyprice + "',lRemark='" + lRemark + "',lPasttime='" + lPasttime + "',lStates='" + lStates + "' where lNum='" + lNum + "'";
                this.bc.execsql(sqlup);
                base.Response.Write("true");
            }
            catch
            {
                base.Response.Write("false");
            }
        }
    }


