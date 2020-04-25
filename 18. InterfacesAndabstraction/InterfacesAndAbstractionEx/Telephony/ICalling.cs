using System.Collections.Generic;

namespace Telephony
{
    interface ICalling
    {
        string[] Numbers { get; }

        string Call(string numbers);


    }
}
