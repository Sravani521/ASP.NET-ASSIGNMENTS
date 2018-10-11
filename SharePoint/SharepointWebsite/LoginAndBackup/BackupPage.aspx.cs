using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using wc = System.Web.UI.WebControls;
using Microsoft.SharePoint.Client;
using System.Security;


namespace LoginAndBackup
{
    public partial class BackupPage : System.Web.UI.Page
    {
        public static string DestSiteName, listname;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BackupButton_Click(object sender, EventArgs e)
        {
            DestSiteName = SiteNameTextBox.Text;

            ClientContext SourceCC = new ClientContext("https://acuvatehyd.sharepoint.com/teams/FirstSite");
            ClientContext DestinationCC = new ClientContext("https://acuvatehyd.sharepoint.com/teams/"+ DestSiteName);

            string UserName = "sravani.makthala@acuvate.com";
            string Password = "janaki.522";

            SecureString securepwd = new SecureString();


            foreach (char c in Password)
            {
                securepwd.AppendChar(c);
            }

            

            SourceCC.Credentials = new SharePointOnlineCredentials(UserName, securepwd);
            DestinationCC.Credentials = new SharePointOnlineCredentials(UserName, securepwd);


            ListCollection listcollection = SourceCC.Web.Lists;         //getting list colectiom
            SourceCC.Load(listcollection);
            List SourceList = listcollection.GetByTitle("newlistforbackup");
            SourceCC.Load(SourceList);
            SourceCC.ExecuteQuery();

            //------creating list in dest



            ListCreationInformation NewList = new ListCreationInformation();
            NewList.Title = SourceList.Title+"asdfghjkxvzsdf";
            NewList.TemplateType = SourceList.BaseTemplate;
            NewList.Description = SourceList.Description;
            List Destlist = DestinationCC.Web.Lists.Add(NewList);
            DestinationCC.Load(Destlist.Fields);
            DestinationCC.ExecuteQuery();

            //-----------adding list item

            ListItemCollection listitemcollection = SourceList.GetItems(CamlQuery.CreateAllItemsQuery());
            SourceCC.Load(listitemcollection);
            SourceCC.ExecuteQuery();
          
            foreach(ListItem li in listitemcollection)
            {
                ListItemCreationInformation NewListItem = new ListItemCreationInformation();
                List destlistitem = Destlist.ParentWeb.Lists.GetByTitle(NewList.Title);
                ListItem listItem = Destlist.AddItem(NewListItem);
                listItem["Title"] = li["Title"];              
                listItem.Update();
                DestinationCC.ExecuteQuery();
            
               
            }

        }
    }
}