using NUnit.Framework;
using System.Threading;

namespace dmuka3.CS.Simple.Semaphore.NUnit
{
    public class ActionQueueTests
    {
        [Test]
        public void RandomQueueTest()
        {
            ActionQueue semaphore = new ActionQueue(coreCount: 4);
            var c = 0;
            for (int i = 0; i < 10; i++)
                semaphore.AddAction(() => c++);
            semaphore.Start();

            Thread.Sleep(1000);
            semaphore.Dispose();
            Assert.AreEqual(c, 10);
        }
    }
}