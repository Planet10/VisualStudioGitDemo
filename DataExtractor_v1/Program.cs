using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevRain.Data.Extracting;

namespace DataExtractor_v1
{
    class Program
    {
        static void Main( string [ ] args )
        {
            UriHtmlExtractor uriExt = new UriHtmlExtractor(  new Uri( "http://austin.craigslist.org/trp/3909498880.html"));
            
            DataExtractor ext = new DataExtractor( new Uri( "http://austin.craigslist.org/trp/3909498880.html" ), DataTypes.Phone );
            
            var results = ext.GetExtractedResults( );

            foreach ( var item in results )
            {
                Console.WriteLine( "{0}: {1}", item.GroupName, item.Value );
            }

            Console.Write( "\nPress any key to exit..." );
            Console.ReadKey( );
        }
    }
}
