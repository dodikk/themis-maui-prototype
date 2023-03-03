using System;


namespace Themis.Clock
{
    /// <summary>
    /// 
    /// Emulates real MonotonicClock by relying on system time.
    /// This class should only be used in unit tests of the app.
    /// 
    /// Note: cannot use real implementations since tests run on desktop with NUnit.
    /// Although it is possible to run tests on a device, it requires quite some CI efforts,
    /// So not everybody might bother with such integration.
    /// 
    /// </summary>
    public class MonotonicClockMock : IMonotonicClock
    {
        public MonotonicClockMock()
        {
            _objectInstanceConstructionTime = DateTime.UtcNow;
        }

        public long GetNumberOfSecondsSinceDeviceLastBooted()
        {
            DateTime nowTime = DateTime.UtcNow;
            TimeSpan elapsedSinceObjectCreated = nowTime - _objectInstanceConstructionTime;

            double rawResult = elapsedSinceObjectCreated.TotalSeconds;
            long result = (long)rawResult;

            return result;
        }

        private DateTime _objectInstanceConstructionTime;
    }
}
