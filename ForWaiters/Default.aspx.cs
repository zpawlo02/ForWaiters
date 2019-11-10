using System;
using System.Web;
using System.Web.UI;
<asp:ListBox runat="server" ID="lblMultiSelect" SelectionMode="multiple">
            <asp:ListItem Text="opt1" Value="opt1" />
            <asp:ListItem Text="opt2" Value="opt2" />
            <asp:ListItem Text="opt3" Value="opt3" />
</asp:ListBox>
namespace ForWaiters
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            
        }
    }
}
