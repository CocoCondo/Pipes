using System.Drawing;
using System;
using TwitterUCU;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y la retorna en escala de grises.
    /// </remarks>
    public class FilterTwitter : IFilter
    {
        PictureProvider provider = new PictureProvider();
        string pathtoimage = "pasomediotwitter.jpg";
        /// <summary>
        /// Un filtro que retorna la imagen recibida con un filtro de escala de grises aplicado.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en escala de grises.</returns>
        public IPicture Filter(IPicture image)
        {
            provider.SavePicture(image, @$"{pathtoimage}");
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("luke loquillo", @$"{pathtoimage}"));
            return image;
        }
    }
}
