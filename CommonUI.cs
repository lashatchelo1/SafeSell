using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SafeSell.Classes
{
    class CommonUI
    {
        public static void ChangeIcon(object Element, bool MouseLeaving)
        {
            Image imgSender = Element as Image;
            string imgSourcePath = imgSender.Source.ToString();
            int extIndex = imgSourcePath.IndexOf(".png");
            string newPath = string.Empty;

            if (MouseLeaving)
                newPath = imgSourcePath.Remove(extIndex - "_hovered".Length, "_hovered".Length);
            else
                newPath = imgSourcePath.Insert(extIndex, "_hovered");

            imgSender.Source = new BitmapImage(new Uri(newPath));
        }
    }
}
