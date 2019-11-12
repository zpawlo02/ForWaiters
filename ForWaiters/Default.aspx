<%@ Page Language="C#" Inherits="ForWaiters.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
        <meta charset="UTF-8">
	<title>Dla kelnerów</title>
        
</head>
<body>
	<form id="form1" runat="server">
    
	
    
    <div id="the whole thing" style="height:100%; width:100%; overflow: hidden;">
      <br>          
    <div id="leftThing" style="float: left; width:25%;margin-top:3%;  margin-left:23% ">
        <asp:ListBox runat="server" ID="lblMultiSelectOfDishes" SelectionMode="multiple" Font-Size="15pt" Width="330" Height="160" >
             <asp:ListItem Text="Pierogi ruskie - 14.00zł" Value="0" />
             <asp:ListItem Text="Zupa pomidorowa - 7.00zł" Value="1" />
             <asp:ListItem Text="Zapiekanka z pieczarkami - 6.00zł" Value="2" />
             <asp:ListItem Text="Lody czekoladowe - 9.00zł" Value="3" />
             <asp:ListItem Text="Szarlotka - 12.00zł" Value="4"/>
             <asp:ListItem Text="Sok pomarańczowy - 5.00zł" Value="5" />
                        
        </asp:ListBox>
    </div>
                
    <div id="content" style="float: left; width:5%;">
                  
        <p>Ilość</p>
                    <asp:TextBox id="txtBoxQuantityPierogi"runat="server" type="number" Width="30" Height="18"></asp:TextBox>
        <br>
                    <asp:TextBox id="txtBoxQuantityZupa"runat="server" type="number" Width="30" Height="18"></asp:TextBox>
        <br>
                    <asp:TextBox id="txtBoxQuantityZapiekanka"runat="server" type="number" Width="30" Height="18"></asp:TextBox>
        <br>
                    <asp:TextBox id="txtBoxQuantityLody"runat="server" type="number" Width="30" Height="18"></asp:TextBox>
        <br>
                    <asp:TextBox id="txtBoxQuantitySzarlotka"runat="server" type="number" Width="30" Height="18"></asp:TextBox>
        <br>
                    <asp:TextBox id="txtBoxQuantitySok"runat="server" type="number" Width="30" Height="18"></asp:TextBox>
        <br>
                    
    </div>
                    
                
    <div id="content" style="float: left; width:15%;margin-top:3% ">
        <asp:ListBox runat="server" ID="lblMultiSelectOfTables" SelectionMode="multiple" Font-Size="16pt" Width="130" Height="160" >
            <asp:ListItem Text="Stolik nr 1" Value="0" />
            <asp:ListItem Text="Stolik nr 2" Value="1" />
            <asp:ListItem Text="Stolik nr 3" Value="2" />
            <asp:ListItem Text="Stolik nr 4" Value="3" />
            <asp:ListItem Text="Stolik nr 5" Value="4" />
                        
        </asp:ListBox> 
                    
    </div>
                <div id="content" style="float: left; width:9%; margin-top:7%  ">
                  
                    <asp:Button id="btnAddDishes" runat="server" OnClick="addDishesOnButtonClick" Width="90" Height="80" Text="Dodaj dania" Font-Size="28pt"></asp:Button>
       
    </div>    
               
    </div>
            
        <div id="content" style="float: left; width:20%;margin-top:20% ">
            <asp:ListBox runat="server" ID="lblDishesForFirstTable" SelectionMode="multiple"style="overflow-x:auto;" Font-Size="12pt" Width="320" Height="160" ></asp:ListBox> 
        </div>
            
        <div id="content" style="float: left; width:20%;margin-top:20% ">
            <asp:ListBox runat="server" ID="lblDishesForSecondTable" SelectionMode="multiple"style="overflow-x:auto;" Font-Size="12pt" Width="320" Height="160" ></asp:ListBox> 
        </div>
            
        <div id="content" style="float: left; width:20%;margin-top:20% ">
            <asp:ListBox runat="server" ID="lblDishesForThirdTable" SelectionMode="multiple"style="overflow-x:auto;" Font-Size="12pt" Width="320" Height="160" ></asp:ListBox> 
        </div>
            
        <div id="content" style="float: left; width:20%;margin-top:20% "> 
            <asp:ListBox runat="server" ID="lblDishesForFourthTable" SelectionMode="multiple"style="overflow-x:auto;" Font-Size="12pt" Width="320" Height="160" ></asp:ListBox> 
        </div>  
            
        <div id="content" style="float: left; width:20%;margin-top:20% ">
            <asp:ListBox runat="server" ID="lblDishesForFifthTable" SelectionMode="multiple"style="overflow-x:auto;" Font-Size="12pt" Width="320" Height="160" ></asp:ListBox>        
        </div>        
        
    </form>
        
        
</body>
</html>
