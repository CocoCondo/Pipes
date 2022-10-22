using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {

            PictureProvider prov = new PictureProvider();
            IFilter filtertwitter = new FilterTwitter();
            IFilter blur = new FilterBlurConvolution();
            IPipe pipenull = new PipeNull();
            IPipe twitterpipe = new PipeSerial(filtertwitter, pipenull);
            IPipe pipecoso = new PipeSerial(blur, twitterpipe);
            

            IPicture picture = prov.GetPicture(@"luke.jpg");
            prov.SavePicture(pipecoso.Send(picture), @"lukeblur.jpg");


            /*IFilter grey = new FilterGreyscale(); 
            IFilter negative = new FilterNegative();
            IFilter picturereturn = new FilterPictureReturn();
            IFilter filtertwitter = new FilterTwitter();

            PictureProvider provider = new PictureProvider();


            IPipe segundopipe = new PipeSerial(negative, pipenull);
            IPipe twitterpipe = new PipeSerial(filtertwitter, pipenull);
            IPipe pipeconditional = new PipeConditional(segundopipe, twitterpipe);
            IPipe primerpipe = new PipeSerial(grey, pipeconditional);

            IPicture picture = provider.GetPicture(@"luke.jpg");
            IPicture cerveza = provider.GetPicture(@"beer.jpg");
            provider.SavePicture(primerpipe.Send(picture), @"LukeconFiltros.jpg");
            provider.SavePicture(primerpipe.Send(cerveza), @"beerresult.jpg");*/
        }
    }
}
