using _DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _ADOWEB
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseBusiness db =
                new DatabaseBusiness();
            GridView1.DataSource = db.ExecuteAdapter("SP_Select");
            GridView1.DataBind();
        }
    }
}