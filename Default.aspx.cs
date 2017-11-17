using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = 100;
        int y = 200;
        int z = x + y;

        x = 500;
        y = 600;

        int i = 99;
        z = z + i;

    }
}