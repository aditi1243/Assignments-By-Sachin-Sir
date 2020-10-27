using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataListTable
{
    public partial class DataLis___ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
	StringBuilder sb=new StringBuilder();
	//Get cookie from the current request
	HttpCookie cookie =Request.Cookies.Get("DateCookieExample");//Request.Cookiesis used to retrieve a cookie value
	
	//Check if cookie exists in the current request.
	if(cookie==null)
	{
	sb.Append("Cookie was not received from the client");
	sb.Append("Creating cookie to add to the response<br/>");
	
	//Create cookie
	HttpCookie cookie = new HttpCookie("DateCookieExample");
	HttpCookie userInfo=new HttpCookie("user info");	
	

	//Set value of cookie to current date and time
	cookie.value=DateTime.Now.ToString();
	userInfo["UserName"] ="Adti";
	userInfo["UserColor"] = "Navy";
	Response.Cookies.Add(userInfo);//ForCreating Cookies
	
	//set cookie to expire in 10min
	cookie.expires=DateTime.now.AddMinutes(10d);
	userInfo.Expires.Add(new TimeSpan(0,1,0));

	//Insert the cookie in the current HttpResponse
	Response.Cookies.Add(cookie);
	string User_Name=string.Empty;
	string User_Color = string.Empty;
	User_Name= Request.Cookies["userName"].Value;
	User_Color=Request.Cookies["userColor"].Value;
	}
	else
	{
	sb.Append("Cookie retrived from client<br/>");
	sb.Append("Cookie Name: " + cookie.Name + "<br/>");
	sb.Append("Cookie value: " + cookie.value + "<br/>");
	sb.Append("Cookie expiration Date: " + cookie.expires.ToString() + "<br/>");
	User_name = reqCookies["UserName"].ToString();
	User_color = reqCookies["UserColor"].ToString();
		

	}
	label1.Text=sb.ToString();
      }
    }
}