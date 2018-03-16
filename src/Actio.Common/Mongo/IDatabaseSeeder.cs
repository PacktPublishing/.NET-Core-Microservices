using System.Threading.Tasks;

namespace Actio.Common.Mongo
{
    public interface IDatabaseSeeder
    {
         Task SeedAsync();
    }
}