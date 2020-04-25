namespace Telephony
{
    using System.Collections.Generic;

    public interface IBrowsing
    {
        string[] Brousers { get; }

        string Browse(string browser);
    }
}
