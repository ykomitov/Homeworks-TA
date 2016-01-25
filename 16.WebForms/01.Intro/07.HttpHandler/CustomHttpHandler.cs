using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Web;

public class CustomHttpHandler : IHttpHandler
{
    public bool IsReusable
    {
        get { return false; }
    }

    public void ProcessRequest(HttpContext context)
    {
        HttpResponse response = context.Response;
        response.ContentType = "image/png";

        string text = context.Request.Url.AbsolutePath;
        Bitmap image = new Bitmap(300, 100);

        Graphics graphics = Graphics.FromImage(image);
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.DrawString(
                text,
                new Font("Arial", 16, FontStyle.Regular),
                SystemBrushes.WindowText,
                new PointF(10, 40));
        image.Save(context.Response.OutputStream, ImageFormat.Png);
    }
}