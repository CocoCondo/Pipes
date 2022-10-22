using System.Drawing;
using System;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterConditional
    {
        PictureProvider provider = new PictureProvider();
        string pathtoimage = "Conditional.jpg";
        bool FaceFound = false;
        public bool Filter(IPicture image)
        {
            CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow);
            provider.SavePicture(image, @$"{pathtoimage}");
            cog.Recognize(@$"{pathtoimage}");
            FaceFound = cog.FaceFound;
            return FaceFound;
        }
    }
}