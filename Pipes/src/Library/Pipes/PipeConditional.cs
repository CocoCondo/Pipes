using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;
using CompAndDel.Filters;


namespace CompAndDel.Pipes
{
    public class PipeConditional : IPipe
    {
        IPipe next2Pipe;
        IPipe nextPipe;
        FilterConditional filterconditional = new FilterConditional();
        
        public PipeConditional(IPipe nextPipe, IPipe next2Pipe) 
        {
            this.next2Pipe = next2Pipe;
            this.nextPipe = nextPipe;           
        }
        
        /// <summary>
        /// La cañería recibe una imagen, construye un duplicado de la misma, 
        /// y envía la original por una cañería y el duplicado por otra.
        /// </summary>
        /// <param name="picture">imagen a filtrar y enviar a las siguientes cañerías</param>
        public IPicture Send(IPicture picture)
        {
            
            if (filterconditional.Filter(picture))
            {
                next2Pipe.Send(picture.Clone()); //Si tiene cara lo manda al next2pipe
                Console.WriteLine("Tiene cara");
            }
            else
            {
                Console.WriteLine("No tiene cara");
            }

            return this.nextPipe.Send(picture);
        }
    }
}
