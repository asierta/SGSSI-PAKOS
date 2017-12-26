using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace PakosFISS
{
    public interface IConfig
    {
        string DirectorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
