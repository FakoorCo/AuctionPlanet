// <auto-generated />

using System.CodeDom.Compiler;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace AuctionPlanet.DataAccess.Migrations
{
    [GeneratedCode("EntityFramework.Migrations", "6.1.0-30225")]
    public sealed partial class RemovedUserReferencesFromLots : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(RemovedUserReferencesFromLots));
        
        string IMigrationMetadata.Id
        {
            get { return "201510031557494_RemovedUserReferencesFromLots"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
