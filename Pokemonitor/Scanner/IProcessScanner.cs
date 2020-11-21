using System.Diagnostics;

namespace Pokemonitor.Scanner
{
    interface IProcessScanner
    {
        bool ScanProcess(Process process);
    }
}
