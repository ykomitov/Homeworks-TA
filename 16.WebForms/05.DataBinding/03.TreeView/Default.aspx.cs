namespace _03.TreeView
{
    using System;
    using System.Xml;

    public partial class Default : System.Web.UI.Page
    {
        protected void Select_Change(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("students.xml"));
            XmlNode node = doc.SelectSingleNode(this.TreeViewXml.SelectedNode.DataPath);

            this.InnerHtmlContainer.InnerText = node.InnerXml;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}