using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Pokemonitor.Scanner
{
    class ProcessScanner : IProcessScanner
    {

        private readonly ILogger _logger;

        public ProcessScanner(ILogger<ProcessScanner> logger)
        {
            _logger = logger;
        }

        public bool ScanProcess(Process process)
        {
            _logger.LogInformation("Scanning process");
            Console.WriteLine("WriteLine");
            return true;
        }
    }
}
