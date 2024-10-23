using SwimmingPool.Controllers;
using SwimmingPool.Models;
using SwimmingPool.Views;

namespace SwimmingPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PoolActionController controller = new PoolActionController();
            controller.Start();
        }
    }
}