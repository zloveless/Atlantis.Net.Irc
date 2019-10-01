namespace Atlantis.Net.Irc
{
    using System;
    using System.Threading;

    public class IrcConnection : IDisposable
    {
        private Thread _workerThread;

        public void Dispose()
        {
        }
    }
}
