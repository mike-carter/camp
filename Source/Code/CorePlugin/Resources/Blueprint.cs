using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Resources;
using Duality.Plugins.Tilemaps;

namespace CampGame.Resources
{
    [ExplicitResourceReference(typeof(Tileset))]
    public class TileBlueprint : Resource
    {
        /// <summary>
        /// [GET/SET] The tileset that contains the tiles for this building
        /// </summary>
        public ContentRef<Tileset> Tileset { get; set; }

        public Tilemap Layout { get; set; }
    }
}
