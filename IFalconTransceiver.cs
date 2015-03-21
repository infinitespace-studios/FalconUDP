﻿using System;
using System.Net;

namespace FalconUDP
{
    internal interface IFalconTransceiver
    {
        int BytesAvaliable { get; }
        FalconOperationResult TryStart();
        void Stop();
        int Receive(byte[] recieveBuffer, ref EndPoint ipFrom);
        bool Send(byte[] buffer, int index, int count, IPEndPoint ip, bool expidite);
    }
}
